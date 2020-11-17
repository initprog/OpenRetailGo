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

using OpenRetailGo.Bll.Api;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.Repository.Service;

namespace OpenRetailGo.Bll.Service
{
    public class DbConnectionHelper : IDbConnectionHelper
    {
        private string _dbError;
        public string DbError => _dbError;

        public bool IsOpenConnection()
        {
            using (IDapperContext context = new DapperContext())
            {
                if (context.IsOpenConnection())
                    return true;
                else if(! string.IsNullOrEmpty(((DapperContext)context).DbError))
                    _dbError = ((DapperContext)context).DbError;
                return false;
            }
        }

        public bool ExecSQL(string sql)
        {
            var result = false;
            _dbError = string.Empty;

            using (IDapperContext context = new DapperContext())
            {
                if (context.IsOpenConnection())
                {
                    result = context.ExecSQL(sql);
                } else
                {
                    _dbError = ((DapperContext)context).DbError;
                }
            }

            return result;
        }
    }
}
