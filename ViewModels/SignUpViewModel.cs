using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FitnestX.ViewModels;

[INotifyPropertyChanged]
public partial class SignUpViewModel
{

    [ObservableProperty]
    private bool isTermsChecked;

    [ObservableProperty] 
    private bool canStateChange;

    [ObservableProperty] 
    private string currentState = States.SignUpStepTwo;

    [RelayCommand]
    private void TermsClicked()
    {
        IsTermsChecked = !IsTermsChecked;
    }

    [RelayCommand(CanExecute = nameof(CanStateChange))]
    private void ChangeState()
    {
        CurrentState = States.SignUpStepTwo;
    }

    partial void OnCanStateChangeChanged(bool value)
    {
        ChangeStateCommand.NotifyCanExecuteChanged();
    }
}

static class States
{
    public const string SignUpStepOne = nameof(SignUpStepOne);
    public const string SignUpStepTwo = nameof(SignUpStepTwo);
    public const string GoalStepOne = nameof(GoalStepOne);
    public const string GoalStepTwo = nameof(GoalStepTwo);
    public const string GoalStepThree = nameof(GoalStepThree);
}
