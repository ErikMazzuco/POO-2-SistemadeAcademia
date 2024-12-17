using Modelos;
using System.Text.RegularExpressions;

namespace WebApp;

public partial class Cadastrar_Usuario : ContentPage
{
	public Cadastrar_Usuario()
	{
		InitializeComponent();
		this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}


	 private async void Cadastrar_User(object sender, EventArgs e)
        {




	var user = UsernameEntry.Text;
    var senha = PasswordEntry.Text;
    var senhaok = PasswordEntryConfirm.Text;


if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(senhaok))
    {
        await DisplayAlert("ERRO", "Preencha todos os campos antes de continuar.", "OK");
        return; // Interrompe a execução da função
    }



if (user.Length < 3)
    {
        await DisplayAlert("ERRO", "O nome de usuário deve ter pelo menos 3 caracteres.", "OK");
        return;
    }

if (user.Length > 100)
    {
        await DisplayAlert("ERRO", "O nome de usuário deve ter menos que 100 caracteres.", "OK");
        return;
    }




	if (senha.Length < 8)
    {
        await DisplayAlert("ERRO", "A senha do usuário deve ter pelo menos 8 caracteres.", "OK");
        return;
    }



if (!Regex.IsMatch(senha, @"[!@#$%^&*(),.?\:{}|<>]"))
    {
        await DisplayAlert("ERRO", "A senha deve conter pelo menos um caractere especial (!@#$%^&* etc.).", "OK");
        return;
    }


 
		if(senha == senhaok){
				var usuario = new Usuario
				{
					User = user,
					Senha = senha,
				};

				// Inserir o user no banco
				DatabaseHelper.Insertuser(usuario);

			
				UsernameEntry.Text = string.Empty;
				PasswordEntry.Text = string.Empty;
				PasswordEntryConfirm.Text = string.Empty;
				
				await Navigation.PushAsync(new LoginPageUser());
				
	}else

	DisplayAlert("ERRO", "Senhas Não Conhecidem", "OK");
			

		}
}