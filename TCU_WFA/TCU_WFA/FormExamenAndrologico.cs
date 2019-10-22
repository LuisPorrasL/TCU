
//Hecho por Alberto Soto
using System;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormExamenAndrologico : DefaultForm
    {
        private const string QUERY_LLENAR_COMBO_BOX_TORO = "SELECT t.PK_NUMERO_TRAZABLE, t.PK_NUMERO_TRAZABLE FROM [dbo].[TORO] t WHERE t.ACTIVA = 1;";
        
        ///<summary>
        ///Constructor del form.
        ///</summary>
        public FormExamenAndrologico()
        {
            InitializeComponent();
            textBoxObservaciones.AutoSize = false;
            textBoxObservaciones.Size = new System.Drawing.Size(230, 50);
        
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_TORO, comboBoxNumToro);
            comboBoxNumToro.Text = "";
        }

        ///<summary>
        ///Método que se llama al clickear el boton de agregar.
        ///</summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        ///<returns> void </returns>
        private void botonAgregar_click(object sender, EventArgs e)
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

        ///<summary>
        ///Agrega el examen mediante el procedimiento almacenado.
        ///</summary>
        ///<param name="datosNuevoExamen"></param>
        ///<returns> booleano dependiendo de si fue exitosa o no la insercion del examen. </returns>
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

        ///<summary>
        ///Extrae los valores ingresados por el usuario.
        ///</summary>
        ///<returns> objeto de tipo ExamenModel inicializado con toda la informacion que ingreso el usuario. </returns>
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


        ///<summary>
        ///Una vez que se inserta un examen exitosamente limpia los campos de texto.
        ///</summary>
        ///<returns> void </returns>
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


        ///<summary>
        ///Muestra una pantalla con los valores de referencia
        ///</summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        ///<returns> void </returns>
        private void botonValoresReferencia_click(object sender, EventArgs e)
        {
            FormValoresReferenciaExamen form = new FormValoresReferenciaExamen();
            form.Tag = this;
            form.Show(this);
        }
    }
}
