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
        string usuarioNuevo = txtUsuarioNuevo.Text?.Trim() ?? string.Empty;
        string contrasenaNueva = txtContrasenaNueva.Text ?? string.Empty;

        if (string.IsNullOrWhiteSpace(usuarioNuevo) || string.IsNullOrWhiteSpace(contrasenaNueva))
        {
            await DisplayAlertAsync("Datos incompletos", "Ingrese el usuario y la contraseña.", "Cerrar");
            return;
        }

        await DisplayAlertAsync("Registro", "Usuario guardado correctamente.", "Continuar");

        // Los datos se envían a vLogin mediante su constructor.
        await Navigation.PushAsync(new vLogin(usuarioNuevo, contrasenaNueva));

    }

    private async void BtnCancelar_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
