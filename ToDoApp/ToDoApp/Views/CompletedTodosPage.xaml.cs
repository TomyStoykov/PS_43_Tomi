using Microsoft.Maui.Controls;
using TodoApp.ViewModels;

namespace TodoApp.Views
{
    public partial class CompletedTodosPage : ContentPage
    {
        public CompletedTodosPage()
        {
            InitializeComponent();
            // Използваме CompletedTodoViewModel, който е модифицирана версия на TodoViewModel
            BindingContext = new CompletedTodoViewModel();
        }
    }
}
