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
    public class RoleDTO
    {
		[Display(Name = "role_id")]		
		public string role_id { get; set; }
		
		[Display(Name = "nama_role")]
		public string nama_role { get; set; }
		
		[Display(Name = "is_active")]
		public bool is_active { get; set; }
		
	}

    public class RoleDTOValidator : AbstractValidator<RoleDTO>
    {
        public RoleDTOValidator()
        {
            CascadeMode = CascadeMode.Stop;

			var msgError1 = "'{PropertyName}' tidak boleh kosong !";
            var msgError2 = "'{PropertyName}' maksimal {MaxLength} karakter !";

			RuleSet("save", () =>
            {
                RuleFor(c => c.nama_role).NotEmpty().WithMessage(msgError1).Length(1, 50).WithMessage(msgError2);			
            });

            RuleSet("update", () =>
            {
                RuleFor(c => c.role_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);
                RuleFor(c => c.nama_role).NotEmpty().WithMessage(msgError1).Length(1, 50).WithMessage(msgError2);			
            });

            RuleSet("delete", () =>
            {
                RuleFor(c => c.role_id).NotEmpty().WithMessage(msgError1).Length(1, 36).WithMessage(msgError2);			
            });
		}
	}
}
