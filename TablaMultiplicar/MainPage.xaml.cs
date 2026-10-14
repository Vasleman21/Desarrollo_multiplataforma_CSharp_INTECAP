namespace TablaMultiplicar;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void generarSecuencia(object? sender, EventArgs e)
	{
		for (int contador = 1; contador <= 10; contador++)
		{
			//Creamos un label en cada iteración
			Label textoNumero = new Label();
			textoNumero.Text = $"8 X {contador.ToString()} = {(contador * 8).ToString()}"; //Le insertamos un texto al label
			/*En la interfaz gráfica se se creo un StackLayout, para mostrar los números
			aqui cargamos el label a ese StackLayout*/
			cajaNumeros.Add(textoNumero);
		}
	}
}