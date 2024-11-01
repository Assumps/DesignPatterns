using PatternProjects.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.AbstractFactory.Products
{
    internal class CretaHyundai : ISuv
    {
        public string ExibeDetalhes()
        {
            return "Hyundai Creta 1.6 Turbo TGDI 2024";
        }
    }
}
