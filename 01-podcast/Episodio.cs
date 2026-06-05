class Episodio
{
    private List<string> convidados = new ();

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get;}
    public string Resumo => $"Informações: {Ordem}. {Titulo} ({Duracao} minutos) - Convidados: {string.Join(", ", convidados)}";

    public Episodio(int ordem, string titulo, int duracao) { 
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }

    
}