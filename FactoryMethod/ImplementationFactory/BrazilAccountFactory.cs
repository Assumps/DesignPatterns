using PatternProjects.FactoryMethod.Abstract;
using PatternProjects.FactoryMethod.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.ImplementationFactory
{
    public class BrazilAccountFactory : AccountFactoryMethod
    {
        public override Account CreateAccount(string state)
        {
            if(state == "SaoPaulo")
            {
                return new SaoPauloAccount();
            }

            return null;
        }
    }
}
