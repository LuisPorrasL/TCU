//Hecho por Luis Porras

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCU_WFA
{
    public partial class FormAlertas : DefaultForm
    {

        //Constantes
        private const string QUERY_SELECT_VACAS_ALERTAS_IEP = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', r.RAZA AS 'Raza', v.PESO AS 'Peso', d.ESTADO AS 'Estado desarrollo', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', v.ACTIVA AS '¿Activa?' FROM dbo.[VACA] v, dbo.[MODO_PRENNES] mP, dbo.[RAZA] r, dbo.DESARROLLO d WHERE v.ACTIVA = 1 AND ((SELECT dbo.FUNC_OBTENER_ULTIMO_IEP(v.PK_NUMERO_TRAZABLE)) > @maximoIEP) AND v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.FK_ID_RAZA = r.PK_ID_RAZA AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO;";
        private const string QUERY_SELECT_VACAS_ALERTAS_PARTOS = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', r.RAZA AS 'Raza', v.PESO AS 'Peso', d.ESTADO AS 'Estado desarrollo', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', v.ACTIVA AS '¿Activa?' FROM dbo.[VACA] v, dbo.[MODO_PRENNES] mP, dbo.[RAZA] r, dbo.DESARROLLO d WHERE v.ACTIVA = 1 AND v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.FK_ID_RAZA = r.PK_ID_RAZA AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO AND mP.MODO_PRENNES != 'No preñada' AND DATEDIFF (DAY, GETDATE(), DATEADD(DAY, @diasAnticipacion, DATEADD( MONTH, @tiempoGestacion, (SELECT MAX(c.PK_FECHA) FROM [dbo].[FECHAS_CELOS] c WHERE c.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE)))) = 0;";
        private const string QUERY_SELECT_VACAS_ALERTAS_PALPACIONES = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', r.RAZA AS 'Raza', v.PESO AS 'Peso', d.ESTADO AS 'Estado desarrollo', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre', v.ACTIVA AS '¿Activa?' FROM dbo.[VACA] v, dbo.[MODO_PRENNES] mP, dbo.[RAZA] r, dbo.DESARROLLO d WHERE v.ACTIVA = 1 AND v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES AND v.FK_ID_RAZA = r.PK_ID_RAZA AND v.FK_ID_DESARROLLO = d.PK_ID_DESARROLLO AND mP.MODO_PRENNES = 'No preñada' AND DATEDIFF(DAY, GETDATE(), DATEADD(DAY, @diasParaPalpacion, (SELECT MAX(c.PK_FECHA) FROM [dbo].[FECHAS_CELOS] c WHERE c.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE))) = 0;";
        private const string MAXIMO_IEP_PARAM = "@maximoIEP";
        private const string DIAS_ANTICIPACION_PARAM = "@diasAnticipacion";
        private const string TIEMPO_GESTACION_PARAM = "@tiempoGestacion";
        private const string DIAS_PARA_PALPACION_PARAM = "@diasParaPalpacion";

        //Campos
        private ProgramConfiguration config;

        public FormAlertas()
        {
            InitializeComponent();
            config = new ProgramConfiguration();
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {
            LlenarDataGridViews();
        }

        private void LlenarDataGridViews()
        {
            Utilities.LlenarDataGridView(QUERY_SELECT_VACAS_ALERTAS_IEP.Replace(MAXIMO_IEP_PARAM, config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_IEP)), dataGridViewAlertasIEP);
            Utilities.LlenarDataGridView(QUERY_SELECT_VACAS_ALERTAS_PARTOS.Replace(DIAS_ANTICIPACION_PARAM, "-" + config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_PARTO)).Replace(TIEMPO_GESTACION_PARAM, Utilities.TIEMPO_GESTACION_VACA_MESES.ToString()), dataGridViewAlertasPartos);
            Utilities.LlenarDataGridView(QUERY_SELECT_VACAS_ALERTAS_PALPACIONES.Replace(DIAS_PARA_PALPACION_PARAM, config.ObtenerConfig(ProgramConfiguration.LLAVE_ALERTA_PALPACION)), dataGridViewAlertasPalpaciones);
        }
    }
}
