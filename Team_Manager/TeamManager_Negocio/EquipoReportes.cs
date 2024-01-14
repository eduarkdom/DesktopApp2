using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager_Negocio;

namespace TeamManager_Negocio
{
    public class EquipoReportes
    {
        public int ObtenerCantidadEquiposMasculinos()
        {
            return Convert.ToInt32(CommonBC.EquipoModelo.spObtenerCantidadEquiposMasculinos().First().Value);
        }

        public int ObtenerCantidadEquiposFemeninos()
        {
            return Convert.ToInt32(CommonBC.EquipoModelo.spObtenerCantidadEquiposFemeninos().First().Value);
        }
    }
}
