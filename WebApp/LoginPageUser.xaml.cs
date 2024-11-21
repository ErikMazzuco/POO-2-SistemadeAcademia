namespace WebApp;

public partial class LoginPageUser : ContentPage
{
	public LoginPageUser()
	{
		InitializeComponent();
		this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {

		//faz login
		await Navigation.PushAsync(new MainPage());
    


    }
}