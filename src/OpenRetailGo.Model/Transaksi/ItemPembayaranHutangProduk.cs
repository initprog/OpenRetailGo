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

using FluentValidation;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace OpenRetailGo.Model
{
    [Table("t_item_pembayaran_hutang_produk")]
    public class ItemPembayaranHutangProduk
    {
        public ItemPembayaranHutangProduk()
        {
            entity_state = EntityState.Added;
        }

		[ExplicitKey]
		[Display(Name = "item_pembayaran_hutang_produk_id")]		
		public string item_pembayaran_hutang_produk_id { get; set; }
		
		[Display(Name = "pembayaran_hutang_produk_id")]
		public string pembayaran_hutang_produk_id { get; set; }

        [JsonIgnore]
		[Write(false)]
        public PembayaranHutangProduk PembayaranHutangProduk { get; set; }

		[Display(Name = "Produk")]
		public string beli_produk_id { get; set; }

        //[JsonIgnore]
		[Write(false)]
        public BeliProduk BeliProduk { get; set; }

		[Display(Name = "Nominal")]
		public double nominal { get; set; }
		
		[Display(Name = "Keterangan")]
		public string keterangan { get; set; }

        [JsonIgnore]
        [Write(false)]
		[Display(Name = "tanggal_sistem")]
		public Nullable<DateTime> tanggal_sistem { get; set; }

        [Write(false)]
        public EntityState entity_state { get; set; }
	}

    public class ItemPembayaranHutangProdukValidator : AbstractValidator<ItemPembayaranHutangProduk>
    {
        public ItemPembayaranHutangProdukValidator()
        {
            CascadeMode = CascadeMode.Stop;

			var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

			RuleFor(c => c.pembayaran_hutang_produk_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
			RuleFor(c => c.beli_produk_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
			RuleFor(c => c.keterangan).Length(0, 100).WithMessage(msgError2);
		}
	}
}
