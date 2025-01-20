using System;
using EspacioProducto;
using Microsoft.Data.Sqlite;

namespace EspacioRepositorios
{

    public class RepositorioProducto : IProductoRepositorio
    {
        public void CrearProducto(Producto producto)
        {
            string connectionString = @"Data Source = db/Tienda.db;Cache=Shared";
            string query = @"INSERT INTO Productos (Descripcion, Precio) 
            VALUES (@Descripcion, @Precio)";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void ModificarProducto(int id, Producto producto)
        {
            string connectionString = @"Data Source = db/Tienda.db;Cache=Shared";
            string query = @"UPDATE Productos SET Descripcion = @Descripcion, Precio = @Precio WHERE idProducto = @Id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Id", producto.IdProducto);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public List<Producto> ListarProductos()
        {
            var listaProductos = new List<Producto>();
            string connectionString = @"Data Source = db/Tienda.db;Cache=Shared";
            string query = "@SELECT * FROM Productos";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var unProducto = new Producto();

                        unProducto.IdProducto = Convert.ToInt32(reader["idProducto"]);
                        unProducto.Descripcion = reader["Descripción"].ToString();
                        unProducto.Precio = Convert.ToInt32(reader["Precio"]);

                        listaProductos.Add(unProducto);
                    }
                }
                connection.Close();

            }

            return listaProductos;
        }
        public Producto ObtenerUnProducto(int id)
        {
            Producto miProducto = new Producto();

            string connectionString = @"Data Source = db/Tienda.db;Cache=Shared";
            string query = "@SELECT * FROM Productos WHERE idProducto = @id";

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        miProducto.IdProducto = Convert.ToInt32(reader["idProducto"]);
                        miProducto.Descripcion = reader["Descripcion"].ToString();
                        miProducto.Precio = Convert.ToInt32(reader["Precio"]);
                    }

                }
                connection.Close();
            }
            return miProducto;
        }

        public void EliminarProducto(int id)
        {

        }
    }
}