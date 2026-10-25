using CommunityToolkit.Mvvm.ComponentModel;

namespace rad55_s_Tasks.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Greeting { get; set; } = "Welcome to Avalonia!";
}
