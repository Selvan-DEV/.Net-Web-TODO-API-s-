using Microsoft.AspNetCore.Mvc;
using Todo_APP.Interface;
using Todo_APP.Models;


namespace Todo_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        private IWorkersData _workersData;

        public WorkersController(IWorkersData workersData)
        {
            _workersData = workersData;
        }

        // GET: api/<WorkersController>
        [HttpGet]
        public IActionResult GetWorkers()
        {
            var workers = _workersData.GetWorkers();
            return Ok(workers);
        }

        // GET api/<WorkersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WorkersController>
        [HttpPost]
        public IActionResult AddWorker(Workers workers)
        {
            _workersData.AddWorker(workers);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host +
                HttpContext.Request.Path + "/" + workers.WorkerId, workers);
        }

        // PUT api/<WorkersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WorkersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
