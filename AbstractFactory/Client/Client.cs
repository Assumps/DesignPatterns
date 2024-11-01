using PatternProjects.AbstractFactory.AbstractProducts;
using PatternProjects.AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.AbstractFactory.Client
{
    internal class Client
    {
        ISuv suv;
        ISedan sedan;

        public Client(IMontadora montadora)
        {
            suv = montadora.CriaSuv();
            sedan = montadora.CriaSedan();
        }

        public string GetSuvDetalhes()
        {
            return suv.ExibeDetalhes();
        }

        public string GetSedanDetalhes()
        {
            return sedan.ExibeDetalhes();
        }
    }
}
