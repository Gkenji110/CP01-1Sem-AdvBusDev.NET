using Exercicio1;

Console.WriteLine("======================================");
Console.WriteLine("   SISTEMA DE CADASTRO DE FUNCIONÁRIOS");
Console.WriteLine("======================================");

Console.Write("\nQuantos funcionários CLT deseja cadastrar? ");
int qtdCLT = int.Parse(Console.ReadLine());

Console.Write("Quantos funcionários PJ deseja cadastrar? ");
int qtdPJ = int.Parse(Console.ReadLine());

if (qtdCLT > 0)
{
    Console.WriteLine("\n========== FUNCIONÁRIOS CLT ==========");
    for (int i = 1; i <= qtdCLT; i++)
    {
        Console.WriteLine($"\n--- Funcionário CLT {i} ---");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Salário Base: R$ ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Desconto INSS (%): ");
        double descontoINSS = double.Parse(Console.ReadLine());

        FuncionarioCLT clt = new FuncionarioCLT(nome, salarioBase, descontoINSS);
        Console.WriteLine($"\nSalário Líquido de {clt.Nome}: R$ {clt.CalcularSalario():F2}");
    }
}

if (qtdPJ > 0)
{
    Console.WriteLine("\n========== FUNCIONÁRIOS PJ ==========");
    for (int i = 1; i <= qtdPJ; i++)
    {
        Console.WriteLine($"\n--- Funcionário PJ {i} ---");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Salário Base: R$ ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Taxa de Imposto (%): ");
        double taxaImposto = double.Parse(Console.ReadLine());

        FuncionarioPJ pj = new FuncionarioPJ(nome, salarioBase, taxaImposto);
        Console.WriteLine($"\nSalário Líquido de {pj.Nome}: R$ {pj.CalcularSalario():F2}");
    }
}

Console.WriteLine("\n======================================");
Console.WriteLine("Cadastro finalizado! Pressione qualquer tecla para sair.");
Console.ReadKey();