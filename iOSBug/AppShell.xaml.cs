
namespace TriggerProblemiOSRelease;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
    }

    void RegisterRoutes()
    {
        Routing.RegisterRoute(nameof(OtherPage), typeof(OtherPage));
    }

    public void ChangeVisibilityDashToA()
    {
        DashTabA.IsVisible = true;
        DashTabB.IsVisible = false;
    }

    public void ChangeVisibilityDashToB()
	{
		DashTabA.IsVisible = false;
		DashTabB.IsVisible = true;
	}
}
