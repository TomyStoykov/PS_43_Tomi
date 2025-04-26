using Microsoft.Maui.Controls;
using ToDoApplication.Models;

namespace ToDoApplication.Views
{
    public partial class TodoDetailPage : ContentPage
    {
        public TodoDetailPage(TodoItem selectedTask)
        {
            InitializeComponent();
            // Bind the selected task to the page
            BindingContext = selectedTask;
        }
    }
}
