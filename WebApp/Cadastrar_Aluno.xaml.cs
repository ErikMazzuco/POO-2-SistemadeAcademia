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


protected override void OnAppearing()
{
    base.OnAppearing();

    // Definir a data máxima para hoje
    NascimentoDatePicker.MaximumDate = DateTime.Now;
}




    

    private async void ButtonCancel_Clicked(object sender, EventArgs e)
    {
			 await Navigation.PopAsync();

    }


    private void cadastrarAluno(object sender, EventArgs e)
{


    //Pegar o Sexo

    string sexoSelecionado = null;

if (MasculinoRadioButton.IsChecked)
{
    sexoSelecionado = "Masculino";
}
else if (FemininoRadioButton.IsChecked)
{
    sexoSelecionado = "Feminino";
}
else if (OutroRadioButton.IsChecked)
{
    sexoSelecionado = "Outro";
}


if (string.IsNullOrWhiteSpace(NomeEntry.Text))
{
    DisplayAlert("Erro", "O campo Nome está vazio!", "OK");
    return;
}
if (string.IsNullOrWhiteSpace(CpfEntry.Text))
{
    DisplayAlert("Erro", "O campo CPF está vazio!", "OK");
    return;
}
if (!int.TryParse(CpfEntry.Text, out int cpfteste))
{
    DisplayAlert("Erro", "O CPF deve conter apenas números!", "OK");
    return;
}

if (string.IsNullOrWhiteSpace(IdadeEntry.Text))
{
    DisplayAlert("Erro", "O campo Idade está vazio!", "OK");
    return;
}
if (!int.TryParse(IdadeEntry.Text, out int idadeteste))
{
    DisplayAlert("Erro", "A idade deve conter apenas números!", "OK");
    return;
}

if (NascimentoDatePicker.Date == DateTime.Now)
{
    DisplayAlert("Erro", "Por favor, selecione uma data de nascimento!", "OK");
    return;
}

if (NascimentoDatePicker.Date == NascimentoDatePicker.MinimumDate)
{
    DisplayAlert("Erro", "Por favor, selecione uma data de nascimento válida!", "OK");
    return;
}

if (sexoSelecionado == null)
{
    DisplayAlert("Erro", "Por favor, selecione o Sexo!", "OK");
    return;
}


    var nome = NomeEntry.Text.ToUpper();
    var cpf = CpfEntry.Text;
    var idade = int.Parse(IdadeEntry.Text);
    var sexo = sexoSelecionado;
    var nascimento = NascimentoDatePicker.Date;

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
    
    // Resetar os RadioButtons
    MasculinoRadioButton.IsChecked = false;
    FemininoRadioButton.IsChecked = false;
    OutroRadioButton.IsChecked = false;
}






}