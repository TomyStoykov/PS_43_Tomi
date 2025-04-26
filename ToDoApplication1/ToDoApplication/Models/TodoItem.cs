namespace ToDoApplication.Models
{
    /// <summary>
    /// Model representing a single todo item.
    /// </summary>
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public string Description { get; set; }  // New property for task description
    }
}
