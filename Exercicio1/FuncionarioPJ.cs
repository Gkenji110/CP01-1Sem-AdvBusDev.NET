using System;
namespace Exercicio1
{
	class FuncionarioPJ : Funcionario
	{
		public double TaxaImposto { get; set; }

		public FuncionarioPJ(string nome, double salarioBase, double taxaImposto) : base(nome,salarioBase)
		{
			this.TaxaImposto = taxaImposto;
		}

        public override double CalcularSalario()
        {
            return SalarioBase - (SalarioBase * TaxaImposto / 100);
        }
    }
}

