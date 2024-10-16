using PatternProjects.SimpleFactory.Abstract;

namespace PatternProjects.SimpleFactory.Concret
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
