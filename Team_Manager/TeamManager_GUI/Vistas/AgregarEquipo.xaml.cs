using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TeamManager_GUI.Vistas
{
    public partial class AgregarEquipo : Window
    {
        private static Regex s_regex = new Regex("[^0-9]+");
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void AgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Por favor, complete todos los campos para continuar.", "Campos Vacíos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {

                TeamManager_Negocio.Equipo equipo = new TeamManager_Negocio.Equipo();
                equipo.NombreEquipo = txtNombreEquipo.Text;
                equipo.CantidadJugadores = Convert.ToInt32(txtCantidadJugadores.Text);
                equipo.NombreDT = txtNombreDT.Text;
                equipo.TipoEquipo = cmbTipoEquipo.Text;
                equipo.CapitanEquipo = txtCapitanEquipo.Text;
                equipo.TieneSub21 = (chkTieneSub21.IsChecked.Value) ? true : false;

                bool response = equipo.Create();

                if (response)
                {
                    MessageBox.Show("Equipo fue agregado correctamente");
                    AgregarOtroEquipo();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreEquipo.Text = string.Empty;
            txtCantidadJugadores.Text = null;
            txtNombreDT.Text = string.Empty;
            ((ComboBoxItem)cmbTipoEquipo.Items[0]).IsSelected = true;
            txtCapitanEquipo.Text = string.Empty;
            chkTieneSub21.IsChecked = false;
        }


        private void AgregarOtroEquipo()
        {
            string title = "Agregar nuevo Equipo";
            string message = "¿Desea agregar nuevo Equipo?";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show(message, title, buttons);

            if (result == MessageBoxResult.No)
            {
                this.Close();
            }
        }

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
