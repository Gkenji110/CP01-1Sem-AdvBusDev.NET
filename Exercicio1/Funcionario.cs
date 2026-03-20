using System;
namespace Exercicio1
{
	class Funcionario
	{
		public string Nome { get; set; }
        public double SalarioBase { get; set; }

		public Funcionario(string nome, double salarioBase)
		{
			this.Nome = nome;
			this.SalarioBase = salarioBase;
		}

		public virtual double CalcularSalario()
		{
			return SalarioBase;
		}
    }
}

