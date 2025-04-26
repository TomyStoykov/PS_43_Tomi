using Microsoft.Maui.Controls;
using ToDoApplication.ViewModels;

namespace ToDoApplication.Views
{
    public partial class CompletedTodosPage : ContentPage
    {
        public CompletedTodosPage()
        {
            InitializeComponent();
            // Using CompletedTodoViewModel, which is a modified version of TodoViewModel
            BindingContext = new CompletedTodoViewModel();
        }
    }
}
