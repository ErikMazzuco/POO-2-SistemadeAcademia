using Sistema.Academia.Modelos;
namespace WebApp;


public partial class Cadastrar_Atendente : ContentPage
{
	public Cadastrar_Atendente()
	{
		InitializeComponent();
		this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}


/*private async void Cadastra_Atendente(object sender, EventArgs e){
	
      Atendente atendente = new();

		atendente.Nome = NomeEntry.Text;
		atendente.Cpf = CpfEntry.Text;
		atendente.Idade = int.Parse(IdadeEntry.Text);
		atendente.Salario = int.Parse(SalarioEntry.Text);
		atendente.Admissao = DateTime.Parse(DataAdmissao.Text);

      ResultadoLabel1.Text = atendente.ToString();
		await DisplayAlert("CADASTRADO!", $"O aluno {atendente.Nome} foi cadastrado com sucesso.", "CONCLUIR");

}*/


	private async void ButtonCancelAtendeteClicked(object sender, EventArgs e)
    {
			 await Navigation.PopAsync();

    }

	 private void Cadastra_Atendente(object sender, EventArgs e)
{
    var nome = NomeEntry.Text.ToUpper();
    var cpf = CpfEntry.Text;
    var idade = int.Parse(IdadeEntry.Text);
    var salario = int.Parse(SalarioEntry.Text);
    var admissao = DateTime.Parse(DataAdmissao.Text);

    var atendente = new Atendente
    {
        Nome = nome,
        Cpf = cpf,
        Idade = idade,
        Salario = salario,
        Admissao = admissao
    };

    // Inserir o aluno no banco
    DatabaseHelper.InsertAtendente(atendente);

    // Exibir uma mensagem de sucesso
    DisplayAlert("Sucesso", "Atendete cadastrado com sucesso!", "OK");

    // Limpar os campos
    NomeEntry.Text = string.Empty;
    CpfEntry.Text = string.Empty;
    IdadeEntry.Text = string.Empty;
    SalarioEntry.Text = string.Empty;
    DataAdmissao.Text = string.Empty;
}

}