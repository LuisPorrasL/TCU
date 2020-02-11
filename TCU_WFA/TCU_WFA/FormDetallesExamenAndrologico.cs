using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCU_WFA.Models;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormDetallesExamenAndrologico : DefaultForm
    {

        //Campos
        private int numeroTrazableToro;
        private DateTime fechaExamenAndrologico;
        private ExamenModel examenSeleccionado;
        private bool editando;
        private FormDetallesToro formAnterior;
        //public const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = TCU_DB; Integrated Security = True; Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
     

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fechaExamen"></param>
        /// <param name="idToro"></param>
        public FormDetallesExamenAndrologico(DateTime fechaExamen, int idToro, FormDetallesToro form)
        {

            formAnterior = form;
            numeroTrazableToro = idToro;
            fechaExamenAndrologico = fechaExamen;
            editando = false;
            examenSeleccionado = new ExamenModel();
            InitializeComponent();
        }


        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDetallesExamenAntropologico_Load(object sender, EventArgs e)
        {
            getExamen();
            LlenarInformcionExamen();
        }

        ///<summary>
        ///Consulta la base y extrae la informacion del examen seleccionado
        ///</summary>
        ///<returns> void </returns>
        private void getExamen()
        {
           
             string query = "SELECT e.CONDICION_CORPORAL, e.LIBIDO, e.CAPACIDAD_DE_MONTA, e.DESCANSO_SEXUAL, e.PREPUCIO, e.PENE, e.TESTICULOS, e.EPIDIDIMOS, e.GLANDULAS_BULBOURETRALES, e.PROSTATA, e.VESICULAS_SEMINALES, e.AMPULAS, e.CIRCUNFERENCIA_ESCROTAL, e.VOLUMEN_EYACULADO, e.CONCENTRACION, e.MOTILIDAD_MASAL, e.MOTILIDAD_PROGRESIVA_RAPIDA, e.MORFOLOGIA_NORMAL, e.ANORMALIDADES_PRIMARIAS, e.DANNOS_ACROSOMALES, e.ANORMALIDADES_SECUNDARIAS, e.TOTAL_ANORMALIDADES, e.ANOMALIA_MAS_FRECUENTE, e.LEUCOCITOS, e.CEDULAS_EPITELEALES, e.OBSERVACIONES, e.SATISFACTORIO, e.VETERINARIO, e.Palpacion, e.Ecografia, e.VaginaArt, e.ElectroEya, e.Protusion FROM dbo.[EXAMEN_ANTROPOLOGICO] e WHERE e.PK_FK_NUMERO_TRAZABLE_TORO = " + numeroTrazableToro + "AND e.PK_FECHA = '" + fechaExamenAndrologico.ToString("yyyy-MM-dd HH:mm:ss.fff") + "';";
         
            var conn = new SqlConnection(Utilities.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter(query, conn);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            examenSeleccionado.pkNumeroTrazable = numeroTrazableToro;
            examenSeleccionado.pkFecha = fechaExamenAndrologico;
            examenSeleccionado.condicionCorporal = ds.Tables[0].Rows[0][0].ToString();
            examenSeleccionado.libido = Convert.ToBoolean(ds.Tables[0].Rows[0][1].ToString());
            examenSeleccionado.capacidadMonta = Convert.ToBoolean(ds.Tables[0].Rows[0][2].ToString());
            examenSeleccionado.descansoSexual = Convert.ToInt32(ds.Tables[0].Rows[0][3]);
            examenSeleccionado.prepucio = Convert.ToBoolean(ds.Tables[0].Rows[0][4].ToString());
            examenSeleccionado.pene = Convert.ToBoolean(ds.Tables[0].Rows[0][5].ToString());
            examenSeleccionado.testiculos = Convert.ToBoolean(ds.Tables[0].Rows[0][6].ToString());
            examenSeleccionado.epididimos = Convert.ToBoolean(ds.Tables[0].Rows[0][7].ToString());
            examenSeleccionado.glandulasB = Convert.ToBoolean(ds.Tables[0].Rows[0][8].ToString());
            examenSeleccionado.prostata = Convert.ToBoolean(ds.Tables[0].Rows[0][9].ToString());
            examenSeleccionado.vesiculasSeminales = Convert.ToBoolean(ds.Tables[0].Rows[0][10].ToString());
            examenSeleccionado.ampulas = Convert.ToBoolean(ds.Tables[0].Rows[0][11].ToString());
            examenSeleccionado.circunferenciaEscrotal = Convert.ToInt32(ds.Tables[0].Rows[0][12]);
            examenSeleccionado.volumenEyaculado = Convert.ToInt32(ds.Tables[0].Rows[0][13]);
            examenSeleccionado.concentracion = Convert.ToInt32(ds.Tables[0].Rows[0][14]);
            examenSeleccionado.motilidadMasal = Convert.ToInt32(ds.Tables[0].Rows[0][15]);
            examenSeleccionado.motidilidadProgresiva = Convert.ToInt32(ds.Tables[0].Rows[0][16]);
            examenSeleccionado.morfologiaNormal = Convert.ToInt32(ds.Tables[0].Rows[0][17]);
            examenSeleccionado.anormalidadesPrimarias = ds.Tables[0].Rows[0][18].ToString();
            examenSeleccionado.dannosAcrosomales = ds.Tables[0].Rows[0][19].ToString();
            examenSeleccionado.anormalidadesSecundarias = ds.Tables[0].Rows[0][20].ToString();
            examenSeleccionado.totalAnormalidades = Convert.ToInt32(ds.Tables[0].Rows[0][21]);
            examenSeleccionado.anomaliaFrecuente = ds.Tables[0].Rows[0][22].ToString();
            examenSeleccionado.leucocitos = Convert.ToInt32(ds.Tables[0].Rows[0][23]);
            examenSeleccionado.celulasEpit = Convert.ToInt32(ds.Tables[0].Rows[0][24]); ;
            examenSeleccionado.observaciones = ds.Tables[0].Rows[0][25].ToString();
            examenSeleccionado.satisfactorio = Convert.ToBoolean(ds.Tables[0].Rows[0][26].ToString());
            examenSeleccionado.veterinario = ds.Tables[0].Rows[0][27].ToString();
            examenSeleccionado.palpacion = Convert.ToBoolean(ds.Tables[0].Rows[0][28].ToString());
            examenSeleccionado.ecografia = Convert.ToBoolean(ds.Tables[0].Rows[0][29].ToString());
            examenSeleccionado.vaginaArt = Convert.ToBoolean(ds.Tables[0].Rows[0][30].ToString());
            examenSeleccionado.electroEya = Convert.ToBoolean(ds.Tables[0].Rows[0][31].ToString());
            examenSeleccionado.protusion = Convert.ToBoolean(ds.Tables[0].Rows[0][32].ToString());
        }

        ///<summary>
        ///Carga la informacion del examen en los campos del interfaz
        ///</summary>
        ///<returns> void </returns>
        private void LlenarInformcionExamen()
        {
            textBoxNumeroTrazableToroDetalles.Text = examenSeleccionado.pkNumeroTrazable.ToString();
            textBoxNumeroTrazableToroDetalles.Enabled = false;

            dateTimePickerExamenDetalles.Value = examenSeleccionado.pkFecha;
            dateTimePickerExamenDetalles.Enabled = false;

            textBoxCondCDetalles.Text = examenSeleccionado.condicionCorporal;
            textBoxCondCDetalles.Enabled = false;


            checkBoxLibidoDetalles.Enabled = false;//1
            if (examenSeleccionado.libido == true)
            {
                checkBoxLibidoDetalles.Checked = true;
            } else
            {
                checkBoxLibidoDetalles.Checked = false;
            }

            checkBoxCMDetalles.Enabled = false;//2
            if (examenSeleccionado.capacidadMonta == true)
            {
                checkBoxCMDetalles.Checked = true;
            } else
            {
                checkBoxCMDetalles.Checked = false;

            }

            checkBoxPrepucioDetalles.Enabled = false;//3
            if (examenSeleccionado.prepucio == true)
            {
                checkBoxPrepucioDetalles.Checked = true;
            } else
            {
                checkBoxPrepucioDetalles.Checked = false;
            }

            checkBoxPeneDetalles.Enabled = false;//4
            if (examenSeleccionado.pene == true)
            {
                checkBoxPeneDetalles.Checked = true;
            } else
            {
                checkBoxPeneDetalles.Checked = false;
            }

            checkBoxTesticulosDetalles.Enabled = false;//5
            if (examenSeleccionado.testiculos == true)
            {
                checkBoxTesticulosDetalles.Checked = true;
            } else
            {
                checkBoxTesticulosDetalles.Checked = false;
            }

            checkBoxEpiDetalles.Enabled = false;//6
            if (examenSeleccionado.epididimos == true)
            {
                checkBoxEpiDetalles.Checked = true;
            } else
            {
                checkBoxEpiDetalles.Checked = false;
            }

            checkBoxGlandulasBDetalles.Enabled = false;//7
            if (examenSeleccionado.glandulasB == true)
            {
                checkBoxGlandulasBDetalles.Checked = true;
            } else
            {
                checkBoxGlandulasBDetalles.Checked = false;
            }

            checkBoxProstataDetalles.Enabled = false;//8
            if (examenSeleccionado.prostata == true)
            {
                checkBoxProstataDetalles.Checked = true;
            } else
            {
                checkBoxProstataDetalles.Checked = false;
            }

            checkBoxVesiculasSDetalles.Enabled = false;//9
            if (examenSeleccionado.vesiculasSeminales == true)
            {
                checkBoxVesiculasSDetalles.Checked = true;
            } else
            {
                checkBoxVesiculasSDetalles.Checked = false;
            }

            checkBoxAmpulasDetalles.Enabled = false;//10
            if (examenSeleccionado.ampulas == true)
            {
                checkBoxAmpulasDetalles.Checked = true;
            } else
            {
                checkBoxAmpulasDetalles.Checked = false;

            }

            numericUpDownDSDetalles.Value = examenSeleccionado.descansoSexual;
            numericUpDownDSDetalles.Enabled = false;

            numericUpDownCircEscrotalDetalles.Value = (int)examenSeleccionado.circunferenciaEscrotal;
            numericUpDownCircEscrotalDetalles.Enabled = false;

            numericUpDownVolumenEyaDetalles.Value = (int)examenSeleccionado.volumenEyaculado;
            numericUpDownVolumenEyaDetalles.Enabled = false;

            numericUpDownConcentracionDetalles.Value = (int)examenSeleccionado.concentracion;
            numericUpDownConcentracionDetalles.Enabled = false;

            numericUpDownMotilidadMDetalles.Value = examenSeleccionado.motilidadMasal;
            numericUpDownMotilidadMDetalles.Enabled = false;

            numericUpDownMotilidadPDetalles.Value = examenSeleccionado.motidilidadProgresiva;
            numericUpDownMotilidadPDetalles.Enabled = false;

            numericUpDownMorfologiaNDetalles.Value = examenSeleccionado.morfologiaNormal;
            numericUpDownMorfologiaNDetalles.Enabled = false;

            textBoxDannosDetalles.Text = examenSeleccionado.dannosAcrosomales;
            textBoxDannosDetalles.Enabled = false;

            textBoxAnormalidadesPDetalles.Text = examenSeleccionado.anormalidadesPrimarias;
            textBoxAnormalidadesPDetalles.Enabled = false;

            textBoxAnormalidadesSDetalles.Text = examenSeleccionado.anormalidadesSecundarias;
            textBoxAnormalidadesSDetalles.Enabled = false;

            numericUpDownTotalAnormalidadesDetalles.Value = examenSeleccionado.totalAnormalidades;
            numericUpDownTotalAnormalidadesDetalles.Enabled = false;

            textBoxAnomaliaMasFDetalles.Text = examenSeleccionado.anomaliaFrecuente;
            textBoxAnomaliaMasFDetalles.Enabled = false;

            numericUpDownLeucocitosDetalles.Value = examenSeleccionado.leucocitos;
            numericUpDownLeucocitosDetalles.Enabled = false;

            numericUpDownCelulasEDetalles.Value = examenSeleccionado.celulasEpit;
            numericUpDownCelulasEDetalles.Enabled = false;

            checkBoxPalpacionDetalles.Enabled = false;
            if (examenSeleccionado.palpacion == true)
            {
                checkBoxPalpacionDetalles.Checked = true;
            } else
            {
                checkBoxPalpacionDetalles.Checked = false;
            }

            checkBoxEcogrfiaDetalles.Enabled = false;//10
            if (examenSeleccionado.ecografia == true)
            {
                checkBoxEcogrfiaDetalles.Checked = true;
            }
            else
            {
                checkBoxEcogrfiaDetalles.Checked = false;
            }

            checkBoxVaginaArtDetalles.Enabled = false;//10
            if (examenSeleccionado.vaginaArt == true)
            {
                checkBoxVaginaArtDetalles.Checked = true;
            } else
            {
                checkBoxVaginaArtDetalles.Checked = false;
            }

            checkBoxElectroEyaDetalles.Enabled = false;//10
            if (examenSeleccionado.electroEya == true)
            {
                checkBoxElectroEyaDetalles.Checked = true;
            } else
            {
                checkBoxElectroEyaDetalles.Checked = false;
            }

            checkBoxProtusionDetalles.Enabled = false;//10
            if (examenSeleccionado.protusion == true)
            {
                checkBoxProtusionDetalles.Checked = true;
            } else
            {
                checkBoxProtusionDetalles.Checked = false;
            }

            checkBoxSatisfactorioDetalles.Enabled = false;
            checkBoxNoSatisfactorioDetalles.Enabled = false;

            if (examenSeleccionado.satisfactorio == true)
            {
                checkBoxSatisfactorioDetalles.Checked = true;
                checkBoxNoSatisfactorioDetalles.Checked = false;
            } else
            {
                checkBoxSatisfactorioDetalles.Checked = false;
                checkBoxNoSatisfactorioDetalles.Checked = true;
            }

            textBoxVeterinarioDetalles.Text = examenSeleccionado.veterinario;
            textBoxVeterinarioDetalles.Enabled = false;

            textBoxObservacionesDetalles.Text = examenSeleccionado.observaciones;
            textBoxObservacionesDetalles.Enabled = false;

            buttonGuardarCambiosDetalles.Enabled = false;
        }

        ///<summary>
        ///Metodo que se llama al hacer click en el boton de eliminar
        ///</summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        ///<returns> void </returns>
        private void buttonEliminarDetalles_Click(object sender, EventArgs e)
        {
        
            bool resultado = eliminarExamen(fechaExamenAndrologico, numeroTrazableToro);
            if (resultado)
            {
                Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                formAnterior.LlenarDataGridViews();
                formAnterior.Show();
            }
            else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

        
        }

        ///<summary>
        ///Elimina un examen andrologico de la base
        ///</summary>
        ///<param name="fecha"></param>
        ///<param name="id"></param>
        ///<returns> booleano dependiendo de si fue o no exitosa la eliminacion </returns>
        private bool eliminarExamen(DateTime fecha, int id)
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcEliminarExamen(fecha, id);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        ///<summary>
        ///Metodo que se llama al hacer click en el boton de editar, habilita los campos que estan bloqueados
        ///</summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        ///<returns> void </returns>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (editando == false)
            {
                buttonEditar.Text = "Cancelar"; 
                editando = true;
                buttonGuardarCambiosDetalles.Enabled = true;
                dateTimePickerExamenDetalles.Enabled = true;
                textBoxCondCDetalles.Enabled = true;
                checkBoxLibidoDetalles.Enabled = true;
                checkBoxCMDetalles.Enabled = true;
                checkBoxPrepucioDetalles.Enabled = true;
                checkBoxPeneDetalles.Enabled = true;
                checkBoxTesticulosDetalles.Enabled = true;
                checkBoxEpiDetalles.Enabled = true;
                checkBoxGlandulasBDetalles.Enabled = true;
                checkBoxProstataDetalles.Enabled = true;
                checkBoxVesiculasSDetalles.Enabled = true;
                checkBoxAmpulasDetalles.Enabled = true;
                numericUpDownDSDetalles.Enabled = true;
                numericUpDownCircEscrotalDetalles.Enabled = true;
                numericUpDownVolumenEyaDetalles.Enabled = true;
                numericUpDownConcentracionDetalles.Enabled = true;
                numericUpDownMotilidadMDetalles.Enabled = true;
                numericUpDownMotilidadPDetalles.Enabled = true;
                numericUpDownMorfologiaNDetalles.Enabled = true;
                textBoxDannosDetalles.Enabled = true;
                textBoxAnormalidadesPDetalles.Enabled = true;
                textBoxAnormalidadesSDetalles.Enabled = true;
                numericUpDownTotalAnormalidadesDetalles.Enabled = true;
                textBoxAnomaliaMasFDetalles.Enabled = true;
                numericUpDownLeucocitosDetalles.Enabled = true;
                numericUpDownCelulasEDetalles.Enabled = true;
                checkBoxPalpacionDetalles.Enabled = true;
                checkBoxEcogrfiaDetalles.Enabled = true;
                checkBoxVaginaArtDetalles.Enabled = true;
                checkBoxElectroEyaDetalles.Enabled = true;
                checkBoxProtusionDetalles.Enabled = true;
                checkBoxSatisfactorioDetalles.Enabled = true;
                checkBoxNoSatisfactorioDetalles.Enabled = true;
                textBoxVeterinarioDetalles.Enabled = true;
                textBoxObservacionesDetalles.Enabled = true;

            } else {
                buttonEditar.Text = "Editar";
                editando = false;
                LlenarInformcionExamen();
                buttonGuardarCambiosDetalles.Enabled = false;
                dateTimePickerExamenDetalles.Enabled = false;
                textBoxCondCDetalles.Enabled = false;
                checkBoxLibidoDetalles.Enabled = false;
                checkBoxCMDetalles.Enabled = false;
                checkBoxPrepucioDetalles.Enabled = false;
                checkBoxPeneDetalles.Enabled = false;
                checkBoxTesticulosDetalles.Enabled = false;
                checkBoxEpiDetalles.Enabled = false;
                checkBoxGlandulasBDetalles.Enabled = false;
                checkBoxProstataDetalles.Enabled = false;
                checkBoxVesiculasSDetalles.Enabled = false;
                checkBoxAmpulasDetalles.Enabled = false;
                numericUpDownDSDetalles.Enabled = false;
                numericUpDownCircEscrotalDetalles.Enabled = false;
                numericUpDownVolumenEyaDetalles.Enabled = false;
                numericUpDownConcentracionDetalles.Enabled = false;
                numericUpDownMotilidadMDetalles.Enabled = false;
                numericUpDownMotilidadPDetalles.Enabled = false;
                numericUpDownMorfologiaNDetalles.Enabled = false;
                textBoxDannosDetalles.Enabled = false;
                textBoxAnormalidadesPDetalles.Enabled = false;
                textBoxAnormalidadesSDetalles.Enabled = false;
                numericUpDownTotalAnormalidadesDetalles.Enabled = false;
                textBoxAnomaliaMasFDetalles.Enabled = false;
                numericUpDownLeucocitosDetalles.Enabled = false;
                numericUpDownCelulasEDetalles.Enabled = false;
                checkBoxPalpacionDetalles.Enabled = false;
                checkBoxEcogrfiaDetalles.Enabled = false;
                checkBoxVaginaArtDetalles.Enabled = false;
                checkBoxElectroEyaDetalles.Enabled = false;
                checkBoxProtusionDetalles.Enabled = false;
                checkBoxSatisfactorioDetalles.Enabled = false;
                checkBoxNoSatisfactorioDetalles.Enabled = false;
                textBoxVeterinarioDetalles.Enabled = false;
                textBoxObservacionesDetalles.Enabled = false;
            }
        }

        ///<summary>
        ///Metodo que se llama al hacer click en el boton de guardar cambios, hace el update del examen en la base
        ///</summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        ///<returns> void </returns>
        private void buttonGuardarCambiosDetalles_Click(object sender, EventArgs e)
        {
            bool resultadoElim = eliminarExamen(fechaExamenAndrologico, numeroTrazableToro);
            if (resultadoElim)
            {
                ExamenModel nuevoExamen = ObtenerDatosEntradaUsuario();

                bool resultado = AgregarNuevoExamen(nuevoExamen);
                if (resultado)
                {
                    Utilities.MostrarMessageBox(Utilities.MENSAJE_EXITO, Utilities.TITULO_EXITO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    formAnterior.LlenarDataGridViews();
                    formAnterior.Show();

                }
                else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else Utilities.MostrarMessageBox(Utilities.MENSAJE_ERROR, Utilities.TITULO_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        ///<summary>
        ///Metodo para agregar un examen
        ///</summary>
        ///<param name="datosNuevoExamen"></param>
        ///<returns> booleano dependiendo de si fue exitosa o no la insercion </returns>
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

            resultado.pkNumeroTrazable = numeroTrazableToro;
            resultado.pkFecha = dateTimePickerExamenDetalles.Value;
            resultado.condicionCorporal = textBoxCondCDetalles.Text;

            if (checkBoxLibidoDetalles.Checked)
            {
                resultado.libido = true;
            }
            else
            {
                resultado.libido = false;
            }

            if (checkBoxCMDetalles.Checked)
            {
                resultado.capacidadMonta = true;
            }
            else
            {
                resultado.capacidadMonta = false;
            }

            resultado.descansoSexual = Decimal.ToInt32(numericUpDownDSDetalles.Value);

            if (checkBoxPrepucioDetalles.Checked)
            {
                resultado.prepucio = true;
            }
            else
            {
                resultado.prepucio = false;
            }

            if (checkBoxPeneDetalles.Checked)
            {
                resultado.pene = true;
            }
            else
            {
                resultado.pene = false;
            }

            if (checkBoxTesticulosDetalles.Checked)
            {
                resultado.testiculos = true;
            }
            else
            {
                resultado.testiculos = false;
            }

            if (checkBoxEpiDetalles.Checked)
            {
                resultado.epididimos = true;
            }
            else
            {
                resultado.epididimos = false;
            }

            if (checkBoxGlandulasBDetalles.Checked)
            {
                resultado.glandulasB = true;
            }
            else
            {
                resultado.glandulasB = false;
            }

            if (checkBoxProstataDetalles.Checked)
            {
                resultado.prostata = true;
            }
            else
            {
                resultado.prostata = false;
            }

            if (checkBoxVesiculasSDetalles.Checked)
            {
                resultado.vesiculasSeminales = true;
            }
            else
            {
                resultado.vesiculasSeminales = false;
            }

            if (checkBoxAmpulasDetalles.Checked)
            {
                resultado.ampulas = true;
            }
            else
            {
                resultado.ampulas = false;
            }
            
            resultado.circunferenciaEscrotal = Decimal.ToInt32(numericUpDownCircEscrotalDetalles.Value);
            resultado.volumenEyaculado = Decimal.ToInt32(numericUpDownVolumenEyaDetalles.Value);
            resultado.concentracion = Decimal.ToInt32(numericUpDownConcentracionDetalles.Value);
            resultado.motilidadMasal = Decimal.ToInt32(numericUpDownMotilidadMDetalles.Value);
            resultado.motidilidadProgresiva = Decimal.ToInt32(numericUpDownMotilidadPDetalles.Value);
            resultado.morfologiaNormal = Decimal.ToInt32(numericUpDownMorfologiaNDetalles.Value);
            resultado.anormalidadesPrimarias = textBoxAnormalidadesPDetalles.Text;
            resultado.dannosAcrosomales = textBoxDannosDetalles.Text;
            resultado.anormalidadesSecundarias = textBoxAnormalidadesSDetalles.Text;
            resultado.totalAnormalidades = Decimal.ToInt32(numericUpDownTotalAnormalidadesDetalles.Value);
            resultado.anomaliaFrecuente = textBoxAnomaliaMasFDetalles.Text;
            resultado.leucocitos = Decimal.ToInt32(numericUpDownLeucocitosDetalles.Value);
            resultado.celulasEpit = Decimal.ToInt32(numericUpDownCelulasEDetalles.Value);
            resultado.observaciones = textBoxObservacionesDetalles.Text;

            if (checkBoxSatisfactorioDetalles.Checked)
            {
                resultado.satisfactorio = true;
            }
            else if (checkBoxNoSatisfactorioDetalles.Checked)
            {
                resultado.satisfactorio = false;
            }
            else
            {
                resultado.satisfactorio = false;
            }

            resultado.veterinario = textBoxVeterinarioDetalles.Text;

            if (checkBoxPalpacionDetalles.Checked)
            {
                resultado.palpacion = true;
            }
            else
            {
                resultado.palpacion = false;
            }

            if (checkBoxEcogrfiaDetalles.Checked)
            {
                resultado.ecografia = true;
            }
            else
            {
                resultado.ecografia = false;
            }

            if (checkBoxVaginaArtDetalles.Checked)
            {
                resultado.vaginaArt = true;
            }
            else
            {
                resultado.vaginaArt = false;
            }

            if (checkBoxElectroEyaDetalles.Checked)
            {
                resultado.electroEya = true;
            }
            else
            {
                resultado.electroEya = false;
            }

            if (checkBoxProtusionDetalles.Checked)
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
        ///Seleccion unica de satisfaccion 
        ///</summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        ///<returns> void </returns>
        private void checkBoxNoSatisfactorioDetalles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoSatisfactorioDetalles.Checked == true)
            {
                checkBoxSatisfactorioDetalles.Checked = false;
            }

            if (checkBoxNoSatisfactorioDetalles.Checked == false)
            {
                checkBoxSatisfactorioDetalles.Checked = true;
            }
        }

        ///<summary>
        ///Seleccion unica de satisfaccion 
        ///</summary>
        ///<param name="e"></param>
        ///<param name="sender"></param>
        ///<returns> void </returns>
        private void checkBoxSatisfactorioDetalles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSatisfactorioDetalles.Checked == true)
            {
                checkBoxNoSatisfactorioDetalles.Checked = false;
            }

            if (checkBoxSatisfactorioDetalles.Checked == false)
            {
                checkBoxNoSatisfactorioDetalles.Checked = true;
            }
        }
    }
}
