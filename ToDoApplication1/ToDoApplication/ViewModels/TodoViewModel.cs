using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToDoApplication.Models;

namespace ToDoApplication.ViewModels
{
    /// <summary>
    /// ViewModel for managing the todo list.
    /// </summary>
    public class TodoViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoViewModel()
        {
            // Initializing with sample data, including descriptions.
            TodoItems = new ObservableCollection<TodoItem>
            {
                new TodoItem { Title = "Learn .NET MAUI", IsCompleted = false, Description = "Study the basics of .NET MAUI and create a simple app." },
                new TodoItem { Title = "Create Todo Application", IsCompleted = true, Description = "Build a todo list app using MVVM in .NET MAUI." },
                new TodoItem { Title = "Review MVVM Template", IsCompleted = false, Description = "Go through the MVVM template provided in the documentation and practice." }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
