namespace todo_list_api.Models
{
    public class Task
    {
        private int Id;
        private string Content;

        public Task(int id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}
