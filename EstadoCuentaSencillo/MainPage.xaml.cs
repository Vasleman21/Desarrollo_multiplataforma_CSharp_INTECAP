namespace EstadoCuentaSencillo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void generarSecuencia(object? sender, EventArgs e)
	{
		decimal total = Convert.ToDecimal(campoTotal.Text);
		int cuotas = Convert.ToInt32(campoCuotas.Text);
		decimal valorCuotas = total / cuotas;
		decimal saldoPendiente = total;
		string texto = "";

		for (int cuota = 1; cuota <= cuotas; cuota++)
		{
			saldoPendiente -= valorCuotas;
			//Creamos un label en cada iteración
			Label textoNumero = new Label();
			texto = $"Mes {cuota}: Cuota = {Math.Round(valorCuotas, 2)} | Saldo restante = {Math.Round(saldoPendiente, 2)}";
			textoNumero.Text = texto.ToString();

			cajaTextos.Add(textoNumero);
		}
	}
}
