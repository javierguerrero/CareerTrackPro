using MusicSchool.Mobile.ViewModels;

namespace MusicSchool.Mobile.Views;

public partial class ViewStudentPage : ContentPage
{
	public ViewStudentPage()
	{
		InitializeComponent();
        BindingContext = new ViewStudentViewModel(this.Navigation);
    }
}