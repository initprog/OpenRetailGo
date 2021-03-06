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
using System.Linq;

using log4net;
using Dapper.Contrib.Extensions;

using OpenRetailGo.Model;
using OpenRetailGo.Repository.Api;

namespace OpenRetailGo.Repository.Service
{
    public class FooterNotaMiniPosRepository : IFooterNotaMiniPosRepository
    {
        private IDapperContext _context;
		private ILog _log;
		
        public FooterNotaMiniPosRepository(IDapperContext context, ILog log)
        {
            this._context = context;
            this._log = log;
        }

        public IList<FooterNotaMiniPos> GetAll()
        {
            IList<FooterNotaMiniPos> oList = new List<FooterNotaMiniPos>();

            try
            {
                oList = _context.db.GetAll<FooterNotaMiniPos>()
                                .Where(f => f.is_active == true)
                                .OrderBy(f => f.order_number)
                                .ToList();
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public int Save(FooterNotaMiniPos obj)
        {
            throw new NotImplementedException();
        }

        public int Update(FooterNotaMiniPos obj)
        {
            var result = 0;

            try
            {
                result = _context.db.Update<FooterNotaMiniPos>(obj) ? 1 : 0;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        public int Delete(FooterNotaMiniPos obj)
        {
            throw new NotImplementedException();
        }
    }
}     
