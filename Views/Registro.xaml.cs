namespace jdiazExamen.Views;

public partial class Registro : ContentPage
{
    public string Username { get; }
    public Registro(string username)
    {
		InitializeComponent();
        Username = username;
        BindingContext = this; // Vincular el contexto para mostrar el usuario
    }

    public Registro()
    {
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        // Redirigir a la página Resumen
        Navigation.PushAsync(new Views.Resumen());
    }
}