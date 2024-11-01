using PatternProjects.AbstractFactory.AbstractProducts;
using PatternProjects.AbstractFactory.ConcreteFactory;
using PatternProjects.AbstractFactory.Factory;
using PatternProjects.FactoryMethod.ImplementationFactory;
using PatternProjects.FactoryMethod.ImplementationFactory.SimpleFactory;
using PatternProjects.SimpleFactory.Abstract;
using PatternProjects.SimpleFactory.ImplementationFactory;

// Simple Factory
Conta contaPf1 = ContaSimpleFactory.CriarConta("F");
Conta contaPj1 = ContaSimpleFactory.CriarConta("J");

contaPf1.criar();
contaPj1.criar();



// Factory Method
AccountFactoryMethod accountFactoryMethodBrazil = AccountSimpleFactory.CreateCountry("Brazil");
AccountFactoryMethod accountFactoryMethodUsa = AccountSimpleFactory.CreateCountry("United States");

var SaoPauloAccount = accountFactoryMethodBrazil.CreateAccount("SaoPaulo");
var floridaAccount = accountFactoryMethodUsa.CreateAccount("Florida");
var newYorkAccount = accountFactoryMethodUsa.CreateAccount("New York");

var infoParanaAccount = SaoPauloAccount.InfoAccount();
var infoFloridaAccount = floridaAccount.InfoAccount();
var infonewYorkAccount = newYorkAccount.InfoAccount();

Console.WriteLine(infoParanaAccount);
Console.WriteLine(infoFloridaAccount);
Console.WriteLine(infonewYorkAccount);

//Abstract Factory

IMontadora honda = new FabricaHonda();
IMontadora hyundai = new FabricaHyundai();

ISedan civic1 = honda.CriaSedan();
ISuv CRV1 = honda.CriaSuv();

ISedan hb201 = hyundai.CriaSedan();
ISuv creta1 = hyundai.CriaSuv();

Console.WriteLine(civic1.ExibeDetalhes());
Console.WriteLine(CRV1.ExibeDetalhes());
Console.WriteLine(hb201.ExibeDetalhes());
Console.WriteLine(creta1.ExibeDetalhes());

