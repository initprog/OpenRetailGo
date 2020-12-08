/**
 * Copyright (C) 2020 OpenRetailGo
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
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace OpenRetailGo.Model
{
    [Table("c_grup_customer")]
    public class GrupCustomer
    {
 		[Key]
		public int grup_customer_id { get; set; }
		
		public string nama_grup { get; set; }
		
		public string deskripsi { get; set; }

        public int seqno { get; set; }

        public bool is_aktif { get; set; }
	}

    public class GrupCustomerValidator : AbstractValidator<GrupCustomer>
    {
        public GrupCustomerValidator()
        {
            CascadeMode = CascadeMode.Stop;

			var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "Inputan '{PropertyName}' maksimal {MaxLength} karakter !";

            RuleFor(c => c.nama_grup).NotEmpty().WithMessage(msgError1).Length(1, 30).WithMessage(msgError2);
		}
	}
}
