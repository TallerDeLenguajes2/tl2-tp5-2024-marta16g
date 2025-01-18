using System;
using EspacioPresupuestoDetalle;

namespace EspacioPresupuesto
{
    public class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public string NombreDestinatario { get; set; }
        public List<PresupuestoDetalle> Detalle { get; set; }

        public Presupuesto() { }
        public Presupuesto(int idPresupuesto, string nombreDestnatario, List<PresupuestoDetalle> detalle)
        {
            IdPresupuesto = idPresupuesto;
            NombreDestinatario = nombreDestnatario;
            Detalle = detalle;
        }

        public int MontoPresupuesto(){return 1;}
        public float MontoPresupuestoConIva(){return 1;}
        public int CantidadProductos(){return 1;}
    }
}