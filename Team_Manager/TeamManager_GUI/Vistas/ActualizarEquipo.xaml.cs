using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace TeamManager_GUI.Vistas
{
    public partial class ActualizarEquipo : Window
    {
        TeamManager_Negocio.Equipo equipo;
        public ActualizarEquipo(int id)
        {
            InitializeComponent();
            this.Title = string.Format("Actualizar Equipo {0}", id);
            
            equipo = new TeamManager_Negocio.Equipo();

            CargarDatosFormulario(id);
        }

        private void ActualizarEquipo_Click(object sender, RoutedEventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos para continuar.", "Campos Vacíos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            equipo.NombreEquipo = txtNombreEquipo.Text;
            equipo.CantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
            equipo.NombreDT = txtNombreDT.Text;
            equipo.TipoEquipo = cmbTipoEquipo.Text;
            equipo.CapitanEquipo = txtCapitanEquipo.Text;
            equipo.TieneSub21 = (chkTieneSub21.IsChecked.Value) ? true : false;

            bool response = equipo.Update();

            if (response)
            {
                MessageBox.Show(string.Format("Equipo {0} actualizado exitósamente!", equipo.NombreEquipo));
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("No se ha actualizado el equipo {0}", equipo.NombreEquipo));
                this.Close();
            }
        }
        private void CargarDatosFormulario(int id)
        {
            bool response = equipo.Read(id);
            if (response)
            {
                txtNombreEquipo.Text = equipo.NombreEquipo;
                txtCantidadJugadores.Text = equipo.CantidadJugadores.ToString();
                txtNombreDT.Text = equipo.NombreDT;
                cmbTipoEquipo.Text = equipo.TipoEquipo;
                txtCapitanEquipo.Text = equipo.CapitanEquipo;
                chkTieneSub21.IsChecked = (equipo.TieneSub21) ? true : false;
            }
            else
            {
                MessageBox.Show(string.Format("El Equipo {0} no fue encontrado.", id));
            }
        }

        private static Regex s_regex = new Regex("[^0-9]+");

        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }

        private bool CamposVacios()
        {
            return string.IsNullOrWhiteSpace(txtNombreEquipo.Text) ||
                   string.IsNullOrWhiteSpace(txtCantidadJugadores.Text) ||
                   string.IsNullOrWhiteSpace(txtNombreDT.Text) ||
                   cmbTipoEquipo.SelectedIndex == 0 ||
                   string.IsNullOrWhiteSpace(txtCapitanEquipo.Text);
        }
    }
}
