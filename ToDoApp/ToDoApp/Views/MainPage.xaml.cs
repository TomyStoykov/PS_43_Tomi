using Microsoft.Maui.Controls;
using TodoApp.ViewModels;

namespace TodoApp.Views
{
    public partial class MainPage : ContentPage
    {
        // Използваме същия TodoViewModel в тази страница.
        public TodoViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new TodoViewModel();
            BindingContext = ViewModel;
        }

        private async void OnViewCompletedClicked(object sender, System.EventArgs e)
        {
            // Навигация към страницата за завършени задачи (използва различен ViewModel, но същия View)
            await Navigation.PushAsync(new CompletedTodosPage());
        }

        private async void OnViewDetailsClicked(object sender, System.EventArgs e)
        {
            // Навигация към страницата за детайли, като предаваме същия ViewModel
            await Navigation.PushAsync(new TodoDetailPage(ViewModel));
        }
    }
}
