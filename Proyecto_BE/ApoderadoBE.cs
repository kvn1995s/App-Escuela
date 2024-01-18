using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyMatricula_BE
{
    public class Apoderado_BE
    {
        // Definimos la entidad de negocio Producto, con todas las propiedades de acuerdo a la estructura 
        // de la tabla apoderadoto
        public Int16 codApoderado { get; set; }
        public String nombres { get; set; }
        public String  apePaterno { get; set; }
        public String apeMaterno { get; set; }
        public String  dni { get; set; }
        public DateTime fechaNac { get; set; }
        public String  direccionApod { get; set; }
        public string telefono { get; set; }
        public Byte[]? Foto_Apo { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public Int16 Est_pro { get; set; }

    }
}
