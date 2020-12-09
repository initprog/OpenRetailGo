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

namespace OpenRetailGo.Model.Report
{
    public class ReportMesinKasir
    {
        public ReportMesinKasir()
        {
            item_jual = new List<ReportPenjualanProduk>();
        }

        public string mesin_id { get; set; }
        public Nullable<DateTime> tanggal { get; set; }
        public double saldo_awal { get; set; }
        public double uang_masuk { get; set; }

        public string pengguna_id { get; set; }
        public Pengguna Pengguna { get; set; }

        public string shift_id { get; set; }
        public Shift Shift { get; set; }

        public double uang_keluar { get; set; }
        public Nullable<DateTime> tanggal_sistem { get; set; }

        public ReportPenjualanProdukHeader jual { get; set; }
        public IList<ReportPenjualanProduk> item_jual { get; set; }
    }
}