using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CommunityToolkit.Mvvm.Input;
using MyAppName.ViewModels;

namespace MyAppName.Views;

public partial class MyUserControlView : UserControl
{
    public MyUserControlView()
    {
        InitializeComponent();
        DataContext = new MyUserControlViewModel();
    }


    
}