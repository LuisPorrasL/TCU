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
        public static int ProcInsertarExamen(ExamenModel examen)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_INSERTAR_EXAMEN @numeroTrazable, @fecha, @condCorp, @libido, @capacidadM, @descansoSexual, @prepucio, @pene, @testiculos, @epididimos, @glandulasB, @prostata, @vesiculasS, @ampulas, @circunferenciaEsc, @volumenEyaculado, @concentracion, @motilidadMasal, @motilidadProgresiva, @morfologiaNormal, @anormalidadesP, @dannosAcrosomales, @anormalidadesS, @totalAnormalidades, @anomaliaFrecuente, @leucocitos, @celulasEpit, @observaciones, @satisfactorio, @veterinario, @palpacion, @ecografia, @vaginaArt, @electroEya, @protusion ";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);//1
                cmd.Parameters["@numeroTrazable"].Value = examen.pkNumeroTrazable;

                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);//2
                cmd.Parameters["@fecha"].Value = examen.pkFecha;

                cmd.Parameters.Add("@condCorp", SqlDbType.VarChar);//3
                cmd.Parameters["@condCorp"].Value = examen.condicionCorporal;

                cmd.Parameters.Add("@libido", SqlDbType.Bit);//4
                cmd.Parameters["@libido"].Value = examen.libido;

                cmd.Parameters.Add("@capacidadM", SqlDbType.Bit);//5
                cmd.Parameters["@capacidadM"].Value = examen.capacidadMonta;

                cmd.Parameters.Add("@descansoSexual", SqlDbType.Int);//6
                cmd.Parameters["@descansoSexual"].Value = examen.descansoSexual;

                cmd.Parameters.Add("@prepucio", SqlDbType.Bit);//7
                cmd.Parameters["@prepucio"].Value = examen.prepucio;

                cmd.Parameters.Add("@pene", SqlDbType.Bit);//8
                cmd.Parameters["@pene"].Value = examen.pene;

                cmd.Parameters.Add("@testiculos", SqlDbType.Bit);//9
                cmd.Parameters["@testiculos"].Value = examen.testiculos;

                cmd.Parameters.Add("@epididimos", SqlDbType.Bit);//10
                cmd.Parameters["@epididimos"].Value = examen.epididimos;

                cmd.Parameters.Add("@glandulasB", SqlDbType.Bit);//11
                cmd.Parameters["@glandulasB"].Value = examen.glandulasB;

                cmd.Parameters.Add("@prostata", SqlDbType.Bit);//12
                cmd.Parameters["@prostata"].Value = examen.prostata;

                cmd.Parameters.Add("@vesiculasS", SqlDbType.Bit);//13
                cmd.Parameters["@vesiculasS"].Value = examen.vesiculasSeminales;

                cmd.Parameters.Add("@ampulas", SqlDbType.Bit);//14
                cmd.Parameters["@ampulas"].Value = examen.ampulas;

                cmd.Parameters.Add("@circunferenciaEsc", SqlDbType.Decimal);//15
                cmd.Parameters["@circunferenciaEsc"].Value = examen.circunferenciaEscrotal;

                cmd.Parameters.Add("@volumenEyaculado", SqlDbType.Decimal);//16
                cmd.Parameters["@volumenEyaculado"].Value = examen.volumenEyaculado;

                cmd.Parameters.Add("@concentracion", SqlDbType.NVarChar);//17
                cmd.Parameters["@concentracion"].Value = examen.concentracion;

                cmd.Parameters.Add("@motilidadMasal", SqlDbType.Int);//18
                cmd.Parameters["@motilidadMasal"].Value = examen.motilidadMasal;

                cmd.Parameters.Add("@motilidadProgresiva", SqlDbType.Int);//19
                cmd.Parameters["@motilidadProgresiva"].Value = examen.motidilidadProgresiva;

                cmd.Parameters.Add("@morfologiaNormal", SqlDbType.Int);//20
                cmd.Parameters["@morfologiaNormal"].Value = examen.morfologiaNormal;

                cmd.Parameters.Add("@anormalidadesP", SqlDbType.NVarChar);//21
                cmd.Parameters["@anormalidadesP"].Value = examen.anormalidadesPrimarias;

                cmd.Parameters.Add("@dannosAcrosomales", SqlDbType.NVarChar);//22
                cmd.Parameters["@dannosAcrosomales"].Value = examen.dannosAcrosomales;

                cmd.Parameters.Add("@anormalidadesS", SqlDbType.VarChar);//23
                cmd.Parameters["@anormalidadesS"].Value = examen.anormalidadesSecundarias;

                cmd.Parameters.Add("@totalAnormalidades", SqlDbType.Int);//24
                cmd.Parameters["@totalAnormalidades"].Value = examen.totalAnormalidades;

                cmd.Parameters.Add("@anomaliaFrecuente", SqlDbType.NVarChar);//25
                cmd.Parameters["@anomaliaFrecuente"].Value = examen.anomaliaFrecuente;

                cmd.Parameters.Add("@leucocitos", SqlDbType.Int);//26
                cmd.Parameters["@leucocitos"].Value = examen.leucocitos;

                cmd.Parameters.Add("@celulasEpit", SqlDbType.Int);//27
                cmd.Parameters["@celulasEpit"].Value = examen.celulasEpit;

                cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar);//28
                cmd.Parameters["@observaciones"].Value = examen.observaciones;

                cmd.Parameters.Add("@satisfactorio", SqlDbType.Bit);//29
                cmd.Parameters["@satisfactorio"].Value = examen.satisfactorio;

                cmd.Parameters.Add("@veterinario", SqlDbType.NVarChar);//30
                cmd.Parameters["@veterinario"].Value = examen.veterinario;

                cmd.Parameters.Add("@palpacion", SqlDbType.Bit);//31
                cmd.Parameters["@palpacion"].Value = examen.palpacion;

                cmd.Parameters.Add("@ecografia", SqlDbType.Bit);//32
                cmd.Parameters["@ecografia"].Value = examen.ecografia;

                cmd.Parameters.Add("@vaginaArt", SqlDbType.Bit);//33
                cmd.Parameters["@vaginaArt"].Value = examen.vaginaArt;

                cmd.Parameters.Add("@electroEya", SqlDbType.Bit);//34
                cmd.Parameters["@electroEya"].Value = examen.electroEya;

                cmd.Parameters.Add("@protusion", SqlDbType.Bit);//35
                cmd.Parameters["@protusion"].Value = examen.protusion;

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

        public static int ProcEliminarExamen(DateTime fecha, int idToro)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_ELIMINAR_EXAMEN @numeroTrazable, @fecha";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = idToro;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime);
                cmd.Parameters["@fecha"].Value = fecha;
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

        public static int ProcInsertarToro(ToroModel toro)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_INSERTAR_TORO @numeroTrazable, @nombre, @caracteristicas, @raza";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = toro.pkNumeroTrazable;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters["@nombre"].Value = toro.nombre;
                cmd.Parameters.Add("@caracteristicas", SqlDbType.NVarChar);
                cmd.Parameters["@caracteristicas"].Value = toro.caracteriscas;
                cmd.Parameters.Add("@raza", SqlDbType.Int);
                cmd.Parameters["@raza"].Value = toro.raza;
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

        public static int ProcEditarToro(ToroModel toro)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_EDITAR_TORO @numeroTrazable, @nombre, @caracteristicas, @raza";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@numeroTrazable", SqlDbType.Int);
                cmd.Parameters["@numeroTrazable"].Value = toro.pkNumeroTrazable;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmd.Parameters["@nombre"].Value = toro.nombre;
                cmd.Parameters.Add("@caracteristicas", SqlDbType.NVarChar);
                cmd.Parameters["@caracteristicas"].Value = toro.caracteriscas;
                cmd.Parameters.Add("@raza", SqlDbType.Int);
                cmd.Parameters["@raza"].Value = toro.raza;
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

        public static int ProcEliminarToro(int vacaId, string causaDeBaja)
        {
            int resultado = 0;
            string sql = "EXECUTE PROC_ELIMINAR_TORO @numeroTrazable, @causaDeBaja";
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

                SqlParameter outputUltimoIEPParam = new SqlParameter("@ultimoIEP", SqlDbType.Int)
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


        public static double ProcInsertarExamen()
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
            string sql = "PROC_OBTENER_RESUMEN_VACAS";
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

        public static double ProcObtenerPromedioPartosHato()
        {
            double resultado = 0;
            string sql = "PROC_OBTENER_PROMEDIO_PARTOS_HATO";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter outputPromedioPartosHato = new SqlParameter("@promedioPartosHato", SqlDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(outputPromedioPartosHato);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = double.Parse(cmd.Parameters["@promedioPartosHato"].Value.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    resultado = Utilities.RESULTADO_ERROR;
                }
            }
            return resultado;
        }

        public static DataTable ProcObtenerDatosGraficosVacas()
        {
            DataTable datos_resultado = new DataTable();
            string sql = "PROC_OBTENER_DATOS_GRAFICOS_VACAS";
            using (SqlConnection conn = new SqlConnection(Utilities.CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        conn.Open();
                        datos_resultado.Load(cmd.ExecuteReader());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }
                }
            }
            return datos_resultado;
        }

    }
}

