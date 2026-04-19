using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrdenChef
{
    public partial class Form3 : Form
    {
        private readonly List<Tuple<string, decimal>> carritoSeleccionado;

        //CONSTRUCTOR
        public Form3(string delegacion, int idRestaurante, string nombreRestaurante, List<Tuple<string, decimal>> carrito)
        {
            InitializeComponent();

            carritoSeleccionado = carrito ?? new List<Tuple<string, decimal>>();

            // INFO
            this.Text = $"Pedido - {nombreRestaurante}";

            // LLENA LISTBOX
            lstPedido.Items.Clear();
            decimal total = 0m;
            foreach (var item in carritoSeleccionado)
            {
                lstPedido.Items.Add($"{item.Item1} - ${item.Item2:0.00}");
                total += item.Item2;
            }

            // LISTADO Y TOTAL
            if (carritoSeleccionado.Count > 0)
            {
                lstPedido.Items.Add("");
                lstPedido.Items.Add($"Total: ${total:0.00}");
            }
        }
    }
}
