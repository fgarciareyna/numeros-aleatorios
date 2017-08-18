using System.Collections.Generic;

namespace NumerosAleatorios.VariablesAleatorias
{
    public class DistribucionUniforme
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public IGeneradorNumerosAleatorios Generador { get; protected set; }

        public DistribucionUniforme(double a, double b, IGeneradorNumerosAleatorios generador)
        {
            A = a;
            B = b;
            Generador = generador;
        }

        public double Generar()
        {
            var aleatorio = Generador.Generar();

            var variable = A + aleatorio * (B - A);

            return variable;
        }

        public List<double> Generar(int cantidad)
        {
            var variables = new List<double>(cantidad);

            for (int i = 0; i < cantidad; i++)
            {
                variables.Add(Generador.Generar());
            }

            return variables;
        }
    }
}
