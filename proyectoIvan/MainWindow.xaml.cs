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

namespace proyectoIvan
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


        private void Txt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textbox)
            {
                if (!String.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = "";
                }

            }
        }


        private void Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textbox)
            {
                if (String.IsNullOrWhiteSpace(textbox.Text))
                {
                    if (textbox.Name == "direccion")
                    {
                        textbox.Text = "¿A donde vas?";
                    }
                    
                }
            }

        }

        private void ChildComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainComboBox.SelectedIndex = 0; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Close();
        }
    }
}
