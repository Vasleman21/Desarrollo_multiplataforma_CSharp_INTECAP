namespace DescuentoRestaurante;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void determinarTotal(object sender, EventArgs e)
	{
		decimal total = Convert.ToDecimal(campoTotal.Text);
		decimal valorDescuento;
		decimal totalConDescuento;
		decimal impuesto;
		decimal totalPagar;

		if (total > 100)
		{
			valorDescuento = total * 0.20m;
			textoPresentarDescuento.Text = $"Descuento: {valorDescuento.ToString()}";

			impuesto = total * 0.12m;
			textoPresentarImpuesto.Text = $"Impuesto: {impuesto.ToString()}";

			totalConDescuento = total - valorDescuento;
			totalPagar = totalConDescuento + impuesto;
			textoPresentarTotal.Text = $"Total a pagar: {totalPagar.ToString()}";
		}
		else
		{
			valorDescuento = total * 0.10m;
			textoPresentarDescuento.Text = $"Descuento: {valorDescuento.ToString()}";

			impuesto = total * 0.12m;
			textoPresentarImpuesto.Text = $"Impuesto: {impuesto.ToString()}";

			totalConDescuento = total - valorDescuento;
			totalPagar = totalConDescuento + impuesto;
			textoPresentarTotal.Text = $"Total a pagar: {totalPagar.ToString()}";
		}
	}
}