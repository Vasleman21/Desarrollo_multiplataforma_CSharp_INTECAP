
namespace ProyeccionAhorro;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void proyeccionAhorro(object? sender, EventArgs e)
	{
		resultadoAhorro.Clear();

		int mesActual = 1;
		decimal ahorro = Convert.ToDecimal(campoTotal.Text);
		int meses = Convert.ToInt32(campoMeses.Text);
		decimal acumulado = 0m;

		while (mesActual <= meses)
		{
			acumulado += ahorro;
			Label fila = new Label();
			fila.Text = $"Mes {mesActual} = {ahorro:F2} | Acumulado = {acumulado:F2}";
			resultadoAhorro.Children.Add(fila);

			mesActual++;
		}
	}
}
