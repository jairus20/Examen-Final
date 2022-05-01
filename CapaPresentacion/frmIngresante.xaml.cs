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
    /// Interaction logic for frmIngresante.xaml
    /// </summary>
    public partial class frmIngresante : Window
    {
        public frmIngresante()
        {
            InitializeComponent();
        }
        static CapaNegocio.Ingresante ingresante = new CapaNegocio.Ingresante();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            // Asignar Propiedades

            // Just Text
            ingresante.Nombres = txtNombres.Text.Trim();
            ingresante.Apellidos = txtApellidos.Text.Trim();
            ingresante.Codigo = txtCodigo.Text.Trim();
            ingresante.Correo = txtCorreo.Text.Trim();
            ingresante.Domicilio = txtDomicilio.Text.Trim();
            ingresante.Seguro = txtSeguro.Text.Trim();
            ingresante.PuestoExamenIn = txtPuestoIn.Text.Trim();

            // Just Dates 
            ingresante.FechaNac = dtpFechaNac.DisplayDate;

            // Just Choices
            //---------------------
            if (cboLugarNac.SelectedIndex >= 1)
            {
                ingresante.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Selecciones una ciudad correcta");

            //---------------------
            if (cboEscuela.SelectedIndex >= 1)
            {
                ingresante.Escuela = cboEscuela.Text;
            }
            else MessageBox.Show("Selecciones una Escuela correcta");

            //---------------------
            if (cboMetodoIn.SelectedIndex >= 1)
            {
                ingresante.MetodoIngreso = cboMetodoIn.Text;
            }
            else MessageBox.Show("Selecciones un Metodo correcto");

            // Confirmar cambios
            MessageBox.Show("Los datos del Alumno Ingresante fueron registrados correctamente", "Agregar Alumno Igresante");

        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Codigo: " + ingresante.Codigo +
                "\nApellidos: " + ingresante.Apellidos +
                "\nNombres: " + ingresante.Nombres +
                "\nLugar de Nacimiento: " + ingresante.LugarNac +
                "\nFecha de nacimiento: " + ingresante.FechaNac.ToString() +
                "\nDomicilio: " + ingresante.Domicilio +
                "\nSeguro: " + ingresante.Seguro +
                "\nCorreo: " + ingresante.Correo +
                "\nEscuela: " + ingresante.Escuela +
                "\nMetodo de Ingreso: " + ingresante.MetodoIngreso +
                "\nPuesto Examen de Ingreso: " + ingresante.PuestoExamenIn , "Datos de Alumno Ingresante");

        }
    }
}
