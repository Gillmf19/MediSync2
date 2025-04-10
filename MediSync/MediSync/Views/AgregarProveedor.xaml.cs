using System.Windows;
using System.Data.SqlClient;

namespace MediSync.Views
{
    public partial class AgregarProveedor : Window
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        // Evento que maneja el clic del botón "Guardar"
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica para guardar los datos del proveedor (en una base de datos, lista, etc.)
            string nombre = txtNombre.Text;
            string contacto = txtContacto.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;

            // Mostrar un mensaje o procesar los datos aquí.

            // Cerrar la ventana después de guardar los datos.
            this.Close();
        }

        // Evento que maneja el clic del botón "Cancelar"
        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void txtContacto_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
