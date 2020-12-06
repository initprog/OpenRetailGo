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
using System.Windows.Forms;

using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;
using OpenRetailGo.Bll.Service;
using OpenRetailGo.Helper.UI.Template;
using OpenRetailGo.Helper;
using Syncfusion.Windows.Forms.Grid;
using ConceptCave.WaitCursor;
using log4net;
using System.IO;
using System.Diagnostics;

namespace OpenRetailGo.Referensi
{
    public partial class FrmListGrupCustomer : FrmListStandard, IListener
    {
        private IGrupCustomerBll _bll; // deklarasi objek business logic layer 
        private IList<GrupCustomer> _listOfCrupCustomer = new List<GrupCustomer>();
        private ILog _log;

        public FrmListGrupCustomer(string header, Pengguna pengguna, string menuId)
            : base(header)
        {
            InitializeComponent();
            this.btnImport.Visible = true;
            this.toolTip1.SetToolTip(this.btnImport, "Import/Export Data GrupCustomer");
            this.mnuBukaFileMaster.Text = "Buka File Master GrupCustomer";
            this.mnuImportFileMaster.Text = "Import File Master GrupCustomer";
            this.mnuExportData.Text = "Export Data GrupCustomer";

            _log = MainProgram.log;
            _bll = new GrupCustomerBll(MainProgram.isUseWebAPI, MainProgram.baseUrl, _log);

            // set hak akses untuk SELECT
            var role = pengguna.GetRoleByMenuAndGrant(menuId, GrantState.SELECT);
            if (role != null)
                if (role.is_grant)
                {
                    LoadData();

                    btnImport.Enabled = pengguna.is_administrator;
                }                    

            InitGridList();

            // set hak akses selain SELECT (TAMBAH, PERBAIKI dan HAPUS)
            RolePrivilegeHelper.SetHakAkses(this, pengguna, menuId, _listOfCrupCustomer.Count);
        }

        private void InitGridList()
        {
            var gridListProperties = new List<GridListControlProperties>();

            gridListProperties.Add(new GridListControlProperties { Header = "No", Width = 30 });
            gridListProperties.Add(new GridListControlProperties { Header = "Nama Grup Customer", Width = 400 });
            gridListProperties.Add(new GridListControlProperties { Header = "Deskripsi", Width = 700 });

            GridListControlHelper.InitializeGridListControl<GrupCustomer>(this.gridList, _listOfCrupCustomer, gridListProperties);

            if (_listOfCrupCustomer.Count > 0)
                this.gridList.SetSelected(0, true);

            this.gridList.Grid.QueryCellInfo += delegate(object sender, GridQueryCellInfoEventArgs e)
            {
                if (_listOfCrupCustomer.Count > 0)
                {
                    if (e.RowIndex > 0)
                    {
                        var rowIndex = e.RowIndex - 1;

                        if (rowIndex < _listOfCrupCustomer.Count)
                        {
                            var grupCustomer = _listOfCrupCustomer[rowIndex];

                            switch (e.ColIndex)
                            {
                                case 2:
                                    e.Style.CellValue = grupCustomer.nama_grup;
                                    break;

                                case 3:
                                    e.Style.CellValue = grupCustomer.deskripsi;
                                    break;

                                default:
                                    break;
                            }

                            // we handled it, let the grid know
                            e.Handled = true;
                        }
                    }
                }
            };
        }

        private void LoadData()
        {
            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                _listOfCrupCustomer = _bll.GetAll();

                GridListControlHelper.Refresh<GrupCustomer>(this.gridList, _listOfCrupCustomer);
            }

            ResetButton();
        }

        private void ResetButton()
        {
            base.SetActiveBtnPerbaikiAndHapus(_listOfCrupCustomer.Count > 0);
        }

        protected override void Tambah()
        {
            var frm = new FrmEntryGrupCustomer("Tambah Data " + this.TabText, _bll);
            frm.Listener = this;
            frm.ShowDialog();
        }

        protected override void Perbaiki()
        {
            var index = this.gridList.SelectedIndex;

            if (!base.IsSelectedItem(index, this.Text))
                return;

            var grupCustomer = _listOfCrupCustomer[index];

            var frm = new FrmEntryGrupCustomer("Edit Data " + this.TabText, grupCustomer, _bll);
            frm.Listener = this;
            frm.ShowDialog();
        }

        protected override void Hapus()
        {
            var index = this.gridList.SelectedIndex;

            if (!base.IsSelectedItem(index, this.Text))
                return;

            if (MsgHelper.MsgDelete())
            {
                var grupCustomer = _listOfCrupCustomer[index];

                using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
                {
                    var result = _bll.Delete(grupCustomer);
                    if (result > 0)
                    {
                        GridListControlHelper.RemoveObject<GrupCustomer>(this.gridList, _listOfCrupCustomer, grupCustomer);
                        ResetButton();
                    }
                    else
                        MsgHelper.MsgDeleteError();
                }                
            }
        }

        protected override void OpenFileMaster()
        {
            var msg = "Untuk membuka file master GrupCustomer membutuhkan Ms Excel versi 2007 atau yang terbaru.\n\n" +
                      "Apakah proses ingin dilanjutkan ?";

            if (MsgHelper.MsgKonfirmasi(msg))
            {
                var fileMaster = Utils.GetAppPath() + @"\File Import Excel\Master Data\data_grupcustomer.xlsx";

                if (!File.Exists(fileMaster))
                {
                    MsgHelper.MsgWarning("Maaf file master GrupCustomer tidak ditemukan.");
                    return;
                }

                try
                {
                    Process.Start(fileMaster);
                }
                catch
                {
                    msg = "Gagal membuka file master GrupCustomer !!!.\n\n" +
                          "Cek apakah Ms Excel versi 2007 atau yang terbaru sudah terinstall ?";

                    MsgHelper.MsgError(msg);
                }
            }
        }

        protected override void ImportData()
        {
            var frm = new FrmImportDataGrupCustomer("Import Data GrupCustomer dari File Excel");
            frm.Listener = this;
            frm.ShowDialog();
        }

        protected override void ExportData()
        {
            using (var dlgSave = new SaveFileDialog())
            {
                dlgSave.Filter = "Microsoft Excel files (*.xlsx)|*.xlsx";
                dlgSave.Title = "Export Data GrupCustomer";

                var result = dlgSave.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
                    {
                        IImportExportDataBll<GrupCustomer> _importDataBll = new ImportExportDataGrupCustomerBll(dlgSave.FileName, _log);
                        _importDataBll.Export(_listOfCrupCustomer);
                    }
                }
            }
        }

        public void Ok(object sender, object data)
        {
            if (sender is FrmImportDataGrupCustomer)
            {
                LoadData(); // refresh data setelah import dari file excel
            }
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            var grupCustomer = (GrupCustomer)data;

            if (isNewData)
            {
                GridListControlHelper.AddObject<GrupCustomer>(this.gridList, _listOfCrupCustomer, grupCustomer);
                ResetButton();
            }
            else
                GridListControlHelper.UpdateObject<GrupCustomer>(this.gridList, _listOfCrupCustomer, grupCustomer);
        }
    }
}
