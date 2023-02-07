using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnestX.Models;

namespace FitnestX.ViewModels;

[INotifyPropertyChanged]
public partial class SignUpViewModel
{

    [ObservableProperty]
    private bool isTermsChecked;

    [ObservableProperty] 
    private bool canStateChange;

    [ObservableProperty] 
    private string currentState = States.SignUpStepOne;

    [ObservableProperty]
    private ObservableCollection<string> genders;

    [ObservableProperty]
    private string selectedGender;

    [ObservableProperty]
    private ObservableCollection<GoalModel> goals;

    public SignUpViewModel()
    {
        Genders = new ObservableCollection<string>()
        {
            "Male",
            "Female",
        };

        Goals = new ObservableCollection<GoalModel>()
        {
            new("Improve Shape", "I have a low amount of body fat and need / want to build more muscle", "first_goal.png"),
            new("Lean & Tone", "I’m “skinny fat”. look thin but have no shape. I want to add learn muscle in the right way", "second_goal.png"),
            new("Lose a Fat", "I have over 20 lbs to lose. I want to drop all this fat and gain muscle mass", "third_goal.png"),
        };
    }

    [RelayCommand]
    private void TermsClicked()
    {
        IsTermsChecked = !IsTermsChecked;
    }

    [RelayCommand]//(CanExecute = nameof(CanStateChange))]
    private void RegisterClicked()
    {
        CurrentState = States.SignUpStepTwo;
    }

    [RelayCommand]//(CanExecute = nameof(CanStateChange))]
    private void NextClicked()
    {
        CurrentState = States.Goals;
    }

    //partial void OnCanStateChangeChanged(bool value)
    //{
    //    ChangeStateCommand.NotifyCanExecuteChanged();
    //}
}

static class States
{
    public const string SignUpStepOne = nameof(SignUpStepOne);
    public const string SignUpStepTwo = nameof(SignUpStepTwo);
    public const string Goals = nameof(Goals);
}
