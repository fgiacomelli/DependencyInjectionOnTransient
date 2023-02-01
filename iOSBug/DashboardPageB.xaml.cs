namespace TriggerProblemiOSRelease;

public partial class DashboardPageB : ContentPage
{
	MainPageViewModel viewModel;

    protected override bool OnBackButtonPressed()
    {
        AppShell.Current.GoToAsync($"//{nameof(MainPage)}");
		return true;
    }

    public DashboardPageB(MainPageViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		this.BindingContext = viewModel;
	}

    private async void Privato_Tapped(object sender, TappedEventArgs e)
    {
	}

    private async void DashboardA_Tapped(object sender, TappedEventArgs e)
    {
        ((AppShell)App.Current.MainPage).ChangeVisibilityDashToA();
        await AppShell.Current.GoToAsync($"//{nameof(DashboardPageA)}");
    }
}

