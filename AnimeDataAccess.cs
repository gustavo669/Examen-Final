//using MySql.Data.MySqlClient;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Examen_Final
//{
//    internal class AnimeDataAccess
//    {
//        private MySqlConnection connection;
//        private string connectionString = "server=localhost;user=root;password=1234;database=examenfinalcrud";

//        public AnimeDataAccess()
//        {
//            connection = new MySqlConnection(connectionString);
//        }

//        public DataTable GetAllAnime()
//        {
//            DataTable table = new DataTable();

//            try
//            {
//                string query = "SELECT * FROM animes";
//                MySqlCommand command = new MySqlCommand(query, connection);
//                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
//                adapter.Fill(table);
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error al cargar los datos: " + ex.Message);
//            }

//            return table;
//        }

//        public void InsertAnime(string nombre, string genero, string plataforma, DateTime fechaLanzamiento, decimal precio, bool disponible)
//        {
//            try
//            {
//                string query = "INSERT INTO animes (Nombre, Genero, Plataforma, FechaLanzamiento, Precio, Disponible) VALUES (@nombre, @genero, @plataforma, @fechaLanzamiento, @precio, @disponible)";
//                MySqlCommand command = new MySqlCommand(query, connection);
//                command.Parameters.AddWithValue("@nombre", nombre);
//                command.Parameters.AddWithValue("@genero", genero);
//                command.Parameters.AddWithValue("@plataforma", plataforma);
//                command.Parameters.AddWithValue("@fechaLanzamiento", fechaLanzamiento);
//                command.Parameters.AddWithValue("@precio", precio);
//                command.Parameters.AddWithValue("@disponible", disponible);

//                connection.Open();
//                command.ExecuteNonQuery();
//                MessageBox.Show("Anime insertado correctamente.");
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error al insertar el anime: " + ex.Message);
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }
//    }
//}

