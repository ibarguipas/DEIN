using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para AgregarEmpleado.xaml
    /// </summary>
    public partial class AgregarEmpleado : Window
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            int id = 10;
            id++;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            bool esUsuario = chkEsUsuario.IsChecked ?? false;
            int edad;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                AgregarEmpleadoString(id, nombre, apellidos, esUsuario, edad);

                // Cerramos la ventana actual después de agregar el empleado
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una edad válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AgregarEmpleadoString(int id, string nombre, string apellidos, bool esUsuario, int edad)
        {
            string consulta = "INSERT INTO EMPLEADOS (Nombre, Apellidos, EsUsuario, Edad) VALUES (@Id, @Nombre, @Apellidos, @EsUsuario, @Edad)";

            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {


                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@EsUsuario", esUsuario);
                    cmd.Parameters.AddWithValue("@Edad", edad);

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar empleado: " + ex.Message);
                    }
                }
            }
        }

    }

    
    
}
