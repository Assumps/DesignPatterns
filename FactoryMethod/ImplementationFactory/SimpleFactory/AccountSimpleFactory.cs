using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.FactoryMethod.ImplementationFactory.SimpleFactory
{
    public class AccountSimpleFactory
    {
        public static AccountFactoryMethod CreateCountry(string country)
        {
            AccountFactoryMethod accountCountry;
            switch (country)
            {
                case "Brazil":
                    accountCountry = new BrazilAccountFactory();
                    break;
                case "United States":
                    accountCountry = new UsaAccountFactory();
                    break;
                default:
                    throw new ApplicationException($"The country {country} to create account wasn't identificate");
            }

            return accountCountry;
        }
    }
}
