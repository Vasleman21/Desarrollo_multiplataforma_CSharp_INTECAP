namespace OperacionesMatematicas{

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        // Esta línea es el switch maestro: es la que lee tu XAML y lo fusiona con este C#
        InitializeComponent();
    }

        public void ejecutarSuma(object sender, EventArgs e)
        {
            //Este botoón primero debe capturar los números que el usuario ingresó
            TextoResultado.Text = (Convert.ToInt32(PrimerCampo.Text) + Convert.ToInt32(SegundoCampo.Text)).ToString(); 
            //.Text nos devuelve lo que el usuario escribió o ingresar texto
        }
    }
}