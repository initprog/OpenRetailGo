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
using Dapper.Contrib.Extensions;

using OpenRetailGo.Model;
using OpenRetailGo.Repository.Api;

namespace OpenRetailGo.Repository.Service
{
    public class MesinKasirRepository : IMesinKasirRepository
    {
        private IDapperContext _context;
		private ILog _log;
		
        public MesinKasirRepository(IDapperContext context, ILog log)
        {
            this._context = context;
            this._log = log;
        }

        public MesinKasir GetByID(string id)
        {
            MesinKasir obj = null;

            try
            {
                obj = _context.db.Get<MesinKasir>(id);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return obj;
        }

        public IList<MesinKasir> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<MesinKasir> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Save(MesinKasir obj)
        {
            var result = 0;

            try
            {
                obj.mesin_id = _context.GetGUID();

                _context.db.Insert<MesinKasir>(obj);
                result = 1;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        public int Update(MesinKasir obj)
        {
            var result = 0;

            try
            {
                result = _context.db.Update<MesinKasir>(obj) ? 1 : 0;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        public int Delete(MesinKasir obj)
        {
            var result = 0;

            try
            {
                result = _context.db.Delete<MesinKasir>(obj) ? 1 : 0;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }
    }
}     
