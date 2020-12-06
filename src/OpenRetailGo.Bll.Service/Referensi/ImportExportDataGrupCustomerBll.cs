/**
 * Copyright (C) 2020 OpenRetailGo
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;

using log4net;
using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;
using ClosedXML.Excel;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.Repository.Service;
using System.IO;
using System.Diagnostics;

namespace OpenRetailGo.Bll.Service
{
    public class ImportExportDataGrupCustomerBll : IImportExportDataBll<GrupCustomer>
    {
        private ILog _log;
        private IUnitOfWork _unitOfWork;

        private string _fileName;
        private XLWorkbook _workbook;

        public ImportExportDataGrupCustomerBll(string fileName, ILog log)
        {
            _fileName = fileName;
            _log = log;
        }

        public bool IsOpened()
        {
            var result = false;

            try
            {
                _workbook = new XLWorkbook(_fileName);
            }
            catch
            {
                result = true;
            }

            return result;
        }

        public bool IsValidFormat(string workSheetName)
        {
            var result = true;

            try
            {
                var ws = _workbook.Worksheet(workSheetName);

                // Look for the first row used
                var firstRowUsed = ws.FirstRowUsed();

                var colums = new string[] { "NAMA GRUP", "DESKRIPSI" };

                for (int i = 0; i < colums.Length; i++)
                {
                    if (!(colums[i] == firstRowUsed.Cell(i + 1).GetString()))
                    {
                        result = false;
                        break;
                    }
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public bool Import(string workSheetName, ref int rowCount)
        {
            var result = false;

            try
            {
                var ws = _workbook.Worksheet(workSheetName);

                // Look for the first row used
                var firstRowUsed = ws.FirstRowUsed();

                // Narrow down the row so that it only includes the used part
                var golonganRow = firstRowUsed.RowUsed();

                // First possible address of the company table:
                var firstPossibleAddress = ws.Row(golonganRow.RowNumber()).FirstCell().Address;

                // Last possible address of the company table:
                var lastPossibleAddress = ws.LastCellUsed().Address;

                // Get a range with the remainder of the worksheet data (the range used)
                var golonganRange = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed();

                // Treat the range as a table (to be able to use the column names)
                var grupCustomerTable = golonganRange.AsTable();

                var listOfGrupCustomer = new List<GrupCustomer>();

                listOfGrupCustomer = grupCustomerTable.DataRange.Rows().Select(row => new GrupCustomer
                {
                    nama_grup = row.Field("NAMA GRUP").GetString(),
                    deskripsi = row.Field("DESKRIPSI").GetString()
                }).ToList();

                if (listOfGrupCustomer.Count == 1 && listOfGrupCustomer[0].nama_grup.Length == 0)
                {
                    rowCount = 0;
                    return false;
                }

                rowCount = listOfGrupCustomer.Count;

                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);

                    foreach (var grupCustomer in listOfGrupCustomer)
                    {
                        if (grupCustomer.nama_grup.Length > 0)
                        {
                            // cek duplikasi data berdasarkan nama grup
                            if (grupCustomer.nama_grup.Length > 30)
                                grupCustomer.nama_grup = grupCustomer.nama_grup.Substring(0, 50);

                            var oldGrupCustomer = repo.GetByName(grupCustomer.nama_grup, false)
                                                                    .FirstOrDefault();

                            // hanya data yg belum ada akan di import
                            if (oldGrupCustomer == null) 
                                result = Convert.ToBoolean(repo.Save(grupCustomer));
                        }                        
                    }                    
                }

                result = true;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }
            finally
            {
                _workbook.Dispose();
            }

            return result;
        }

        public void Export(IList<GrupCustomer> listOfObject)
        {
            try
            {
                // Creating a new workbook
                using (var wb = new XLWorkbook())
                {
                    // Adding a worksheet
                    var ws = wb.Worksheets.Add("grup customer");

                    // Set header table
                    ws.Cell(1, 1).Value = "NO";
                    ws.Cell(1, 2).Value = "NAMA GRUP";
                    ws.Cell(1, 3).Value = "DESKRIPSI";

                    var noUrut = 1;
                    foreach (var golongan in listOfObject)
                    {
                        ws.Cell(1 + noUrut, 1).Value = noUrut;
                        ws.Cell(1 + noUrut, 2).Value = golongan.nama_grup;
                        ws.Cell(1 + noUrut, 3).Value = golongan.deskripsi;

                        noUrut++;
                    }

                    // Saving the workbook
                    wb.SaveAs(_fileName);

                    var fi = new FileInfo(_fileName);

                    // Open the spreadsheet
                    if (fi.Exists)
                        Process.Start(_fileName);
                }                               
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }
        }

        public IList<string> GetWorksheets()
        {
            var listOfWorksheet = new List<string>();

            foreach (IXLWorksheet worksheet in _workbook.Worksheets)
            {
                listOfWorksheet.Add(worksheet.Name);
            }

            return listOfWorksheet;
        }
    }
}
