namespace TriggerProblemiOSRelease;

public partial class DashboardPageA : ContentPage
{
	MainPageViewModel viewModel;
    protected override bool OnBackButtonPressed()
    {
        AppShell.Current.GoToAsync($"//{nameof(MainPage)}");
        return true;
    }

    public DashboardPageA(MainPageViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		this.BindingContext = viewModel;
	}

    private async void Privato_Tapped(object sender, TappedEventArgs e)
    {

	}


}

