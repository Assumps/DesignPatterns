using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.SimpleFactory
{
    internal class ContaPj : Conta
    {
        public ContaPj()
        {
            Id = Guid.NewGuid();
            TipoConta = "PJ";
        }
        public override void criar()
        {
            Console.WriteLine($"Conta de Id: {Id} do tipo {TipoConta} criada com sucesso");
        }
    }
}
