namespace jdiazExamen.Views;

public partial class Resumen : ContentPage
{
    public string Username { get; }
    public string Nombre { get; }
    public string Apellido { get; }
    public string VA { get; }
    public DateTime Fecha { get; }
    public string Cuidad { get; }
    public string MontoInicial { get; }
    public string CuataMensual { get; }
    public string PagoTotal{ get; }
    public Resumen()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void btnCerrarsesion_Clicked(object sender, EventArgs e)
    {
        // Mostrar un mensaje de bienvenida
        DisplayAlert("Cerrar sesión", "has cerrado sesion con exito", "OK");

        // Redirigir a la página vHome
        Navigation.PushAsync(new Views.Registro());
        Navigation.PopToRootAsync();
    }
}