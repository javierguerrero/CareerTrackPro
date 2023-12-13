using CommunityToolkit.Mvvm.ComponentModel;
using MusicSchool.Mobile.Models;
using MusicSchool.Mobile.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MusicSchool.Mobile.ViewModels
{
    public class StudentsViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        public ICommand AddStudentTapCommand => new Command(OnTappedAddStudent);

        private Command<object> _viewStudentTapCommand;

        public StudentsViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _viewStudentTapCommand = new Command<object>(OnTappedViewStudent);
        }

        public Command<object> ViewStudentTapCommand
        {
            get { return _viewStudentTapCommand; }
            set { _viewStudentTapCommand = value; }
        }

        public ObservableCollection<Student> Students { get; set; } = new()
        {
            new Student { Name = "Javier" , LastName = "Guerrero", FullName = "Javier Guerrero"},
            new Student { Name = "Maribel" , LastName = "Campovero", FullName = "Maribel Campovero"}
        };

        private async void OnTappedViewStudent(object obj)
        {
            try
            {
                var student = obj as Student;
                var viewStudentPage = new ViewStudentPage();
                await _navigation.PushAsync(viewStudentPage);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
        }

        private async void OnTappedAddStudent()
        {
            try
            {
                var addStudentPage = new AddStudentPage();
                await _navigation.PushAsync(addStudentPage);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
        }
    }
}