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
    internal class FabricaHyundai : IMontadora
    {
        public ISedan CriaSedan()
        {
            return new Hb20sHyundai();
        }

        public ISuv CriaSuv()
        {
            return new CretaHyundai();
        }
    }
}
