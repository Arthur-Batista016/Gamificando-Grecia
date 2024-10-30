namespace Jogo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("GameView", typeof(Jogo.Views.GameView));
            Routing.RegisterRoute("MenuPrincipal", typeof(Jogo.Views.MenuPrincipal));
            Routing.RegisterRoute("Creditos",typeof(Jogo.Views.Creditos));
        }
    }
}
