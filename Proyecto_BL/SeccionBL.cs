using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_ADO;
using Proyecto_BE;

namespace Proyecto_BL
{
    public class SeccionBL
    {
        SeccionADO objSeccionADO = new SeccionADO();

        public DataTable ListarSeccion() { 
            return objSeccionADO.ListarSeccion();
        }

        public SeccionBE ConsultarSeccion(Int16 strCodSec) {
            return objSeccionADO.ConsultarSeccion(strCodSec);
        }

        public Boolean InsertarSeccion(SeccionBE objSeccionBE) { 
            return objSeccionADO.InsertarSeccion(objSeccionBE);
        }

        public Boolean ActualizarSeccion(SeccionBE objSeccionBE) {
            return objSeccionADO.ActualizarSeccion(objSeccionBE);
        }

        public Boolean EliminarSeccion(Int16 strCodSec) { 
            return objSeccionADO.EliminarSeccion(strCodSec);
        }
    }
}
