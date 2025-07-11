using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiInvoice.Application.Interfaces;
using WebApiInvoice.Domain.Models;

namespace WebApiInvoince.WebApi.Controllers
{
    [ApiController]
    [Route("api/proveedores")]

    public class ProveedoresController : ControllerBase
    {
        IProveedorService _service;

        public ProveedoresController(IProveedorService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Proveedor> GetAll()
        {
            return _service.SelectAll();
        }

        /// <summary>
        /// Obtener un proveedor x id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Proveedor), StatusCodes.Status200OK)]
        public IActionResult GetById(int id)
        {
            return new OkObjectResult(_service.SelectById(id));
        }

        [HttpPost]
        [ProducesResponseType(typeof(Proveedor), StatusCodes.Status201Created)]
        public IActionResult CreateProveedor(Proveedor proveedor)
        {
            return new CreatedResult("default", _service.Add(proveedor));
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteProveedor(int id)
        {
            return new OkObjectResult(_service.Delete(id));
        }

        [HttpPut]
        [ProducesResponseType(typeof(bool),StatusCodes.Status200OK)]
        public IActionResult UpdateProveedor (Proveedor model)
        {
            return new OkObjectResult(_service.Update( model));
        }
    }

    
        
}