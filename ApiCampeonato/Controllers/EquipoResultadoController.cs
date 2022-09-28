using ApiCampeonato.Models;
using ApiCampeonato.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCampeonato.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipoResultadoController : ControllerBase
    {
        EquipoResultadorRepositorio _equipoResultadorRepositorio;
        public EquipoResultadoController(EquipoResultadorRepositorio equipoResultadorRepositorio)
        {
            _equipoResultadorRepositorio = equipoResultadorRepositorio;
            

        }


        [HttpPost]
        public IActionResult Post([FromBody] Resultado equipoResultado)
        {
            _equipoResultadorRepositorio.AgregarResultado(equipoResultado);
            return Ok("Resultado Creado");
        }
    }
}
