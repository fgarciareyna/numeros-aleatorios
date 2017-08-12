namespace NumerosAleatorios
{
    public class CongruencialMultiplicativo
    {
        public double Generar()
        {
            var aleatorio = (A * Semilla) % M;

            Semilla = aleatorio;

            return aleatorio / M;
        }

        public int Generar(int cifras)
        {
            var aleatorio = Generar();

            return (int)(aleatorio * (10 ^ cifras));
        }

        public double Semilla { get; protected set; }
        public double A { get; protected set; }
        public double M { get; protected set; }

        public int Intervalos { get; protected set; }
        public double TamañoIntervalo { get; protected set; }
    }
}
