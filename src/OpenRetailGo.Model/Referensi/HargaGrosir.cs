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

using Dapper.Contrib.Extensions;

namespace OpenRetailGo.Model
{
    [Table("m_harga_grosir")]
    public class HargaGrosir
    {
        [ExplicitKey]
        public string harga_grosir_id { get; set; }

		public string produk_id { get; set; }

		[Write(false)]
        public Produk Produk { get; set; }

		public int harga_ke { get; set; }
		public double harga_grosir { get; set; }
		public double jumlah_minimal { get; set; }
		public double diskon { get; set; }
	}    
}
