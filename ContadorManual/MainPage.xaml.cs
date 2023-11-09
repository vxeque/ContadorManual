
using ContadorManual.Models;

namespace ContadorManual;

public partial class MainPage : ContentPage
{

    private Contador _contador;

    public MainPage()
    {
        InitializeComponent();
        _contador = new Contador();
        this.BindingContext = _contador;
    }

    private void onClickedContadorButton(object sender, EventArgs e)
    {
        // int rango = (int) RangoDelConteoSlider.Value;
        _contador.Contar();
    }

    private void onClickedReiniciarButton(object sender, EventArgs e)
    {
        _contador.Reiniciar();
    }
}

