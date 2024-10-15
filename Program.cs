using PatternProjects.SimpleFactory;
// Simple Factory
Conta contaPf1 = ContaSimpleFactory.CriarConta("F");
Conta contaPj1 = ContaSimpleFactory.CriarConta("J");

contaPf1.criar();
contaPj1.criar();

