using Sistema.Academia.Modelos;

namespace WebApp;

public partial class MainPage : ContentPage
{



	public MainPage(){
		InitializeComponent();
		 this.Title = "";
		 
         NavigationPage.SetHasNavigationBar(this, false); // Para remover a barra de navegação
        NavigationPage.SetHasBackButton(this, false); // Para remover a seta de voltar
	}	



       // Alterna a visibilidade do menu
        private void OnProfileTapped(object sender, EventArgs e)
        {
            LogoutMenu.IsVisible = !LogoutMenu.IsVisible;
        }

        // Redireciona para a página de login
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            LogoutMenu.IsVisible = false;
            // Redireciona para a página de login
            await Navigation.PushAsync(new LoginPageUser());
        }


protected override async void OnAppearing()
{
    base.OnAppearing();

    int loggedUserId = Preferences.Get("LoggedUserId", 0);

    

    if (loggedUserId > 0)
    {
        var usuarioLogado = DatabaseHelper.GetUserById(loggedUserId);
        if (usuarioLogado != null)
        {
            NomeUsuarioLabel.Text = $"Bem-vindo, {usuarioLogado.User}";
        }
        else
        {
            NomeUsuarioLabel.Text = "Usuário não encontrado.";
        }
    }
    else
    {
        NomeUsuarioLabel.Text = "Nenhum usuário logado.";
    }
}









private async void Cadastrar_Exercicio(object sender, EventArgs e)
    {

		await Navigation.PushAsync(new Cadastrar_Exercicio());
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

