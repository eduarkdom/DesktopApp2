using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager_Negocio
{
    public class EquipoCollection
    {
        public List<Equipo> ReadAll()
        {
            try
            {
                var equiposFromDB = CommonBC.EquipoModelo.vwGetEquipos.ToList();

                return equiposFromDB.Select(equipoDB => new Equipo
                {
                    EquipoId = equipoDB.EquipoId,
                    NombreEquipo = equipoDB.NombreEquipo,
                    CantidadJugadores = equipoDB.CantidadJugadores,
                    NombreDT = equipoDB.NombreDT,
                    TipoEquipo = equipoDB.TipoEquipo,
                    CapitanEquipo = equipoDB.CapitanEquipo,
                    TieneSub21 = equipoDB.TieneSub21
                }).ToList();
            }
            catch (Exception)
            {
                return new List<Equipo>();
            }
        }
    }
}
