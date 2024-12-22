namespace WebApp;

public partial class BuscaAtendente : ContentPage
{
	public BuscaAtendente()
	{
		InitializeComponent();
        this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
		CarregarAtendente();
	}





	private void AtualizarAtendente(object sender, EventArgs e)
{
    CarregarAtendente(); // Atualiza a lista de alunos
    DisplayAlert("Atualizado", "Lista de Atendente carregada com sucesso!", "OK");
}


private void ExcluirAtendente(object sender, EventArgs e)
{
   
}

	


private void CarregarAtendente()
{
    try
    {
        // Busca os alunos no banco de dados
        var atendente = DatabaseHelper.GetAllAtendente();

        if (atendente.Count == 0)
        {
            DisplayAlert("Aviso", "Nenhum atendente cadastrado no momento!", "OK");
        }

        // Atribui a lista de alunos ao ListView
        AtendentesListView.ItemsSource = atendente;
    }
    catch (Exception ex)
    {
        DisplayAlert("Erro", $"Erro ao carregar alunos: {ex.Message}", "OK");
    }
}
}