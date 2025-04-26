using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TodoApp.Models;

namespace TodoApp.ViewModels
{
    /// <summary>
    /// ViewModel за управление на списък с Todo елементи.
    /// </summary>
    public class TodoViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public TodoViewModel()
        {
            // Инициализация със примерни данни.
            TodoItems = new ObservableCollection<TodoItem>
            {
                new TodoItem { Title = "Научи .NET MAUI", IsCompleted = false },
                new TodoItem { Title = "Създай Todo приложение", IsCompleted = true },
                new TodoItem { Title = "Прегледай MVVM шаблона", IsCompleted = false }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
