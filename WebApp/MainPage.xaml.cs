using Sistema.Academia.Modelos;

namespace WebApp;

public partial class MainPage : ContentPage
{



	public MainPage(){
		InitializeComponent();
		 this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}	


    private async void Button_Clicked(object sender, EventArgs e)
    {

		await Navigation.PushAsync(new Cadastrar_Aluno());
    }





}

