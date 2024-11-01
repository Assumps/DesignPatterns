using PatternProjects.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.Concret
{
    public class NewYorkAccount : Account
    {
        public NewYorkAccount()
        {
            Name = "New York bank";
            Document = "NYPD-435325";
        }
    }
}
