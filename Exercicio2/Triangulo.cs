using Exercicio2;

class Triangulo : FormaGeometrica
{
    public double LadoA { get; set; }
    public double LadoB { get; set; }
    public double LadoC { get; set; }

    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        this.LadoA = ladoA;
        this.LadoB = ladoB;
        this.LadoC = ladoC;
    }

    public override double CalcularArea()
    {
        double s = (LadoA + LadoB + LadoC) / 2;
        return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
    }

    public override double CalcularPerimetro()
    {
        return LadoA + LadoB + LadoC;
    }
}
