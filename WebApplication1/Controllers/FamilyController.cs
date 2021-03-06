﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/Family")]
    public class FamilyController : Controller
    {
        private AppDbContext _dbContext;

        public FamilyController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Family
        [HttpGet]
        public IEnumerable<Family> Get()
        {
            return _dbContext.Families;
        }
        
        // POST: api/Family
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

    }
}
