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

    private async void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
        await iniciar.ScaleTo(1.1, 250, Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerExited(object sender, PointerEventArgs e)
    {
        await iniciar.ScaleTo(1.0, 250, Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerEntered_1(object sender, PointerEventArgs e)
    {
        await creditos.ScaleTo(1.1, 250, Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerExited_1(object sender, PointerEventArgs e)
    {
        await creditos.ScaleTo(1.0, 250, Easing.CubicInOut);
    }




    




}