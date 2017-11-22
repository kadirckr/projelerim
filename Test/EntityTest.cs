using Microsoft.VisualStudio.TestTools.UnitTesting;
using proje3.Data;
using proje3.Data.Repositories;
using proje3.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class EntityTest
    {
        private denemeEntities _db;

        private IUnitOfWork _uow;

        private IRepository<User> _userRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _db = new denemeEntities();
            _uow = new UnitOfWork(_db);
            _userRepository = new Repository<User>(_db);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _db = null;
            _uow.Dispose();
        }

        [TestMethod]
        public void GetUser()
        {
            User user = _userRepository.GetById(1);

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void UpdateUser()
        {
            User user = _userRepository.GetById(1);

            user.Ad = "Mehmet";

            _userRepository.Update(user);
            int process = _uow.SaveChanges();

            Assert.AreNotEqual(-1, process);
        }


    }
}
