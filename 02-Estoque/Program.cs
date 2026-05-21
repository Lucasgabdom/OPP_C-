using System;
using System.Collections.Generic; // Necessário para usar List<>

// Mudei o nome do namespace para não dar conflito com o nome da sua classe EstoqueDeProdutos
namespace SistemaDeEstoque
{
    // 1. A classe principal que VAI RODAR o programa
    class Program
    {
        // O método Main é o ponto de partida obrigatório!
        static void Main(string[] args)
        {
            Console.WriteLine("--- Iniciando o Sistema ---");

            // Instanciando o seu estoque
            EstoqueDeProdutos meuEstoque = new EstoqueDeProdutos();

            // Criando e configurando um produto
            Produto p1 = new Produto();
            p1.Nome = "Notebook";
            p1.Marca = "Dell";
            p1.Preco = 4500.00;
            p1.Estoque = 10;

            // Usando os métodos que você criou
            meuEstoque.AdicionarProduto(p1);

            Console.WriteLine("\n--- Exibindo o Estoque ---");
            meuEstoque.ExibirProduto();
        }
    }

    // 2. Suas classes separadas, fora da classe Program
    class Produto
    {
        private double preco;
        private int estoque;
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Preco
        {
            get => preco;
            set
            {
                if (value > 0)
                    preco = value;
                else preco = 10;
            }
        }

        public int Estoque
        {
            get => estoque;
            set
            {
                if (value > 0)
                    estoque = value;
                else estoque = 0;
            }
        }

        public string Descricao => $"{this.Nome} - {this.Marca} - {this.Preco} - Quantidade: {this.Estoque}";
    }

    class EstoqueDeProdutos
    {
        private List<Produto> Produtos { get; set; } = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto); // Removi os parênteses duplos que estavam aqui
            Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque.");
        }

        public void ExibirProduto()
        {
            if (Produtos.Count == 0)
            {
                Console.WriteLine("O estoque está vazio.");
                return;
            }
            else
            {
                Console.WriteLine("Lista de produtos no estoque:");
                foreach (var produto in Produtos)
                {
                    Console.WriteLine(produto.Descricao);
                }
            }
        }
    }
}