class Podcast
{
    private List<Episodio> episodios = new();

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;


    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome}, aprensentado por {Host}. Números de episódios - {episodios.Count}\n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\n\nEste podcast possui {episodios.Count} episódios.");
    }
}