using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyAppName.ViewModels;

namespace MyAppName.Views;

public partial class DashboardView : UserControl
{
    public DashboardView()
    {
        InitializeComponent();
        DataContext = new DashboardViewModel();
    }
}