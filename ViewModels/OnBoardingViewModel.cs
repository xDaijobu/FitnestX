using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnestX.Models;
using FitnestX.Views;

namespace FitnestX.ViewModels;

[INotifyPropertyChanged]
public partial class OnBoardingViewModel
{
    [ObservableProperty]
    private ObservableCollection<OnBoardingModel> onBoardings;

    [ObservableProperty]
    private int position;

    [ObservableProperty]
    private int currentValue = 25;
    public OnBoardingViewModel()
    {
        OnBoardings = new ObservableCollection<OnBoardingModel>();
        OnBoardings.Add(new OnBoardingModel("Track Your Goal", "Don't worry if you have trouble determining your goals, We can help you determine your goals and track your goals", "track_your_goal.png"));
        OnBoardings.Add(new OnBoardingModel("Get Burn", "Let’s keep burning, to achive yours goals, it hurts only temporarily, if you give up now you will be in pain forever", "get_burn.png"));
        OnBoardings.Add(new OnBoardingModel("Eat Well", "Let's start a healthy lifestyle with us, we can determine your diet every day. healthy eating is fun", "eat_well.png"));
        OnBoardings.Add(new OnBoardingModel("Improve Sleep  Quality", "Improve the quality of your sleep with us, good quality sleep can bring a good mood in the morning", "improve_sleep_quality.png"));

        Position = 0;
    }

    [RelayCommand]
    private async Task UpdatePosition()
    {
        if (Position == OnBoardings.Count - 1)
        {
            await (App.Current as Application).MainPage.Navigation.PushModalAsync(new SignUpView());
            return;
        }

        Position++;
        CurrentValue += 25;
    }
}