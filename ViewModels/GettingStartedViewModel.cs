using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnestX.Views;

namespace FitnestX.ViewModels;

[INotifyPropertyChanged]
public partial class GettingStartedViewModel
{
    public GettingStartedViewModel()
    {

    }

    [RelayCommand]
    private async Task GoToOnBoardingView()
    {
        await (App.Current as Application).MainPage.Navigation.PushModalAsync(new OnBoardingView());
    }
}