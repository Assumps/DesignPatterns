namespace PatternProjects.SimpleFactory.Abstract
{
    abstract class Conta
    {
        public Guid Id { get; set; }

        public string TipoConta { get; set; }

        public abstract void criar();


    }
}
