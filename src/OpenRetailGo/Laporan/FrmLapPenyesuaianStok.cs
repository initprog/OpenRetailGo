﻿/**
 * Original work Copyright (C) 2017 Kamarudin (http://coding4ever.net/)
 * Modified work copyright 2020 OpenRetailGo
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
using System.Data;
using System.Linq;
using System.Windows.Forms;

using log4net;
using OpenRetailGo.Model;
using OpenRetailGo.Model.Report;
using OpenRetailGo.Bll.Api;
using OpenRetailGo.Bll.Service;
using OpenRetailGo.Helper;
using OpenRetailGo.Bll.Api.Report;
using OpenRetailGo.Bll.Service.Report;
using ConceptCave.WaitCursor;
using Microsoft.Reporting.WinForms;
using OpenRetailGo.Helper.UI.Template;

namespace OpenRetailGo.Laporan
{
    public partial class FrmLapPenyesuaianStok : FrmSettingReportStandard
    {
        private IList<AlasanPenyesuaianStok> _listOfAlasanPenyesuaianStok = new List<AlasanPenyesuaianStok>();
        private ILog _log;
        
        public FrmLapPenyesuaianStok(string header)
        {
            InitializeComponent();
            base.SetHeader(header);
            base.SetCheckBoxTitle("Pilih Alasan Penyesuaian Stok");
            base.ReSize(120);
            this.txtKeyword.Visible = false;

            _log = MainProgram.log;

            chkTampilkanNota.Visible = false;

            LoadAlasanPenyesuaianStok();
            LoadBulanDanTahun();            
        }

        private void LoadAlasanPenyesuaianStok()
        {
            IAlasanPenyesuaianStokBll bll = new AlasanPenyesuaianStokBll(_log);
            _listOfAlasanPenyesuaianStok = bll.GetAll();

            FillDataHelper.FillAlasanPenyesuaianStok(chkListBox, _listOfAlasanPenyesuaianStok);
        }

        private void LoadBulanDanTahun()
        {
            FillDataHelper.FillBulan(cmbBulan, true);
            FillDataHelper.FillTahun(cmbTahun, true);
        }        

        protected override void Preview()
        {
            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                PreviewReport();
            }
        }

        private IList<string> GetAlasanPenyesuaianStokId(IList<AlasanPenyesuaianStok> listOfAlasanPenyesuaianStok)
        {
            var listOfAlasanPenyesuaianStokId = new List<string>();

            for (var i = 0; i < chkListBox.Items.Count; i++)
            {
                if (chkListBox.GetItemChecked(i))
                {
                    var alasan = listOfAlasanPenyesuaianStok[i];
                    listOfAlasanPenyesuaianStokId.Add(alasan.alasan_penyesuaian_stok_id);
                }
            }

            return listOfAlasanPenyesuaianStokId;
        }

        private void PreviewReport()
        {
            var periode = string.Empty;

            IReportStokProdukBll reportBll = new ReportStokProdukBll(_log);

            IList<ReportPenyesuaianStokProduk> listOfReportPenyesuaianStokProduk = new List<ReportPenyesuaianStokProduk>();
            IList<string> listOfAlasanPenyesuaianStokId = new List<string>();

            if (chkBoxTitle.Checked)
            {
                listOfAlasanPenyesuaianStokId = GetAlasanPenyesuaianStokId(_listOfAlasanPenyesuaianStok);

                if (listOfAlasanPenyesuaianStokId.Count == 0)
                {
                    MsgHelper.MsgWarning("Minimal 1 alasan harus dipilih");
                    return;
                }
            }

            if (rdoTanggal.Checked)
            {
                if (!DateTimeHelper.IsValidRangeTanggal(dtpTanggalMulai.Value, dtpTanggalSelesai.Value))
                {
                    MsgHelper.MsgNotValidRangeTanggal();
                    return;
                }

                var tanggalMulai = DateTimeHelper.DateToString(dtpTanggalMulai.Value);
                var tanggalSelesai = DateTimeHelper.DateToString(dtpTanggalSelesai.Value);

                periode = dtpTanggalMulai.Value == dtpTanggalSelesai.Value ? string.Format("Periode : {0}", tanggalMulai) : string.Format("Periode : {0} s.d {1}", tanggalMulai, tanggalSelesai);

                listOfReportPenyesuaianStokProduk = reportBll.GetPenyesuaianStokByTanggal(dtpTanggalMulai.Value, dtpTanggalSelesai.Value);
            }
            else
            {
                periode = string.Format("Periode : {0} {1}", cmbBulan.Text, cmbTahun.Text);

                var bulan = cmbBulan.SelectedIndex + 1;
                var tahun = int.Parse(cmbTahun.Text);

                listOfReportPenyesuaianStokProduk = reportBll.GetPenyesuaianStokByBulan(bulan, tahun);
            }

            if (listOfAlasanPenyesuaianStokId.Count > 0 && listOfReportPenyesuaianStokProduk.Count > 0)
            {
                listOfReportPenyesuaianStokProduk = listOfReportPenyesuaianStokProduk.Where(f => listOfAlasanPenyesuaianStokId.Contains(f.alasan_penyesuaian_stok_id))
                                                                   .ToList();
            }
            
            if (listOfReportPenyesuaianStokProduk.Count > 0)
            {
                var reportDataSource = new ReportDataSource
                {
                    Name = "ReportPenyesuaianStok",
                    Value = listOfReportPenyesuaianStokProduk
                };

                var parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("periode", periode));

                base.ShowReport(this.Text, "RvPenyesuaianStok", reportDataSource, parameters);
            }
            else
            {
                MsgHelper.MsgInfo("Maaf laporan data penyesuaian stok tidak ditemukan");
            }
        }
    }
}
