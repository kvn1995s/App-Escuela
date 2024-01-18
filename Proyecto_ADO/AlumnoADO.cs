using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using ProyAlumnos_BE;
using System.Globalization;
using System.Net;
using Proyecto_ADO;

namespace ProyAlumADO
{
    public  class AlumnoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

		public DataTable ListarUsuario()
		{
			DataSet dts = new DataSet();
			cnx.ConnectionString = MiConexion.GetCnx();
			cmd.Connection = cnx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "usp_listarUsuarios";
			cmd.Parameters.Clear();
			SqlDataAdapter ada = new SqlDataAdapter(cmd);
			ada.Fill(dts, "Usuario");
			return dts.Tables["Usuario"];
		}
		public DataTable ListarDistritos()
        {
			DataSet dts = new DataSet();
			cnx.ConnectionString = MiConexion.GetCnx();
			cmd.Connection = cnx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "usp_listarDistritos";
			cmd.Parameters.Clear();
			SqlDataAdapter ada = new SqlDataAdapter(cmd);
			ada.Fill(dts, "Distritos");
			return dts.Tables["Distritos"];
		}
		public DataTable ListarApoderado()
		{
			DataSet dts = new DataSet();
			cnx.ConnectionString = MiConexion.GetCnx();
			cmd.Connection = cnx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "usp_listarApoderado";
			cmd.Parameters.Clear();
			SqlDataAdapter ada = new SqlDataAdapter(cmd);
			ada.Fill(dts, "Apoderado");
			return dts.Tables["Apoderado"];
		}

