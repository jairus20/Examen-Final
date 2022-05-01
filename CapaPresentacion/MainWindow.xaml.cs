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

namespace CapaPresentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal int saver;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAlumno_Click(object sender, RoutedEventArgs e)
        {
            
            // Llamar a formulario Alumno
            frmAlumno frm = new frmAlumno();

            //Mostrar el fromulario
            frm.Show();
        }

        private void btnDocente_Click(object sender, RoutedEventArgs e)
        {
            // Llamar a formulario Docente
            frmDocente frm = new frmDocente();

            //Mostrar el fromulario
            frm.Show();
        }

        private void btnAdministrativo_Click(object sender, RoutedEventArgs e)
        {
            // Llamar a formulario Administrativo
            frmAdministrativo frm = new frmAdministrativo();

            //Mostrar el fromulario
            frm.Show();
        }
    }
}
