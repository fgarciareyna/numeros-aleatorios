using System;
using Meta.Numerics.Statistics.Distributions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumerosAleatoriosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Distribution d = new ExponentialDistribution(13);

            var prueba = d.LeftProbability(3);

            var algo = 2;
        }
    }
}
