namespace todo_list_api.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public TodoTask( int id, string content)
        {
            this.Id = id;
            this.Content = content;
        }
    }
}
