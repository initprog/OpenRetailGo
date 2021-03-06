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

using Newtonsoft.Json;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using OpenRetailGo.Model;

namespace OpenRetailGo.WebAPI.Models.DTO
{
    public class ItemBeliProdukDTO
    {
        [Display(Name = "item_beli_produk_id")]
        public string item_beli_produk_id { get; set; }

        [Display(Name = "beli_produk_id")]
        public string beli_produk_id { get; set; }

        [JsonIgnore]        
        public BeliProdukDTO BeliProduk { get; set; }

        [Display(Name = "pengguna_id")]
        public string pengguna_id { get; set; }

        [JsonIgnore]
        public PenggunaDTO Pengguna { get; set; }

        [Display(Name = "produk_id")]
        public string produk_id { get; set; }

        public ProdukDTO Produk { get; set; }

        [Display(Name = "Harga")]
        public double harga { get; set; }

        [Display(Name = "Jumlah")]
        public double jumlah { get; set; }

        [Display(Name = "Diskon")]
        public double diskon { get; set; }

        [JsonIgnore]
        [Display(Name = "tanggal_sistem")]
        public Nullable<DateTime> tanggal_sistem { get; set; }

        [Display(Name = "jumlah_retur")]
        public double jumlah_retur { get; set; }

        public double diskon_rupiah
        {
            get { return diskon / 100 * harga; }
        }

        public double harga_setelah_diskon
        {
            get { return harga - diskon_rupiah; }
        }

        public double sub_total
        {
            get { return (jumlah - jumlah_retur) * harga_setelah_diskon; }
        }

        public EntityState entity_state { get; set; }
    }

    public class ItemBeliProdukDTOValidator : AbstractValidator<ItemBeliProdukDTO>
    {
        public ItemBeliProdukDTOValidator()
        {
            CascadeMode = CascadeMode.Stop;

            var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "'{PropertyName}' maksimal {MaxLength} karakter !";


            RuleSet("save", () =>
            {
                DefaultRule(msgError1, msgError2);
            });

            RuleSet("update", () =>
            {
                RuleFor(c => c.item_beli_produk_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
                DefaultRule(msgError1, msgError2);
            });

            RuleSet("delete", () =>
            {
                RuleFor(c => c.item_beli_produk_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
            });
        }

        private void DefaultRule(string msgError1, string msgError2)
        {
            RuleFor(c => c.beli_produk_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
            RuleFor(c => c.pengguna_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
            RuleFor(c => c.produk_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
        }
    }
}