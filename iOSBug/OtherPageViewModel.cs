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
    public partial class OtherPageViewModel
    {
        [ObservableProperty]
        private bool enabled;

        [ObservableProperty]
        private string textLabel;

        public OtherPageViewModel()
        {
            TextLabel = "This is registered as transient!";
        }

        public async void ButtonClicked()
        { 
            await AppShell.Current.GoToAsync($"//{nameof(MainPage)}");
        }


    }
}
