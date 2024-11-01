using System;
using EspacioPresupuesto; 

namespace EspacioRepositorioPresupuesto
{
    public interface IPresupuestoRepositorio
    {
        void CrearPresupuesto(Presupuesto presupuesto);
        List<Presupuesto> ListarPresupuestos();
        Presupuesto ObtenerDetallesDeUnPresupuesto(int id);
        void AgregarProductoYCantidad(int id);
        void EliminarPresupuesto(int id);
    }


    public class RepositorioPresupuesto : IPresupuestoRepositorio
    {
        public void CrearPresupuesto(Presupuesto presupuesto)
        {

        }

        public List<Presupuesto> ListarPresupuesto()
        {

        }

        public Presupuesto ObtenerDetallesDeUnPresupuesto(int id)
        {

        }
        public void AgregarProductoYCantidad(int id)
        {

        }
        public EliminarPresupuestos(int id)
        {

        }
    }
}