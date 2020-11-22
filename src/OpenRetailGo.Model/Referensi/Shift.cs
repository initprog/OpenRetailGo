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

namespace OpenRetailGo.Model
{
    [Table("m_shift")]
    public class Shift
    {
		[ExplicitKey]
		[Display(Name = "shift_id")]		
		public string shift_id { get; set; }
		
		[Display(Name = "nama_shift")]
		public string nama_shift { get; set; }
		
		[Display(Name = "jam_mulai")]
		public Nullable<DateTime> jam_mulai { get; set; }
		
		[Display(Name = "jam_selesai")]
		public Nullable<DateTime> jam_selesai { get; set; }
		
		[Display(Name = "is_active")]
		public bool is_active { get; set; }
		
	}

    public class ShiftValidator : AbstractValidator<Shift>
    {
        public ShiftValidator()
        {
            CascadeMode = CascadeMode.Stop;

			var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

			RuleFor(c => c.nama_shift).NotEmpty().WithMessage(msgError1).Length(1, 100).WithMessage(msgError2);
		}
	}
}
