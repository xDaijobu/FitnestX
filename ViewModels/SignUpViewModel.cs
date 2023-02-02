using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FitnestX.ViewModels
{
    [INotifyPropertyChanged]
    public partial class SignUpViewModel
    {

        [ObservableProperty] 
        private bool isTermsChecked;

        [RelayCommand]
        private void TermsClicked()
        {
            IsTermsChecked = !IsTermsChecked;
        }
    }
}
