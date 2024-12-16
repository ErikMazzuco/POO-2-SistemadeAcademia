using Sistema.Academia.Modelos;
namespace WebApp;


public partial class Cadastrar_Aluno : ContentPage
{
	public Cadastrar_Aluno()
	{
		InitializeComponent();
	this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);

	}

    

    private async void ButtonCancel_Clicked(object sender, EventArgs e)
    {
			 await Navigation.PopAsync();

    }


    private void cadastrarAluno(object sender, EventArgs e)
{
    var nome = NomeEntry.Text.ToUpper();
    var cpf = CpfEntry.Text;
    var idade = int.Parse(IdadeEntry.Text);
    var sexo = SexoEntry.Text;
    var nascimento = DateTime.Parse(NascimentoEntry.Text);

    var aluno = new Aluno
    {
        Nome = nome,
        Cpf = cpf,
        Idade = idade,
        Sexo = sexo,
        Nascimento = nascimento
    };

    // Inserir o aluno no banco
    DatabaseHelper.InsertAluno(aluno);

    // Exibir uma mensagem de sucesso
    DisplayAlert("Sucesso", "Aluno cadastrado com sucesso!", "OK");

    // Limpar os campos
    NomeEntry.Text = string.Empty;
    CpfEntry.Text = string.Empty;
    IdadeEntry.Text = string.Empty;
    SexoEntry.Text = string.Empty;
    NascimentoEntry.Text = string.Empty;
}






}