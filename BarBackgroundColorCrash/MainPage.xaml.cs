namespace BarBackgroundColorCrash;

public partial class MainPage : ContentPage
{
    private Random _random;
    
    public MainPage()
    {
        InitializeComponent();
        
        _random = new Random();
    }

    private void UpdatePrimaryColor()
    {
        App.Current.Resources["Primary"] = $"#{_random.Next(0x1000000):X6}";
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();

        UpdatePrimaryColor();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        UpdatePrimaryColor();
    }
}