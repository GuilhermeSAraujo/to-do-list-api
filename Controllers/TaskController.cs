using Microsoft.AspNetCore.Mvc;
using todo_list_api.Models;

namespace todo_list_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public static int Id = 1;
        public static List<TodoTask> Tasks = new();

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
            foreach (TodoTask Task in Tasks)
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
        public IActionResult Post([FromBody] string content)
        {
            int id = Id++;
            TodoTask newTask = new(id,content);
            Tasks.Add(newTask);
            return Ok(newTask);
        }

        // PUT api/<Task>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].Id == id)
                {
                    TodoTask updatedTask = new(id, value);
                    Tasks[i] = updatedTask;
                    return Ok(updatedTask);
                }
            }
            return NotFound(id);
        }

        // DELETE api/<Task>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if(Tasks[i].Id == id)
                {
                    var task = Tasks[i];
                    Tasks.RemoveAt(i);
                    return Ok(task);
                }
            }
            return NotFound(id);
        }
    }
}
