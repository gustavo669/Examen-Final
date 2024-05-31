using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final.Data
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;                               
        private string connectionString = "server=localhost;user=root;password=1234;database=examenfinalcrud";

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM animes";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string nombre = Nombre.Text;
                string genero = Genero.Text;
                string plataforma = Plataforma.Text;
                DateTime fechaLanzamiento = FechaLanzamiento.Value;
                decimal precio = Precio.Value;
                bool disponible = Disponible.Checked;

                string query = "INSERT INTO animes (Nombre, Genero, Plataforma, FechaLanzamiento, Precio, Disponible) VALUES (@nombre, @genero, @plataforma, @fechaLanzamiento, @precio, @disponible)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@genero", genero);
                command.Parameters.AddWithValue("@plataforma", plataforma);
                command.Parameters.AddWithValue("@fechaLanzamiento", fechaLanzamiento);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@disponible", disponible);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Anime Agregado correctamente.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el anime: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (ValidateInput())
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    string nombre = Nombre.Text;
                    string genero = Genero.Text;
                    string plataforma = Plataforma.Text;
                    DateTime fechaLanzamiento = FechaLanzamiento.Value;
                    decimal precio = Precio.Value;
                    bool disponible = Disponible.Checked;

                    if (MessageBox.Show("¿Estás seguro de que deseas actualizar este registro?", "Confirmar actualización", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string query = "UPDATE animes SET Nombre = @nombre, Genero = @genero, Plataforma = @plataforma, FechaLanzamiento = @fechaLanzamiento, Precio = @precio, Disponible = @disponible WHERE ID = @id";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@genero", genero);
                        command.Parameters.AddWithValue("@plataforma", plataforma);
                        command.Parameters.AddWithValue("@fechaLanzamiento", fechaLanzamiento);
                        command.Parameters.AddWithValue("@precio", precio);
                        command.Parameters.AddWithValue("@disponible", disponible);
                        command.Parameters.AddWithValue("@id", id);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Anime actualizado correctamente.");
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar el anime: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string query = "DELETE FROM animes WHERE ID = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Anime eliminado correctamente.");
                        LoadData(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el anime: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(Nombre.Text) ||
                string.IsNullOrWhiteSpace(Genero.Text) ||
                string.IsNullOrWhiteSpace(Plataforma.Text) ||
                Precio.Value <= 0)
            {
                MessageBox.Show("Por favor, llena todos los campos correctamente.");
                return false;
            }
            return true;
        }
    }
}