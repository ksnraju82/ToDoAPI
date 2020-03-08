using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoService.Models;
using Microsoft.AspNetCore.Authorization;

namespace ToDoService.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulerController : ControllerBase
    {
        private readonly SampleDBContext _context;

        public SchedulerController(SampleDBContext context)
        {
            _context = context;
        }

        // GET: api/Scheduler
        [HttpGet]
        public async Task<ActionResult<IEnumerable>> Get()
        {
            return await _context.Scheduler.ToListAsync();
        }

        // GET: api/Scheduler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Scheduler>> GetToDoTaskByID(int id)
        {
            Scheduler ToDoTask = await _context.Scheduler.FindAsync(id);

            if (ToDoTask == null)
            {
                return NotFound();
            }

            return ToDoTask;
        }

        // POST: api/Scheduler
        [HttpPost]
        public async Task<ActionResult> PostProducts(Scheduler scheduler)
        {
            _context.Scheduler.Add(scheduler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = scheduler.TaskId }, scheduler);
        }

        // PUT: api/Scheduler/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Scheduler>> DeleteTasks(int id)
        {
            var tasks = await _context.Scheduler.FindAsync(id);
            if (tasks == null)
            {
                return NotFound();
            }

            _context.Scheduler.Remove(tasks);
            await _context.SaveChangesAsync();

            return tasks;
        }
    }
}
