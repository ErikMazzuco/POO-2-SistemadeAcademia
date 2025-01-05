using Modelos;

namespace WebApp;

public partial class GerenciamentoFichaTreino : ContentPage
{
	public GerenciamentoFichaTreino()
	{
		InitializeComponent();
		CarregarFichas();
			this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        CarregarFichas();
    }


	private async void CadastrarFichaTreino(object sender, EventArgs e)
    {

		await Navigation.PushAsync(new Cadastra_Ficha());


	}




private void CarregarFichas()
{
    try
    {
        // Busca os alunos no banco de dados
        var Fichas = DatabaseHelper.GetAllFichas();

        if (Fichas.Count == 0)
        {
            DisplayAlert("Aviso", "Nenhuma Ficha cadastrada no momento!", "OK");
        }

        FichasListView.ItemsSource = Fichas;
    }
    catch (Exception ex)
    {
        DisplayAlert("Erro", $"Erro ao carregar Fichas: {ex.Message}", "OK");
    }
}



    
            private void ExcluirFicha(object sender, EventArgs e)
{
    var button = (ImageButton)sender; // O botão que foi clicado
    var Ficha = (FichaTreino)button.BindingContext; // Objeto aluno no contexto
    var id = Ficha.Id; // Obtenha o ID

    // Chame a função para excluir o aluno
    DatabaseHelper.DeleteFicha(id);

    // Exiba a mensagem
    DisplayAlert("Sucesso", $"Ficha com ID {id} excluído com sucesso!", "OK");
    
   CarregarFichas();

}











	private async void EditFichaTreino(object sender, EventArgs e)
    {



		
	}

	private async void ExcluirFuchatreino(object sender, EventArgs e)
    {



		
	}




	
}