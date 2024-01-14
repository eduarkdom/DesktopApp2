using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager_Negocio
{
    public static class CommonBC
    {
        private static TeamManager_DALC.PCEEntities _equipoModelo;

        public static TeamManager_DALC.PCEEntities EquipoModelo
        {
            get
            {
                if (_equipoModelo == null)
                {
                    _equipoModelo = new TeamManager_DALC.PCEEntities();
                }
                return _equipoModelo;
            }
        }
    }
}