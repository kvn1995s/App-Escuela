using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using ProyMatricula_BE;
using Proyecto_ADO;//No esta esto

namespace ProyMatricula_ADO
{
    public  class ApoderadoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        //// A los StoredProcedures agregarles los campos que le faltan 
        public DataTable ListarApoderado()
        {
            
            try
            {

                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_listarApoderado";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Apoderados");

                return dts.Tables["Apoderados"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public Apoderado_BE ConsultarApoderado(Int16 strCodigo)
        {
            
            try
            {
                DateTime a = new DateTime();
                DateTime feReg = new DateTime();
                DateTime feUltMod = new DateTime();

                Apoderado_BE objApoderadoBE = new Apoderado_BE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_consultarApoderado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codApoderado", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objApoderadoBE.codApoderado = Convert.ToInt16( dtr["codApoderado"].ToString());
                    objApoderadoBE.nombres = dtr["nombres"].ToString();
                    objApoderadoBE.apePaterno = dtr["apePaterno"].ToString();
                    objApoderadoBE.apeMaterno = dtr["apeMaterno"].ToString();
                    objApoderadoBE.dni = dtr["dni"].ToString();
                    DateTime.TryParse(dtr["fechaNac"].ToString(), out a );
                    objApoderadoBE.fechaNac = a;
                    objApoderadoBE.direccionApod = dtr["direccionApod"].ToString();
                    objApoderadoBE.telefono = dtr["telefono"].ToString();

                    // Convertimos la imagen a mapa de bytes y lo cargamos a la propiedad Foto de la entidad de negocios
                    //por si es null en foto
                    if (!DBNull.Value.Equals(dtr["foto"]))
                    {
                        objApoderadoBE.Foto_Apo = (Byte[])(dtr["foto"]);

                    }
                    else
                    {
                        objApoderadoBE.Foto_Apo = new byte[0];
                    }

                    

                    objApoderadoBE.Usu_Registro = dtr["usu_registro"].ToString();
                    DateTime.TryParse(dtr["fecha_registro"].ToString(), out feReg) ;
                    objApoderadoBE.Fec_Registro = feReg ;
                    objApoderadoBE.Usu_Ult_Mod = dtr["usu_ult_mod"].ToString();
                    DateTime.TryParse(dtr["fecha_ult_mod"].ToString(), out feUltMod);
                    objApoderadoBE.Fec_Ult_Mod = feUltMod;


                    dtr.Close();

                }
                return objApoderadoBE;
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

        public Boolean InsertarApoderado(Apoderado_BE objApoderadoBE)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_insertarApoderado";
                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@nombres", objApoderadoBE.nombres);
                cmd.Parameters.AddWithValue("@apePaterno", objApoderadoBE.apePaterno);
                cmd.Parameters.AddWithValue("@apeMaterno", objApoderadoBE.apeMaterno);
                cmd.Parameters.AddWithValue("@dni", objApoderadoBE.dni);
                cmd.Parameters.AddWithValue("@fechaNac", objApoderadoBE.fechaNac);
                cmd.Parameters.AddWithValue("@direccionApod", objApoderadoBE.direccionApod);
                cmd.Parameters.AddWithValue("@telefono", objApoderadoBE.telefono);
                cmd.Parameters.AddWithValue("@foto", objApoderadoBE.Foto_Apo);
                cmd.Parameters.AddWithValue("@usu_registro", objApoderadoBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@fecha_registro", objApoderadoBE.Fec_Registro);


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
        public Boolean ActualizarApoderado(Apoderado_BE objApoderadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_actualizarApoderado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codApoderado", objApoderadoBE.codApoderado);
                cmd.Parameters.AddWithValue("@nombres", objApoderadoBE.nombres);
                cmd.Parameters.AddWithValue("@apePaterno", objApoderadoBE.apePaterno);
                cmd.Parameters.AddWithValue("@apeMaterno", objApoderadoBE.apeMaterno);
                cmd.Parameters.AddWithValue("@dni", objApoderadoBE.dni);
                cmd.Parameters.AddWithValue("@fechaNac", objApoderadoBE.fechaNac);
                cmd.Parameters.AddWithValue("@direccionApod", objApoderadoBE.direccionApod);
                cmd.Parameters.AddWithValue("@telefono", objApoderadoBE.telefono);
                cmd.Parameters.AddWithValue("@foto", objApoderadoBE.Foto_Apo);
                cmd.Parameters.AddWithValue("@usu_ult_mod", objApoderadoBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@fecha_ult_mod", objApoderadoBE.Fec_Ult_Mod);

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

        public Boolean EliminarApoderado(String strCodigo)
        {
           

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_eliminarApoderado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codApoderado", strCodigo);
               

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
