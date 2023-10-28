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

namespace Navegación_de_Ivan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boton_Window1(object sender, RoutedEventArgs e)
        {
            Window1 Abrirventana1 = new Window1();
            this.Close();
            Abrirventana1.Show();
        }
        private void Boton_Window2(object sender, RoutedEventArgs e)
        {
            Window2 Abrirventana1 = new Window2();
            this.Close();
            Abrirventana1.Show();
        }

        private void Boton_Salir(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
