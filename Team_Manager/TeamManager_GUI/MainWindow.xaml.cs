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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TeamManager_Negocio;

namespace TeamManager_GUI
{
    public partial class MainWindow : Window
    {
        TeamManager_Negocio.EquipoCollection equipoCollection;
        TeamManager_Negocio.EquipoReportes equipoReportes;

        public MainWindow()
        {
            InitializeComponent();
            equipoCollection = new TeamManager_Negocio.EquipoCollection();
            CargarGrilla();
        }

        private void AgregarEquipo_Click(object sender, RoutedEventArgs e)
        {

            Vistas.AgregarEquipo agregarEquipo = new Vistas.AgregarEquipo();
            agregarEquipo.ShowDialog();
        }

        private void ListarEquipos_Click(object sender, RoutedEventArgs e)
        {

            Vistas.ListarEquipos listarEquipos = new Vistas.ListarEquipos();
            listarEquipos.ShowDialog();
        }

        private void optReportes_Click(object sender, RoutedEventArgs e)
        {
            equipoReportes = new TeamManager_Negocio.EquipoReportes();
            int equiposMasculinos = equipoReportes.ObtenerCantidadEquiposMasculinos();
            int equiposFemeninos = equipoReportes.ObtenerCantidadEquiposFemeninos();
            string message = string.Format(
                "Cantidad de Equipos Masculinos: {0} \n" +
                "Cantidad de Equipos Femeninos: {1}",
                equiposMasculinos,
                equiposFemeninos
            );
            MessageBox.Show(message);
        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            Vistas.AcercaDe acercaDe = new Vistas.AcercaDe();
            acercaDe.ShowDialog();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgListadoEquipos.ItemsSource = equipoCollection.ReadAll();
        }

    }
}
