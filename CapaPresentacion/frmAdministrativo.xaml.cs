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

namespace CapaPresentacion
{
    /// <summary>
    /// Interaction logic for frmAdministrativo.xaml
    /// </summary>
    public partial class frmAdministrativo : Window
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }

        //Declarar Objeto
        static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            // Asignar Propiedades

            // Just Text
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            administrativo.Experiencia = txtExperiencia.Text.Trim();

            // Just Dates 
            administrativo.FechaNac = dtpFechaNac.DisplayDate;

            // Just Choices
            //---------------------
            if (cboLugarNac.SelectedIndex >= 1)
            {
                administrativo.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Selecciones una ciudad correcta");

            // Confirmar cambios
            MessageBox.Show("Los datos de el Administrado fueron registrados correctamente", "Agregar Administrativo");


        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            {
                MessageBox.Show(
                "Codigo: " + administrativo.Codigo +
                "\nApellidos: " + administrativo.Apellidos +
                "\nNombres: " + administrativo.Nombres +
                "\nLugar de Nacimiento: " + administrativo.LugarNac +
                "\nFecha de nacimiento: " + administrativo.FechaNac.ToString() +
                "\nDomicilio: " + administrativo.Domicilio +
                "\nCorreo: " + administrativo.Correo +
                "\nSeguro: " + administrativo.Experiencia, "Datos de Administrativo");
            }
        }
    }
}
