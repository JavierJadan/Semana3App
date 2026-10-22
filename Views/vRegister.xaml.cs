using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3App.Views;

public partial class vRegister : ContentPage
{
    public vRegister()
    {
        InitializeComponent();
    }

    private async void BtnGuardarUsuario_OnClicked(object? sender, EventArgs e)
    {
        string usuarioNuevo = txtUsuarioNuevo.Text;
        string contrasenaNueva = txtContrasenaNueva.Text;
        
        await Navigation.PushAsync(new Views.vLogin(usuarioNuevo, contrasenaNueva));
        await DisplayAlertAsync("Alerta", "Usuario guardado correctamente", "Cerrar");

    }

    private async void BtnCancelar_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vLogin());
    }
}