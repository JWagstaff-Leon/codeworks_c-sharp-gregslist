using Microsoft.AspNetCore.Mvc;
using w10d2.Models;
using w10d2.Services;

namespace w10d2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        JobsService _serv;

        public JobsController(JobsService serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public ActionResult<List<Job>> GetAll()
        {
            try
            {
                List<Job> found = _serv.GetAll();
                return Ok(found);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Job> GetById(string id)
        {
            try
            {
                Job found = _serv.GetById(id);
                return Ok(found);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job data)
        {
            try
            {
                Job created = _serv.Create(data);
                return Ok(created);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Job> Edit(string id, [FromBody] Job update)
        {
            try
            {
                update.Id = id;
                Job updated = _serv.Edit(update);
                return Ok(updated);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Job> Remove(string id)
        {
            try
            {
                Job removed = _serv.Remove(id);
                return Ok(removed);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}