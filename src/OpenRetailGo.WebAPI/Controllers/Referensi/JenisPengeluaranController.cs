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
using System.Net;
using System.Web.Http;
using OpenRetailGo.Model;
using OpenRetailGo.Repository.Api;
using OpenRetailGo.WebAPI.Models;
using OpenRetailGo.WebAPI.Models.DTO;
using OpenRetailGo.WebAPI.Controllers.Helper;

namespace OpenRetailGo.WebAPI.Controllers
{
    public interface IJenisPengeluaranController : IBaseApiController<JenisPengeluaranDTO>
    {
        IHttpActionResult GetByID(string id);
        IHttpActionResult GetByName(string name);
    }

    [RoutePrefix("api/jenis_pengeluaran")]
    public class JenisPengeluaranController : BaseApiController, IJenisPengeluaranController
    {
        private IUnitOfWork _unitOfWork;
        private ILog _log;
        private HttpStatusCode _httpStatusCode = HttpStatusCode.BadRequest;
        private IHttpActionResult _response = null;

        public JenisPengeluaranController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public JenisPengeluaranController(IUnitOfWork unitOfWork, ILog log)
        {
            this._unitOfWork = unitOfWork;
            this._log = log;
        }

        [HttpGet, Route("get_by_id")]
        public IHttpActionResult GetByID(string id)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            try
            {
                var results = new List<JenisPengeluaran>();
                var obj = _unitOfWork.JenisPengeluaranRepository.GetByID(id);

                if (obj != null)
                    results.Add(obj);

                _httpStatusCode = HttpStatusCode.OK;
                var output = GenerateOutput(_httpStatusCode, results);

                _response = Content(_httpStatusCode, output);
            }
            catch (Exception ex)
            {
                if (_log != null)
                    _log.Error("Error:", ex);
            }

            return _response;
        }

        [HttpGet, Route("get_by_name")]
        public IHttpActionResult GetByName(string name)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            try
            {
                var results = _unitOfWork.JenisPengeluaranRepository.GetByName(name.NullToString());

                _httpStatusCode = HttpStatusCode.OK;
                var output = GenerateOutput(_httpStatusCode, results);

                _response = Content(_httpStatusCode, output);
            }
            catch (Exception ex)
            {
                if (_log != null)
                    _log.Error("Error:", ex);
            }

            return _response;
        }

        [HttpGet, Route("get_all")]
        public IHttpActionResult GetAll()
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            try
            {
                var results = _unitOfWork.JenisPengeluaranRepository.GetAll();

                _httpStatusCode = HttpStatusCode.OK;
                var output = GenerateOutput(_httpStatusCode, results);

                _response = Content(_httpStatusCode, output);
            }
            catch (Exception ex)
            {
                if (_log != null)
                    _log.Error("Error:", ex);
            }

            return _response;
        }

        [HttpPost, Route("save")]
        public IHttpActionResult Save(JenisPengeluaranDTO objDTO)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            if (!objDTO.IsValidate(Request, ref _response))
            {
                return _response;
            }

            try
            {
                var obj = AutoMapper.Mapper.Map<JenisPengeluaran>(objDTO);

                var result = _unitOfWork.JenisPengeluaranRepository.Save(obj);

                _httpStatusCode = HttpStatusCode.OK;
                var output = GenerateOutput(_httpStatusCode, result);

                _response = Content(_httpStatusCode, output);
            }
            catch (Exception ex)
            {
                if (_log != null)
                    _log.Error("Error:", ex);
            }

            return _response;
        }

        [HttpPost, Route("update")]
        public IHttpActionResult Update(JenisPengeluaranDTO objDTO)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            if (!objDTO.IsValidate(Request, ref _response))
            {
                return _response;
            }

            try
            {
                var obj = AutoMapper.Mapper.Map<JenisPengeluaran>(objDTO);

                var result = _unitOfWork.JenisPengeluaranRepository.Update(obj);

                _httpStatusCode = HttpStatusCode.OK;
                var output = GenerateOutput(_httpStatusCode, result);

                _response = Content(_httpStatusCode, output);
            }
            catch (Exception ex)
            {
                if (_log != null)
                    _log.Error("Error:", ex);
            }

            return _response;
        }

        [HttpPost, Route("delete")]
        public IHttpActionResult Delete(JenisPengeluaranDTO objDTO)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            if (!objDTO.IsValidate(Request, ref _response))
            {
                return _response;
            }

            try
            {
                var obj = AutoMapper.Mapper.Map<JenisPengeluaran>(objDTO);

                var result = _unitOfWork.JenisPengeluaranRepository.Delete(obj);

                _httpStatusCode = HttpStatusCode.OK;
                var output = GenerateOutput(_httpStatusCode, result);

                _response = Content(_httpStatusCode, output);
            }
            catch (Exception ex)
            {
                if (_log != null)
                    _log.Error("Error:", ex);
            }

            return _response;
        }
    }
}
