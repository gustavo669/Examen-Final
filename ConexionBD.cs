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

namespace Examen_Final
{
    public class ConexionBD : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user=root;password=1234;database=examenfinalcrud";


        public bool AbrirConexion()
            {
                try
                {
                connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                    return false;
                }
            }

            public void CerrarConexion()
            {
                try
                {
                connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
                }
            }

            public DataTable EjecutarConsulta(string query)
            {
                DataTable tabla = new DataTable();
                try
                {
                    MySqlCommand comando = new MySqlCommand(query, connection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
                return tabla;
            }

            public int EjecutarComando(string comando)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(comando, connection);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
                    return -1;
                }
            }
        }
    }