using System;

namespace EspacioProducto
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string? Descripcion { get; set; }
        public int Precio { get; set; }

        public Producto(){}
        public Producto(int idProducto, string descripcion, int precio)
        {
            IdProducto = idProducto;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}