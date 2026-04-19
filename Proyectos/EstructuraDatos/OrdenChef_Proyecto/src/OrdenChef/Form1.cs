using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenChef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // VALIDACION DE SECCIONES DELEGACION Y RESTAURANTE 
            if (string.IsNullOrWhiteSpace(cmbDelegacion.Text))
            {
                MessageBox.Show("Por favor, selecciona una delegación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRestaurante.Text))
            {
                MessageBox.Show("Por favor, selecciona un restaurante.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el id del restaurante seleccionado
            int idRestaurante = -1;
            string conexion = "Server=Yami\\SQLEXPRESS;Database=OrdenChefDB;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT TOP 1 IdRestaurante FROM Restaurantes WHERE Nombre = @nombre AND Delegacion = @delegacion";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", cmbRestaurante.Text);
                    cmd.Parameters.AddWithValue("@delegacion", cmbDelegacion.Text);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idRestaurante = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el restaurante seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            var form2 = new OrdenChef.Form2(cmbDelegacion.Text, idRestaurante, cmbRestaurante.Text);
            form2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CARGA DE DATOS AL COMBOBOX DE DELEGACIONES
            string conexion = "Server=Yami\\SQLEXPRESS;Database=OrdenChefDB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = "SELECT DISTINCT Delegacion FROM Restaurantes";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDelegacion.DataSource = dt;
                cmbDelegacion.DisplayMember = "Delegacion";

                cmbDelegacion.SelectedIndex = -1;
            }

            //SE CARGAN RESTAURANTES HASTA QUE TENGA UNA DELEGACION SELECCIONADA
            cmbRestaurante.DataSource = null;
            cmbRestaurante.Items.Clear();
            cmbRestaurante.Text = string.Empty;
        }

        private void LoadRestaurantesPorDelegacion(string delegacion)
        {
            if (string.IsNullOrWhiteSpace(delegacion))
            {
                cmbRestaurante.DataSource = null;
                cmbRestaurante.Items.Clear();
                cmbRestaurante.Text = string.Empty;
                return;
            }

            string conexion = "Server=Yami\\SQLEXPRESS;Database=OrdenChefDB;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                //CONSULTA SQL PARA RESTAURANTES POR DELEGACION
                string query = "SELECT DISTINCT Nombre FROM Restaurantes WHERE Delegacion = @delegacion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@delegacion", delegacion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbRestaurante.DataSource = dt;
                    cmbRestaurante.DisplayMember = "Nombre";
                    cmbRestaurante.SelectedIndex = -1;
                }
            }
        }

        private void cmbRestaurante_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbDelegacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string delegacionSeleccionada = null;

            if (cmbDelegacion.SelectedItem is DataRowView drv)
            {
                delegacionSeleccionada = drv["Delegacion"]?.ToString();
            }
            else
            {
                delegacionSeleccionada = cmbDelegacion.Text;
            }

            LoadRestaurantesPorDelegacion(delegacionSeleccionada);
        }
    }
}
