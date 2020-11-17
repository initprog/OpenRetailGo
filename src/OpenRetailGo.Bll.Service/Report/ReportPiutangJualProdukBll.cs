/**
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

using log4net;
using OpenRetailGo.Model.Report;
using OpenRetailGo.Bll.Api.Report;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.Repository.Service;

namespace OpenRetailGo.Bll.Service.Report
{
    public class ReportPiutangJualProdukBll : IReportPiutangJualProdukBll
    {
        private ILog _log;
        private IUnitOfWork _unitOfWork;

        public ReportPiutangJualProdukBll(ILog log)
        {
            _log = log;
        }

        public IList<ReportPiutangPenjualanProdukHeader> GetByBulan(int bulan, int tahun)
        {
            IList<ReportPiutangPenjualanProdukHeader> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.GetByBulan(bulan, tahun);
            }

            return oList;
        }

        public IList<ReportPiutangPenjualanProdukHeader> GetByBulan(int bulanAwal, int bulanAkhir, int tahun)
        {
            IList<ReportPiutangPenjualanProdukHeader> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.GetByBulan(bulanAwal, bulanAkhir, tahun);
            }

            return oList;
        }

        public IList<ReportPiutangPenjualanProdukHeader> GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            IList<ReportPiutangPenjualanProdukHeader> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.GetByTanggal(tanggalMulai, tanggalSelesai);
            }

            return oList;
        }

        public IList<ReportPiutangPenjualanProdukDetail> DetailGetByBulan(int bulan, int tahun)
        {
            IList<ReportPiutangPenjualanProdukDetail> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.DetailGetByBulan(bulan, tahun);
            }

            return oList;
        }

        public IList<ReportPiutangPenjualanProdukDetail> DetailGetByBulan(int bulanAwal, int bulanAkhir, int tahun)
        {
            IList<ReportPiutangPenjualanProdukDetail> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.DetailGetByBulan(bulanAwal, bulanAkhir, tahun);
            }

            return oList;
        }

        public IList<ReportPiutangPenjualanProdukDetail> DetailGetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            IList<ReportPiutangPenjualanProdukDetail> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.DetailGetByTanggal(tanggalMulai, tanggalSelesai);
            }

            return oList;
        }

        private void HitungGrandTotalCustomer(IList<ReportPiutangPenjualanProduk> listOfReportPiutang)
        {
            var isFirstRecord = false;
            var jualId = string.Empty;

            foreach (var item in listOfReportPiutang)
            {
                if (jualId != item.jual_id)
                {
                    jualId = item.jual_id;
                    isFirstRecord = true;
                }

                if (isFirstRecord)
                {
                    item.total_pelunasan_customer = item.total_pelunasan;
                    item.grand_total_customer = item.grand_total;

                    isFirstRecord = false;
                }
            }
        }

        public IList<ReportPiutangPenjualanProduk> PerProdukGetByBulan(int bulan, int tahun)
        {
            IList<ReportPiutangPenjualanProduk> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.PerProdukGetByBulan(bulan, tahun);
            }

            if (oList.Count > 0)
            {
                HitungGrandTotalCustomer(oList);
            }

            return oList;
        }        

        public IList<ReportPiutangPenjualanProduk> PerProdukGetByBulan(int bulanAwal, int bulanAkhir, int tahun)
        {
            IList<ReportPiutangPenjualanProduk> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.PerProdukGetByBulan(bulanAwal, bulanAkhir, tahun);
            }

            if (oList.Count > 0)
            {
                HitungGrandTotalCustomer(oList);
            }

            return oList;
        }

        public IList<ReportPiutangPenjualanProduk> PerProdukGetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            IList<ReportPiutangPenjualanProduk> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportPiutangJualProdukRepository.PerProdukGetByTanggal(tanggalMulai, tanggalSelesai);
            }

            if (oList.Count > 0)
            {
                HitungGrandTotalCustomer(oList);
            }

            return oList;
        }        
    }
}
