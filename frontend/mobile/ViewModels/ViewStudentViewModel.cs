using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchool.Mobile.ViewModels
{
    public class ViewStudentViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        public ViewStudentViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
