using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyAppName.ViewModels;

namespace MyAppName.Views;

public partial class RSSView : UserControl
{
    public RSSView()
    {
        InitializeComponent();
        DataContext = new RSSViewModel();
    }
}