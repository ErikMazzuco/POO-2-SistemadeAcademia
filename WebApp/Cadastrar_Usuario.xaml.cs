using Modelos;

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