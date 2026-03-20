using System;
namespace Exercicio2
{
	class Retangulo : FormaGeometrica
	{
		public double Largura { get; set; }
		public double Altura { get; set; }

		public Retangulo(double largura, double altura)
		{
			this.Largura = largura;
			this.Altura = altura;
		}

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }


    }
}

