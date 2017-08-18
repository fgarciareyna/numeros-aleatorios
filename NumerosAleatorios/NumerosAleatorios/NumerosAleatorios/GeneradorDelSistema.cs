using System;

namespace NumerosAleatorios
{
     public class GeneradorDelSistema : IGeneradorNumerosAleatorios
    {


        public double Generar()
        {
            var aleatorio = new Random().NextDouble();

            return aleatorio;
        }

        public int Generar(int cifras)
        {
            var aleatorio = Generar();

            return (int)(aleatorio * (10 ^ cifras));
        }
    }
}
