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

using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenRetailGo.Bll.Api;

namespace OpenRetailGo.Bll.Service.UnitTest
{
    [TestClass]
    public class DatabaseVersionBllTest
    {
        private ILog _log;
        private IDatabaseVersionBll _bll;

        [TestInitialize]
        public void Init()
        {
            _log = LogManager.GetLogger(typeof(DatabaseVersionBllTest));
            _bll = new DatabaseVersionBll(_log);
        }

        [TestCleanup]
        public void CleanUp()
        {
            _bll = null;
        }

        [TestMethod]
        public void GetTest()
        {
            var obj = _bll.Get();

            Assert.IsNotNull(obj);
            Assert.AreEqual(1, obj.version_number);
        }

        [TestMethod]
        public void UpdateTest()
        {
            var result = _bll.UpdateVersion();

            Assert.IsTrue(result != 0);

            var updatedObj = _bll.Get();
            Assert.IsNotNull(updatedObj);
            Assert.AreEqual(2, updatedObj.version_number);
        }
    }
}
