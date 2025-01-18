using System;
using EspacioProducto;


namespace EspacioPresupuestoDetalle
{
    public class PresupuestoDetalle
    {
        public Producto producto { get; set; }
        public int Cantidad { get; set; }

        public PresupuestoDetalle(Producto producto, int cantidad)
        {
            producto = new Producto(producto.IdProducto, producto.Descripcion, producto.Precio);
            Cantidad = cantidad;
        }
    }
}