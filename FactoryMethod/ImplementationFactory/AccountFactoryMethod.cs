using PatternProjects.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.ImplementationFactory
{
    public abstract class AccountFactoryMethod
    {
        public Account BuildAccountByState(string state)
        {
            Account account;
            account = CreateAccount(state);
            return account;
        }

        public abstract Account CreateAccount(string state);
    }
}
