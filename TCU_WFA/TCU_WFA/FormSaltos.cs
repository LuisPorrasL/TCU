﻿// Hecho por Luis Porras.
using System;
using System.Windows.Forms;
using TCU_WFA.Repository;

namespace TCU_WFA
{
    public partial class FormSaltos : DefaultForm
    {
        // Constantes
        private const string QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_VACA = "SELECT v.PK_NUMERO_TRAZABLE, v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v, [dbo].[MODO_PRENNES] mP, [dbo].[DESARROLLO] d WHERE v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.ACTIVA = 1 AND mp.MODO_PRENNES = 'No preñada' AND d.ESTADO != 'Ternera' AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO;";

        //Campos
        private int vacaId;
        private DateTime fechaSalto;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FormSaltos()
        {
            InitializeComponent();
            InicializarCampos();
        }

        /// <summary>
        /// Asigna un valor inicial a los atributos privados de la clase.
        /// </summary>
        private void InicializarCampos()
        {
            this.vacaId = 0;
            this.fechaSalto = new DateTime();
        }

        /// <summary>
        /// Método que se llama cada vez que se carga el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSaltos_Load(object sender, EventArgs e)
        {
            LlenarComboBoxList();
        }

        /// <summary>
        /// Llena todos los ComboBoxList del form.
        /// </summary>
        private void LlenarComboBoxList()
        {
            Utilities.LlenarComboBoxList(QUERY_LLENAR_COMBO_BOX_NUMERO_TRAZABLE_VACA, comboBoxNumeroTrazableVaca);
        }

        /// <summary>
        /// Implementa la función principal del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            bool entradaUsuarioCorrecta = RevisarEntradaUsuario();
            if (entradaUsuarioCorrecta)
            {
                ObtenerDatosEntradaUsuario();
                bool resultado = InsertarCelo();
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

        /// <summary>
        /// Limpia la entrada realizada por el usuario.
        /// </summary>
        private void LimpiarEntradaUsuario()
        {
            InicializarCampos();
            LlenarComboBoxList();
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
        }

        /// <summary>
        /// Intenta insertar un nuevo celo en la base de datos.
        /// </summary>
        /// <returns>Un booleano. True sí la operación fue correcta, false en caso contrario.</returns>
        private bool InsertarCelo()
        {
            try
            {
                int resultado = ProcedimientosAlmacenados.ProcInsertarCelo(this.vacaId, this.fechaSalto);
                if (resultado == Utilities.RESULTADO_ERROR) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene los datos digitados o seleccionados por el usuario.
        /// </summary>
        private void ObtenerDatosEntradaUsuario()
        {
            this.vacaId = Int32.Parse(comboBoxNumeroTrazableVaca.Text);
            this.fechaSalto = dateTimePickerFechaNacimiento.Value;
        }

        /// <summary>
        /// Revisa que los datos insertados o seleccionados por el usuario sean válidos.
        /// </summary>
        /// <returns>Un booleano. True sí los datos insertados por el usuario son válidos, false en caso contrario.</returns>
        private bool RevisarEntradaUsuario()
        {
            try
            {
                if (Int32.Parse(comboBoxNumeroTrazableVaca.Text) <= 0) return false;
                if (dateTimePickerFechaNacimiento.Value > DateTime.Now) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
