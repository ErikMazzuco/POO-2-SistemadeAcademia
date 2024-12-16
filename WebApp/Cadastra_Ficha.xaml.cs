using Modelos;
using System.Data;

namespace WebApp;

public partial class Cadastra_Ficha : ContentPage
{
	public Cadastra_Ficha()
	{
		InitializeComponent();
		this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}

private void ButtonCadastra_Ficha(object sender, EventArgs e)
{
    var desc = DescEntry.Text.ToUpper();
	var data = DateTime.Now.Date;

    var ficha = new FichaTreino
    {

        Descricao = desc,
		DataCriacao = data
   
    };

    // Inserir o aluno no banco
    DatabaseHelper.InsertFichas(ficha);

    // Exibir uma mensagem de sucesso
    DisplayAlert("Sucesso", "Ficha criada!", "OK");

    // Limpar os campos
    DescEntry.Text = string.Empty;

}



}