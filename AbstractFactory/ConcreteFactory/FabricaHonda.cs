using PatternProjects.AbstractFactory.AbstractProducts;
using PatternProjects.AbstractFactory.Factory;
using PatternProjects.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.AbstractFactory.ConcreteFactory
{
    internal class FabricaHonda : IMontadora
    {
        public ISedan CriaSedan()
        {
            return new CivicHonda();
        }

        public ISuv CriaSuv()
        {
            return new CrvHonda();
        }
    }
}
