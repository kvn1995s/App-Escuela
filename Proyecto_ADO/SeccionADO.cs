using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proyecto_BE;

namespace Proyecto_ADO
{
    public class SeccionADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarSeccion()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listarSecciones";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Secciones");
                return dts.Tables["Secciones"];

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public SeccionBE ConsultarSeccion(Int16 strCodSec)
        {
            try
            {
                SeccionBE objSeccionBE = new SeccionBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_consultarSeccion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codSeccion", strCodSec);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objSeccionBE.codSeccion = Convert.ToInt16(dtr["codSeccion"]);
                    objSeccionBE.codPersonal = Convert.ToInt16(dtr["codPersonal"]);
                    objSeccionBE.grupo = dtr["grupo"].ToString();
                    objSeccionBE.turno = dtr["turno"].ToString();
                    objSeccionBE.numSalon = dtr["numSalon"].ToString();
                    objSeccionBE.numGrado = dtr["numGrado"].ToString();
                    dtr.Close();
                }
                return objSeccionBE;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean InsertarSeccion(SeccionBE objSeccionBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_insertarSeccion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codPersonal", objSeccionBE.codPersonal);
                cmd.Parameters.AddWithValue("@grupo", objSeccionBE.grupo);
                cmd.Parameters.AddWithValue("@turno", objSeccionBE.turno);
                cmd.Parameters.AddWithValue("@numSalon", objSeccionBE.numSalon);
                cmd.Parameters.AddWithValue("@numGrado", objSeccionBE.numGrado);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }

        public Boolean ActualizarSeccion(SeccionBE objSeccionBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizarSeccion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codSeccion", objSeccionBE.codSeccion);
                cmd.Parameters.AddWithValue("@codPersonal", objSeccionBE.codPersonal);
                cmd.Parameters.AddWithValue("@grupo", objSeccionBE.grupo);
                cmd.Parameters.AddWithValue("@turno", objSeccionBE.turno);
                cmd.Parameters.AddWithValue("@numSalon", objSeccionBE.numSalon);
                cmd.Parameters.AddWithValue("@numGrado", objSeccionBE.numGrado);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean EliminarSeccion(Int16 strCodSec) {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_eliminarSeccion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codSeccion",strCodSec);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
    }
}
