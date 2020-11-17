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
using System.Collections.Generic;

using log4net;
using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.Repository.Service;

namespace OpenRetailGo.Bll.Service
{
    public class HeaderNotaBll : IHeaderNotaBll
    {
		private ILog _log = LogManager.GetLogger(typeof(HeaderNotaBll));
        private IUnitOfWork _unitOfWork;
		private HeaderNotaValidator _validator;

		public HeaderNotaBll()
        {
            _validator = new HeaderNotaValidator();
        }

        public IList<HeaderNota> GetAll()
        {
            IList<HeaderNota> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.HeaderNotaRepository.GetAll();
            }

            return oList;
        }

        public int Save(HeaderNota obj)
        {
            throw new NotImplementedException();
        }

		public int Update(HeaderNota obj)
        {
            var result = 0;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                result = _unitOfWork.HeaderNotaRepository.Update(obj);
            }

            return result;
        }

        public int Update(HeaderNota obj, ref ValidationError validationError)
        {
            var validatorResults = _validator.Validate(obj);

            if (!validatorResults.IsValid)
            {
                foreach (var failure in validatorResults.Errors)
                {
                    validationError.Message = failure.ErrorMessage;
                    validationError.PropertyName = failure.PropertyName;
                    return 0;
                }
            }

            return Update(obj);
        }

        public int Delete(HeaderNota obj)
        {
            throw new NotImplementedException();
        }        
    }
}     
