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

using log4net;
using OpenRetailGo.Model.Report;
using OpenRetailGo.Bll.Api.Report;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.Repository.Service;

namespace OpenRetailGo.Bll.Service.Report
{
    public class ReportRugiLabaBll : IReportRugiLabaBll
    {
        private ILog _log;
        private IUnitOfWork _unitOfWork;

        public ReportRugiLabaBll(ILog log)
        {
            _log = log;
        }

        public ReportRugiLaba GetByBulan(int bulan, int tahun)
        {
            ReportRugiLaba obj = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                obj = _unitOfWork.ReportRugiLabaRepository.GetByBulan(bulan, tahun);
            }

            return obj;
        }

        public ReportRugiLaba GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            ReportRugiLaba obj = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                obj = _unitOfWork.ReportRugiLabaRepository.GetByTanggal(tanggalMulai, tanggalSelesai);
            }

            return obj;
        }
    }
}
