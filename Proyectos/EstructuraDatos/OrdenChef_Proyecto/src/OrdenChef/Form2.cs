using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrdenChef
{
    public partial class Form2 : Form
    {
        // CARRITO GUARDA NOMBRE Y PRECIO
        private List<Tuple<string, decimal>> miCarrito = new List<Tuple<string, decimal>>();

        //DATOS
        private string delegacionSeleccionada;
        private int idRestaurante;
        private string nombreRestaurante;

        string conexion = "Server=Yami\\SQLEXPRESS;Database=OrdenChefDB;Trusted_Connection=True;";

        //CONSTRUCTOR
        public Form2(string delegacion, int idRestaurante, string nombreRestaurante)
        {
            InitializeComponent();

            this.delegacionSeleccionada = delegacion;
            this.idRestaurante = idRestaurante;
            this.nombreRestaurante = nombreRestaurante;
        }

        // CARGA FORM
        private void Form2_Load(object sender, EventArgs e)
        {
            // MOSTRAR RESTAURANTE
            txtRestaurantAactual.Text = nombreRestaurante;

            lblContador.Text = "Carrito: 0";

            // CARGA MENU
            LoadMenuPorRestaurante(idRestaurante);
        }

        // CARGAR PRODUCTO
        private void LoadMenuPorRestaurante(int id)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = @"
            SELECT NombreProducto, Precio
            FROM Productos
            WHERE IdRestaurante = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //CREAR COLUMNAS
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns.Clear();

                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn {
                        Name = "NombreProducto",
                        HeaderText = "Producto",
                        DataPropertyName = "NombreProducto"
                    });
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn {
                        Name = "Precio",
                        HeaderText = "Precio",
                        DataPropertyName = "Precio"
                    });
                    if (!dataGridView1.Columns.Contains("btnAgregar")) {
                        dataGridView1.Columns.Add(new DataGridViewButtonColumn {
                            Name = "btnAgregar",
                            HeaderText = "Acción",
                            Text = "Agregar",
                            UseColumnTextForButtonValue = true
                        });
                    }

                    dataGridView1.DataSource = dt;
                }
            }
        }

//CARRITO
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var columna = dataGridView1.Columns[e.ColumnIndex];
            if (columna == null || columna.Name != "btnAgregar") return;

            var valor = dataGridView1.Rows[e.RowIndex].Cells["NombreProducto"].Value;
            if (valor == null) return;

            string nombreProducto = valor.ToString();

            decimal precio = 0m;
            var valorPrecio = dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value;
            if (valorPrecio != null)
            {
                decimal.TryParse(valorPrecio.ToString(), out precio);
            }

            miCarrito.Add(Tuple.Create(nombreProducto, precio));
            lblContador.Text = $"Carrito: {miCarrito.Count}";
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtRestaurantAactual_TextChanged(object sender, EventArgs e)
        {
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            //PASA CARRITO A FORM 3
            var form3 = new OrdenChef.Form3(delegacionSeleccionada, idRestaurante, nombreRestaurante, new List<Tuple<string, decimal>>(miCarrito));

            //ABRE FORM 3
            form3.Show();
            this.Hide();
        }
    }
}