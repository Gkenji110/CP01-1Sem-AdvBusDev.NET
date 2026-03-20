using System;
namespace Exercicio1
{
	class FuncionarioCLT : Funcionario
	{
		public double DescontoINSS { get; set; }

		public FuncionarioCLT(string nome, double salarioBase, double descontoINSS) : base(nome, salarioBase)
		{
			this.DescontoINSS = descontoINSS;
		}

        public override double CalcularSalario()
        {
			return SalarioBase - (SalarioBase * DescontoINSS / 100);
        }
    }
}

