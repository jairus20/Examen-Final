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
    /// Interaction logic for frmDocente.xaml
    /// </summary>
    public partial class frmDocente : Window
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        //Declarar Objeto
        static CapaNegocio.Docente docente = new CapaNegocio.Docente();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            // Asignar Propiedades

            // Just Text
            docente.Nombres = txtNombres.Text.Trim();
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();

            // Just Dates 
            docente.FechaNac = dtpFechaNac.DisplayDate;

            // Just Choices
            //---------------------
            if (cboLugarNac.SelectedIndex >= 1)
            {
                docente.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Selecciones una ciudad correcta");

            //---------------------
            if (cboEscuela.SelectedIndex >= 1)
            {
                docente.Profesion = cboEscuela.Text;
            }
            else MessageBox.Show("Selecciones una Profesion correcta");

            //---------------------
            if (cboNivelEdu.SelectedIndex >= 1)
            {
                docente.NivelEdu = cboNivelEdu.Text;
            }
            else MessageBox.Show("Selecciones un Nivel de Educacion correcta");

            // Confirmar cambios
            MessageBox.Show("Los datos del Docente fueron registrados correctamente", "Agregar Docente");

        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Codigo: " + docente.Codigo +
            "\nApellidos: " + docente.Apellidos +
            "\nNombres: " + docente.Nombres +
            "\nLugar de Nacimiento: " + docente.LugarNac +
            "\nFecha de nacimiento: " + docente.FechaNac.ToString() +
            "\nDomicilio: " + docente.Domicilio +
            "\nCorreo: " + docente.Correo +
            "\nSeguro: " + docente.Profesion +
            "\nSeguro: " + docente.NivelEdu , "Datos de Alumno Regular");
        }
    }
}
