using PatternProjects.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.AbstractFactory.Factory
{
    internal interface IMontadora
    {
        ISedan CriaSedan();
        ISuv CriaSuv();
    }
}
