using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NumerosAleatorios;
using NumerosAleatorios.NumerosAleatorios;
using NumerosAleatorios.VariablesAleatorias;

namespace Genradores
{
    public partial class Tp1 : Form
    {
        private IGeneradorNumerosAleatorios _generadorAleatorio;
        private const int TamañoMuestra = 20;
        private const int Cifras = 4;
        int ord;
        bool error = false;
        int intervalos;
        subIntervalos[] sub_intervalos; //vector de subintervalos
        readonly List<double> _lista = new List<double>();

        public Tp1()
        {
            InitializeComponent();
            btn_siguiente.Enabled = false;
            btn_compro.Enabled = false;
            txt_semillaA.Focus();
        }

        ////////////////     Punto A     ////////////////

        private void btn_PuntoA_Click(object sender, EventArgs e)
        {
            ValidarTextoA();
            if (error == false)
            {
                GenerarNumerosA();
                btn_siguiente.Enabled = true;
                btn_PuntoA.Enabled = false;
            }
        }

        private void ValidarTextoA()
        {
            error = false;
            if (string.IsNullOrEmpty(txt_semillaA.Text))
            {
                MessageBox.Show(@"Ingrese un valor de semilla");
                error = true;
                txt_semillaA.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_aA.Text))
            {
                MessageBox.Show(@"Ingrese un valor de A");
                error = true;
                txt_aA.Focus();
                return;
            }
            if (radioButton1.Checked)
            {
                if (string.IsNullOrEmpty(txt_cA.Text))
                {
                    MessageBox.Show(@"Ingrese un valor de C");
                    error = true;
                    txt_cA.Focus();
                    return;
                }
            }
            if (string.IsNullOrEmpty(txt_mA.Text))
            {
                MessageBox.Show(@"Ingrese un valor de M");
                error = true;
                txt_mA.Focus();
            }
        }

        public void GenerarNumerosA()
        {
            _lista.Clear();
            dataGridView1.Rows.Clear();
            ord = 0;

            var a = int.Parse(txt_aA.Text);
            var m = int.Parse(txt_mA.Text);
            var semilla = double.Parse(txt_semillaA.Text);

            //Congruencial Multiplicativo : Xn = (A * Xn-1 ) Mod M
            if (radioButton2.Checked)
            {
                _generadorAleatorio = new CongruencialMultiplicativo(semilla, a, m);
            }

            //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
            else if (radioButton1.Checked)
            {
                var c = int.Parse(txt_cA.Text);
                _generadorAleatorio = new CongruencialMixto(semilla, a, c, m);
            }

            for (var i = 0; i < TamañoMuestra; i++)
            {
                var aleatorio = _generadorAleatorio.Generar(Cifras);
                ord++;
                dataGridView1.Rows.Add(ord, aleatorio);
                _lista.Add(aleatorio);
            }
        }

        public double TruncateFunction(double number, int digits) //0,65412 4
        {
            double stepper = (double) (Math.Pow(10.0, (double) digits)); //10000
            int temp = (int) (stepper * number); //6541
            return (double) temp / stepper; //6541.2 / 10000
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            var aleatorio = _generadorAleatorio.Generar(Cifras);
            ord++;
            dataGridView1.Rows.Add(ord, aleatorio);
            _lista.Add(aleatorio);
        }

        private void LimpiarDatosA()
        {
            txt_semillaA.Text = "";
            txt_aA.Text = "";
            txt_cA.Text = "";
            txt_mA.Text = "";
            btn_siguiente.Enabled = false;
            btn_PuntoA.Enabled = true;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_cA.Enabled = true;
            groupBox3.Enabled = true;
            btn_siguiente.Enabled = true;
            LimpiarDatosA();
            txt_semillaA.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_cA.Enabled = false;
            groupBox3.Enabled = false;
            btn_siguiente.Enabled = false;
            LimpiarDatosA();
            txt_semillaA.Focus();
        }

        ////////////////     Punto B     ////////////////

        private void btn_PuntoB_Click(object sender, EventArgs e)
        {
            ValidarTextoB();
            if (error == false)
            {
                GenerarPuntoB();
            }
        }

