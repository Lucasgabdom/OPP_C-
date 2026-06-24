Retangulo retangulo = new Retangulo();

Console.WriteLine("Por favor, informe a altura do retângulo: ");
retangulo.Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Por favor, informe a largura do retângulo: ");
retangulo.Largura = double.Parse(Console.ReadLine());

double area = retangulo.CalcularArea();

Console.WriteLine($"A área do retângulo é: {area}");