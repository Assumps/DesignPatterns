using PatternProjects.FactoryMethod.Abstract;
using PatternProjects.FactoryMethod.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.ImplementationFactory
{
    internal class UsaAccountFactory : AccountFactoryMethod
    {
        public override Account CreateAccount(string country)
        {
            var factory = UsaAccountFactories[country];
            return factory();

        }

        public static Dictionary<string, Func<Account>> UsaAccountFactories = new Dictionary<string, Func<Account>>()
        {
            {"Florida", () => new FloridaAccount() },
            {"New York", () => new NewYorkAccount() }

        };
    }
}
