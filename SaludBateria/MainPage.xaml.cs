namespace SaludBateria;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void analizarSaludBateria(object? sender, EventArgs e)
	{
		resultadoAnalisis.Clear();

		int hora = 1;
		int porcentajeActual = Convert.ToInt32(campoPorcentajeActual.Text);
		int consumoHora = Convert.ToInt32(campoConsumoHora.Text);

		while (porcentajeActual > 0)
		{
			porcentajeActual -= consumoHora;
			//Evito que el porcentaje salga en números negativos con if
			if (porcentajeActual < 0)
			{
				porcentajeActual = 0;
			}
			Label fila = new Label();
			fila.Text = $"Hora {hora}: Consumo = {consumoHora}% | Batería restante = {porcentajeActual}%";
			resultadoAnalisis.Children.Add(fila);

			hora++;
		}
	}
}
