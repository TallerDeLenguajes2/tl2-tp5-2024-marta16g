using System;
using EspacioProducto;

namespace EspacioRepositorioProducto
{
    public interface IProductoRepositorio
    {
        void CrearProducto(Producto producto);
        void ModificarProducto(int id, EspacioRepositorioProducto producto);
        List<Producto> ListarProductos();
        Producto ObtenerDetallesDeUnProducto(int Id);
        void EliminarProducto(int id);
    }
}