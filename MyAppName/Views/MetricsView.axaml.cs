using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyAppName.ViewModels;

namespace MyAppName.Views;

public partial class MetricsView : UserControl
{
    public MetricsView()
    {
        InitializeComponent();
        DataContext = new MetricsViewModel();
    }
}