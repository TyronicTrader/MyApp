using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyAppName.ViewModels;

namespace MyAppName.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();
        DataContext = new SettingsViewModel();
    }
}