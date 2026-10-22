using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3App.Views;

public partial class vLogin : ContentPage
{
    string usuario = ""; 
    string contrasena = "";
    
    
    public vLogin()
    {
        InitializeComponent();
    }

    public vLogin(string usuarionuevo, string contrasenanueva)
    {
        usuario = usuarionuevo;
        contrasena = contrasenanueva;
        InitializeComponent();
    }

    private async void  BtnIniciar_OnClicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtPassword.Text;

            if (usuario == usuarioIngresado && contrasena == contrasenaIngresada)
            {
              await   Navigation.PushAsync(new Views.vPrincipal(usuario));
            }
            else
            { 
              await  DisplayAlertAsync("Error", "Usuario/Contraseña incorrectos", "Cerrar");
              txtUsuario.Text = "";
              txtPassword.Text = "";
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            await DisplayAlertAsync("Error", "Error", "Cerrar");
        }
        
    }

    private async void BtnRegistrar_OnClicked(object sender, EventArgs e)
    {
       await  Navigation.PushAsync(new Views.vRegister());
    }
}