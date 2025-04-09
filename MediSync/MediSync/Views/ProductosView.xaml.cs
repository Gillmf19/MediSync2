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

namespace MediSync.Views
{
    /// <summary>
    /// Lógica de interacción para ProductosView.xaml
    /// </summary>
    public partial class ProductosView : UserControl
    {
        public ProductosView()
        {
            InitializeComponent();
        }


        private void AgregarProductoButton_Click(object sender, RoutedEventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog(); // Use ShowDialog to wait for the window to close

            if (agregarProducto.ProductoAgregado)
            {
                // Refresh your product list or do whatever you need
                MessageBox.Show("Producto agregado exitosamente!");
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }
        }
    }
}