namespace BarBackgroundColorCrash;

public class ContainerPage : FlyoutPage
{
    public ContainerPage()
    {
        Detail = new NavigationPage(new MainPage());
        Flyout = new ContentPage
        {
            Title = "Flyout"
        };
    }
}

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new ContainerPage();
    }
}