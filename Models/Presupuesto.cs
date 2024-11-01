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
        public Presupuesto(int idPresupuesto, string nombreDestnatario)
        {
            IdPresupuesto = idPresupuesto;
            NombreDestinatario = nombreDestnatario;
        }

        public int MontoPresupuesto()
        public float MontoPresupuestoConIva()
        public int CantidadProductos()
    }
}