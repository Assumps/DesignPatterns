using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.SimpleFactory
{
    abstract class Conta
    {
        public Guid Id { get; set; }

        public string TipoConta { get; set; }

        public abstract void criar();


    }
}
