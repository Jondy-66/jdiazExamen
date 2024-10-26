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
    public string TotalPayment { get; }
    public Resumen()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}