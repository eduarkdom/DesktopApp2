using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager_Negocio
{
    public class Equipo : IPersistente
    {
        public int EquipoId { get; set; }
        public string NombreEquipo { get; set; }
        public int CantidadJugadores { get; set; }
        public string NombreDT { get; set; }
        public string TipoEquipo { get; set; }
        public string CapitanEquipo { get; set; }
        public bool TieneSub21 { get; set; }

        public bool Create()
        {
            try
            {
                CommonBC.EquipoModelo.spEquipoSave(
                    NombreEquipo,
                    CantidadJugadores,
                    NombreDT,
                    TipoEquipo,
                    CapitanEquipo,
                    TieneSub21
                );

                CommonBC.EquipoModelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read(int id)
        {
            try
            {
                TeamManager_DALC.vwGetEquipos equipo = CommonBC.EquipoModelo.vwGetEquipos.First(e => e.EquipoId == id);

                EquipoId = equipo.EquipoId;
                NombreEquipo = equipo.NombreEquipo;
                CantidadJugadores = equipo.CantidadJugadores;
                NombreDT = equipo.NombreDT;
                TipoEquipo = equipo.TipoEquipo;
                CapitanEquipo = equipo.CapitanEquipo;
                TieneSub21 = equipo.TieneSub21;

                return true;
                
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Update()
        {
            try
            {
                CommonBC.EquipoModelo.spEquipoUpdateById(
                    EquipoId,
                    NombreEquipo,
                    CantidadJugadores,
                    NombreDT,
                    TipoEquipo,
                    CapitanEquipo,
                    TieneSub21
                );

                CommonBC.EquipoModelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                CommonBC.EquipoModelo.spEquipoDeleteById(id);

                CommonBC.EquipoModelo.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}