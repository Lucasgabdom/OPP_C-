Funcionario funcionario1 = new Funcionario("Lucas", "Analista");

Console.WriteLine($"Deseja promover o funcionário {funcionario1.Nome}? (s/n)");
string resposta = Console.ReadLine();

if (resposta == "s")
{

    Console.WriteLine($"O funcionário {funcionario1.Nome} será promovido para: ");
    string novoCargo = Console.ReadLine();

    funcionario1.Promover(novoCargo);

    Console.WriteLine("\n-- Pos promoção --");
    Console.WriteLine("Funcionário: " + funcionario1.Nome);
    Console.WriteLine("Cargo: " + funcionario1.Cargo);
}
else
{
    Console.WriteLine("-- Promoção cancelada --");
}