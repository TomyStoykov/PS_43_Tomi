using Microsoft.Maui.Controls;
using ToDoApplication.Models;
using ToDoApplication.ViewModels;

namespace ToDoApplication.Views
{
    public partial class TodoListView : ContentView
    {
        public TodoListView()
        {
            InitializeComponent();
        }

        // Event handler for task item click
        public async void OnTaskSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is TodoItem selectedTask)
            {
                // Navigate to the task details page and pass the selected task
                await Navigation.PushAsync(new TodoDetailPage(selectedTask));
            }
        }
    }
}
