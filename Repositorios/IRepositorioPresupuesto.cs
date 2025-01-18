using System;
using EspacioPresupuesto;

namespace EspacioRepositorios
{
public interface IPresupuestoRepositorio
    {
        void CrearPresupuesto(Presupuesto presupuesto);
        List<Presupuesto> ListarPresupuestos();
        Presupuesto ObtenerDetallesDeUnPresupuesto(int id);
        void AgregarProductoYCantidad(int id);
        void EliminarPresupuesto(int id);
    }
}