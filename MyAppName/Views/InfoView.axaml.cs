using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyAppName.ViewModels;

namespace MyAppName.Views;

public partial class InfoView : UserControl
{
    public InfoView()
    {
        InitializeComponent();
        DataContext = new InfoViewModel();
    }
}