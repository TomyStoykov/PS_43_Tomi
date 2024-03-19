using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;
        private UserViewModel viewModel;

        public UserView(UserViewModel viewModel, User user)
        {
            _viewModel = viewModel;
            _viewModel.Name = user.Names;
            _viewModel.Role= user.Role;
            _viewModel.Email = user.Email;
            _viewModel.FacultyNumber = user.FacultyNumber;
        }

        public UserView(UserViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public enum VisualizationType
        {
            Standard,
            WithOutRole
        }
        public void Display(VisualizationType visualization)
        {
            switch (visualization)
            {
                case VisualizationType.Standard:
                    DisplayStandard();
                    break;
                case VisualizationType.WithOutRole:
                    DisplayWithOutRole();
                    break;
                default:
                    Console.WriteLine("Invalid visualization type.");
                    break;
            }
        }

        public void DisplayStandard()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("User: " + _viewModel.Name);
            Console.WriteLine("Role: " + _viewModel.Role);
            Console.WriteLine("Email: " + _viewModel.Email);
            Console.WriteLine("Faculty Number: " + _viewModel.FacultyNumber);
        }

        public void DisplayWithOutRole()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("User: " + _viewModel.Name);
            Console.WriteLine("Email: " + _viewModel.Email);
            Console.WriteLine("Faculty Number: " + _viewModel.FacultyNumber);
        }

        public void DisplayError()
        {
            throw new Exception("ERROR TEXT");
        }
    }
}
