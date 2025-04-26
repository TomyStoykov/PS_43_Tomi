using Microsoft.Maui.Controls;
using ToDoApplication.Models;
using ToDoApplication.ViewModels;

namespace ToDoApplication.Views
{
    public partial class MainPage : ContentPage
    {
        public TodoViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new TodoViewModel();
            BindingContext = ViewModel;
        }

        private async void OnViewCompletedClicked(object sender, System.EventArgs e)
        {
            // Navigation to the completed tasks page (uses a different ViewModel but the same View)
            await Navigation.PushAsync(new CompletedTodosPage());
        }

        // Event handler for task item click
        private async void OnTaskSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is TodoItem selectedTask)
            {
                // Navigate to the task details page and pass the selected task
                await Navigation.PushAsync(new TodoDetailPage(selectedTask));
            }
        }
    }
}
