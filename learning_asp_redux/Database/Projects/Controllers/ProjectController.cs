using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Projects.Models;

namespace Projects.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectContext _context;
        public ProjectsController(ProjectContext context){

            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]

        public IActionResult GetAllSectors(){
            return Ok(_context.Sectors.ToArray());
        }
    }

}