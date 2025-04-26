namespace TodoApp.Models
{
    /// <summary>
    /// Модел, който представя една задача.
    /// </summary>
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
