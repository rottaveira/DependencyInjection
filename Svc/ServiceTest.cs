using DaoInterface;
using SvcInterface;
using System; 

namespace Svc
{
    public class ServiceTest : IServiceTest
    {
        private readonly IDaoTest _daoTest;
        public ServiceTest(IDaoTest daoTest)
        {
            _daoTest = daoTest;
        }

        public string TestMethod()
        {
            return _daoTest.TestDao();
        }
    }
}
