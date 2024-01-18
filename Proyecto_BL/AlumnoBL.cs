using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using ProyAlumADO;
using ProyAlumnos_BE;

namespace ProyAlumnosBL
{
    public  class AlumnoBL
    {
        AlumnoADO objAlumnoADO = new AlumnoADO();

		public DataTable ListarUsuario()
		{
			return objAlumnoADO.ListarUsuario();
		}
		public DataTable ListarApoderado()
		{
			return objAlumnoADO.ListarApoderado();
		}
		public DataTable ListarAlumno()
        {
            return objAlumnoADO.ListarAlumnos();
        }
		public DataTable ListarDistritos()
		{
			return objAlumnoADO.ListarDistritos();
		}
		public AlumnoBE ConsultarAlumno(Int16 strCodigo)
        {
            return objAlumnoADO.ConsultarAlumno(strCodigo );
        }

        public Boolean InsertarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.InsertarAlumno(objAlumnoBE);
        }
        public Boolean ActualizarAlumno(AlumnoBE objAlumnoBE)
        {
            return objAlumnoADO.ActualizarAlumno(objAlumnoBE);
        }
        public Boolean EliminarAlumno(String strCodigo)
        {
            return objAlumnoADO.EliminarAlumno(strCodigo);
        }
    }
}
