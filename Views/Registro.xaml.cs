//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jdiazExamen.Views;

public partial class Registro : ContentPage
{
    // Costo total del UPS
    private const double TotalCost = 300; 
    public string Username1 { get; }
    public Registro()
    {
		InitializeComponent();

    }
    public Registro(string username1)
    {
        InitializeComponent();
        Username1 = username1;
        // Vincular el contexto para mostrar el usuario
        BindingContext = this; 
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Calcular el monto inicial (15%)
        double initialPayment = TotalCost * 0.15;
        initialAmountEntry.Text = initialPayment.ToString("F2");

        // Calcular el monto restante
        double remainingAmount = TotalCost - initialPayment;

        // Calcular cuotas (5% adicional por cuota)
        double installment = (remainingAmount / 3) * 1.05; // Añadir el 5%

        // Mostrar el valor de la cuota mensual
        monthlyPaymentEntry.Text = installment.ToString("F2");
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        // Redirigir a la página Resumen
        Navigation.PushAsync(new Views.Resumen());
    }
}