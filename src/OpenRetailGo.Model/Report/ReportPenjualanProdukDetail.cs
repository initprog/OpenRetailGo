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

namespace OpenRetailGo.Model.Report
{
    public class ReportPenjualanProdukDetail
    {
        public string customer_id { get; set; }
        public string nama_customer { get; set; }
        public DateTime tanggal { get; set; }
        public DateTime tanggal_tempo { get; set; }
        public string nota { get; set; }
        public string produk_id { get; set; }
        public string nama_produk { get; set; }
        public string satuan { get; set; }
        public double jumlah { get; set; }
        public double diskon { get; set; }
        public double jumlah_retur { get; set; }
        public double harga_beli { get; set; }
        public double harga_jual { get; set; }
        public string keterangan { get; set; }

        public double diskon_rupiah_harga_jual
        {
            get { return diskon / 100 * harga_jual; }
        }

        public double harga_jual_setelah_diskon
        {
            get { return harga_jual - diskon_rupiah_harga_jual; }
        }

        public double sub_total
        {
            get { return (jumlah - jumlah_retur) * harga_jual_setelah_diskon; }
        }
    }
}