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
    public class PenyesuaianStokWebAPIRepository : IPenyesuaianStokRepository
    {
        private string _apiUrl = string.Empty;
        private ILog _log;
		
        public PenyesuaianStokWebAPIRepository(string baseUrl, ILog log)
        {
            this._apiUrl = baseUrl + "api/penyesuaian_stok/";
            this._log = log;
        }

        public PenyesuaianStok GetByID(string id)
        {
            PenyesuaianStok obj = null;

			try
            {
                var api = string.Format("get_by_id?id={0}", id);
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<PenyesuaianStok>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    obj = response.Results[0];
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return obj;
        }

        public IList<PenyesuaianStok> GetByName(string name)
        {
            IList<PenyesuaianStok> oList = new List<PenyesuaianStok>();

			try
            {
                var api = string.Format("get_by_name?name={0}", name);
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<PenyesuaianStok>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    oList = response.Results;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public IList<PenyesuaianStok> GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai)
        {
            IList<PenyesuaianStok> oList = new List<PenyesuaianStok>();

            try
            {
                var api = string.Format("get_by_tanggal?tanggal_mulai={0}&tanggal_selesai={1}", tanggalMulai, tanggalSelesai);
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<PenyesuaianStok>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    oList = response.Results;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public IList<PenyesuaianStok> GetAll()
        {
            IList<PenyesuaianStok> oList = new List<PenyesuaianStok>();

			try
            {
                var api = "get_all";
                var response = RestSharpHelper<OpenRetailWebApiGetResponse<PenyesuaianStok>>.GetRequest(_apiUrl, api).Data;

                if (response.Results.Count > 0)
                    oList = response.Results;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return oList;
        }

        public int Save(PenyesuaianStok obj)
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

        public int Update(PenyesuaianStok obj)
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

        public int Delete(PenyesuaianStok obj)
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
