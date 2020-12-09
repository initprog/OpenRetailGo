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
    public interface IGajiKaryawanController : IBaseApiController<GajiKaryawanDTO>
    {        
        IHttpActionResult GetByID(string id);
        IHttpActionResult GetByName(string name);

        IHttpActionResult GetLastNota();
        IHttpActionResult GetByBulanAndTahun(int bulan, int tahun);
    }

	[RoutePrefix("api/gaji_karyawan")]
    public class GajiKaryawanController : BaseApiController, IGajiKaryawanController
    {
        private IUnitOfWork _unitOfWork;
        private ILog _log;
        private HttpStatusCode _httpStatusCode = HttpStatusCode.BadRequest;
        private IHttpActionResult _response = null;
		
		public GajiKaryawanController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public GajiKaryawanController(IUnitOfWork unitOfWork, ILog log)
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
                var results = new List<GajiKaryawan>();
                var obj = _unitOfWork.GajiKaryawanRepository.GetByID(id);
                
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

        [HttpGet, Route("get_last_nota")]
        public IHttpActionResult GetLastNota()
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            try
            {
                var results = new List<string>();
                var obj = _unitOfWork.GajiKaryawanRepository.GetLastNota();

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
            throw new NotImplementedException();
        }

        [HttpGet, Route("get_by_bulan_and_tahun")]
        public IHttpActionResult GetByBulanAndTahun(int bulan, int tahun)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            try
            {
                var results = _unitOfWork.GajiKaryawanRepository.GetByBulanAndTahun(bulan, tahun);

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
            throw new NotImplementedException();
        }

		[HttpPost, Route("save")]
        public IHttpActionResult Save(GajiKaryawanDTO objDTO)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            if (!objDTO.IsValidate(Request, ref _response))
            {
                return _response;
            }

            try
            {
                var obj = AutoMapper.Mapper.Map<GajiKaryawan>(objDTO);

                var result = _unitOfWork.GajiKaryawanRepository.Save(obj);

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
        public IHttpActionResult Update(GajiKaryawanDTO objDTO)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            if (!objDTO.IsValidate(Request, ref _response))
            {
                return _response;
            }

            try
            {
                var obj = AutoMapper.Mapper.Map<GajiKaryawan>(objDTO);

                var result = _unitOfWork.GajiKaryawanRepository.Update(obj);

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
        public IHttpActionResult Delete(GajiKaryawanDTO objDTO)
        {
            _httpStatusCode = HttpStatusCode.BadRequest;
            _response = Content(_httpStatusCode, new ResponsePackage(_httpStatusCode));

            if (!objDTO.IsValidate(Request, ref _response))
            {
                return _response;
            }

            try
            {
                var obj = AutoMapper.Mapper.Map<GajiKaryawan>(objDTO);

                var result = _unitOfWork.GajiKaryawanRepository.Delete(obj);

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