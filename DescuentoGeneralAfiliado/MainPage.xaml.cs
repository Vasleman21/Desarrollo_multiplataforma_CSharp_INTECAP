namespace DescuentoGeneralAfiliado;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void determinarTotal(object sender, EventArgs e)
	{
		decimal precioBase = Convert.ToDecimal(campoTotal.Text);
		string tipoCliente = Convert.ToString(campoTipoCliente.Text).ToUpper();
		string tipoPago = Convert.ToString(campoTipoPago.Text).ToUpper();
		decimal valorDescuento;
		decimal valorRecargo;
		decimal precioFinal;

		if (tipoCliente == "G" && tipoPago == "C"){
			valorDescuento = precioBase * 0.15m;
			textoPresentarDescuentoRecargo.Text = $"Descuento: {valorDescuento.ToString()}";

			precioFinal = precioBase - valorDescuento;
			textoPresentarTotal.Text = $"Total a pagar: {precioFinal.ToString()}";
		}
	}
}