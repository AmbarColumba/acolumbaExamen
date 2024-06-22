using System.Security.Principal;

namespace acolumbaExamen.Vistas;

public partial class Login : ContentPage
{
    string[] user = { "estudiante", "uisrael" };
    string[] pass = { "moviles", "2024"};
    public Login()
    {
        InitializeComponent();
    }

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        string userIngresado = txtUsuario.Text;
        string passIngresada = txtContraseña.Text;
        bool accesoUsuario = false;
        for (int i = 0; i < user.Length; i++)
        {
            if (userIngresado == user[i] && passIngresada == pass[i])
            {
                accesoUsuario = true;
                break;
            }

        }
        if (accesoUsuario)
        {
            Navigation.PushAsync(new Registro(userIngresado));
            //Limpiar();
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/contraseña Incorrectos", "Cerrar");
        }
    }

}