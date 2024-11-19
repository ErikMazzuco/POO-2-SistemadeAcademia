using Sistema.Academia.Modelos;
namespace WebApp;


public partial class Cadastrar_Atendente : ContentPage
{
	public Cadastrar_Atendente()
	{
		InitializeComponent();
	}


private async void Cadastra_Atendente(object sender, EventArgs e){
	
      Atendente atendente = new();

		atendente.Nome = NomeEntry.Text;
		atendente.Cpf = CpfEntry.Text;
		atendente.Idade = int.Parse(IdadeEntry.Text);
		atendente.Salario = int.Parse(SalarioEntry.Text);
		atendente.Admissao = DateTime.Parse(DataAdmissao.Text);

      ResultadoLabel1.Text = atendente.ToString();
		await DisplayAlert("CADASTRADO!", $"O aluno {atendente.Nome} foi cadastrado com sucesso.", "CONCLUIR");

}


	private async void ButtonCancelAtendeteClicked(object sender, EventArgs e)
    {
			 await Navigation.PopAsync();

    }
}