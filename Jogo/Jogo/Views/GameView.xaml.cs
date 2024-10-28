using Jogo.ViewModels;

namespace Jogo.Views;

public partial class GameView : ContentPage
{
	public GameView()
	{
		InitializeComponent();
        BindingContext = new CartaViewModel();
    }

    private async void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
        await opcao1.ScaleTo(1.2, 250, Easing.CubicInOut);
        firstOption.IsVisible = true;
        firstOptionimg.IsVisible = true;
    }

    private async void PointerGestureRecognizer_PointerExited(object sender, PointerEventArgs e)
    {
        await opcao1.ScaleTo(1.0, 250, Easing.CubicInOut);
        firstOption.IsVisible = false;
        firstOptionimg.IsVisible = false;
    }

    private async void PointerGestureRecognizer_PointerExited_1(object sender, PointerEventArgs e)
    {
        await opcao2.ScaleTo(1.0, 250, Easing.CubicInOut);
        secondOption.IsVisible = false;
        secondOptionimg.IsVisible = false;
    }

    private async void PointerGestureRecognizer_PointerEntered_1(object sender, PointerEventArgs e)
    {
        await opcao2.ScaleTo(1.2, 250, Easing.CubicInOut);
        secondOption.IsVisible = true;
        secondOptionimg.IsVisible = true;
    }

    private async void voltar_menu_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MenuPrincipal");
    }

    private async void PointerGestureRecognizer_PointerEntered_2(object sender, PointerEventArgs e)
    {
        await inicio.ScaleTo(1.2,250,Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerExited_2(object sender, PointerEventArgs e)
    {
        await inicio.ScaleTo(1.0, 250, Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerEntered_3(object sender, PointerEventArgs e)
    {
        await fim.ScaleTo(1.2, 250, Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerExited_3(object sender, PointerEventArgs e)
    {
        await fim.ScaleTo(1.0, 250, Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerEntered_4(object sender, PointerEventArgs e)
    {
        await derrota.ScaleTo(1.2, 250, Easing.CubicInOut);
    }

    private async void PointerGestureRecognizer_PointerExited_4(object sender, PointerEventArgs e)
    {
        await derrota.ScaleTo(1.0, 250, Easing.CubicInOut);
    }
}