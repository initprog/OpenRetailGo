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
    public class ItemMenuBll : IItemMenuBll
    {
		private ILog _log;
        private IUnitOfWork _unitOfWork;

		public ItemMenuBll(ILog log)
        {
			_log = log;
        }

        public ItemMenu GetByID(string id)
        {
            ItemMenu obj = null;
            
            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                obj = _unitOfWork.ItemMenuRepository.GetByID(id);
            }

            return obj;
        }

        public IList<ItemMenu> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<ItemMenu> GetByMenu(string menuId)
        {
            IList<ItemMenu> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ItemMenuRepository.GetByMenu(menuId);
            }

            return oList;
        }

        public IList<ItemMenu> GetAll()
        {
            IList<ItemMenu> oList = null;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                oList = _unitOfWork.ItemMenuRepository.GetAll();
            }

            return oList;
        }

		public int Save(ItemMenu obj)
        {
            var result = 0;

            using (IDapperContext context = new DapperContext())
            {
                _unitOfWork = new UnitOfWork(context, _log);
                result = _unitOfWork.ItemMenuRepository.Save(obj);
            }

            return result;
        }

		public int Update(ItemMenu obj)
        {
            throw new NotImplementedException();
        }

        public int Delete(ItemMenu obj)
        {
            throw new NotImplementedException();
        }        
    }
}     
