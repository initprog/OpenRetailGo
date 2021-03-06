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
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;

namespace OpenRetailGo.Bll.Service.UnitTest
{
    [TestClass]
    public class HeaderNotaBllTest
    {
        private IHeaderNotaBll _bll;

        [TestInitialize]
        public void Init()
        {
            _bll = new HeaderNotaBll();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _bll = null;
        }

        [TestMethod]
        public void GetAllTest()
        {
            var index = 2;
            var oList = _bll.GetAll();
            var obj = oList[index];
                 
            Assert.IsNotNull(obj);
            Assert.AreEqual("567abd02-cd14-1c97-262b-805038b7d6a8", obj.header_nota_id);
            Assert.AreEqual("Piyungan, Sitimulyo, Bantul", obj.keterangan);                                
            Assert.AreEqual(3, obj.order_number);
            Assert.IsTrue(obj.is_active);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var listOfHeaderNota = _bll.GetAll();
            Assert.AreEqual(5, listOfHeaderNota.Count);

            var headerNota = listOfHeaderNota[1];
            headerNota.keterangan = "Jl. Wonosari Km 11";

            var validationError = new ValidationError();

            var result = _bll.Update(headerNota, ref validationError);
            Console.WriteLine("Error : " + validationError.Message);

            Assert.IsTrue(result != 0);
        }
    }
}     
