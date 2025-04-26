using Microsoft.Maui.Controls;
using TodoApp.ViewModels;

namespace TodoApp.Views
{
    public partial class TodoDetailPage : ContentPage
    {
        /// <summary>
        /// Приема съществуващия TodoViewModel, за да демонстрира използването му от няколко View-та.
        /// </summary>
        /// <param name="viewModel">Същият екземпляр на TodoViewModel от MainPage.</param>
        public TodoDetailPage(TodoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
