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

using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;

namespace OpenRetailGo.Bll.Service.UnitTest
{
    [TestClass]
    public class ImportExportDataSupplierBllTest
    {
        private ILog _log;
        private IImportExportDataBll<Supplier> _bll;
        private const string WorksheetName = "supplier";

        [TestInitialize]
        public void Init()
        {
            var fileName = @"D:\Project Non IC\Aplikasi Open Retail\src\OpenRetailGo\bin\Debug\File Import Excel\Master Data\data_supplier.xlsx";

            _log = LogManager.GetLogger(typeof(ImportExportDataSupplierBllTest));
            _bll = new ImportExportDataSupplierBll(fileName, _log);
        }

        [TestCleanup]
        public void CleanUp()
        {
            _bll = null;
        }

        [TestMethod]
        public void IsOpenedTest()
        {
            var result = _bll.IsOpened();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidFormatTest()
        {
            var result = _bll.IsValidFormat(WorksheetName);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ImportTest()
        {
            var rowCount = 0;
            var result = _bll.Import(WorksheetName, ref rowCount);

            Assert.IsTrue(result);
            Assert.AreEqual(5, rowCount);
        }
    }
}
