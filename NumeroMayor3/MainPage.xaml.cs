namespace NumeroMayor3;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void detectarNumeroMayor3(object sender, EventArgs e)
	{
		int primerNumero = Convert.ToInt32(primerCampoNumero.Text);
		int segundoNumero = Convert.ToInt32(segundoCampoNumero.Text);
		int tercerNumero = Convert.ToInt32(tercerCampoNumero.Text);

		if (primerNumero > segundoNumero && primerNumero > tercerNumero){
			textoPresentarMayor.Text = primerNumero.ToString();
		}
		else if (segundoNumero > primerNumero && segundoNumero > tercerNumero){
			textoPresentarMayor.Text = segundoNumero.ToString();
			
		}
		else{
			textoPresentarMayor.Text = tercerNumero.ToString();
		}
	}
}