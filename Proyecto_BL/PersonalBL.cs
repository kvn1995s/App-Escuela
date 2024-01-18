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
    public class PersonalBL
    {
        PersonalADO objPersonalADO = new PersonalADO();

        public DataTable listarPersonal() { 
            return objPersonalADO.listarPersonal();
        }
    }
}
