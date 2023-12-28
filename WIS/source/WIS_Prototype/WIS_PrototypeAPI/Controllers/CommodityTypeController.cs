﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WIS_PrototypeAPI.Data.Models;
using WIS_PrototypeAPI.DbContexts;

namespace WIS_PrototypeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommodityTypeController : ControllerBase
    {
        // Reference for Data Base Context.
        private readonly MasterContext _context;

        //****************************************
        // Default Ctor DI of database context.
        public CommodityTypeController(MasterContext context)
        {
            _context = context;
        }

        //****************************************
        // Gets ALL commodity Types
        [HttpGet]
        public async Task<ActionResult<List<CommodityType>>> GetAll()
        {
            return Ok(await _context.CommodityTypes.ToListAsync());
        }


    }
}
