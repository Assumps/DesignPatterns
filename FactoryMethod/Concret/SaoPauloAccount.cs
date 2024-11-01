using PatternProjects.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.Concret
{
    public class SaoPauloAccount : Account
    {
        public SaoPauloAccount()
        {
            Name = "Banco de São Paulo";
            Document = "Brasilian-1234";
        }
    }
}
