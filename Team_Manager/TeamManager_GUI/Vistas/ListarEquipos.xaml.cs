using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TeamManager_Negocio;

namespace TeamManager_GUI.Vistas
{
    public partial class ListarEquipos : Window
    {
        TeamManager_Negocio.EquipoCollection equipoCollection;
        public ListarEquipos()
        {
            InitializeComponent();
            CargarGrilla();

        }
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            var filaSeleccionada = (TeamManager_Negocio.Equipo)dgListadoEquipos.SelectedItem;
            ActualizarEquipo actualizarEquipo = new ActualizarEquipo(filaSeleccionada.EquipoId);
            actualizarEquipo.ShowDialog();
        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            var filaSeleccionada = (TeamManager_Negocio.Equipo)dgListadoEquipos.SelectedItem;
            string nombreEquipo = filaSeleccionada.NombreEquipo;
            int id = filaSeleccionada.EquipoId;
            string title = "Eliminar Equipo";
            string message = string.Format("¿Estás seguro de eliminar el Equipo {0} ?", nombreEquipo);

            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.Yes)
            {
                var res = filaSeleccionada.Delete(id) ?
                    MessageBox.Show(string.Format("Equipo {0} eliminado", nombreEquipo)) :
                    MessageBox.Show(string.Format("Equipo {0} no ha sido eliminado", nombreEquipo));
            }
        }
        

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            equipoCollection = new TeamManager_Negocio.EquipoCollection();
            dgListadoEquipos.ItemsSource = equipoCollection.ReadAll();
        }
    }
}
