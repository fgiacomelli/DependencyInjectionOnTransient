namespace TriggerProblemiOSRelease;

public partial class MainPage : ContentPage
{
	MainPageViewModel viewModel;


    public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		this.BindingContext = viewModel;
	}


    private async void GoToTabbed_Tapped(object sender, TappedEventArgs e)
    {
        await viewModel.GoToTabbedTapped();
    }
}

