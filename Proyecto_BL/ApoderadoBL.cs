using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using ProyMatricula_ADO;
using ProyMatricula_BE;

namespace ProyMatricula_BL
{
    public  class Apoderado_BL
    {
       ApoderadoADO objApoderadoADO = new ApoderadoADO();

        public DataTable ListarApoderado()
        { 
           return objApoderadoADO .ListarApoderado ();
        }
        public Apoderado_BE ConsultarApoderado(Int16 strCodigo)
        {
            return objApoderadoADO.ConsultarApoderado (strCodigo );
        }

        public Boolean InsertarApoderado(Apoderado_BE objApoderadoBE)
        {
            return objApoderadoADO.InsertarApoderado(objApoderadoBE);
        }
        public Boolean ActualizarApoderado(Apoderado_BE objApoderadoBE)
        {
            return objApoderadoADO.ActualizarApoderado(objApoderadoBE);
        }
        public Boolean EliminarApoderado(String strCodigo)
        {
            return objApoderadoADO.EliminarApoderado(strCodigo);
        }
    }
}
