using Sistema.Academia.Modelos;
namespace WebApp;


public partial class Cadastrar_Aluno : ContentPage
{
	public Cadastrar_Aluno()
	{
		InitializeComponent();
	

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		 
		 if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
        string.IsNullOrWhiteSpace(CpfEntry.Text) ||
        string.IsNullOrWhiteSpace(IdadeEntry.Text) ||
        string.IsNullOrWhiteSpace(SexoEntry.Text) ||
        string.IsNullOrWhiteSpace(NascimentoEntry.Text))
    {
        // Exibindo um alerta se algum campo estiver vazio
        await DisplayAlert("Erro", "Todos os campos são obrigatórios. Por favor, preencha todos.", "OK");
        return; // Impede que o código continue caso algum campo esteja vazio
    }
		
		Aluno aluno = new();

		aluno.Nome = NomeEntry.Text;
		aluno.Cpf = CpfEntry.Text;
		aluno.Idade = int.Parse(IdadeEntry.Text);
		aluno.Sexo = SexoEntry.Text;
		aluno.Nascimento = DateTime.Parse(NascimentoEntry.Text);

		ResultadoLabel1.Text = aluno.ToString();

		await DisplayAlert("CADASTRADO!", $"O aluno {aluno.Nome} foi cadastrado com sucesso.", "CONCLUIR");
		
    }

    private async void ButtonCancel_Clicked(object sender, EventArgs e)
    {
			 await Navigation.PopAsync();

    }






}