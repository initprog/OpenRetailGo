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
using System.ComponentModel.DataAnnotations;

namespace OpenRetailGo.WebAPI.Models.DTO
{
    public class AlasanPenyesuaianStokDTO
    {
		[Display(Name = "alasan_penyesuaian_stok_id")]		
		public string alasan_penyesuaian_stok_id { get; set; }
		
		[Display(Name = "alasan")]
		public string alasan { get; set; }
		
	}

    public class AlasanPenyesuaianStokDTOValidator : AbstractValidator<AlasanPenyesuaianStokDTO>
    {
        public AlasanPenyesuaianStokDTOValidator()
        {
            CascadeMode = CascadeMode.Stop;

			var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "'{PropertyName}' maksimal {MaxLength} karakter !";			

			RuleSet("save", () =>
            {
                RuleFor(c => c.alasan).NotEmpty().WithMessage(msgError1).Length(1, 100).WithMessage(msgError2);			
            });

            RuleSet("update", () =>
            {
                RuleFor(c => c.alasan_penyesuaian_stok_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
                RuleFor(c => c.alasan).NotEmpty().WithMessage(msgError1).Length(1, 100).WithMessage(msgError2);			
            });

            RuleSet("delete", () =>
            {
                RuleFor(c => c.alasan_penyesuaian_stok_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
            });
		}
	}
}
