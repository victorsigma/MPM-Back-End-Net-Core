using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MPM_Back_End.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MPM_Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ActivitiesController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ActivitiesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listActividades = await _context.Activities.ToListAsync();
                return Ok(listActividades);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ActivitiesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var activity = await _context.Activities.FindAsync(id);
                if (activity == null)
                {
                    return NotFound();
                }
                return Ok(activity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ActivitiesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ActivityData activity)
        {
            try
            {
                _context.Add(activity);
                await _context.SaveChangesAsync();
                return Ok(activity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ActivitiesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ActivityData activity)
        {
            try
            {
                if (id != activity.id)
                {
                    return NotFound();
                }
                _context.Update(activity);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ActivitiesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var activity = await _context.Activities.FindAsync(id);
                if (activity == null)
                {
                    return NotFound();
                }

                _context.Activities.Remove(activity);
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
