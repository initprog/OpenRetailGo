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

using OpenRetailGo.Model;

namespace OpenRetailGo.Repository.Api
{
    public interface IBeliProdukRepository : IBaseRepository<BeliProduk>
    {
        string GetLastNota();
		BeliProduk GetByID(string id);

        IList<BeliProduk> GetAll(string name);
        IList<BeliProduk> GetAll(int pageNumber, int pageSize, ref int pagesCount);

        /// <summary>
        /// Method untuk mendapatkan informasi pembelian masing-masing supplier
        /// </summary>
        /// <param name="id">supplier id</param>
        /// <param name="nota"></param>
        /// <returns></returns>
        IList<BeliProduk> GetNotaSupplier(string id, string nota);

        /// <summary>
        /// Method untuk mendapatkan informasi pembelian kredit yang lunas/belum masing-masing supplier
        /// </summary>
        /// <param name="id">supplier id</param>
        /// <param name="isLunas"></param>
        /// <returns></returns>
        IList<BeliProduk> GetNotaKreditBySupplier(string id, bool isLunas);

        /// <summary>
        /// Method untuk mendapatkan informasi pembelian kredit yang lunas/belum masing-masing supplier berdasarkan nota
        /// </summary>
        /// <param name="id">supplier id</param>
        /// <param name="nota"></param>
        /// <returns></returns>
        IList<BeliProduk> GetNotaKreditByNota(string id, string nota);

        IList<BeliProduk> GetByName(string name);
        IList<BeliProduk> GetByName(string name, int pageNumber, int pageSize, ref int pagesCount);

        IList<BeliProduk> GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai);
        IList<BeliProduk> GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai, int pageNumber, int pageSize, ref int pagesCount);

        IList<BeliProduk> GetByTanggal(DateTime tanggalMulai, DateTime tanggalSelesai, string name);

        IList<ItemBeliProduk> GetItemBeli(string beliId);
    }
}     
