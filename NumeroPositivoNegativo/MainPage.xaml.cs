namespace NumeroPositivoNegativo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void detectarNumeroPositivoNegativo(object sender, EventArgs e)
	{
		int numeroCapturado = Convert.ToInt32(campoNumero.Text);
		
		if (numeroCapturado > 0)
		{
			textoResultado.Text = "El número es positivo";
		}
		else{
			textoResultado.Text = "El número es negativo";
		}
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
    }
}
