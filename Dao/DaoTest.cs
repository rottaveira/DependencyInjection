using DaoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoTest : IDaoTest
    {

        public string TestDao()
        {
            return "Teste chamada OK";
        }
    }
}
