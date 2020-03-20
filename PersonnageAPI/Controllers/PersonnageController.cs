using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonnageAPI.Controllers
{
    using Models;
    using Exceptions;
    using Services;

    [Route("personnages")]
    [ApiController]
    public class PersonnageController : ControllerBase
    {
        private PersonnageService service;

        public PersonnageController(PersonnageService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("")]
        public IActionResult Save([FromBody] Personnage p)
        {
            return Ok(this.service.Sauvegarde(p));
        }

        [HttpGet]
        [Route("")]
        public IActionResult FindAll()
        {
            return Ok(this.service.TrouverTous());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindById(int id)
        {
            try
            {
                return Ok(this.service.TrouverUn(id));
            }
            catch (IndexOutOfRangeException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return this.ValidationProblem();
            }

        }

        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Personnage p)
        {
            return Ok(this.service.Modifier(p));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                this.service.Supprimer(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }

        }

        [HttpPut]
        [Route("{id}/pere/{idp}")]
        public IActionResult UpdatePere(int id, int idp)
        {
            try
            {
                return Ok();
            }
            catch (RessourceException e)
            {
                if (e.Statu == 404)
                    return NotFound(e.Message);
                if (e.Statu == 400)
                    return BadRequest(e.Message);
            }
        }
    }
}