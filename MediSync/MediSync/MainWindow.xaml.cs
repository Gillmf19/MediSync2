using MediSync.Views;
using System.Windows;

namespace MediSync
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

        // Evento para el botón "Movimientos"
        private void MovimientosButton_Click(object sender, RoutedEventArgs e)
        {
            Movimientos movimientosWindow = new Movimientos();  // Asegúrate que la clase Movimientos existe
            movimientosWindow.Show();
        }

        // Evento para el botón "Productos"
        private void ProductosButton_Click(object sender, RoutedEventArgs e)
        {
            Productos productosWindow = new Productos();  // Asegúrate que la clase Productos existe
            productosWindow.Show();
        }

        // Evento para el botón "Proveedores"
        private void ProveedoresButton_Click(object sender, RoutedEventArgs e)
        {
            Proveedores proveedoresWindow = new Proveedores();  // Asegúrate que la clase Proveedores existe
            proveedoresWindow.Show();
        }

        // Evento para el botón "Categorías"
        private void CategoriasButton_Click(object sender, RoutedEventArgs e)
        {
            Categorias categoriasWindow = new Categorias();  // Asegúrate que la clase Categorias existe
            categoriasWindow.Show();
        }

        // Evento para el botón "Roles"
        private void RolesButton_Click(object sender, RoutedEventArgs e)
        {
            Roles rolesWindow = new Roles();  // Asegúrate que la clase Roles existe
            rolesWindow.Show();
        }
    }
}
