namespace WebApp;

public partial class App : Application
{

	 public static int UsuarioLogadoId { get; set; }
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginPageUser());
	}
}
