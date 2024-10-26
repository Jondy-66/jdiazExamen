using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace jdiazExamen.Views;

public partial class Resumen : ContentPage
{
    public string Username { get; }
    public string Nombre { get; }
    public string Apellido { get; }
    public string VA { get; }
    public DateTime Fecha { get; }
    public string Ciudad { get; }
    public string MontoInicial { get; }
    public string CuotaMensual { get; }
    public string PagoTotal{ get; }
    public Resumen()
	{
		InitializeComponent();
	}
    public Resumen(string username, string nombre, string apellido, string va, DateTime fecha, string ciudad, string montoInicial, string cuotaMensual)
    {
        InitializeComponent();

        // Calcular el pago total
        double pagoTotal = double.Parse(montoInicial) + (double.Parse(cuotaMensual) * 3);

        Username = username;
        Nombre = nombre;
        Apellido = apellido;
        VA = va;
        Fecha = fecha;
        Ciudad = ciudad;
        MontoInicial = montoInicial;
        CuotaMensual = cuotaMensual;
        PagoTotal = pagoTotal.ToString("F2");

        BindingContext = this; // Establecer el contexto de datos
    }
    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void btnCerrarsesion_Clicked(object sender, EventArgs e)
    {
        // Mostrar un mensaje de cierre sesion
        DisplayAlert("Cerrar sesi�n", "has cerrado sesion con exito", "OK");

        // Redirigir a la p�gina Registro
        Navigation.PushAsync(new Views.Registro());
        Navigation.PopToRootAsync();
    }
}