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
            // Obtenha os valores inseridos
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Verifique os dados (use o banco de dados ou um valor fixo para teste)
            if (username == "admin" && password == "1234") // Exemplo de validação fixa
            {
                //DisplayAlert("Sucesso", "Login realizado com sucesso!", "OK");
				await Navigation.PushAsync(new MainPage());
                // Navegue para outra página ou abra o sistema principal
            }
            else
            {
                DisplayAlert("Erro", "Usuário ou senha inválidos.", "OK");
            }
        }
}