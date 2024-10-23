using Jogo.ViewModels;

namespace Jogo.Views;

public partial class GameView : ContentPage
{
	public GameView()
	{
		InitializeComponent();
        BindingContext = new CartaViewModel();
    }

    private void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
        firstOption.IsVisible = true;
        firstOptionimg.IsVisible = true;
    }

    private void PointerGestureRecognizer_PointerExited(object sender, PointerEventArgs e)
    {
        firstOption.IsVisible = false;
        firstOptionimg.IsVisible = false;
    }

    private void PointerGestureRecognizer_PointerExited_1(object sender, PointerEventArgs e)
    {
        secondOption.IsVisible = false;
        secondOptionimg.IsVisible = false;
    }

    private void PointerGestureRecognizer_PointerEntered_1(object sender, PointerEventArgs e)
    {
        secondOption.IsVisible = true;
        secondOptionimg.IsVisible = true;
    }
}