using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;



namespace AmigoInvisibleApp
{
    public class Database
    {
        string str = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public static bool verificarcodigo()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("verificarcodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter retorno = new SqlParameter("retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(retorno);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

                if((int)retorno.Value == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool verificarNombre(string nombre)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("verificarnombre", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter retorno = new SqlParameter("retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.AddWithValue("nombre", nombre);
            cmd.Parameters.Add(retorno);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

                if ((int)retorno.Value == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            catch(Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static List<Pista> listarPistas()
        {
            List<Pista> listaPistas = new List<Pista>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("obtenerpistas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime fecha = (DateTime)reader["fecha"];
                        string texto = (string)reader["texto"];
                        Pista unaPista = new Pista(fecha, texto);
                        listaPistas.Add(unaPista);
                    }
                    reader.Close();

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return listaPistas;
        }

        public static List<Pista> listarPreguntas()
        {
            List<Pista> listaPistas = new List<Pista>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("verpreguntas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime fecha = (DateTime)reader["fecha"];
                        string texto = (string)reader["texto"];
                        Pista unaPista = new Pista(fecha, texto);
                        listaPistas.Add(unaPista);
                    }
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return listaPistas;
        }

        public static void enviarPregunta(Pista pista)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("agregarpregunta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter retorno = new SqlParameter("retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(retorno);
            cmd.Parameters.AddWithValue("fecha", pista.Fecha);
            cmd.Parameters.AddWithValue("texto", pista.Texto);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                if ((int)retorno.Value == 1)
                {
                    throw new Exception("Pregunta enviada");
                }
                else if ((int)retorno.Value == 0)
                {
                    throw new Exception("ocurrio algun error super raro");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void enviarPista(Pista pista)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("agregarpista", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter retorno = new SqlParameter("retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(retorno);
            cmd.Parameters.AddWithValue("texto", pista.Texto);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                if ((int)retorno.Value == 1)
                {
                    throw new Exception("Pista enviada");
                }
                else if ((int)retorno.Value == 0)
                {
                    throw new Exception("ocurrio algun error super raro");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }


        public static bool enviarNombre(string nombre)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("verificarnombre", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter retorno = new SqlParameter("retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(retorno);
            cmd.Parameters.AddWithValue("nombre", nombre);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                if ((int)retorno.Value == 1)
                {
                    return true;
                }
                else if ((int)retorno.Value == 0)
                {
                    throw new Exception("No soy ese, perdiste tu intento :c");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return false;
        }

        public static void agregarIntento()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("agregarIntento", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void obtenerUltimoIntento()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("obtenerultimointento", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            try
            {
                cn.Open();
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    DateTime ultimoIntento = (DateTime)reader["fecha"];
                    if (ultimoIntento.Day == DateTime.Now.Day)
                    {
                        throw new Exception("Ya lo has intentado hoy, proba manana!!");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void ganado()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("ganar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool verificarganado()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("verificarganado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter retorno = new SqlParameter("retorno", SqlDbType.Int);
            retorno.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(retorno);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

                if ((int)retorno.Value == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }

        }

        public static void activarCodigo()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("codigoactivado", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void desactivarCodigo()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            SqlCommand cmd = new SqlCommand("codigodesactivado", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }





    }
}