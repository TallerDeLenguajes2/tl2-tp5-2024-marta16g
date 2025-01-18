using System;
using EspacioProducto;
using Microsoft.AspNetCore.Mvc;

namespace EspacioProductosController;

[ApiController]
[Route("[controller]")]

public class ProductosController : ControllerBase
{
    private ILogger<ProductosController> _logger;

    public ProductosController(ILogger<ProductosController> logger)
    {
        _logger = logger;
    }

    [HttpPost("api/Producto")]
    public ActionResult<Producto> CrearNuevoProducto([FromBody]Producto producto)
    {
        Producto nuevoProducto = new Producto(producto.IdProducto, producto.Descripcion, producto.Precio);
        return Ok(producto);
    }

    [HttpGet("api/Producto")]
    public ActionResult<List<Producto>> ListarProductos()
    {
        return Ok();
    }

    [HttpPut("api/Producto{id}")]
    public ActionResult<Producto> RenombrarProducto()
    {
        return Ok();
    }
}