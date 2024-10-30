namespace Jogo.Views;

public partial class MenuPrincipal : ContentPage
{
	public MenuPrincipal()
	{
		InitializeComponent();
	}

    private async void jogar_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("GameView");
    }

    private async void creditos_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Creditos");
    }
}