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

using FluentValidation;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace OpenRetailGo.Model
{
    [Table("m_alasan_penyesuaian_stok")]
    public class AlasanPenyesuaianStok
    {
        [ExplicitKey]
		[Display(Name = "alasan_penyesuaian_stok_id")]		
		public string alasan_penyesuaian_stok_id { get; set; }
		
		[Display(Name = "Alasan")]
		public string alasan { get; set; }
	}

    public class AlasanPenyesuaianStokValidator : AbstractValidator<AlasanPenyesuaianStok>
    {
        public AlasanPenyesuaianStokValidator()
        {
            CascadeMode = FluentValidation.CascadeMode.Stop;

			var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

			RuleFor(c => c.alasan).NotEmpty().WithMessage(msgError1).Length(1, 100).WithMessage(msgError2);
		}
	}
}
