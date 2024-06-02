using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MyAppName.ViewModels;

namespace MyAppName.Views;

public partial class JournalView : UserControl
{
    public JournalView()
    {
        InitializeComponent();
        DataContext = new JournalViewModel();
    }




}


