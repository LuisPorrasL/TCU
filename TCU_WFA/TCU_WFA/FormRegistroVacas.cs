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

namespace TCU_WFA
{
    public partial class FormRegistroVacas : DefaultForm
    {

        //Constantes
        private const string QUERY_SELECT_VACAS_DATA_GRID_VIEW = "SELECT v.PK_NUMERO_TRAZABLE as 'Id', v.NOMBRE AS 'Nombre', v.FECHA_NACIMIENTO AS 'Fecha nacimiento', v.RAZA AS 'Raza', v.CARACTERISTICAS AS 'Caracteristicas', mP.MODO_PRENNES AS 'Modo preñes', v.FK_NUMERO_TRAZABLE_VACA AS 'Id madre', v.FK_NUMERO_TRAZABLE_TORO AS 'Id padre'  FROM [dbo].[VACA] v, [dbo].MODO_PRENNES mP WHERE v.FK_ID_MODO_PRENNES = mP.PK_ID_MODO_PRENNES";

        public FormRegistroVacas()
        {
            InitializeComponent();
        }

        private void FormRegistroVacas_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewVacas();
        }

        public void LlenarDataGridViewVacas()
        {
            Utilities.LlenarDataGridView(QUERY_SELECT_VACAS_DATA_GRID_VIEW, dataGridViewVacas);
        }

        private void botonAgregarVaca_Click(object sender, EventArgs e)
        {
            FormAgregarVaca form = new FormAgregarVaca();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}
