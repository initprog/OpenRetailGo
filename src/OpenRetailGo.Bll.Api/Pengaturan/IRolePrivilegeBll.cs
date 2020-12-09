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
    public interface IRolePrivilegeBll : IBaseBll<RolePrivilege>
    {
        RolePrivilege GetByID(string id);    
        IList<RolePrivilege> GetByName(string name);
        IList<RolePrivilege> GetByRole(string roleId);
        IList<RolePrivilege> GetByRoleAndMenu(string roleId, string menuId);
    }
}     