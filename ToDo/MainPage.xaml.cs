namespace ToDo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	//Creamos la función para mostrar las tareas en la interfaz gráfica
	public void agregarTarea(object sender, EventArgs e){
		//Primero capturamos lo que el usuario escribió
		string textoCapturado = campoTarea.Text;
		string personaCapturada = campoPersona.Text;
		CheckBox casilla = new CheckBox(); //Creamos la casilla para marcar la tarea como completada
		Label textoPresentar = new Label(); //Creamos el label para presentar el texto que escribió el usuario
		textoPresentar.Text = $"{textoCapturado} {personaCapturada}";
		textoPresentar.FontSize = 16; //Cambiamos el tamaño del texto a presentar
		//Los dos guiones corresponden al object sender de arriba
		casilla.CheckedChanged += (_, _) => 
		textoPresentar.TextDecorations = casilla.IsChecked //.IsChecked válida que sea verdadero
		? TextDecorations.Strikethrough : TextDecorations.None; //Aquí se aplica y se quita el tachado
		HorizontalStackLayout fila = new HorizontalStackLayout(); //Creamos la fila para mostrar la casilla y el texto
		fila.Children.Add(casilla); //Ponemos la casilla en la fila
		fila.Children.Add(textoPresentar); //Ponemos el texto en la fila
		cajaTareas.Children.Add(fila); //Cargamos la fila a la cajaTareas
		campoTarea.Text = ""; //Limpiamos el texto anterior para agrergar una nueva tarea
		campoPersona.Text = "";
	}
}