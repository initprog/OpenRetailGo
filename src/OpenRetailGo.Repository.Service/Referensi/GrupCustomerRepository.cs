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
    public class GrupCustomerRepository : IGrupCustomerRepository
    {
        private IDapperContext _context;
        private ILog _log;

        public GrupCustomerRepository(IDapperContext context, ILog log)
        {
            this._context = context;
            this._log = log;
        }

        public GrupCustomer GetByID(int id)
        {
            GrupCustomer obj = null;

            try
            {
                obj = _context.db.Get<GrupCustomer>(id);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);                
            }

            return obj;
        }

        public IList<GrupCustomer> GetByName(string name, bool useLikeOperator = true)
        {
            IList<GrupCustomer> oList = new List<GrupCustomer>();

            try
            {
                oList = _context.db.GetAll<GrupCustomer>()
                                .Where(f => useLikeOperator ? f.nama_grup.ToLower().Contains(name.ToLower()) : f.nama_grup.ToLower() == name.ToLower())
                                .OrderBy(f => f.nama_grup)
                                .ToList();
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public IList<GrupCustomer> GetAll()
        {
            IList<GrupCustomer> oList = new List<GrupCustomer>();

            try
            {
                oList = _context.db.GetAll<GrupCustomer>()
                                .OrderBy(f => f.seqno)
                                .ToList();
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        /// <summary>
        /// Save GrupCustomer record.
        /// </summary>
        /// <param name="obj">GrupCustomer</param>
        /// <returns>Newly inserted grup customer ID</returns>
        public int Save(GrupCustomer obj)
        {
            var result = 0;

            try
            {
                result = (int)_context.db.Insert<GrupCustomer>(obj);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        /// <summary>
        /// Update GrupCustomer record.
        /// </summary>
        /// <param name="obj">GrupCustomer</param>
        /// <returns>1 on success, otherwise 0</returns>
        public int Update(GrupCustomer obj)
        {
            var result = 0;

            try
            {
                result = _context.db.Update(obj) ? 1 : 0;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        /// <summary>
        /// Delete record pelanggan.
        /// </summary>
        /// <param name="obj">Record pelanggan</param>
        /// <param name="softDelete">Kalau true, jangan hapus recordnya tapi set isAktif=false. Kalau false, delete recordnya.</param>
        /// <returns>Berapa record yg dihapus atau di update.</returns>
        public int Delete(GrupCustomer obj, bool softDelete = true)
        {
            var result = 0;
            
            try
            {
                if (softDelete)
                {
                    obj.is_aktif = false;
                    result = Update(obj);
                }
                else
                    result = _context.db.Delete<GrupCustomer>(obj) ? 1 : 0;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }
    }
}     
