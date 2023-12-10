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

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListaEmpleadosClick(object sender, RoutedEventArgs e)
        {
            ListaEmpleados lista = new ListaEmpleados();
            lista.Show();
            this.Close(); // Close the current window if needed
        }

        private void AgregarEmpleadosClick(object sender, RoutedEventArgs e)
        {
            AgregarEmpleado agre = new AgregarEmpleado();
            agre.Show();
            this.Close(); // Close the current window if needed
        }
    }
}
