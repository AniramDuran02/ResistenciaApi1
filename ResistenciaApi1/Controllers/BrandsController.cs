using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResistenciaApi1.Domain.Entities;

namespace ResistenciaApi1.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class BrandsController:ControllerBase
    {
        /* 
    Nombre de la escuela: Universidad Tecnologica Metropolitana

    Asignatura: Aplicaciones Web Orientadas a Servicios

    Nombre del Maestro: Joel Ivan Chuc Uc

    Nombre de la actividad: Actividad 2 (Unidad ll)

    Nombre del alumno: Anaeli Aniram Duran Canche

    Cuatrimestre: 4    Grupo: A    Parcial: 2
*/
        [HttpGet]
        [Route("Calcular")]

        public IActionResult Lineas(string _Line1, string _Line2, string _Line3, string _Line4)

        {
            var rest = new Color();

            rest.Line1(_Line1);

            if (_Line1.ToLower() != "naranja" && _Line1.ToLower() != "negro" && _Line1.ToLower() != "violeta"
            && _Line1.ToLower() != "blanco" && _Line1.ToLower() != "azul" && _Line1.ToLower() != "verde"
            && _Line1.ToLower() != "gris" && _Line1.ToLower() != "amarillo" && _Line1.ToLower() != "cafe"
            && _Line1.ToLower() != "rojo")

            {
                return Ok("El color de la Linea 1 es INCORRECTO");
            }

            rest.Line2(_Line2);

            if (_Line2.ToLower() != "naranja" && _Line2.ToLower() != "negro" && _Line2.ToLower() != "violeta"
            && _Line2.ToLower() != "blanco" && _Line2.ToLower() != "azul" && _Line2.ToLower() != "verde"
            && _Line2.ToLower() != "gris" && _Line2.ToLower() != "amarillo" && _Line2.ToLower() != "cafe"
            && _Line2.ToLower() != "rojo")

            {
                return Ok("El color de la Linea 2 es INCORRECTO");
            }

            rest.Line3(_Line3);

            if (_Line3.ToLower() != "naranja" && _Line3.ToLower() != "azul" && _Line3.ToLower() != "verde"
            && _Line3.ToLower() != "negro" && _Line3.ToLower() != "rojo" && _Line3.ToLower() != "cafe"
            && _Line3.ToLower() != "amarillo" || _Line3.ToLower() == "violeta" || _Line3.ToLower() == "gris" || _Line3.ToLower() == "blanco")

            {
                return Ok("El color de la Linea 3 es INCORRECTO");
            }

            rest.Line4(_Line4);

            if (_Line4.ToLower() != "dorado" && _Line4.ToLower() != "plata")
            {
                return Ok("El color de la Linea 4 es INCORRECTO, Solo se acepta el color DORADO y PLATA");
            }
            rest.Retornardatos();

            return Ok(rest.Retornardatos());
        }
    }
}
