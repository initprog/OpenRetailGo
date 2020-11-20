using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenRetailGo.Repository.Service;
using OpenRetailGo.Model;
using OpenRetailGo.Repository.Api;
using log4net;

namespace OpenRetailGo.Bll.Service.UnitTest
{
    [TestClass]
    public class GenericRepoTest
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod1Async()
        {
            IDapperContext dc = new DapperContext();
            ILog log = LogManager.GetLogger(typeof(GenericRepoTest));
            var golonganRepository = new GolonganRepository(dc, log);
            Console.WriteLine(" Save into table users ");
            var guid = Guid.NewGuid();
            await golonganRepository.GetAll();
            {
                FirstName = "Test2",
                Id = guid,
                LastName = "LastName2"
            });
        }
    }
}
