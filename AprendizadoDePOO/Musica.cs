using System.Diagnostics;

class Musica
{

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }


    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";


    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }else { Console.WriteLine("Adquira o plano Plus+"); }
    }
}


 