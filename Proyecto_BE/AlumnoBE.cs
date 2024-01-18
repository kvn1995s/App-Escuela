using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyAlumnos_BE
{
    public class AlumnoBE
    {
        // Definimos la entidad Alumno, con todas las propiedades de acuerdo a la estructura 
        // de la tabla Tb_alumno
        public Int16 codAlumno { get; set; }
        public Int16 codDistrito { get; set; }
        public Int16 codApoderado { get; set; }
        public String nombres { get; set; }
        public String apePaterno { get; set; }
        public String apeMaterno { get; set; }
        public String dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String direccionAlum { get; set; }
		public Byte[]? foto { get; set; }
		public String telefono { get; set; }
        public Int16 codUsuario { get; set; }	
		public DateTime fecha_registro { get; set; }
        public String usu_registro { get; set; }
		public String usu_ult_mod { get; set; }
		public DateTime fecha_ult_mod { get; set; }
		public Int16 estado { get; set; }
	}
}
