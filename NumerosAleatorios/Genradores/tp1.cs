using System;
using System.Drawing;
using System.Globalization;
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
        private GestorEstadistico _gestor;
        private const int TamañoMuestra = 20;
        private const int Cifras = 4;
        private const int Decimales = 3;
        private int _ord;

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
            if (FormularioValidoA())
            {
                GenerarNumerosA();
                btn_siguiente.Enabled = true;
                btn_PuntoA.Enabled = false;
            }
        }

        private bool FormularioValidoA()
        {
            if (string.IsNullOrEmpty(txt_semillaA.Text))
            {
                MessageBox.Show(@"Ingrese un valor de semilla");
                txt_semillaA.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_aA.Text))
            {
                MessageBox.Show(@"Ingrese un valor de A");
                txt_aA.Focus();
                return false;
            }
            if (radioButton1.Checked && string.IsNullOrEmpty(txt_cA.Text))
            {
                MessageBox.Show(@"Ingrese un valor de C");
                txt_cA.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_mA.Text))
            {
                MessageBox.Show(@"Ingrese un valor de M");
                txt_mA.Focus();
                return false;
            }

            return true;
        }

        public void GenerarNumerosA()
        {
            dataGridView1.Rows.Clear();
            _ord = 0;

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
                _ord++;
                dataGridView1.Rows.Add(_ord, aleatorio);
            }
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            var aleatorio = _generadorAleatorio.Generar(Cifras);
            _ord++;
            dataGridView1.Rows.Add(_ord, aleatorio);
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
            groupBox3.Enabled = true;
            btn_siguiente.Enabled = false;
            LimpiarDatosA();
            txt_semillaA.Focus();
        }

        ////////////////     Punto B     ////////////////

        private void btn_PuntoB_Click(object sender, EventArgs e)
        {
            if (FormularioValidoB())
            {
                GenerarNumerosB();
            }
        }

        private bool FormularioValidoB()
        {
            if (string.IsNullOrEmpty(txt_Cant_nroB.Text))
            {
                MessageBox.Show(@"Ingrese el tamaño de la muestra");
                txt_Cant_nroB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_IntB.Text))
            {
                MessageBox.Show(@"Ingrese la cantidad de intervalos");
                txt_IntB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_chicierto.Text))
            {
                MessageBox.Show(@"Ingrese un valor de alfa");
                txt_chicierto.Focus();
                return false;
            }

            return true;
        }

        public void GenerarNumerosB()
        {
            dataGridView1.Rows.Clear();
            _ord = 0;

            var tamañoMuestra = int.Parse(txt_Cant_nroB.Text);
            var cantidadIntervalos = int.Parse(txt_IntB.Text);
            var alfa = double.Parse(txt_chicierto.Text);

            var distribucion = new DistribucionUniforme(0, 1);
            _gestor = new GestorEstadistico(distribucion, tamañoMuestra, cantidadIntervalos, alfa);

            foreach (var valor in _gestor.Valores)
            {
                _ord++;
                dataGridView1.Rows.Add(_ord, valor);
            }

            AgregarValoresTabla();
            CargarHistograma();
        }

        ////////////////     Punto C     ////////////////

        private void btn_PuntoC_Click(object sender, EventArgs e)
        {
            if (FormularioValidoC())
            {
                GenerarNumerosC();
            }
        }

        private bool FormularioValidoC()
        {
            if (string.IsNullOrEmpty(txt_cant_nroC.Text))
            {
                MessageBox.Show(@"Ingrese el tamaño de la muestra");
                txt_cant_nroC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_IntC.Text))
            {
                MessageBox.Show(@"Ingrese la cantidad de intervalos");
                txt_IntC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_semillaC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de semilla");
                txt_semillaC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_aC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de A");
                txt_aC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_cC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de C");
                txt_cC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_mC.Text))
            {
                MessageBox.Show(@"Ingrese un valor de M");
                txt_mC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_chicierto.Text))
            {
                MessageBox.Show(@"Ingrese un valor de alfa");
                txt_chicierto.Focus();
                return false;
            }

            return true;
        }

        public void GenerarNumerosC()
        {
            //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
            dataGridView1.Rows.Clear();
            _ord = 0;

            var c = int.Parse(txt_cC.Text);
            var a = int.Parse(txt_aC.Text);
            var m = int.Parse(txt_mC.Text);
            var semilla = double.Parse(txt_semillaC.Text);

            _generadorAleatorio = new CongruencialMixto(semilla, a, c, m);

            var tamañoMuestra = int.Parse(txt_cant_nroC.Text);
            var cantidadIntervalos = int.Parse(txt_IntC.Text);
            var alfa = double.Parse(txt_chicierto.Text);

            var distribucion = new DistribucionUniforme(0, 1, _generadorAleatorio);
            _gestor = new GestorEstadistico(distribucion, tamañoMuestra, cantidadIntervalos, alfa);

            foreach (var valor in _gestor.Valores)
            {
                _ord++;
                dataGridView1.Rows.Add(_ord, valor);
            }

            AgregarValoresTabla();
            CargarHistograma();
        }

        ////////////////     Grafico     ////////////////

        private void btn_graficarB_Click(object sender, EventArgs e)
        {
            /*if (FormularioValidoB())
            {
                dataGridView1.Rows.Clear();
                ord = 0;
                _lista.Clear();
                GenerarNumerosB();
                intervalos = int.Parse(txt_IntB.Text);
                CargarHistograma();
                AgregarValoresTabla();
            }*/
        }

        private void btn_graficarC_Click_1(object sender, EventArgs e)
        {
            /*if (FormularioValidoC())
            {
                dataGridView1.Rows.Clear();
                ord = 0;
                _lista.Clear();
                GenerarNumerosC();
                intervalos = int.Parse(txt_IntC.Text);
                CargarHistograma();
                AgregarValoresTabla();
            }*/
        }

        private void AgregarValoresTabla()
        {
            // Agregar Valores en la Tabla
            dataGridView2.Rows.Clear();

            for (var i = 0; i < _gestor.CantidadIntervalos; i++)
            {
                var subint = $"{decimal.Round((decimal)_gestor.Intervalos[i].Inicio, Decimales)} - " +
                             $"{decimal.Round((decimal)_gestor.Intervalos[i].Fin, Decimales)}";
                var freObs = _gestor.FrecuenciasObservadasAbsolutas[i];
                var freEsp = decimal.Round((decimal)_gestor.FrecuenciasEsperadasAbsolutas[i], Decimales);
                var freObsRel = decimal.Round((decimal)_gestor.FrecuenciasObservadasRelativas[i], Decimales);
                //var freEspRel = decimal.Round((decimal)_gestor.FrecuenciasEsperadasRelativas[i], Decimales);
                var chiCuad = decimal.Round((decimal)_gestor.ValoresChiCuadrado[i], Decimales);

                dataGridView2.Rows.Add(subint, freObs, freEsp, freObsRel, chiCuad);
            }

            lbl_chi_cu.Text = decimal.Round((decimal)_gestor.ValoresChiCuadrado.Sum(), Decimales)
                .ToString(CultureInfo.InvariantCulture);

            lblFrecuenciaEsperada.Text = decimal.Round((decimal) _gestor.TablaChiCuadrado, Decimales)
                .ToString(CultureInfo.InvariantCulture);

            btn_compro.Enabled = true;
        }

        private void CargarHistograma()
        {
            histogramaGenerado.Series.Clear();
            histogramaGenerado.Series.Add("Frecuecias Observadas");
            histogramaGenerado.Series.Add("Frecuecias Esperadas");

            for (var i = 0; i < _gestor.CantidadIntervalos; i++)
            {
                histogramaGenerado.Series[0].Points.Add(_gestor.FrecuenciasObservadasAbsolutas[i]);
                histogramaGenerado.Series[1].Points.Add(
                    (double)decimal.Round((decimal)_gestor.FrecuenciasEsperadasAbsolutas[i], Decimales));
                histogramaGenerado.Series[0].Points[i].AxisLabel = 
                    $"[{decimal.Round((decimal)_gestor.Intervalos[i].Inicio, Decimales)} - " +
                    $"{decimal.Round((decimal)_gestor.Intervalos[i].Fin, Decimales)}]";
                histogramaGenerado.Series[0].IsValueShownAsLabel = true;
                histogramaGenerado.Series[1].IsValueShownAsLabel = true;
            }

            histogramaGenerado.ChartAreas[0].AxisY.Maximum = _gestor.FrecuenciasObservadasAbsolutas.Max();

            histogramaGenerado.Series[0].Color = Color.Blue;
            histogramaGenerado.Series[1].Color = Color.Red;
        }

        private void btn_compro_Click(object sender, EventArgs e)
        {
            var chiObtenido = _gestor.ValoresChiCuadrado.Sum();
            var chiEsperado = _gestor.TablaChiCuadrado;

            if (chiObtenido < chiEsperado)
            {
                MessageBox.Show(@"Se acepta la hipótesis");
            }
            else
            {
                MessageBox.Show(@"Se rechaza la hipótesis");
            }
        }
    }
}