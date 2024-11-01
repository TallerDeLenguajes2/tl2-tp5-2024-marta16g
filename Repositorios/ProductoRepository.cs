using System;
using EspacioProducto;

namespace EspacioRepositorioProducto
{
    public interface IProductoRepositorio
    {
        void CrearProducto(Producto producto);
        void ModificarProducto(int id, Producto producto);
        List<Producto> ListarProductos();
        Producto ObtenerDetallesDeUnProducto(int Id);
        void EliminarProducto(int id);
    }

    public class RepositorioProducto : IProductoRepositorio
    {
        public void CrearProducto(Producto producto)
        {

        }

        public void ModificarProducto(int id, Producto producto)
        {

        }

        public List<Producto> ListarProductos()
        {

        }
        public Producto ObtenerDetallesDeUnProducto(int id)
        {

        }

        public void EliminarProducto(int id)
        {
            
        }
    }
}