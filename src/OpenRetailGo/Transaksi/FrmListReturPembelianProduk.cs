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
using System.Windows.Forms;

using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;
using OpenRetailGo.Bll.Service;
using OpenRetailGo.Helper.UI.Template;
using OpenRetailGo.Helper;
using Syncfusion.Windows.Forms.Grid;
using ConceptCave.WaitCursor;
using log4net;

namespace OpenRetailGo.Transaksi
{
    public partial class FrmListReturPembelianProduk : FrmListEmptyBody, IListener
    {
        private IReturBeliProdukBll _bll; // deklarasi objek business logic layer 
        private IList<ReturBeliProduk> _listOfRetur = new List<ReturBeliProduk>();
        private ILog _log;
        private Pengguna _pengguna;
        private string _menuId;

        public FrmListReturPembelianProduk(string header, Pengguna pengguna, string menuId)
            : base()
        {
            InitializeComponent();

            base.SetHeader(header);
            base.WindowState = FormWindowState.Maximized;

            _log = MainProgram.log;
            _bll = new ReturBeliProdukBll(_log);
            _pengguna = pengguna;
            _menuId = menuId;

            // set hak akses untuk SELECT
            var role = _pengguna.GetRoleByMenuAndGrant(_menuId, GrantState.SELECT);
            if (role != null)
            {
                if (role.is_grant)
                    LoadData(filterRangeTanggal.TanggalMulai, filterRangeTanggal.TanggalSelesai);

                filterRangeTanggal.Enabled = role.is_grant;
            }

            InitGridList();

            // set hak akses selain SELECT (TAMBAH, PERBAIKI dan HAPUS)
            RolePrivilegeHelper.SetHakAkses(this, _pengguna, _menuId, _listOfRetur.Count);
        }

        private void InitGridList()
        {
            var gridListProperties = new List<GridListControlProperties>();

            gridListProperties.Add(new GridListControlProperties { Header = "No", Width = 30 });
            gridListProperties.Add(new GridListControlProperties { Header = "Tanggal", Width = 100 });
            gridListProperties.Add(new GridListControlProperties { Header = "Nota Retur", Width = 100 });
            gridListProperties.Add(new GridListControlProperties { Header = "Nota Beli", Width = 100 });
            gridListProperties.Add(new GridListControlProperties { Header = "Supplier", Width = 400 });
            gridListProperties.Add(new GridListControlProperties { Header = "Keterangan", Width = 500 });
            gridListProperties.Add(new GridListControlProperties { Header = "Total", Width = 150 });

            GridListControlHelper.InitializeGridListControl<ReturBeliProduk>(this.gridList, _listOfRetur, gridListProperties);

            if (_listOfRetur.Count > 0)
                this.gridList.SetSelected(0, true);

            this.gridList.Grid.QueryCellInfo += delegate(object sender, GridQueryCellInfoEventArgs e)
            {

                if (_listOfRetur.Count > 0)
                {
                    if (e.RowIndex > 0)
                    {
                        var rowIndex = e.RowIndex - 1;

                        if (rowIndex < _listOfRetur.Count)
                        {
                            double totalNota = 0;

                            var retur = _listOfRetur[rowIndex];

                            if (retur != null)
                                totalNota = retur.total_nota;

                            switch (e.ColIndex)
                            {
                                case 2:
                                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
                                    e.Style.CellValue = DateTimeHelper.DateToString(retur.tanggal);
                                    break;

                                case 3:
                                    e.Style.CellValue = retur.nota;
                                    break;

                                case 4:
                                    var beli = retur.BeliProduk;
                                    if (beli != null)
                                        e.Style.CellValue = beli.nota;

                                    break;

                                case 5:
                                    if (retur.Supplier != null)
                                        e.Style.CellValue = retur.Supplier.nama_supplier;

                                    break;

                                case 6:
                                    e.Style.CellValue = retur.keterangan;
                                    break;

                                case 7:
                                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Right;
                                    e.Style.CellValue = NumberHelper.NumberToString(totalNota);
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
                _listOfRetur = _bll.GetAll();
                GridListControlHelper.Refresh<ReturBeliProduk>(this.gridList, _listOfRetur);
            }

            ResetButton();
        }

        private void LoadData(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                _listOfRetur = _bll.GetByTanggal(tanggalMulai, tanggalSelesai);
                GridListControlHelper.Refresh<ReturBeliProduk>(this.gridList, _listOfRetur);
            }

            ResetButton();
        }

        private void ResetButton()
        {
            base.SetActiveBtnPerbaikiAndHapus(_listOfRetur.Count > 0);

            // set hak akses selain SELECT (TAMBAH, PERBAIKI dan HAPUS)
            RolePrivilegeHelper.SetHakAkses(this, _pengguna, _menuId, _listOfRetur.Count);
        }

        protected override void Tambah()
        {
            var frm = new FrmEntryReturPembelianProduk("Tambah Data " + this.Text, _bll);
            frm.Listener = this;
            frm.ShowDialog();
        }

        protected override void Perbaiki()
        {
            var index = this.gridList.SelectedIndex;

            if (!base.IsSelectedItem(index, this.TabText))
                return;

            var retur = _listOfRetur[index];

            LogicalThreadContext.Properties["OldValue"] = retur.ToJson();

            var frm = new FrmEntryReturPembelianProduk("Edit Data " + this.Text, retur, _bll);
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
                var retur = _listOfRetur[index];

                var result = _bll.Delete(retur);
                if (result > 0)
                {
                    GridListControlHelper.RemoveObject<ReturBeliProduk>(this.gridList, _listOfRetur, retur);
                    ResetButton();
                }
                else
                    MsgHelper.MsgDeleteError();
            }
        }

        public void Ok(object sender, object data)
        {
            throw new NotImplementedException();
        }

        public void Ok(object sender, bool isNewData, object data)
        {
            var retur = (ReturBeliProduk)data;

            if (isNewData)
            {
                GridListControlHelper.AddObject<ReturBeliProduk>(this.gridList, _listOfRetur, retur);
                ResetButton();
            }
            else
                GridListControlHelper.UpdateObject<ReturBeliProduk>(this.gridList, _listOfRetur, retur);
        }

        private void gridList_DoubleClick(object sender, EventArgs e)
        {
            if (btnPerbaiki.Enabled)
                Perbaiki();
        }

        private void filterRangeTanggal_BtnTampilkanClicked(object sender, EventArgs e)
        {
            var tanggalMulai = filterRangeTanggal.TanggalMulai;
            var tanggalSelesai = filterRangeTanggal.TanggalSelesai;

            if (!DateTimeHelper.IsValidRangeTanggal(tanggalMulai, tanggalSelesai))
            {
                MsgHelper.MsgNotValidRangeTanggal();
                return;
            }

            LoadData(tanggalMulai, tanggalSelesai);
        }

        private void filterRangeTanggal_ChkTampilkanSemuaDataClicked(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;

            if (chk.Checked)
                LoadData();
            else
                LoadData(filterRangeTanggal.TanggalMulai, filterRangeTanggal.TanggalSelesai);
        }
    }
}
