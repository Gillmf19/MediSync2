using System.Windows;

namespace MediSync.Views
{
    public partial class Proveedores : Window
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        // Evento que se dispara cuando se hace clic en el botón "Agregar Proveedor"
        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            // Abrir la ventana AgregarProveedor como modal
            AgregarProveedor ventanaAgregarProveedor = new AgregarProveedor();
            ventanaAgregarProveedor.ShowDialog();  // Usamos ShowDialog() para abrir como ventana modal
        }
    }
}
