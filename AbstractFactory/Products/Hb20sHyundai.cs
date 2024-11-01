using PatternProjects.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.AbstractFactory.Products
{
    internal class Hb20sHyundai : ISedan
    {
        public string ExibeDetalhes()
        {
            return "HB20S 1.0 turbo TGDI 2024";
        }
    }
}
