namespace jdiazExamen.Views;

public partial class Login : ContentPage
{
    // Vectores de usuarios y contraseñas
    private string[] users = { "estudiante2024", "examen1 ", "NombreEstudiante" };
    private string[] passwords = { "uisrael2024", "parcial1", "2024" };
    public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string username = Username.Text;
        string password = Password.Text;

        // Validar si el usuario y la contraseña son correctos
        bool isValid = false;
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] == username && passwords[i] == password)
            {
                isValid = true;
                break;
            }
        }

        if (isValid)
        {
            // Mostrar un mensaje de bienvenida
            DisplayAlert("Bienvenido", $"Hola {username}, has iniciado sesión con éxito.", "OK");

            // Redirigir a la página vHome
            Navigation.PushAsync(new Views.Registro());
        }
        else
        {
            // Mostrar un mensaje de error
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }


    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        DisplayAlert("Acerca de", "Este programa fue desarrollado por Jonathan", "Cerrar");
    }
}