using PatternProjects.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.AbstractFactory.Products
{
    internal class CrvHonda : ISuv
    {
        public string ExibeDetalhes()
        {
            return "Honda CR-V 2.0 Turbo 2024";
        }
    }
}
