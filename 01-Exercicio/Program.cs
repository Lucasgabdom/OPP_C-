Titular t = new();
Conta c = new();

t.Nome = "Lucas Gabriel";
t.Cpf = "123.456.789-00";
t.Endereco = "Rua das Flores, 123";

c.titular = t;
c.Agencia = 1234;
c.NumeroConta = 56789;
c.Saldo = 1000.00;
c.Limite = 500.00;

Console.WriteLine("Informações da Conta");
Console.WriteLine($"Nome: {c.titular.Nome}");
Console.WriteLine($"CPF: {c.titular.Cpf}");
Console.WriteLine($"Endereço: {c.titular.Endereco}");

