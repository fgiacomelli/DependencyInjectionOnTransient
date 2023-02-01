namespace TriggerProblemiOSRelease;

public partial class OtherPage : ContentPage
{
    OtherPageViewModel viewModel;

    protected override bool OnBackButtonPressed()
    {
        AppShell.Current.GoToAsync($"//{nameof(MainPage)}");
        return true;
    }
    public OtherPage(OtherPageViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		this.BindingContext = viewModel;
	}

    private async void ReturnMainTapped(object sender, TappedEventArgs e)
    {
		viewModel.ButtonClicked();
	}
}

