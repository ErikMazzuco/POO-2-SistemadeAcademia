namespace WebApp;

public partial class GerenciamentoFichaTreino : ContentPage
{
	public GerenciamentoFichaTreino()
	{
		InitializeComponent();
			this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}

	private async void CadastrarFichaTreino(object sender, EventArgs e)
    {

		await Navigation.PushAsync(new Cadastra_Ficha());


	}


	private async void EditFichaTreino(object sender, EventArgs e)
    {



		
	}

	private async void ExcluirFuchatreino(object sender, EventArgs e)
    {



		
	}




	
}