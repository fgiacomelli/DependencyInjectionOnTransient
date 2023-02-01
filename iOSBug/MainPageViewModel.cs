using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerProblemiOSRelease
{
    [INotifyPropertyChanged]
    public partial class MainPageViewModel 
    {
        [ObservableProperty]
        private bool enabled;

        [ObservableProperty]
        private string textLabel;

        public MainPageViewModel()
        {

            TextLabel = "This page represent the root (i.e. LoginPage)";
        }


        public async Task GoToTabbedTapped()
        {
            await AppShell.Current.GoToAsync($"//{nameof(DashboardPageA)}");
        }
    }
}
