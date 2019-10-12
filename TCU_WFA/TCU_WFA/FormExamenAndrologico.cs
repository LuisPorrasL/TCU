
//Hecho por Alberto Soto

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormExamenAndrologico : DefaultForm
    {
        private const string QUERY_LLENAR_COMBO_BOX_TORO = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t;";


        //Constructor
        public FormExamenAndrologico()
        {
            InitializeComponent();

            textBoxObservaciones.AutoSize = false;
            textBoxObservaciones.Size = new System.Drawing.Size(230, 50);

        
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_TORO, comboBoxNumToro);
            comboBoxNumToro.Text = "";
        }

        private void FormExamenAndrologico_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //Método que se llama al tocar el boton de agregar
        private void button2_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ExamenModel nuevoExamen = ObtenerDatosEntradaUsuario();

                bool resultado = AgregarNuevoExamen(nuevoExamen);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarEntradaUsuario();     
                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR_ENTRADA_USUARIO, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Agrega el examen mediante la el procedimiento almacenado
        private bool AgregarNuevoExamen(ExamenModel datosNuevoExamen)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcInsertarExamen(datosNuevoExamen);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Extrae los valores ingresados por el usuario
        private ExamenModel ObtenerDatosEntradaUsuario()
        {
            ExamenModel resultado = new ExamenModel();

            resultado.pkNumeroTrazable = Int32.Parse(comboBoxNumToro.Text);
            resultado.pkFecha = dateTimePickerExamen.Value;
            resultado.condicionCorporal = textBoxCondC.Text;

            if (checkBoxLibido.Checked)
            {
                resultado.libido = true;
            } else
            {
                resultado.libido = false;
            }

            if (checkBoxCM.Checked)
            {
                resultado.capacidadMonta = true;
            } else
            {
                resultado.capacidadMonta = false;
            }
         
            resultado.descansoSexual = Decimal.ToInt32(numericUpDownDS.Value);

            if (checkBoxPrepucio.Checked)
            {
                resultado.prepucio = true;
            } else
            {
                resultado.prepucio = false;
            }

            if (checkBoxPene.Checked)
            {
                resultado.pene = true;
            } else
            {
                resultado.pene = false;
            }

            if (checkBoxTesticulos.Checked)
            {
                resultado.testiculos = true;
            }
            else
            {
                resultado.testiculos = false;
            }

            if (checkBoxEpi.Checked)
            {
                resultado.epididimos = true;
            }
            else
            {
                resultado.epididimos = false;
            }
         
            if (checkBoxGlandulasB.Checked)
            {
                resultado.glandulasB = true;
            }
            else
            {
                resultado.glandulasB = false;
            }
   
            if (checkBoxProstata.Checked)
            {
                resultado.prostata = true;
            }
            else
            {
                resultado.prostata = false;
            }


            if (checkBoxVesiculasS.Checked)
            {
                resultado.vesiculasSeminales = true;
            }  else
            {
                resultado.vesiculasSeminales = false;
            }

            if (checkBoxAmpulas.Checked)
            {
                resultado.ampulas = true;
            }
            else
            {
                resultado.ampulas = false;
            }

            resultado.circunferenciaEscrotal = Decimal.ToInt32(numericUpDownCircEscrotal.Value);
            resultado.volumenEyaculado = Decimal.ToInt32(numericUpDownVolumenEya.Value);
            resultado.concentracion = Decimal.ToInt32(numericUpDownConcentracion.Value);
            resultado.motilidadMasal = Decimal.ToInt32(numericUpDownMotilidadM.Value);           
            resultado.motidilidadProgresiva = Decimal.ToInt32(numericUpDownMotilidadP.Value);
            resultado.morfologiaNormal = Decimal.ToInt32(numericUpDownMorfologiaN.Value);
            resultado.anormalidadesPrimarias = textBoxAnormalidadesP.Text;
            resultado.dannosAcrosomales = textBoxDannos.Text;
            resultado.anormalidadesSecundarias = textBoxAnormalidadesS.Text;
            resultado.totalAnormalidades = Decimal.ToInt32(numericUpDownTotalAnormalidades.Value);
            resultado.anomaliaFrecuente = textBoxAnomaliaMasF.Text;
            resultado.leucocitos = Decimal.ToInt32(numericUpDownLeucocitos.Value);
            resultado.celulasEpit = Decimal.ToInt32(numericUpDownCelulasE.Value);
            resultado.observaciones = textBoxObservaciones.Text;

            if (checkBoxSatisfactorio.Checked)
            {
                resultado.satisfactorio = true;
            }
            else if(checkBoxNoSatisfactorio.Checked)
            {
                resultado.satisfactorio = false;
            } else
            {
                resultado.satisfactorio = false;
            }

            resultado.veterinario = textBoxVeterinario.Text;

            if (checkBoxPalpacion.Checked)
            {
                resultado.palpacion = true;
            }
            else
            {
                resultado.palpacion = false;
            }

            if (checkBoxEcogrfia.Checked)
            {
                resultado.ecografia = true;
            }
            else
            {
                resultado.ecografia = false;
            }

            if (checkBoxVaginaArt.Checked)
            {
                resultado.vaginaArt = true;
            }
            else
            {
                resultado.vaginaArt = false;
            }

            if (checkBoxElectroEya.Checked)
            {
                resultado.electroEya = true;
            }
            else
            {
                resultado.electroEya = false;
            }

            if (checkBoxProtusion.Checked)
            {
                resultado.protusion = true;
            }
            else
            {
                resultado.protusion = false;
            }

            return resultado;
        }


        //Verifica que los campos de porcentaje esten dentro del rango de 0 a 100
        private bool RevisarEntradaUsuario()
        {
                if(numericUpDownMotilidadM.Value<0 | numericUpDownMotilidadM.Value > 100)
                {
                    return false;
                }

                if (numericUpDownMotilidadP.Value < 0 | numericUpDownMotilidadP.Value > 100)
                {
                    return false;
                }

                if (numericUpDownMorfologiaN.Value < 0 | numericUpDownMorfologiaN.Value > 100)
                {
                    return false;
                }

                if (numericUpDownTotalAnormalidades.Value < 0 | numericUpDownTotalAnormalidades.Value > 100)
                {
                    return false;
                }

                return true;
        }

        //Una vez que se inserta un examen exitosamente, limpia los campos de texto
        private void LimpiarEntradaUsuario()
        {           
            dateTimePickerExamen.Value = DateTime.Now;
            textBoxCondC.Clear();
            textBoxDannos.Clear();
            textBoxAnormalidadesP.Clear();
            textBoxAnormalidadesS.Clear();
            textBoxAnomaliaMasF.Clear();
            textBoxVeterinario.Clear();
            textBoxObservaciones.Clear();          
        }


        //Muestra una pantalla con los valores de referencia
        private void button1_Click(object sender, EventArgs e)
        {
            FormValoresReferenciaExamen form = new FormValoresReferenciaExamen();
            form.Tag = this;
            form.Show(this);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
