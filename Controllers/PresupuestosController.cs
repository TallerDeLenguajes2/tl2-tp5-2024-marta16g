using System;
using EspacioPresupuesto;
using Microsoft.AspNetCore.Mvc;

namespace EspacioPresupuestoController;

[ApiController]
[Route("[controller]")]

public class PresupuestosController : ControllerBase
{
    private ILogger<PresupuestosController> _logger;

    public PresupuestosController(ILogger<PresupuestosController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public ActionResult<Presupuesto> CrearPresupuesto(Presupuesto presupuesto)
    {
        Presupuesto nuevoPresupuesto = new Presupuesto(presupuesto.IdPresupuesto, presupuesto.NombreDestinatario, presupuesto.Detalle);
        return Ok(presupuesto);
    }

}