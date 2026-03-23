using Exercicio2;

Console.WriteLine("======================================");
Console.WriteLine("   SISTEMA DE FORMAS GEOMÉTRICAS");
Console.WriteLine("======================================");

Console.WriteLine("\n========== CÍRCULO ==========");
Console.Write("Digite o Raio do Círculo: ");
double raio = double.Parse(Console.ReadLine());

Circulo circulo = new Circulo(raio);
Console.WriteLine($"\nÁrea do Círculo: {circulo.CalcularArea():F2}");
Console.WriteLine($"Perímetro do Círculo: {circulo.CalcularPerimetro():F2}");

Console.WriteLine("\n========== RETÂNGULO ==========");
Console.Write("Digite a Largura do Retângulo: ");
double largura = double.Parse(Console.ReadLine());

Console.Write("Digite a Altura do Retângulo: ");
double altura = double.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo(largura, altura);
Console.WriteLine($"\nÁrea do Retângulo: {retangulo.CalcularArea():F2}");
Console.WriteLine($"Perímetro do Retângulo: {retangulo.CalcularPerimetro():F2}");

Console.WriteLine("\n========== TRIÂNGULO ==========");
Console.Write("Digite o Lado A do Triângulo: ");
double ladoA = double.Parse(Console.ReadLine());

Console.Write("Digite o Lado B do Triângulo: ");
double ladoB = double.Parse(Console.ReadLine());

Console.Write("Digite o Lado C do Triângulo: ");
double ladoC = double.Parse(Console.ReadLine());

Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
Console.WriteLine($"\nÁrea do Triângulo: {triangulo.CalcularArea():F2}");
Console.WriteLine($"Perímetro do Triângulo: {triangulo.CalcularPerimetro():F2}");

Console.WriteLine("\n======================================");
Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();

