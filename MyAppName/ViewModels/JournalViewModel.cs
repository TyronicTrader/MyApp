using Avalonia.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Diagnostics;
using System.Text;

namespace MyAppName.ViewModels;

public partial class JournalViewModel : ViewModelBase
{
        [ObservableProperty]
        string theTextBox = "the String";

        [ObservableProperty]
        string richTextBox = "";

        [RelayCommand]
        public void AddDT()
        {
                RichTextBox = RichTextBox + "\r\n" + DateTime.Now.ToString() + "\r\n";
        }

}
