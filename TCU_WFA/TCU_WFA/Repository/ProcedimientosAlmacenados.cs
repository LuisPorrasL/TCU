// Hecho por Luis Porras.
using System;
using System.Data;
using System.Data.SqlClient;
using TCU_WFA.Models;

namespace TCU_WFA.Repository
{
    /// <summary>
    /// Clase estáctica utilizada para llamar procedimientos almacenados.
    /// </summary>
    public static class ProcedimientosAlmacenados
    {
        public static int ProcInsertarVaca(VacaModel vaca)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_INSERTAR_VACA @numeroTrazable, @nombre, @caracteristicas, @raza, @fechaNacimiento, @fkModoPrennes, @fkNumeroTrazableMadre, @fkNumeroTrazablePadre, @peso, @fkDesarrollo";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vaca.pkNumeroTrazable;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters["@nombre"].Value = vaca.nombre;
                cmd.Parameters.Add("@caracteristicas", SqlDbType.NVarChar);
                cmd.Parameters["@caracteristicas"].Value = vaca.caracteriscas;
                cmd.Parameters.Add("@raza", SqlDbType.Int);
                cmd.Parameters["@raza"].Value = vaca.raza;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
                cmd.Parameters["@fechaNacimiento"].Value = vaca.fecha;
                cmd.Parameters.Add("@fkModoPrennes", SqlDbType.Int);
                cmd.Parameters["@fkModoPrennes"].Value = vaca.fkModoPrennes;
                cmd.Parameters.Add("@fkNumeroTrazableMadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazableMadre"].Value = (object)vaca.fkNumeroTrazableMadre ?? DBNull.Value;
                cmd.Parameters.Add("@fkNumeroTrazablePadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazablePadre"].Value = (object)vaca.fkNumeroTrazablePadre ?? DBNull.Value;
                cmd.Parameters.Add("@peso", SqlDbType.Decimal);
                cmd.Parameters["@peso"].Value = (object)vaca.peso ?? DBNull.Value;
                cmd.Parameters.Add("@fkDesarrollo", SqlDbType.Int);
                cmd.Parameters["@fkDesarrollo"].Value = vaca.fkDesarrollo;
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
            string sql = "EXECUTE PROC_EDITAR_VACA @numeroTrazable, @nombre, @caracteristicas, @raza, @fechaNacimiento, @fkModoPrennes, @fkNumeroTrazableMadre, @fkNumeroTrazablePadre, @peso, @fkDesarrollo";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vaca.pkNumeroTrazable;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters["@nombre"].Value = vaca.nombre;
                cmd.Parameters.Add("@caracteristicas", SqlDbType.NVarChar);
                cmd.Parameters["@caracteristicas"].Value = vaca.caracteriscas;
                cmd.Parameters.Add("@raza", SqlDbType.Int);
                cmd.Parameters["@raza"].Value = vaca.raza;
                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
                cmd.Parameters["@fechaNacimiento"].Value = vaca.fecha;
                cmd.Parameters.Add("@fkModoPrennes", SqlDbType.Int);
                cmd.Parameters["@fkModoPrennes"].Value = vaca.fkModoPrennes;
                cmd.Parameters.Add("@fkNumeroTrazableMadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazableMadre"].Value = (object)vaca.fkNumeroTrazableMadre ?? DBNull.Value;
                cmd.Parameters.Add("@fkNumeroTrazablePadre", SqlDbType.Int);
                cmd.Parameters["@fkNumeroTrazablePadre"].Value = (object)vaca.fkNumeroTrazablePadre ?? DBNull.Value;
                cmd.Parameters.Add("@peso", SqlDbType.Decimal);
                cmd.Parameters["@peso"].Value = (object)vaca.peso ?? DBNull.Value;
                cmd.Parameters.Add("@fkDesarrollo", SqlDbType.Int);
                cmd.Parameters["@fkDesarrollo"].Value = vaca.fkDesarrollo;
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

        public static int ProcInsertarCelo(int vacaId, DateTime fechaCelo)
        {
            int resultado = 0;
            string sql = "PROC_INSERTAR_CELO @numeroTrazable, @fecha";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vacaId;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = fechaCelo;
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

        public static int ProcEliminarVaca(int vacaId, string causaDeBaja)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_ELIMINAR_VACA @numeroTrazable, @causaDeBaja";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vacaId;
                cmd.Parameters.Add("@causaDeBaja", SqlDbType.NVarChar);
                cmd.Parameters["@causaDeBaja"].Value = causaDeBaja;
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

        public static int ProcActualizarModoPrennesVaca(int vacaId, int nuevoModoPrennes)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_ACTUALIZAR_MODO_PRENNES_VACA @numeroTrazable, @fkModoPrennes";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = vacaId;
                cmd.Parameters.Add("@fkModoPrennes", SqlDbType.Int);
                cmd.Parameters["@fkModoPrennes"].Value = nuevoModoPrennes;
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

        //Proc para recuperación de parametros reproductivos.
        public static double ProcObtenerUltimoIEP(int vacaId)
        {
            double resultado = 0;
            string sql = "PROC_OBTENER_ULTIMO_IEP";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inIdVacaParam = new SqlParameter("@idVaca", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Input
                };

                inIdVacaParam.Value = vacaId;

                cmd.Parameters.Add(inIdVacaParam);

                SqlParameter outputUltimoIEPParam = new SqlParameter("@ultimoIEP", SqlDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputUltimoIEPParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = double.Parse(cmd.Parameters["@ultimoIEP"].Value.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    resultado = Utilities.RESULTADO_ERROR;
                }
            }
            return resultado;
        }

        public static double ProcObtenerIEP(int vacaId)
        {
            double resultado = 0;
            string sql = "PROC_OBTENER_IEP";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter inIdVacaParam = new SqlParameter("@idVaca", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Input
                };

                inIdVacaParam.Value = vacaId;

                cmd.Parameters.Add(inIdVacaParam);

                SqlParameter outputUltimoIEPParam = new SqlParameter("@IEP", SqlDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputUltimoIEPParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = double.Parse(cmd.Parameters["@IEP"].Value.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    resultado = Utilities.RESULTADO_ERROR;
                }
            }
            return resultado;
        }

        public static double ProcObtenerUltimoIEPHistorico()
        {
            double resultado = 0;
            string sql = "PROC_OBTENER_ULTIMO_IEP_HISTORICO";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter outputUltimoIEPParam = new SqlParameter("@ultimoIEPHistorico", SqlDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputUltimoIEPParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = double.Parse(cmd.Parameters["@ultimoIEPHistorico"].Value.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    resultado = Utilities.RESULTADO_ERROR;
                }
            }
            return resultado;
        }

        public static double ProcObtenerIEPHistorico()
        {
            double resultado = 0;
            string sql = "PROC_OBTENER_IEP_HISTORICO";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter outputUltimoIEPParam = new SqlParameter("@IEPHistorico", SqlDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputUltimoIEPParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = double.Parse(cmd.Parameters["@IEPHistorico"].Value.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    resultado = Utilities.RESULTADO_ERROR;
                }
            }
            return resultado;
        }

        public static DataTable ProcObtenerResumenVacas()
        {
            DataTable resumen_resultado = new DataTable();
            string sql = "EXEC PROC_OBTENER_RESUMEN_VACAS";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        conn.Open();
                        resumen_resultado.Load(cmd.ExecuteReader());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }
                }
            }
            return resumen_resultado;
        }

    }
}

