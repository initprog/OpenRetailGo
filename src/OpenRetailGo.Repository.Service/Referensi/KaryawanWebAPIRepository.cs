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

using OpenRetailGo.Helper;
using OpenRetailGo.Model;
using OpenRetailGo.Model.WebAPI;
using OpenRetailGo.Repository.Api;

namespace OpenRetailGo.Repository.Service
{
    public class KaryawanWebAPIRepository : IKaryawanRepository
    {
        private string _apiUrl = string.Empty;
        private ILog _log;
		
        public KaryawanWebAPIRepository(string baseUrl, ILog log)
        {
            this._apiUrl = baseUrl + "api/karyawan/";
            this._log = log;
        }

        public Karyawan GetByID(string id)
        {
            Karyawan obj = null;

			try
            {
                var api = string.Format("get_by_id?id={0}", id);
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<Karyawan>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    obj = response.Results[0];
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return obj;
        }

        public IList<Karyawan> GetByName(string name)
        {
            IList<Karyawan> oList = new List<Karyawan>();

			try
            {
                var api = string.Format("get_by_name?name={0}", name);
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<Karyawan>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    oList = response.Results;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public IList<Karyawan> GetAll()
        {
            IList<Karyawan> oList = new List<Karyawan>();

			try
            {
                var api = "get_all";
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<Karyawan>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    oList = response.Results;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public int Save(Karyawan obj)
        {
            var result = 0;

			try
            {
                var api = "save";
                var response = RestSharpHelper<OpenRetailWebApiPostResponse>.PostRequest(_apiUrl, api, obj);

                result = Convert.ToInt32(response.Results);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        public int Update(Karyawan obj)
        {
            var result = 0;

			try
            {
                var api = "update";
                var response = RestSharpHelper<OpenRetailWebApiPostResponse>.PostRequest(_apiUrl, api, obj);

                result = Convert.ToInt32(response.Results);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        public int Delete(Karyawan obj)
        {
            var result = 0;

			try
            {
                var api = "delete";
                var response = RestSharpHelper<OpenRetailWebApiPostResponse>.PostRequest(_apiUrl, api, obj);

                result = Convert.ToInt32(response.Results);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }
    }
}     
