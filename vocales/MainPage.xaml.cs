namespace vocales;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void detectarVocal(object sender, EventArgs e)
	{
		string letraCapturada = (campoLetra.Text).ToUpper();
		if (letraCapturada == "A" || letraCapturada == "E" || letraCapturada == "I" || letraCapturada == "O" || letraCapturada == "U"){
			textoResultado.Text = "VOCAL";
		}
		else
		{
			textoResultado.Text = "CONSONANTE";
		}
	}
}
//! Yo ya había aprendindo C# antes por eso se el uso del OR (||), NO ES IA