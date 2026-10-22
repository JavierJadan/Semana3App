using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3App.Views;

public partial class vPrincipal : ContentPage
{
    public vPrincipal(string usuario)
    {
        InitializeComponent();
        DisplayAlertAsync("Bienvenido", usuario, "Cerrar");
        lblUsuario.Text = "Usuario Conectado " + usuario;
    }
}