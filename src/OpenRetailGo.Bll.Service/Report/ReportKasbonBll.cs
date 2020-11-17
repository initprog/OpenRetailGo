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

using log4net;
using OpenRetailGo.Model.Report;
using OpenRetailGo.Bll.Api.Report;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.Repository.Service;

namespace OpenRetailGo.Bll.Service.Report
{
    public class ReportKasbonBll : IReportKasbonBll
    {
        private ILog _log;
        private IUnitOfWork _unitOfWork;

        public ReportKasbonBll(ILog log)
        {
            _log = log;
        }

        public IList<ReportKasbonHeader> GetByBulan(int bulan, int tahun)
        {
            IList<ReportKasbonHeader> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportKasbonRepository.GetByBulan(bulan, tahun);
            }

            return oList;
        }

        public IList<ReportKasbonHeader> GetByBulan(int bulanAwal, int bulanAkhir, int tahun)
        {
            IList<ReportKasbonHeader> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportKasbonRepository.GetByBulan(bulanAwal, bulanAkhir, tahun);
            }

            return oList;
        }

        public IList<ReportKasbonHeader> GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            IList<ReportKasbonHeader> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportKasbonRepository.GetByTanggal(tanggalMulai, tanggalSelesai);
            }

            return oList;
        }

        public IList<ReportKasbonDetail> DetailGetByBulan(int bulan, int tahun)
        {
            IList<ReportKasbonDetail> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportKasbonRepository.DetailGetByBulan(bulan, tahun);
            }

            return oList;
        }

        public IList<ReportKasbonDetail> DetailGetByBulan(int bulanAwal, int bulanAkhir, int tahun)
        {
            IList<ReportKasbonDetail> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportKasbonRepository.DetailGetByBulan(bulanAwal, bulanAkhir, tahun);
            }

            return oList;
        }

        public IList<ReportKasbonDetail> DetailGetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            IList<ReportKasbonDetail> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ReportKasbonRepository.DetailGetByTanggal(tanggalMulai, tanggalSelesai);
            }

            return oList;
        }        
    }
}
