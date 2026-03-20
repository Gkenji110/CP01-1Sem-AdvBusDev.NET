using System;
namespace Exercicio2
{
	class Circulo : FormaGeometrica
	{
		public double Raio { get; set; }

		public Circulo(double raio)
		{
			this.Raio = raio;
		}

        public override double CalcularArea()
        {
			return Math.PI * Raio * Raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}

