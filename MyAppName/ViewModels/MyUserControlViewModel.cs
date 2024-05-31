using Avalonia.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Diagnostics;
using System.Text;


namespace MyAppName.ViewModels;

public partial class MyUserControlViewModel : ViewModelBase
{
//#pragma warning disable CA1822 // Mark members as static
 //   public string Greeting2 => "Welcome to Avalonia!";
//#pragma warning restore CA1822 // Mark members as static


    [ObservableProperty]
    private string appName = "Simple Trade Journal";

    [ObservableProperty]
    private string devName = "Developer";

    [ObservableProperty]
    private string devCrypto = "placeholder12309487oiqjfoklajsdfasdfkjhjkhuwe";

    [ObservableProperty]
    private string devPatreon = "https://www.patreon.com";

    [ObservableProperty]
    public string devPaypal = "https://www.paypal.com";

    [RelayCommand]
    public void OpenThePatreonHyperlink()
    {
        try
        {
            Process.Start(new ProcessStartInfo(DevPatreon) { UseShellExecute = true });
        }
        catch
        {
            Console.WriteLine("Link didn't work or can't open your default browser.");
        }

    }

    [RelayCommand]
    public void OpenThePayPalHyperlink()
    {
        try
        {
            Process.Start(new ProcessStartInfo(DevPaypal) { UseShellExecute = true });
        }
        catch
        {
            Console.WriteLine("Link didn't work or can't open your default browser.");
        }
    }

    [RelayCommand]
    public void CopyCryptoToClipboard()
    {
        // var clipboard = TopLevel.GetTopLevel(this)?..Clipboard;
        // var dataObject = new DataObject();
        // dataObject.Set(DataFormats.Text, DevCrypto);
        // await clipboard.SetDataObjectAsync(dataObject);
        Console.WriteLine("Crypto Address copied to your clipboard");
    }

}
