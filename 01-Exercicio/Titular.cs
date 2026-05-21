class Titular
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
}

class Conta
{
    public Titular titular { get; set;  }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string InformacoesConta => $"Conta n° {this.NumeroConta}, Agência {this.Agencia}, Titular {this.titular.Nome}, - Saldo: {this.Saldo}";
}