using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProjects.SimpleFactory
{
    internal class ContaSimpleFactory
    {
        public static Conta CriarConta(string TipoConta)
        {
            Conta conta;

            switch (TipoConta)
            {
                case "F":
                    conta = new ContaPf();
                    break;
                case "J":
                    conta = new ContaPj();  
                    break;
                default:
                    throw new ApplicationException($"A Conta {TipoConta} Nao foi criada");
            }
            return conta;
        }
    }
}
