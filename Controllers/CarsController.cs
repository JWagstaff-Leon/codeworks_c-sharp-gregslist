using Microsoft.AspNetCore.Mvc;
using w10d2.Services;
using w10d2.Models;

namespace w10d2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly CarsService _serv;
        public CarsController(CarsService serv)
        {
            _serv = serv;
        }

        [HttpGet]
        public ActionResult<List<Car>> GetAll()
        {
            try
            {
                List<Car> found = _serv.GetAll();
                return Ok(found);
                
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetById(string id)
        {
            try
            {
                Car found = _serv.GetById(id);
                return Ok(found);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Car> Create([FromBody] Car data)
        {
            try
            {
                Car created = _serv.Create(data);
                return Ok(created);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Car> Edit(string id, [FromBody] Car update)
        {
            try
            {
                update.Id = id;
                Car updated = _serv.Edit(update);
                return Ok(updated);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Car> Remove(string id)
        {
            try
            {
                Car removed = _serv.Remove(id);
                return Ok(removed);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}