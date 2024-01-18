using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BE
{
    public class PersonalBE
    {
        public Int16 codPersonal { get; set; }
        public String nombres { get; set; }
        public String apePaterno { get; set; }
        public String apeMaterno { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String dniPersonal { get; set; }
        public DateTime fechaIngreso { get; set; }
        public String telfPersonal { get; set; }
        public Int16 sueldo { get; set; }
        public Int16 codUsuario { get; set; }
    }
}
