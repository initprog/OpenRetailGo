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

using Newtonsoft.Json;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using OpenRetailGo.Model;

namespace OpenRetailGo.WebAPI.Models.DTO
{
    public class JualProdukDTO
    {
        private Nullable<DateTime> _tanggal_tempo;

        public JualProdukDTO()
        {
            is_sdac = true;
            item_jual = new List<ItemJualProdukDTO>();
            item_jual_deleted = new List<ItemJualProdukDTO>();
        }

		[Display(Name = "jual_id")]		
		public string jual_id { get; set; }
		
		[Display(Name = "pengguna_id")]
		public string pengguna_id { get; set; }

		[Display(Name = "Customer")]
		public string customer_id { get; set; }

        [JsonIgnore]
        public Customer Customer { get; set; }

		[Display(Name = "Nota")]
		public string nota { get; set; }
		
		[Display(Name = "Tanggal")]
		public Nullable<DateTime> tanggal { get; set; }        

		[Display(Name = "Tanggal Tempo")]        
        public Nullable<DateTime> tanggal_tempo
        {
            get { return _tanggal_tempo.IsNull() ? null : _tanggal_tempo; }
            set { _tanggal_tempo = value; }
        }

        [JsonIgnore]
        public Nullable<DateTime> tanggal_tempo_old { get; set; }

		[Display(Name = "PPN")]
		public double ppn { get; set; }
		
		[Display(Name = "Diskon")]
		public double diskon { get; set; }

        [Display(Name = "Kurir")]
        public string kurir { get; set; }

        [Display(Name = "Ongkos Kirim")]
        public double ongkos_kirim { get; set; }

		[Display(Name = "total_nota")]
		public double total_nota { get; set; }

		[Display(Name = "total_pelunasan")]
		public double total_pelunasan { get; set; }
		
		[Display(Name = "keterangan")]
		public string keterangan { get; set; }

        /// <summary>
        /// Property untuk menyimpan informasi apakah alamat kirim sama dengan alamat customer
        /// </summary>
        public bool is_sdac { get; set; }

        public bool is_dropship { get; set; }

        [Display(Name = "Kepada")]
        public string kirim_kepada { get; set; }

        [Display(Name = "Alamat")]
        public string kirim_alamat { get; set; }

        [Display(Name = "Desa")]
        public string kirim_desa { get; set; }        

        [Display(Name = "Kelurahan")]
        public string kirim_kelurahan { get; set; }

        [Display(Name = "Kecamatan")]
        public string kirim_kecamatan { get; set; }

        [Display(Name = "Kota")]
        public string kirim_kota { get; set; }

        [Display(Name = "Kabupaten")]
        public string kirim_kabupaten { get; set; }

        [Display(Name = "Kode Pos")]
        public string kirim_kode_pos { get; set; }

        [Display(Name = "Telepon")]
        public string kirim_telepon { get; set; }

        [Display(Name = "Label dari #1")]
        public string label_dari1 { get; set; }

        [Display(Name = "Label dari #2")]
        public string label_dari2 { get; set; }

        [Display(Name = "Label dari #3")]
        public string label_dari3 { get; set; }

        [Display(Name = "Label dari #4")]
        public string label_dari4 { get; set; }

        [Display(Name = "Label kepada #1")]
        public string label_kepada1 { get; set; }

        [Display(Name = "Label kepada #2")]
        public string label_kepada2 { get; set; }

        [Display(Name = "Label kepada #3")]
        public string label_kepada3 { get; set; }

        [Display(Name = "Label kepada #4")]
        public string label_kepada4 { get; set; }

        [JsonIgnore]
        [Display(Name = "Bayar Tunai")]
        public double bayar_tunai { get; set; }

        [Display(Name = "Bayar Kartu")]
        public double bayar_kartu { get; set; }

        public double jumlah_bayar
        {
            get { return bayar_tunai + bayar_kartu; }
        }

        [JsonIgnore]
        [Display(Name = "tanggal_sistem")]
        public Nullable<DateTime> tanggal_sistem { get; set; }
		
		[Display(Name = "retur_jual_id")]
		public string retur_jual_id { get; set; }

        [JsonIgnore]
        public ReturJualProdukDTO ReturJualProduk { get; set; }

		[Display(Name = "shift_id")]
		public string shift_id { get; set; }

        [JsonIgnore]
        public Shift Shift { get; set; }

        [Display(Name = "mesin_id")]
        public string mesin_id { get; set; }

        [JsonIgnore]
        public MesinKasir Mesin { get; set; }

        [Display(Name = "kartu_id")]
        public string kartu_id { get; set; }

        [JsonIgnore]
        public KartuDTO Kartu { get; set; }

        [Display(Name = "dropshipper_id")]
        public string dropshipper_id { get; set; }

        [JsonIgnore]
        public DropshipperDTO Dropshipper { get; set; }

        [Display(Name = "Nomor Kartu")]
        public string nomor_kartu { get; set; }

        public bool is_tunai { get; set; }

        public double total_pelunasan_old { get; set; }        

        /// <summary>
        /// total nota setelah dikurangi diskon kemudian ditambah ppn
        /// </summary>
        public double grand_total
        {
            get { return total_nota - diskon + ongkos_kirim + ppn; }
        }

        public double sisa_nota
        {
            get { return grand_total - total_pelunasan; }
        }

        public IList<ItemJualProdukDTO> item_jual { get; set; }

        public IList<ItemJualProdukDTO> item_jual_deleted { get; set; }
    }

    public class JualProdukDTOValidator : AbstractValidator<JualProdukDTO>
    {
        public JualProdukDTOValidator()
        {
            CascadeMode = FluentValidation.CascadeMode.StopOnFirstFailure;

            var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "'{PropertyName}' maksimal {MaxLength} karakter !";

            RuleSet("save", () =>
            {
                DefaultRule(msgError1, msgError2);
            });

            RuleSet("update", () =>
            {
                RuleFor(c => c.jual_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
                DefaultRule(msgError1, msgError2);
            });

            RuleSet("delete", () =>
            {
                RuleFor(c => c.jual_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
            });
        }

        private void DefaultRule(string msgError1, string msgError2)
        {
            RuleFor(c => c.pengguna_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
            RuleFor(c => c.nota).NotEmpty().WithMessage(msgError1).Length(1, 20).WithMessage(msgError2);
            RuleFor(c => c.keterangan).Length(0, 100).WithMessage(msgError2);
            RuleFor(c => c.kurir).Length(0, 100).WithMessage(msgError2);
            RuleFor(c => c.nomor_kartu).Length(0, 20).WithMessage(msgError2);

            RuleFor(c => c.label_dari1).Length(0, 100).WithMessage(msgError2);
            RuleFor(c => c.label_dari2).Length(0, 100).WithMessage(msgError2);
            RuleFor(c => c.label_dari3).Length(0, 100).WithMessage(msgError2);
            RuleFor(c => c.label_dari4).Length(0, 100).WithMessage(msgError2);

            RuleFor(c => c.label_kepada1).Length(0, 250).WithMessage(msgError2);
            RuleFor(c => c.label_kepada2).Length(0, 250).WithMessage(msgError2);
            RuleFor(c => c.label_kepada3).Length(0, 250).WithMessage(msgError2);
            RuleFor(c => c.label_kepada4).Length(0, 250).WithMessage(msgError2);
        }
    }
}