        private void ValidarTextoB()
        {
            error = false;
            if (string.IsNullOrEmpty(txt_Cant_nroB.Text))
            {
                MessageBox.Show(@"Ingrese el tamaño de la muestra");
                error = true;
                txt_Cant_nroB.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_IntB.Text))
            {
                MessageBox.Show(@"Ingrese la cantidad de intervalos");
                error = true;
                txt_IntB.Focus();
            }
        }

        public void GenerarPuntoB()
        {
            _lista.Clear();
            dataGridView1.Rows.Clear();
            ord = 0;

            var tamañoMuestra = int.Parse(txt_Cant_nroB.Text);
            var cantidadIntervalos = int.Parse(txt_IntB.Text);
            var alfa = double.Parse(txt_chicierto.Text);

            var distribucion = new DistribucionUniforme(0, 1);
            var generador = new GestorEstadistico(distribucion, tamañoMuestra, cantidadIntervalos, alfa);

            foreach (var valor in generador.Valores)
            {
                ord++;
                dataGridView1.Rows.Add(ord, valor);
                _lista.Add(valor);
            }
        }

        ////////////////     Punto C     ////////////////

        private void btn_PuntoC_Click(object sender, EventArgs e)
        {
            ValidarTextoC();
            if (error == false)
            {
                GenerarNumerosC();
            }
        }

        private void ValidarTextoC()
        {
            error = false;
            if (string.IsNullOrEmpty(txt_cant_nroC.Text))
            {
                MessageBox.Show(@"Ingrese el tamaño de la muestra");
                error = true;
                txt_cant_nroC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_IntC.Text))
            {
                MessageBox.Show(@"Ingrese la cantidad de intervalos");
                error = true;
                txt_IntC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_semillaC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de semilla");
                error = true;
                txt_semillaC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_aC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de A");
                error = true;
                txt_aC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_cC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de C");
                error = true;
                txt_cC.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_mC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de M");
                error = true;
                txt_mC.Focus();
            }
        }

        public void GenerarNumerosC()
        {
            //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
            _lista.Clear();
            dataGridView1.Rows.Clear();
            ord = 0;

            var c = int.Parse(txt_cC.Text);
            var a = int.Parse(txt_aC.Text);
            var m = int.Parse(txt_mC.Text);
            var semilla = double.Parse(txt_semillaC.Text);

            _generadorAleatorio = new CongruencialMixto(semilla, a, c, m);

            var tamañoMuestra = int.Parse(txt_cant_nroC.Text);
            var cantidadIntervalos = int.Parse(txt_IntC.Text);
            var alfa = double.Parse(txt_chicierto.Text);

            var distribucion = new DistribucionUniforme(0, 1, _generadorAleatorio);
            var generador = new GestorEstadistico(distribucion, tamañoMuestra, cantidadIntervalos, alfa);

            foreach (var valor in generador.Valores)
            {
                ord++;
                dataGridView1.Rows.Add(ord, valor);
                _lista.Add(valor);
            }
        }

        ////////////////     Grafico     ////////////////

        private void btn_graficarB_Click(object sender, EventArgs e)
        {
            ValidarTextoB();
            if (error == false)
            {
                dataGridView1.Rows.Clear();
                ord = 0;
                _lista.Clear();
                GenerarPuntoB();
                intervalos = int.Parse(txt_IntB.Text);
                CargarHistograma();
                AgregarValoresTabla();
            }
        }

        private void btn_graficarC_Click_1(object sender, EventArgs e)
        {
            ValidarTextoC();
            if (error == false)
            {
                dataGridView1.Rows.Clear();
                ord = 0;
                _lista.Clear();
                GenerarNumerosC();
                intervalos = int.Parse(txt_IntC.Text);
                CargarHistograma();
                AgregarValoresTabla();
            }
        }

        private void CargarHistograma()
        {
            //creo los subintervalos del histograma
            sub_intervalos = new subIntervalos[intervalos];

            for (int i = 0; i < intervalos; i++)
            {
                if (i == 0)
                    sub_intervalos[i] = new subIntervalos(0, ((float) 1 / intervalos) * (i + 1));
                else
                {
                    sub_intervalos[i] = new subIntervalos(sub_intervalos[i - 1].LimiteSuperior,
                        ((float) 1 / intervalos) * (i + 1));
                }
            }

            //ahora recorremos la lista para calcular las frecuencias.
            for (int i = 0; i < _lista.Count; i++)
            {
                for (int j = 0; j < sub_intervalos.Length; j++)
                {
                    if (_lista[i] >= sub_intervalos[j].LimiteInferior && _lista[i] <= sub_intervalos[j].LimiteSuperior)
                    {
                        sub_intervalos[j].CantidadObservaciones++;
                    }
                }
            }

            //limpiamos el chart y preparamos el nuevo histograma
            List<int> listaEnteros = new List<int>();
                //lista para acumular las cantidades de cada intervalo y luego poder obtener el MAX()
            histogramaGenerado.Series.Clear();
            histogramaGenerado.Series.Add("Frecuecias Observadas");


            for (int i = 0; i < intervalos; i++)
            {
                listaEnteros.Add(sub_intervalos[i].CantidadObservaciones);
                histogramaGenerado.Series[0].Points.Add(sub_intervalos[i].CantidadObservaciones);
                histogramaGenerado.Series[0].Points[i].AxisLabel = "[" + sub_intervalos[i].LimiteInferior + " - " +
                                                                   sub_intervalos[i].LimiteSuperior + "]";
                histogramaGenerado.Series[0].IsValueShownAsLabel = true;
            }
            double cantidadObservaciones = double.Parse(_lista.Count.ToString());
            histogramaGenerado.ChartAreas[0].AxisY.Maximum = listaEnteros.Max();
            double freEsperada = (double) cantidadObservaciones / (double) intervalos;
            lblFrecuenciaEsperada.Text = freEsperada.ToString();
            histogramaGenerado.Series["Frecuecias Observadas"].Color = Color.Fuchsia;
        }

        void AgregarValoresTabla()
        {
            // Agregar Valores en la Tabla
            double sumaChi = 0;
            dataGridView2.Rows.Clear();
            for (int i = 0; i < sub_intervalos.Length; i++)
            {
                string subint = sub_intervalos[i].LimiteInferior + " - " + sub_intervalos[i].LimiteSuperior;
                double freEsp = _lista.Count / intervalos;
                var FORelativa = (double) sub_intervalos[i].CantidadObservaciones / (double) _lista.Count;
                var feRelativa = 1 / (double) intervalos;
                var ChiCuadrado = Math.Pow(feRelativa - FORelativa, 2) / feRelativa;
                sumaChi = sumaChi + ChiCuadrado;

                dataGridView2.Rows.Add(subint, sub_intervalos[i].CantidadObservaciones, freEsp, FORelativa, ChiCuadrado);
            }

            lbl_chi_cu.Text = Convert.ToString(sumaChi);
            btn_compro.Enabled = true;
        }

        /// VER Falta
        private void btn_compro_Click(object sender, EventArgs e)
        {
            /*if (chi < double.Parse(txt_chicierto.Text))
            {
                MessageBox.Show(@"Se acepta la hipótesis");
            }
            else
            {
                MessageBox.Show(@"Se rechaza la hipótesis");
            }*/
        }
    }
}