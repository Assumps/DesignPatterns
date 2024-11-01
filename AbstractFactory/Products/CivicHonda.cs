using PatternProjects.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.AbstractFactory.Products
{
    internal class CivicHonda : ISedan
    {
        public string ExibeDetalhes()
        {
            return "Honda Civic Hybrid 2.0 2024";
        }
    }
}
