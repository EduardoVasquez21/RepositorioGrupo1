using Ejercicio_Grupo_1.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Grupo_1.DAO
{
    class Class1
    {
        public List<Tbl_Datos1> cargarDatosUserlist()
        {
            List<Tbl_Datos1> Lista;


            using (Grupo1Entities  db = new Grupo1Entities())
            {
                Lista = db.Tbl_Datos1.ToList();


            }
            return Lista;
        }
    }
}
