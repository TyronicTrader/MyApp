using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Collections;

namespace MyAppName.ViewModels;


public partial class MainViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    //public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static
        public MainViewModel(){
            ExecuteShowDashboardView();
        }

        [ObservableProperty]
        private ViewModelBase? currentChildView;

        [ObservableProperty]
        private string? caption;


        [RelayCommand]
        internal void ExecuteShowDashboardView()
        {
            CurrentChildView = new MyUserControlViewModel();
            Caption = "Dashboard";
        }

        [RelayCommand]
        internal void ExecuteShowJournalView()
        {
            CurrentChildView = new MainViewModel();
            Caption = "Journal";
        }

        [RelayCommand]
        internal void ExecuteShowMetricsView()
        {
            CurrentChildView = new MyUserControlViewModel();
            Caption = "Metrics";
        }

        [RelayCommand]
        internal void ExecuteShowEventsView() 
        {
            CurrentChildView = new MainViewModel();
            Caption = "Events";
        }

        [RelayCommand]
        internal void ExecuteShowRSSView()
        {
            CurrentChildView = new MyUserControlViewModel();
            Caption = "RSS";
        }

        [RelayCommand]
        internal void ExecuteShowSearchView()
        {
            CurrentChildView = new MainViewModel();
            Caption = "Search";
        }

        [RelayCommand]
        internal void ExecuteShowSettingsView()
        {
            CurrentChildView = new MyUserControlViewModel();
            Caption = "Settings"; 
        }

        [RelayCommand]
        internal void ExecuteShowInfoView()
        {
            CurrentChildView = new MainViewModel();
            Caption = "Info";
        }
}
