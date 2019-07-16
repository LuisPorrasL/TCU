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
                cmd.Parameters["@fkNumeroTrazableMadre"].Value = (object)vaca.fkNumeroTrazableMadre ?? DBNull.Value;
                cmd.Parameters.Add("@fkNumeroTrazablePadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazablePadre"].Value = (object)vaca.fkNumeroTrazablePadre ?? DBNull.Value;
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

        public static int ProcEditarVaca(VacaModel vaca)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_EDITAR_VACA @numeroTrazable, @nombre, @caracteristicas, @raza, @fechaNacimiento, @fkModoPrennes, @fkNumeroTrazableMadre, @fkNumeroTrazablePadre";
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
                cmd.Parameters["@fkNumeroTrazableMadre"].Value = (object)vaca.fkNumeroTrazableMadre ?? DBNull.Value;
                cmd.Parameters.Add("@fkNumeroTrazablePadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazablePadre"].Value = (object)vaca.fkNumeroTrazablePadre ?? DBNull.Value;
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

        public static int ProcRegistrarParto(DateTime fechaParto, char sexoCria, int idMadre, int? idPadre, bool muertePrematura, string causaAborto)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_REGISTRAR_PARTO @numeroTrazableMadre, @fecha, @numeroTrazablePadre, @muertePrematura, @sexo, @causaAborto";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazableMadre", SqlDbType.Int);
                cmd.Parameters["@numeroTrazableMadre"].Value = idMadre;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = fechaParto;
                cmd.Parameters.Add("@numeroTrazablePadre", SqlDbType.Int);
                cmd.Parameters["@numeroTrazablePadre"].Value = (object)idPadre ?? DBNull.Value;
                cmd.Parameters.Add("@muertePrematura", SqlDbType.Bit);
                cmd.Parameters["@muertePrematura"].Value = muertePrematura;
                cmd.Parameters.Add("@sexo", SqlDbType.Char);
                cmd.Parameters["@sexo"].Value = sexoCria;
                cmd.Parameters.Add("@causaAborto", SqlDbType.NVarChar);
                cmd.Parameters["@causaAborto"].Value = causaAborto;
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

        public static int ProcRegistrarPalpacion(int numeroTrazable, DateTime fecha, float condicionCorporal, bool confirmacion, string resultadoPalpacion)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_REGISTRAR_PALPACION @numeroTrazable, @fecha, @condicionCorporal, @confirmacion, @resultado";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = numeroTrazable;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = fecha;
                cmd.Parameters.Add("@condicionCorporal", SqlDbType.Decimal);
                cmd.Parameters["@condicionCorporal"].Value = condicionCorporal;
                cmd.Parameters.Add("@confirmacion", SqlDbType.Bit);
                cmd.Parameters["@confirmacion"].Value = confirmacion;
                cmd.Parameters.Add("@resultado", SqlDbType.NVarChar);
                cmd.Parameters["@resultado"].Value = resultadoPalpacion;
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

        public static int ProcInsertarDestete(int vacaId, DateTime fechaDestete)
        {
            int resultado = 0;
            string sql = "PROC_INSERTAR_DESTETE @numeroTrazable, @fecha";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vacaId;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = fechaDestete;
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

        public static int ProcInsertarSalto(int vacaId, DateTime fechaSalto)
        {
            int resultado = 0;
            string sql = "PROC_INSERTAR_SALTO @numeroTrazable, @fecha";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vacaId;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = fechaSalto;
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

        public static int ProcEliminarVaca(int vacaId)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_ELIMINAR_VACA @numeroTrazable";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vacaId;
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

