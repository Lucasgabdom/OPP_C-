ContaBancaria conta1 = new ContaBancaria("12345", 1000.0);
Console.WriteLine();

Console.WriteLine("Deseja fazer um depósito? (s/n)");

string resposta = Console.ReadLine();

if (resposta == "s")
{
    Console.WriteLine("Qual o valor do depósito?");
    double valor = double.Parse(Console.ReadLine());

    conta1.Depositar(valor);


    Console.WriteLine($"Conta: {conta1.NumeroConta}");
    Console.WriteLine($"Saldo atual: {conta1.Saldo}");
} else
{
    Console.WriteLine($"Conta: {conta1.NumeroConta}");
    Console.WriteLine($"Saldo: {conta1.Saldo}");
}
