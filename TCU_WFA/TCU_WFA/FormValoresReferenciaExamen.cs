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
    public partial class FormValoresReferenciaExamen : Form
    {
        public FormValoresReferenciaExamen()
        {
            InitializeComponent();

            gridCircEsc.DefaultCellStyle.SelectionBackColor = gridCircEsc.DefaultCellStyle.BackColor;
            gridCircEsc.DefaultCellStyle.SelectionForeColor = gridCircEsc.DefaultCellStyle.ForeColor;
            gridCircEsc.Enabled = false;

            DataGridViewColumn column1 = gridCircEsc.Columns[0];
            column1.Width = 70;

            DataGridViewColumn column2 = gridCircEsc.Columns[1];
            column2.Width = 40;

            DataGridViewColumn column3 = gridCircEsc.Columns[2];
            column3.Width = 40;

            DataGridViewColumn column4 = gridCircEsc.Columns[3];
            column4.Width = 40;

            DataGridViewColumn column5 = gridCircEsc.Columns[4];
            column5.Width = 43;

            DataGridViewColumn column6 = gridCircEsc.Columns[5];
            column6.Width = 43;

            DataGridViewColumn column7 = gridCircEsc.Columns[6];
            column7.Width = 43;

            gridCircEsc.Rows.Add("12 a 14", "≤29", "30-33", "≥34", "≤19", "20-21", "≥22");
            gridCircEsc.Rows.Add("15 a 20", "≤30", "31-35", "≥36", "≤22", "23-28", "≥29");
            gridCircEsc.Rows.Add("21 a 30", "≤31", "32-37", "≥38", "≤29", "30-31", "≥32");
            gridCircEsc.Rows.Add("31 a 36", "≤33", "34-38", "≥39", "≤32", "33-34", "≥35");
            gridCircEsc.Rows.Add("Puntaje", "10", "20", "40", "10", "20", "40");



            gridMotilidad.DefaultCellStyle.SelectionBackColor = gridMotilidad.DefaultCellStyle.BackColor;
            gridMotilidad.DefaultCellStyle.SelectionForeColor = gridMotilidad.DefaultCellStyle.ForeColor;
            gridMotilidad.Enabled = false;

            DataGridViewColumn column1m = gridMotilidad.Columns[0];
            column1m.Width = 70;

            DataGridViewColumn column2m = gridMotilidad.Columns[1];
            column2m.Width = 55;

            gridMotilidad.Rows.Add("60 o más", "20");
            gridMotilidad.Rows.Add("40 a 60", "15");
            gridMotilidad.Rows.Add("20 a 35", "10");
            gridMotilidad.Rows.Add("10 a 15", "5");


            gridAnormalidades.DefaultCellStyle.SelectionBackColor = gridAnormalidades.DefaultCellStyle.BackColor;
            gridAnormalidades.DefaultCellStyle.SelectionForeColor = gridAnormalidades.DefaultCellStyle.ForeColor;
            gridAnormalidades.Enabled = false;

            DataGridViewColumn column1a = gridAnormalidades.Columns[0];
            column1a.Width = 62;

            DataGridViewColumn column2a = gridAnormalidades.Columns[1];
            column2a.Width = 55;

            gridAnormalidades.Rows.Add("≤25", "40");
            gridAnormalidades.Rows.Add("26 a 39", "25");
            gridAnormalidades.Rows.Add("40 a 50", "10");
            gridAnormalidades.Rows.Add("≥51", "5");


            this.CenterToScreen();



        }

        private void FormValoresReferenciaExamen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gridCircEsc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
