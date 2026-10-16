namespace PrestamoBancario;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void generarPrestamo(object? sender, EventArgs e)
	{
		resultadoPrestamo.Clear();

		decimal montoPrestado = Convert.ToDecimal(campoTotal.Text);
		int meses = Convert.ToInt32(campoMeses.Text);
		decimal cuotaMensual = montoPrestado / meses;
		int mes = 1;

		while (mes <= meses)
		{
			decimal interes = montoPrestado * 0.015m;

			if (mes == meses)
			{
				cuotaMensual = montoPrestado;
			}

			decimal pagoMensual = cuotaMensual + interes; //Se agrega el interés a la cuota mensual
			montoPrestado -= cuotaMensual;

			Label fila = new Label();
			fila.Text = $"Mes {mes}: Cuota = {pagoMensual:F2} (int: {interes:F2}) | Saldo = {montoPrestado:F2}";
			resultadoPrestamo.Children.Add(fila);

			mes++;
		}
	}
}