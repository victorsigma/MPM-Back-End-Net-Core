using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MPM_Back_End.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MPM_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsHasUserController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ProjectsHasUserController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ProjectsHasUserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listProjectosUsuarios = await _context.ProjectsHasUsers.ToListAsync();
                return Ok(listProjectosUsuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ProjectsHasUserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var projectUser = await _context.ProjectsHasUsers.FindAsync(id);
                if (projectUser == null)
                {
                    return NotFound();
                }
                return Ok(projectUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ProjectsHasUserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProjectsHasUser projectUser)
        {
            try
            {
                _context.Add(projectUser);
                await _context.SaveChangesAsync();
                return Ok(projectUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProjectsHasUserController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProjectsHasUser projectUser)
        {
            try
            {
                if (id != projectUser.Id)
                {
                    return NotFound();
                }
                _context.Update(projectUser);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProjectsHasUserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var projectUser = await _context.ProjectsHasUsers.FindAsync(id);
                if (projectUser == null)
                {
                    return NotFound();
                }

                _context.ProjectsHasUsers.Remove(projectUser);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
