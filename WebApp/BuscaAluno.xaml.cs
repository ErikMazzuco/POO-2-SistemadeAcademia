using Sistema.Academia.Modelos;
namespace WebApp;

public partial class BuscaAluno : ContentPage
{
	public BuscaAluno()
	{
		InitializeComponent();
		CarregarAlunos();
		 this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
         
	}






private void AtualizarAlunos(object sender, EventArgs e)
{
    CarregarAlunos(); // Atualiza a lista de alunos
    DisplayAlert("Atualizado", "Lista de alunos carregada com sucesso!", "OK");
}




	


private void CarregarAlunos()
{
    try
    {
        // Busca os alunos no banco de dados
        var alunos = DatabaseHelper.GetAllAlunos();

        if (alunos.Count == 0)
        {
            DisplayAlert("Aviso", "Nenhum aluno cadastrado no momento!", "OK");
        }

        // Atribui a lista de alunos ao ListView
        AlunosListView.ItemsSource = alunos;
    }
    catch (Exception ex)
    {
        DisplayAlert("Erro", $"Erro ao carregar alunos: {ex.Message}", "OK");
    }
}



    
            private void ExcluirAluno(object sender, EventArgs e)
{
    var button = (ImageButton)sender; // O botão que foi clicado
    var aluno = (Aluno)button.BindingContext; // Objeto aluno no contexto
    var id = aluno.Id; // Obtenha o ID

    // Chame a função para excluir o aluno
    DatabaseHelper.DeleteAluno(id);

    // Exiba a mensagem
    DisplayAlert("Sucesso", $"Aluno com ID {id} excluído com sucesso!", "OK");
    
   CarregarAlunos();


    // Atualize a interface, como recarregar a lista de alunos
}

}