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
    /// Interaction logic for frmRegular.xaml
    /// </summary>
    public partial class frmRegular : Window
    {
        public frmRegular()
        {
            InitializeComponent();
        }

        //Declarar objeto
        static CapaNegocio.Regular regular = new CapaNegocio.Regular();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            // Asignar Propiedades

            // Just Text
            regular.Nombres = txtNombres.Text.Trim();
            regular.Apellidos = txtApellidos.Text.Trim();
            regular.Codigo = txtCodigo.Text.Trim();
            regular.Correo = txtCorreo.Text.Trim();
            regular.Domicilio = txtDomicilio.Text.Trim();
            regular.Seguro = txtSeguro.Text.Trim();

            // Just Numbers
            regular.Creditos = int.Parse(txtCreditos.Text);
            regular.CursosDesaprobados = int.Parse(txtCursosDes.Text);
            regular.CursosAprobados = int.Parse(txtCursosApr.Text);

            // Just Dates 
            regular.FechaNac = dtpFechaNac.DisplayDate;

            // Just Choices
            //---------------------
            if (cboLugarNac.SelectedIndex >= 1)
            {
                regular.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Selecciones una ciudad correcta");

            //---------------------
            if (cboEscuela.SelectedIndex >= 1)
            {
                regular.Escuela = cboEscuela.Text;
            }
            else MessageBox.Show("Selecciones una Escuela correcta");

            //---------------------
            if (cboSemestre.SelectedIndex >= 1)
            {
                regular.NumSemestre = int.Parse(cboSemestre.Text);
            }
            else MessageBox.Show("Selecciones un Semestre correcto");

            // Confirmar cambios
            MessageBox.Show("Los datos del Alumno Regular fueron registrados correctamente", "Agregar Alumno Regular");

        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Codigo: " + regular.Codigo +
                "\nApellidos: " + regular.Apellidos +
                "\nNombres: " + regular.Nombres +
                "\nLugar de Nacimiento: " + regular.LugarNac +
                "\nFecha de nacimiento: " + regular.FechaNac.ToString() +
                "\nDomicilio: " + regular.Domicilio +
                "\nSeguro: " + regular.Seguro +
                "\nCorreo: " + regular.Correo +
                "\nEscuela: " + regular.Escuela +
                "\nSemestre: " + regular.NumSemestre +
                "\nCreditos: " + regular.Creditos +
                "\nCursos Aprobados: " + regular.CursosAprobados+
                "\nCursos Desaprobados: " + regular.CursosAprobados, "Datos de Alumno Regular");
        }
    }
}
