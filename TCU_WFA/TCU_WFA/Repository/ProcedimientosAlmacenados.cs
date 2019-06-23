using System;
using System.Data;
using System.Data.SqlClient;
using TCU_WFA.Models;

namespace TCU_WFA.Repository
{
    public static class ProcedimientosAlmacenados
    {
        public static int ProcInsertarVaca(VacaModel vaca)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_INSERTAR_VACA @numeroTrazable, @nombre, @caracteristicas, @raza, @fechaNacimiento, @fkModoPrennes, @fkNumeroTrazableMadre, @fkNumeroTrazablePadre";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vaca.pkNumeroTrazable;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters["@nombre"].Value = vaca.nombre;
                cmd.Parameters.Add("@caracteristicas", SqlDbType.NVarChar);
                cmd.Parameters["@caracteristicas"].Value = vaca.caracteriscas;
                cmd.Parameters.Add("@raza", SqlDbType.NVarChar);
                cmd.Parameters["@raza"].Value = vaca.raza;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
                cmd.Parameters["@fechaNacimiento"].Value = vaca.fecha;
                cmd.Parameters.Add("@fkModoPrennes", SqlDbType.Int);
                cmd.Parameters["@fkModoPrennes"].Value = vaca.fkModoPrennes;
                cmd.Parameters.Add("@fkNumeroTrazableMadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazableMadre"].Value = vaca.fkNumeroTrazableMadre;
                cmd.Parameters.Add("@fkNumeroTrazablePadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazablePadre"].Value = vaca.fkNumeroTrazablePadre;
                try
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    resultado = Utilities.RESULTADO_ERROR;
                }
            }
            return resultado;
        }
    }
}
