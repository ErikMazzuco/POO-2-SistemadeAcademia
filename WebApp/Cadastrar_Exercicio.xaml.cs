using Modelos;

namespace WebApp;

public partial class Cadastrar_Exercicio : ContentPage
{
	public Cadastrar_Exercicio()
	{
		InitializeComponent();
	}


  private async void ButtonCancel_Clicked(object sender, EventArgs e)
    {
			 await Navigation.PopAsync();

    }

private async void cadastrarExercicio(object sender, EventArgs e)
    {
			 

		if (string.IsNullOrWhiteSpace(NomeEntry.Text)){
			DisplayAlert("ERRO", "Preencha todos os campos antes de continuar.", "OK");
			return; 
		}

		if (GrupoMuscularPicker == null){
			DisplayAlert("Erro", "Por favor, selecione o Grupo Muscular!", "OK");
			return;
		}

		if (SeriesEntry == null){
			DisplayAlert("Erro", "Por favor, Preencha as Séries!", "OK");
			return;
		}
		if (RepeticoesEntry == null){
			DisplayAlert("Erro", "Por favor, Preencha as Repeticões!", "OK");
			return;
		}






		var Exercicio = new Exercicio
				{
					Nome = NomeEntry.Text,
					GrupoMuscular = GrupoMuscularPicker.Text,
					Series = int.Parse(SeriesEntry.Text),
					Repeticoes = int.Parse(RepeticoesEntry.Text),
					Descricao = DescricaoEntry.Text
				};

				// Inserir o user no banco
				DatabaseHelper.InsertExercicio(Exercicio);

			
				NomeEntry.Text = string.Empty;
				
				



    }



}