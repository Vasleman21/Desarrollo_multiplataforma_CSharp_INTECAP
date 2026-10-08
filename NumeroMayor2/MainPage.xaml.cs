namespace NumeroMayor2;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void detectarNumeroMayor(object sender, EventArgs e)
	{
		int primerNumero = Convert.ToInt32(primerCampoNumero.Text);
		int segundoNumero = Convert.ToInt32(segundoCampoNumero.Text);

		if (primerNumero > segundoNumero){
			textoPresentarMayor.Text = primerNumero.ToString();
		}
		else{
			textoPresentarMayor.Text = segundoNumero.ToString();
		}
	}
}