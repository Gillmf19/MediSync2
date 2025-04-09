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

namespace MediSync.Views
{
    /// <summary>
    /// Lógica de interacción para AgregarProducto.xaml
    /// </summary>
    public partial class AgregarProducto : Window
    {
        // Add this property to track if a product was added
        public bool ProductoAgregado { get; private set; } = false;
        public AgregarProducto()
        {
            InitializeComponent();
        }
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs here
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                cbCategoria.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // If validation passes
            ProductoAgregado = true;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            ProductoAgregado = false;
            this.Close();
        }
    }
}
