﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoisController : ControllerBase
    {
        private readonly IPoiRepository _repository;

        public PoisController(IPoiRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Poi>> Get()
        {
            return _repository.GetAll().ToList();
        }

        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Poi> Get(Guid id)
        {
            return Ok(this._repository.GetById(id));
        }

        [HttpPost]
        public ActionResult<Poi> Post([FromBody] Poi poi)
        {
            if (poi == null)
            {
                return BadRequest();
            }

            this._repository.Create(poi);

            return CreatedAtRoute("GetById", new { id = poi.Id }, poi);
        }
    }
}