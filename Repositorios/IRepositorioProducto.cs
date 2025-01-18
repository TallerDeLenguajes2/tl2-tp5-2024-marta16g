using System;
using EspacioProducto;

namespace EspacioRepositorios
{
    public interface IProductoRepositorio
    {
        void CrearProducto(Producto producto);
        void ModificarProducto(int id, Producto producto);
        List<Producto> ListarProductos();
        Producto ObtenerDetallesDeUnProducto(int Id);
        void EliminarProducto(int id);
    }
}