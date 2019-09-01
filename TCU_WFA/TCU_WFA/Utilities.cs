﻿// Hecho por Luis Porras.
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
        public const int RESULTADO_ERROR = -1;
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
        /// <param name="queryObtenerId">Consulta para obtener el id de uba tabla</param>
        /// <param name="tablaParam">Nombre de la tabla objetivo</param>
        /// <param name="valorParam">Nombre del atributo id de la tabla</param>
        /// <returns>Un entero con el id de una tabla</returns>
        public static int ObtenerIdTabla(string queryObtenerId, string tablaParam, string valorParam)
        {
            int resultado;
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(queryObtenerId, conn);
                cmd.Parameters.Add(tablaParam, SqlDbType.VarChar);
                cmd.Parameters[tablaParam].Value = valorParam;
                try
                {
                    conn.Open();
                    resultado = (Int32)cmd.ExecuteScalar();
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
    }
}
