using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MediSync.Views
{
    public partial class Requerimientos : Window
    {
        // ObservableCollection para los requerimientos
        public ObservableCollection<Requerimiento> RequerimientosList { get; set; }

        public Requerimientos()
        {
            InitializeComponent();
            RequerimientosList = new ObservableCollection<Requerimiento>
            {
                new Requerimiento { Id = 1, Status = "Pendiente", Producto = "Producto A", Descripcion = "Descripción A", Locacion = "Ubicación 1", Cantidad = 10, Tipo = "Tipo 1", Fecha = DateTime.Now },
                new Requerimiento { Id = 2, Status = "En Proceso", Producto = "Producto B", Descripcion = "Descripción B", Locacion = "Ubicación 2", Cantidad = 20, Tipo = "Tipo 2", Fecha = DateTime.Now },
                new Requerimiento { Id = 3, Status = "Completado", Producto = "Producto C", Descripcion = "Descripción C", Locacion = "Ubicación 3", Cantidad = 30, Tipo = "Tipo 3", Fecha = DateTime.Now }
                // Agrega más datos de prueba si lo necesitas
            };

            // Vincula los datos al DataGrid
            dgMovimientos.ItemsSource = RequerimientosList;
        }

        // Evento para el botón Filtrar
        private void BtnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener los valores de los filtros
            string status = ((ComboBoxItem)ComboBoxStatus.SelectedItem)?.Content.ToString();
            string idPedido = TextBoxPedidoID.Text;
            string usuario = TextBoxUsuario.Text;

            // Filtrar los datos
            var filtrados = RequerimientosList.AsEnumerable();

            // Filtrar por Status
            if (status != "Todos")
            {
                filtrados = filtrados.Where(r => r.Status == status);
            }

            // Filtrar por ID de Pedido (si el valor no está vacío)
            if (!string.IsNullOrEmpty(idPedido))
            {
                if (int.TryParse(idPedido, out int id))
                {
                    filtrados = filtrados.Where(r => r.Id == id);
                }
                else
                {
                    MessageBox.Show("ID de Pedido inválido.");
                    return;
                }
            }

            // Filtrar por Usuario (si el valor no está vacío)
            // Puedes adaptar este filtro según tus necesidades
            if (!string.IsNullOrEmpty(usuario))
            {
                // Asumiendo que tienes lógica para asociar un usuario con el requerimiento
                // Esto depende de cómo manejes la información del usuario. Para este ejemplo,
                // lo estamos dejando como un filtro simple.
                filtrados = filtrados.Where(r => r.Producto.Contains(usuario)); // Solo un ejemplo
            }

            // Actualizar el DataGrid con los resultados filtrados
            dgMovimientos.ItemsSource = new ObservableCollection<Requerimiento>(filtrados);
        }

        // Evento para el cambio de selección en el DataGrid (si es necesario)
        private void DgMovimientos_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Lógica para manejar la selección de un ítem del DataGrid, si es necesario
        }
    }

    // Modelo de Requerimiento
    public class Requerimiento
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public string Locacion { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
    }
}

