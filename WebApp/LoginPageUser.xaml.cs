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
                            // Obtenha os valores inseridos pelo usuário
                            string username = UsernameEntry.Text;
                            string password = PasswordEntry.Text;

                            // Obtenha a lista de usuários cadastrados no banco
                            var usuarios = DatabaseHelper.GetAllusers();

                            // Verifique se há algum usuário com o nome e a senha informados
                            var usuarioValido = usuarios.FirstOrDefault(u => u.User == username && u.Senha == password);

                            if (usuarioValido != null)
                            {
                                // Usuário encontrado, faça o login

                                // Salve o ID do usuário logado (exemplo usando Preferences)
                                    Preferences.Set("LoggedUserId", usuarioValido.Id);

                                
                                await Navigation.PushAsync(new MainPage());

                            }
                            else
                            {
                                // Usuário ou senha inválidos
                                await DisplayAlert("Erro", "Usuário ou senha inválidos.", "OK");
                            }
        }

        private async void Criar_Conta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cadastrar_Usuario());
        }
}