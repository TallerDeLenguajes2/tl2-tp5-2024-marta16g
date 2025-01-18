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

        }

        public List<Producto> ListarProductos()
        {
            return null;
        }
        public Producto ObtenerDetallesDeUnProducto(int id)
        {
            return null;
        }

        public void EliminarProducto(int id)
        {

        }
    }
}