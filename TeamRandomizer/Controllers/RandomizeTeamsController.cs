﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamRandomizer.Models;

namespace TeamRandomizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomizeTeamsController : ControllerBase
    {
        // GET: api/RandomizeTeams
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            var randomizer = new RandomizeTeams();

            return randomizer.Randomize(NamesRepository.Names);
        }

        // GET: api/RandomizeTeams/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RandomizeTeams
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/RandomizeTeams/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
