using Microsoft.AspNetCore.Mvc;

namespace todo_list_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public int Id = 1;
        public List<Task> Tasks = new(); 

        // GET: api/<Task>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Tasks);
        }

        // GET api/<Task>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            foreach (Task Task in Tasks)
            {
                if (Task.Id == id)
                {
                    return Ok(Task);
                }
            }
            return NotFound();
        }

        // POST api/<Task>
        [HttpPost]
        public void Post([FromBody] string content)
        {
            int id = Id++;
            Task newTask = new();
            Tasks.Add(newTask);
        }

        // PUT api/<Task>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Task>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
