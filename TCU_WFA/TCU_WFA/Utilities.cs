using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCU_WFA
{
    public class Utilities
    {
        //Constantes
        private const string QUERY_OBTENER_ID_MODO_PRENNES = "WHERE MODO_PRENNES = ";
        //Connection string 
        public const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = TCU_DB; Integrated Security = True; Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //Mensajes
        public const string MENSAJE_ERROR_ENTRADA_USUARIO = "Error: Datos de entrada inválidos.";
        public const string MENSAJE_ERROR = "Error: Ocurrió un problema. La operación no fue realizada correctamente.";
        public const string MENSAJE_EXITO = "Exito: La operación fue realizada exitosamente.";
        //Titulos
        public const string TITULO_ERROR = "Error";
        public const string TITULO_EXITO = "Exito";

        public static void MostrarMessageBox(string mensaje, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public static void LlenarComboBoxList(string query, ComboBox comboBoxName)
        {
            DataTable dt = new DataTable();

            using (var cn = new SqlConnection(CONNECTION_STRING))
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cn.Open();

                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                        return;
                    }
                }
            }

            comboBoxName.DataSource = dt;
            comboBoxName.ValueMember = dt.Columns[0].ColumnName;
            comboBoxName.DisplayMember = dt.Columns[1].ColumnName;
        }

        public static int ObtenerIdModoPrennes(string nombreModoPrennes)
        {
            return 1;
        }
    }
}
