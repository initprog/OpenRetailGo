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
    [Table("m_kabupaten2")]
    public class Kabupaten
    {
		[ExplicitKey]
		[Display(Name = "kabupaten_id")]		
		public string kabupaten_id { get; set; }
		
		[Display(Name = "provinsi_id")]
		public string provinsi_id { get; set; }

		[Write(false)]
        public Provinsi Provinsi { get; set; }

		[Display(Name = "nama_kabupaten")]
		public string nama_kabupaten { get; set; }
		
	}

    public class KabupatenValidator : AbstractValidator<Kabupaten>
    {
        public KabupatenValidator()
        {
            CascadeMode = CascadeMode.Stop;

			var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

			RuleFor(c => c.provinsi_id).NotEmpty().WithMessage(msgError1).Length(1, 2).WithMessage(msgError2);
			RuleFor(c => c.nama_kabupaten).NotEmpty().WithMessage(msgError1).Length(1, 250).WithMessage(msgError2);
		}
	}
}
