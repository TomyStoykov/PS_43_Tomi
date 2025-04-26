using System.Collections.ObjectModel;
using System.Linq;
using TodoApp.Models;

namespace TodoApp.ViewModels
{
    /// <summary>
    /// ViewModel за филтриране на завършени задачи.
    /// Използва наследяване от TodoViewModel, за да демонстрира повторна употреба на View чрез различен ViewModel.
    /// </summary>
    public class CompletedTodoViewModel : TodoViewModel
    {
        public CompletedTodoViewModel() : base()
        {
            // Филтрираме само завършените задачи.
            var completed = TodoItems.Where(t => t.IsCompleted).ToList();
            TodoItems = new ObservableCollection<TodoItem>(completed);
        }
    }
}
