using CommunityToolkit.Mvvm.ComponentModel;

namespace rad55_s_Tasks.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
