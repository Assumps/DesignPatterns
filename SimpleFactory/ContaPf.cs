using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.SimpleFactory
{
    internal class ContaPf : Conta
    {
        public ContaPf()
        {
            Id = Guid.NewGuid();
            TipoConta = "PF";
        }
        public override void criar()
        {
            Console.WriteLine($"Conta de Id: {Id} do tipo {TipoConta} criada com sucesso");
        }
    }
}
