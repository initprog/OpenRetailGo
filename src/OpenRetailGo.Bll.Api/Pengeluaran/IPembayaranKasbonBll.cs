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

using System.Collections.Generic;

using OpenRetailGo.Model;

namespace OpenRetailGo.Bll.Api
{
    public interface IPembayaranKasbonBll : IBaseBll<PembayaranKasbon>
    {
        string GetLastNota();
        PembayaranKasbon GetByID(string id);    
        IList<PembayaranKasbon> GetByName(string name);
        IList<PembayaranKasbon> GetByKasbonId(string kasbonId);
        IList<PembayaranKasbon> GetByGajiKaryawan(string gajiKaryawanId);

		int Save(PembayaranKasbon obj, ref ValidationError validationError);
		int Update(PembayaranKasbon obj, ref ValidationError validationError);
    }
}     