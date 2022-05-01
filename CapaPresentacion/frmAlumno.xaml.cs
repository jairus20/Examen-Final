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
    /// Interaction logic for frmAlumno.xaml
    /// </summary>
    public partial class frmAlumno : Window
    {
        public frmAlumno()
        {
            InitializeComponent();
        }


        private void btnIngresante_Click(object sender, RoutedEventArgs e)
        {
            // Llamar a formulario Docente
            frmIngresante frm = new frmIngresante();

            //Mostrar el fromulario
            frm.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Llamar a formulario Docente
            frmRegular frm = new frmRegular();

            //Mostrar el fromulario
            frm.Show();
        }
    }
}
