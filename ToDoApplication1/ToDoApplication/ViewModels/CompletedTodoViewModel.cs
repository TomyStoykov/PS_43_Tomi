using System.Collections.ObjectModel;
using System.Linq;
using ToDoApplication.Models;

namespace ToDoApplication.ViewModels
{
    /// <summary>
    /// ViewModel for filtering completed tasks.
    /// Inherits from TodoViewModel to demonstrate reusing the view with a different ViewModel.
    /// </summary>
    public class CompletedTodoViewModel : TodoViewModel
    {
        public CompletedTodoViewModel() : base()
        {
            // Filter only completed tasks.
            var completed = TodoItems.Where(t => t.IsCompleted).ToList();
            TodoItems = new ObservableCollection<TodoItem>(completed);
        }
    }
}
