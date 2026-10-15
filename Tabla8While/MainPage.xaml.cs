namespace Tabla8While;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void generarTabla(object? sender, EventArgs e)
	{
		resultadoTabla.Clear(); //Limpiamos la pantalla

		int contador = 1;

		while (contador <= 10)
		{
			//Creamos el Label para presentar la fila
			Label fila = new Label();
			//Agregamos el texto
			fila.Text = $"8 X {contador.ToString()} = {(contador * 8).ToString()}";
			//Agregamos la fila al Label
			resultadoTabla.Children.Add(fila);

			contador++;
		}
	}
}
