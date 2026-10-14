namespace SumaNumeros;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void generarSecuencia(object? sender, EventArgs e)
	{
		int total = 0;
		int pares = 0;
		int impares = 0;

		for (int t = 1; t <= 10; t++)
		{
			total += t;
		}

		for (int i = 1; i <= 10; i+=2){
			impares += i;

			/*
			if (i % 2 == 0)
			{
				pares += i;
			}
			else
			{
				impares += i;
			}
			*/
		}

		for (int p = 2; p <= 10; p+=2)
		{
			pares += p;
		}
		cajaTotal.Text = $"Suma total: {total}";
		cajaPares.Text = $"Pares: {pares}";
		cajaImpares.Text = $"Impares: {impares}";
	}
}