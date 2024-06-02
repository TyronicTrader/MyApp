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
            CurrentChildView = new DashboardViewModel();
            Caption = "Dashboard";
        }

        [RelayCommand]
        internal void ExecuteShowJournalView()
        {
            CurrentChildView = new JournalViewModel();
            Caption = "Journal";
        }

        [RelayCommand]
        internal void ExecuteShowMetricsView()
        {
            CurrentChildView = new MetricsViewModel();
            Caption = "Metrics";
        }

        [RelayCommand]
        internal void ExecuteShowEventsView() 
        {
            CurrentChildView = new EventsViewModel();
            Caption = "Events";
        }

        [RelayCommand]
        internal void ExecuteShowRSSView()
        {
            CurrentChildView = new RSSViewModel();
            Caption = "RSS";
        }

        [RelayCommand]
        internal void ExecuteShowSearchView()
        {
            CurrentChildView = new SearchViewModel();
            Caption = "Search";
        }

        [RelayCommand]
        internal void ExecuteShowSettingsView()
        {
            CurrentChildView = new SettingsViewModel();
            Caption = "Settings"; 
        }

        [RelayCommand]
        internal void ExecuteShowInfoView()
        {
            CurrentChildView = new InfoViewModel();
            Caption = "Info";
        }
}
