using System.Collections.Generic;
using NumerosAleatorios.VariablesAleatorias;

namespace NumerosAleatorios
{
    public class GestorEstadistico
    {
        public int Muestra { get; protected set; }
        public int CantidadIntervalos { get; protected set; }
        public IDistribucion Distribucion { get; protected set; }
        public List<double> Valores { get; protected set; }
    }
}
