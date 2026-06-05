class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public Conta(Titular titular, int agencia, int numeroConta, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroConta;
        Saldo = 0;  
        Limite = limite;
    }
}