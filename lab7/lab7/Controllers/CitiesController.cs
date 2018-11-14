using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _repository;

        public CitiesController(ICityRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<City>> Get()
        {
            return _repository.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<City> Get(Guid id)
        {
            return Ok(this._repository.GetById(id));
        }

        [HttpPost]
        public ActionResult<City> Post([FromBody] City city)
        {
            if (city == null)
            {
                return BadRequest();
            }

            this._repository.Create(city);

            return CreatedAtRoute("GetById", new { id = city.Id }, city);
        }
    }
}