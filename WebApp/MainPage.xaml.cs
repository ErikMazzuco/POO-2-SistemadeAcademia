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


  private async void Button_Clicked2(object sender, EventArgs e)
    {

		await Navigation.PushAsync(new Cadastrar_Atendente());
    }

    private async void Busca_alunos(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new BuscaAluno());
    }
    private async void Busca_atendente(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new BuscaAtendente());
    }

        private async void GerenciamentoFicha(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new GerenciamentoFichaTreino());
    }




}

