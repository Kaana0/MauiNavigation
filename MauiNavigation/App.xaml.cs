namespace MauiNavigation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //MainPage = new AppShell(new MainPage());
        MainPage = new NavigationPage(new MainPage(string.Empty));
	}
}

