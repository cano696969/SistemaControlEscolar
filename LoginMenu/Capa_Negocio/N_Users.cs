using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class N_Users
    {

        D_Users objd = new D_Users();

        public DataTable N_user(E_Users obje) 
        {
            return objd.D_user(obje);
        }

    }
}
