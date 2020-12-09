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

using System;
using System.Collections.Generic;

using log4net;
using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.Repository.Service;

namespace OpenRetailGo.Bll.Service
{
    public class GrupCustomerBll : IGrupCustomerBll
    {
        private ILog _log;
        private IUnitOfWork _unitOfWork;
        private GrupCustomerValidator _validator;

        private bool _isUseWebAPI;
        private string _baseUrl;		

        public GrupCustomerBll(ILog log)
        {
            _log = log;
            _validator = new GrupCustomerValidator();
        }

        public GrupCustomerBll(bool isUseWebAPI, string baseUrl, ILog log)
            : this(log)
        {
            _isUseWebAPI = isUseWebAPI;
            _baseUrl = baseUrl;
        }

        public GrupCustomer GetByID(int id)
        {
            GrupCustomer obj = null;

            if (_isUseWebAPI)
            {
                // TODO: not implemented yet
                //_unitOfWork = new UnitOfWork(_isUseWebAPI, _baseUrl, _log);
                //obj = _unitOfWork.GrupCustomerRepository.GetByID(id);
            }
            else
            {
                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);
                    obj = repo.GetByID(id);
                }
            }            

            return obj;
        }

        public IList<GrupCustomer> GetByName(string name)
        {
            IList<GrupCustomer> oList = null;

            if (_isUseWebAPI)
            {
                //_unitOfWork = new UnitOfWork(_isUseWebAPI, _baseUrl, _log);
                //oList = _unitOfWork.GrupCustomerRepository.GetByName(name);
            }
            else
            {
                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);
                    oList = repo.GetByName(name);
                }
            }            

            return oList;
        }

        public IList<GrupCustomer> GetAll()
        {
            IList<GrupCustomer> oList = null;

            if (_isUseWebAPI)
            {
                //_unitOfWork = new UnitOfWork(_isUseWebAPI, _baseUrl, _log);
                //oList = _unitOfWork.GrupCustomerRepository.GetAll();
            }
            else
            {
                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);
                    oList = repo.GetAll();
                }
            }            

            return oList;
        }

		public int Save(GrupCustomer obj)
        {
            var result = 0;

            if (_isUseWebAPI)
            {
                //obj.GrupCustomer_id = Guid.NewGuid().ToString();

                //_unitOfWork = new UnitOfWork(_isUseWebAPI, _baseUrl, _log);                
                //result = _unitOfWork.GrupCustomerRepository.Save(obj);
            }
            else
            {
                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);
                    result = repo.Save(obj);
                }
            }            

            return result;
        }

        public int Save(GrupCustomer obj, ref ValidationError validationError)
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

            return Save(obj);
        }

		public int Update(GrupCustomer obj)
        {
            var result = 0;

            if (_isUseWebAPI)
            {
                //_unitOfWork = new UnitOfWork(_isUseWebAPI, _baseUrl, _log);
                //result = _unitOfWork.GrupCustomerRepository.Update(obj);
            }
            else
            {
                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);
                    result = repo.Update(obj);
                }
            }            

            return result;
        }

        public int Update(GrupCustomer obj, ref ValidationError validationError)
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

        public int Delete(GrupCustomer obj)
        {
            var result = 0;

            if (_isUseWebAPI)
            {
                //_unitOfWork = new UnitOfWork(_isUseWebAPI, _baseUrl, _log);
                //result = _unitOfWork.GrupCustomerRepository.Delete(obj);
            }
            else
            {
                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);
                    result = repo.Delete(obj, true);
                }
            }            

            return result;
        }

        public int SoftDelete(GrupCustomer obj)
        {            
            var result = 0;

            if (_isUseWebAPI)
            {
                //_unitOfWork = new UnitOfWork(_isUseWebAPI, _baseUrl, _log);
                //result = _unitOfWork.GrupCustomerRepository.Delete(obj);
            }
            else
            {
                using (IDapperContext context = new DapperContext())
                {
                    GrupCustomerRepository repo = new GrupCustomerRepository(context, _log);
                    result = repo.Delete(obj, true);
                }
            }

            return result;
        }
    }
}     
