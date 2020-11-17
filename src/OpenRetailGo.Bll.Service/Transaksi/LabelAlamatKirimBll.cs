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

using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;

namespace OpenRetailGo.Bll.Service
{
    public class LabelAlamatKirimBll : ILabelAlamatKirimBll
    {
        private LabelAlamatKirimValidator _validator;

        public LabelAlamatKirimBll()
        {
            _validator = new LabelAlamatKirimValidator();
        }

        public bool IsValid(LabelAlamatKirim obj, ref ValidationError validationError)
        {
            var validatorResults = _validator.Validate(obj);

            if (!validatorResults.IsValid)
            {
                foreach (var failure in validatorResults.Errors)
                {
                    validationError.Message = failure.ErrorMessage;
                    validationError.PropertyName = failure.PropertyName;
                    return false;
                }
            }

            return true;
        }
    }
}
