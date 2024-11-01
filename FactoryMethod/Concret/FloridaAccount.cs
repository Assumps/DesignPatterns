using PatternProjects.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.Concret
{
    public class FloridaAccount : Account
    {
        public FloridaAccount()
        {
            Name = "Florida Bank";
            Document = "EUA-90EY";
        }
    }
}
