// Hecho por Luis Porras.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TCU_WFA
{
    /// <summary>
    /// Clase estática de utilidades.
    /// </summary>
    public static class Utilities
    {
        //Constantes
        public const int RESULTADO_ERROR = -18;
        public const int TIEMPO_GESTACION_VACA_MESES = 9;
        public const int DIAS_SEMANA = 7;
        public const int DIAS_MES = 30;
        //Connection string 
        public const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = TCU_DB; Integrated Security = True; Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //Mensajes
        public const string MENSAJE_ERROR_ENTRADA_USUARIO = "Error: Datos de entrada inválidos.";
        public const string MENSAJE_ERROR = "Error: Ocurrió un problema. La operación no fue realizada correctamente.";
        public const string MENSAJE_EXITO = "Exito: La operación fue realizada exitosamente.";
        //Titulos
        public const string TITULO_ERROR = "Error";
        public const string TITULO_EXITO = "Exito";

        /// <summary>
        /// Despliega una ventana emergente con el mensaje "mensaje", el titulo "titulo", los botones "botones" y el icono "icono".s 
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar en la ventana emergente</param>
        /// <param name="titulo">Titulo a mostrar en la ventana emergente</param>
        /// <param name="botones">Los botones a mostrar en la ventana emergente</param>
        /// <param name="icono">El icono a mostrar en la ventana emergente</param>
        /// <returns></returns>
        public static DialogResult MostrarMessageBox(string mensaje, string titulo, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            return MessageBox.Show(mensaje, titulo, botones, icono);
        }

        /// <summary>
        /// Puebla al combobox "comboBoxName" con el resultado de la consulta "query".
        /// </summary>
        /// <param name="query">Consulta a ejecutar</param>
        /// <param name="comboBoxName">ComboBox que se desea poblar</param>
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

        /// <summary>
        /// Devuelve un entero con el id resultado de ejecutar la consulta "queryObtenerId" con los parámetros "tablaParam" y "valorParam".
        /// </summary>
        /// <param name="queryObtenerId">Consulta para obtener el atributo de una tabla</param>
        /// <param name="tablaParam">Nombre de la tabla objetivo</param>
        /// <param name="valorParam">Nombre del atributo de la tabla</param>
        /// <returns>Un objeto con el atributo de una tabla</returns>
        public static Object ObtenerAtributoTabla(string queryObtenerAtributo, string tablaParam, Object valorParam)
        {
            Object resultado;
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(queryObtenerAtributo, conn);
                string tipoValorParam = valorParam.GetType().ToString();
                switch (tipoValorParam)
                {
                    case "System.Int32":
                        cmd.Parameters.Add(tablaParam, SqlDbType.Int);
                        break;
                    case "System.String":
                        cmd.Parameters.Add(tablaParam, SqlDbType.VarChar);
                        break;
                    default:
                        cmd.Parameters.Add(tablaParam, SqlDbType.VarChar);
                        break;
                }
                
                cmd.Parameters[tablaParam].Value = valorParam;
                try
                {
                    conn.Open();
                    resultado = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    resultado = RESULTADO_ERROR;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Llena al DataGridView "dataGridView" con el resultado de la consulta "query"
        /// </summary>
        /// <param name="query">Consulta que devuelve lo que se desea mostrar en el DataGridView</param>
        /// <param name="dataGridView">DataGridView a poblar</param>
        public static void LlenarDataGridView(string query, DataGridView dataGridView)
        {
            var conn = new SqlConnection(CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter(query, conn);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// Devuelve el resultado de realizar una consulta que solo retorna un Count, de lo contrario retorna el valor de la primera fila y columna.
        /// </summary>
        /// <param name="query">Consulta que retorna un Count()</param>
        /// <returns>Un entero con el resultado, en caso de error retorna el código de error</returns>
        public static int EjecutarConsultaCount(string query)
        {
            int cantidad = 0;
            using (SqlConnection conexion = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    try
                    {
                        conexion.Open();
                        cantidad  = (Int32)cmd.ExecuteScalar();
                    }
                    catch
                    {
                        cantidad = RESULTADO_ERROR;
                    }
                }
            }
            return cantidad;
        }
        
    }
}
