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
    public class AlasanPenyesuaianStokWebAPIRepository : IAlasanPenyesuaianStokRepository
    {
        private string _apiUrl = string.Empty;
        private ILog _log;
		
        public AlasanPenyesuaianStokWebAPIRepository(string baseUrl, ILog log)
        {
            this._apiUrl = baseUrl + "api/alasan_penyesuaian_stok/";
            this._log = log;
        }

        public AlasanPenyesuaianStok GetByID(string id)
        {
            AlasanPenyesuaianStok obj = null;

			try
            {
                var api = string.Format("get_by_id?id={0}", id);
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<AlasanPenyesuaianStok>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    obj = response.Results[0];
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return obj;
        }

        public IList<AlasanPenyesuaianStok> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<AlasanPenyesuaianStok> GetAll()
        {
            IList<AlasanPenyesuaianStok> oList = new List<AlasanPenyesuaianStok>();

			try
            {
                var api = "get_all";
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<AlasanPenyesuaianStok>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    oList = response.Results;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public int Save(AlasanPenyesuaianStok obj)
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

        public int Update(AlasanPenyesuaianStok obj)
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

        public int Delete(AlasanPenyesuaianStok obj)
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
