using Microsoft.Win32;
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

namespace Formularios_de_Ivan
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

        private void SeleccionarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string rutaImagen = openFileDialog.FileName;

                // Cargar la imagen seleccionada en el control Image
                BitmapImage imagenBitmap = new BitmapImage(new Uri(rutaImagen));
                imagenPrevia.Source = imagenBitmap;
            }
        }

        private void boton_cancelar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nuevaVentana = new MainWindow();
            nuevaVentana.Show();
            this.Close();
        }

        private void boton_guardar_Click(object sender, RoutedEventArgs e)
        {


            if (name.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Error");
            }
            else if (surname.Text == "")
            {
                MessageBox.Show("El campo Apellidos no puede estar vacío", "Error");
            }
            else if (email.Text == "")
            {
                MessageBox.Show("El campo E-mail no puede estar vacío", "Error");
            }
            else if (phoneNumber.Text == "")
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío", "Error");
            }
            else
            {
                Empleado nuevoEmpleado = new Empleado(name.Text, surname.Text, email.Text, phoneNumber.Text);


                datagrid.Items.Add(nuevoEmpleado);
            }


        }







        public class Empleado
        {
            public string nombre { get; set; }
            public string apellidos { get; set; }
            public string email { get; set; }
            public string telefono { get; set; }

            public Empleado(string nombre, string apellidos, string email, string telefono)
            {
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.email = email;
                this.telefono = telefono;
            }
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
                        textbox.Text = "Dirección";
                    }
                    else if (textbox.Name == "ciudad")
                    {
                        textbox.Text = "Ciudad";
                    }
                    else if (textbox.Name == "provincia")
                        textbox.Text = "Provincia";
                    else if (textbox.Name == "CP")
                        textbox.Text = "Código Postal";
                    else if (textbox.Name == "pais")
                        textbox.Text = "País";
                }
            }
        }

    }
}
