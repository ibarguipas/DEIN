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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BBDD_de_ivan
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection miConexionSql;
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["BBDD_de_ivan.Properties.Settings.travelPet_bbddConnectionString"].ConnectionString;
            
            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();
        }

        public void MuestraClientes()
        {
            string consulta = "SELECT * FROM Empleados;";
            SqlDataAdapter miadapatador = new SqlDataAdapter(consulta, miConexionSql);

            using (miadapatador)
            {
                DataTable empleados = new DataTable();
                miadapatador.Fill(empleados);

                listaEmpleados.ItemsSource = empleados.DefaultView;
            }
        }
        

    }
}
