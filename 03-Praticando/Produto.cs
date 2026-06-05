class Produto
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    public void exibirInformacoes()
    {
        Console.WriteLine($"Dados do produto:\nNome: {Nome}\nDescrição: {Descricao}\nPreço: {Preco}\nEstoque: {Estoque}\n");
    }

            
}