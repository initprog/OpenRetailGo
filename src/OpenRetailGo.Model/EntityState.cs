﻿/**
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

namespace OpenRetailGo.Model
{
    public enum EntityState
    {
        /// <summary>
        /// Status objek tidak ada perubahan
        /// </summary>
        Unchanged = 1,

        /// <summary>
        /// Objek yang baru ditambahkan
        /// </summary>
        Added = 2,

        /// <summary>
        /// Objek yang diupdate
        /// </summary>
        Modified = 3,

        /// <summary>
        /// Objek yang siap dihapus
        /// </summary>
        Deleted = 4
    }
}
