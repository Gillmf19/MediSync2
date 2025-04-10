using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MediSync.Views
{
    public partial class Movimientos : Window
    {
        // Lista simulada de movimientos
        private List<Movimiento> movimientos;

        public Movimientos()
        {
            InitializeComponent();

            // Inicializar los datos de prueba (simulando datos de la base de datos)
            movimientos = new List<Movimiento>
            {
                new Movimiento { Id = 1, Producto = "Producto A", Generado = "Usuario1", Cantidad = 10, Locacion = "Bodega 1", Status = "Pendiente", Fecha = DateTime.Now.AddDays(-1) },
                new Movimiento { Id = 2, Producto = "Producto B", Generado = "Usuario2", Cantidad = 5, Locacion = "Bodega 2", Status = "En Proceso", Fecha = DateTime.Now.AddDays(-2) },
                new Movimiento { Id = 3, Producto = "Producto C", Generado = "Usuario3", Cantidad = 20, Locacion = "Bodega 3", Status = "Completado", Fecha = DateTime.Now.AddDays(-3) }
            };

            // Asignar la lista de movimientos al DataGrid
            dgMovimientos.ItemsSource = movimientos;
        }

        // Método para simular la búsqueda de movimientos (filtrando por producto o generado)
        private void BuscarMovimientos(string filtro)
        {
            // Filtrar los movimientos simulados
            var resultado = movimientos.Where(m => m.Producto.Contains(filtro) || m.Generado.Contains(filtro)).ToList();

            // Asignar los resultados al DataGrid
            dgMovimientos.ItemsSource = resultado;
        }

        // Evento al cambiar el texto en el campo de búsqueda
        private void TxtBuscarMovimiento_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filtro = txtBuscarMovimiento.Text;
            BuscarMovimientos(filtro);
        }

        // Evento al hacer clic en el botón "Buscar"
        private void BtnRegistrarMovimiento_Click(object sender, RoutedEventArgs e)
        {
            var filtro = txtBuscarMovimiento.Text;
            BuscarMovimientos(filtro);
        }

        // Evento cuando se selecciona un movimiento en la tabla
        private void DgMovimientos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var movimientoSeleccionado = (Movimiento)dgMovimientos.SelectedItem;
            if (movimientoSeleccionado != null)
            {
                MessageBox.Show("Movimiento seleccionado con ID: " + movimientoSeleccionado.Id);
            }
        }
    }

    // Clase Movimiento para simular los datos
    public class Movimiento
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public string Generado { get; set; }
        public int Cantidad { get; set; }
        public string Locacion { get; set; }
        public string Status { get; set; }
        public DateTime Fecha { get; set; }
    }
}

