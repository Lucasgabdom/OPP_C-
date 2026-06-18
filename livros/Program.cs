Livro meuLivro = new Livro();
meuLivro.Titulo = "O Senhor dos Anéis";
meuLivro.Autor = "J.R.R. Tolkien";

Console.WriteLine("Livro: " + meuLivro.Titulo);
Console.WriteLine("Autor: " + meuLivro.Autor);

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
}