		public DataTable ListarAlumnos()
        {
            
            try
            {

				DataSet dts = new DataSet();
				cnx.ConnectionString = MiConexion.GetCnx();
				cmd.Connection = cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "usp_listarAlumnos";
				cmd.Parameters.Clear();
				SqlDataAdapter ada = new SqlDataAdapter(cmd);
				ada.Fill(dts, "Alumnos");
				return dts.Tables["Alumnos"];


			}
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public AlumnoBE ConsultarAlumno(Int16 strCodigo)
        {
            
            try
            {
				//DateTime a = new DateTime();
				//DateTime feReg = new DateTime();
				//DateTime feUltMod = new DateTime();

				AlumnoBE objAlumnoBE = new AlumnoBE();
				cnx.ConnectionString = MiConexion.GetCnx();
				cmd.Connection = cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "usp_consultarAlumno";
				cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codAlumno", strCodigo);

                cnx.Open();
                dtr =cmd.ExecuteReader();

                if (dtr.HasRows==true)
                {
                    dtr.Read();
                    objAlumnoBE.codAlumno = Convert.ToInt16(dtr["codAlumno"]);
					objAlumnoBE.codDistrito = Convert.ToInt16(dtr["codDistrito"]);
					objAlumnoBE.codApoderado = Convert.ToInt16(dtr["codApoderado"]);
					objAlumnoBE.nombres =dtr["nombres"].ToString();
					objAlumnoBE.apePaterno = dtr["apePaterno"].ToString();
					objAlumnoBE.apeMaterno = dtr["apeMaterno"].ToString();
					objAlumnoBE.dni = dtr["dni"].ToString();
					//DateTime.TryParse(dtr["fechaNacimiento"].ToString(), out a);
					objAlumnoBE.fechaNacimiento =Convert.ToDateTime( dtr["fechaNacimiento"]);
					objAlumnoBE.direccionAlum = dtr["direccionAlum"].ToString();
					objAlumnoBE.telefono = dtr["telefono"].ToString();					
					objAlumnoBE.codUsuario = Convert.ToInt16(dtr["codUsuario"]);
					//objAlumnoBE.fecha_registro = Convert.ToDateTime(dtr["fecha_registro"]);
					//objAlumnoBE.usu_registro = dtr["usu_registro"].ToString();
					//objAlumnoBE.usu_ult_mod = dtr["usu_ult_mod"].ToString();
					//objAlumnoBE.fecha_ult_mod = Convert.ToDateTime(dtr["fecha_ult_mod"]);

					// Convertimos la imagen a mapa de bytes y lo cargamos a la propiedad Foto de la entidad de negocios


					//por si es null en foto
					if (!DBNull.Value.Equals(dtr["foto"]))
					{
						objAlumnoBE.foto = (Byte[])(dtr["foto"]);

					}
					else
					{
						objAlumnoBE.foto = new byte[0];
					}

					objAlumnoBE.estado = Convert.ToInt16(dtr["estado"]);

                    //objAlumnoBE.usu_registro = dtr["usu_registro"].ToString();
                    //DateTime.TryParse(dtr["fecha_registro"].ToString(), out feReg);
                    //objAlumnoBE.fecha_registro = feReg;
                    //objAlumnoBE.usu_ult_mod = dtr["usu_ult_mod"].ToString();
                    //DateTime.TryParse(dtr["fecha_ult_mod"].ToString(), out feUltMod);
                    //objAlumnoBE.fecha_ult_mod = feUltMod;
                    dtr.Close();
				}
                return objAlumnoBE;
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

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE)
        {
          
            try
            {
				cnx.ConnectionString = MiConexion.GetCnx();
				cmd.Connection = cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "usp_insertarAlumno";
				cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codDistrito", objAlumnoBE.codDistrito);
				cmd.Parameters.AddWithValue("@codApoderado", objAlumnoBE.codApoderado);
				cmd.Parameters.AddWithValue("@nombres", objAlumnoBE.nombres);
				cmd.Parameters.AddWithValue("@apePaterno", objAlumnoBE.apePaterno);
				cmd.Parameters.AddWithValue("@apeMaterno", objAlumnoBE.apeMaterno);
				cmd.Parameters.AddWithValue("@dni", objAlumnoBE.dni);
				cmd.Parameters.AddWithValue("@foto", objAlumnoBE.foto);
				cmd.Parameters.AddWithValue("@fechaNacimiento", objAlumnoBE.fechaNacimiento);
				cmd.Parameters.AddWithValue("@direccionAlum", objAlumnoBE.direccionAlum);
				cmd.Parameters.AddWithValue("@telefono", objAlumnoBE.telefono);
				cmd.Parameters.AddWithValue("@codUsuario", objAlumnoBE.codUsuario);
				cmd.Parameters.AddWithValue("@estado", objAlumnoBE.estado);
				cmd.Parameters.AddWithValue("@usu_registro", objAlumnoBE.usu_registro);
				cmd.Parameters.AddWithValue("@fecha_registro", objAlumnoBE.fecha_registro);
				

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
        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            try
            {
				cnx.ConnectionString = MiConexion.GetCnx();
				cmd.Connection = cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "usp_actualizarAlumno";
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@codAlumno", objAlumnoBE.codAlumno);
				cmd.Parameters.AddWithValue("@codDistrito", objAlumnoBE.codDistrito);
				cmd.Parameters.AddWithValue("@codApoderado", objAlumnoBE.codApoderado);
				cmd.Parameters.AddWithValue("@nombres", objAlumnoBE.nombres);
				cmd.Parameters.AddWithValue("@apePaterno", objAlumnoBE.apePaterno);
				cmd.Parameters.AddWithValue("@apeMaterno", objAlumnoBE.apeMaterno);
				cmd.Parameters.AddWithValue("@dni", objAlumnoBE.dni);
				cmd.Parameters.AddWithValue("@fechaNacimiento", objAlumnoBE.fechaNacimiento);
				cmd.Parameters.AddWithValue("@direccionAlum", objAlumnoBE.direccionAlum);
				cmd.Parameters.AddWithValue("@foto", objAlumnoBE.foto);
				cmd.Parameters.AddWithValue("@telefono", objAlumnoBE.telefono);
				cmd.Parameters.AddWithValue("@codUsuario", objAlumnoBE.codUsuario);
				cmd.Parameters.AddWithValue("@estado", objAlumnoBE.estado);
                cmd.Parameters.AddWithValue("@usu_ult_mod", objAlumnoBE.usu_ult_mod);
                cmd.Parameters.AddWithValue("@fecha_ult_mod", objAlumnoBE.fecha_ult_mod);



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

        public Boolean EliminarAlumno(String strCodigo)
        {
           

            try
            {
				cnx.ConnectionString = MiConexion.GetCnx();
				cmd.Connection = cnx;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = "usp_eliminarAlumno";
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@codAlumno",strCodigo);				

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
