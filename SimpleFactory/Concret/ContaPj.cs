using PatternProjects.SimpleFactory.Abstract;

namespace PatternProjects.SimpleFactory.Concret
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
