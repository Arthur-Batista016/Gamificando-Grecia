using Jogo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Jogo.Services;
using System.Runtime.Intrinsics.X86;

namespace Jogo.ViewModels
{
    internal partial class CartaViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id=1;

        [ObservableProperty]
        private Carta carta;

        [ObservableProperty]
        private Medidor medidor;


        [ObservableProperty]
        private string texto = "General, o caminho será longo, deveríamos seguir para o Oeste ou para o Noroeste.";

        [ObservableProperty]
        private string image = "image1.png";

        [ObservableProperty]
        private string name = "Agapetos";

        [ObservableProperty]
        private int idMedidor = 1;


        [ObservableProperty]
        private int estatisMantimentos = 100;
        
        [ObservableProperty]
        private int estatisExercito = 100;
        
        [ObservableProperty]
        private int estatisConfianca = 100;

        [ObservableProperty]
        private int diasGuerra = 15;

        [ObservableProperty]
        private string textoGuerra;

        [ObservableProperty]
        private int count = 0;

        [ObservableProperty]
        private bool inicioGuerra;

        [ObservableProperty]
        private string txtopc1 = "Vamos, para o Oeste";

        [ObservableProperty]
        private string txtopc2 = "Continuem no Noroeste";

        private int retorno = 0;


        CartaService cartaService;
        MedidorService medidorService;

        public ICommand GetCartaCommand { get; }
        public ICommand TrocarCartaCommand { get; }

        public ICommand Opcao1 { get; }
        public ICommand Opcao2 { get; }

        public ICommand FecharAvisoCommand { get; }

        public CartaViewModel()
        {
           
            cartaService = new CartaService();
            medidorService = new MedidorService();
            Opcao1 = new Command(() =>
            {
                ModificarMedidor(1);
                TrocarCarta();
                contadorDias();
            });
            Opcao2 = new Command(() =>
            {
                ModificarMedidor(2);
                TrocarCarta();
                contadorDias();
            });

            FecharAvisoCommand = new Command(retirarAviso);
            
        }

       

        public async void ModificarMedidor(int opcao)
        {
           
            Medidor = await medidorService.GetMedidorByIdAsync(id);
            if (opcao == 1)
            {
                IdMedidor += 1;
                EstatisExercito = EstatisExercito + Medidor.EstatisExercito;
                EstatisConfianca = EstatisConfianca +  Medidor.EstatisConfiaca;
                EstatisMantimentos = EstatisMantimentos + Medidor.EstatisMantimentos;
                Convert.ToString(estatisExercito);
                Convert.ToString(estatisConfianca);
                Convert.ToString(estatisMantimentos);
                IdMedidor += 1;
            }
            else if (opcao == 2 )
            {
                IdMedidor += 2;
                EstatisExercito = EstatisExercito + Medidor.EstatisExercito;
                EstatisConfianca = EstatisConfianca + Medidor.EstatisConfiaca;
                EstatisMantimentos = EstatisMantimentos + Medidor.EstatisMantimentos;
                Convert.ToString(EstatisExercito);
                Convert.ToString(EstatisConfianca);
                Convert.ToString(EstatisMantimentos);

            }

            if (EstatisConfianca>100 || EstatisExercito>100 || EstatisMantimentos > 100)
            {
                EstatisMantimentos = 100;
                EstatisExercito = 100;
                EstatisExercito = 100;

            }

            if(IdMedidor >= 6)
            {
                IdMedidor = 0;
            }

           
            
        }
       
        public async void TrocarCarta()
        {
            Id += 1;

            

            if (Id <= 20) {
                Image = "image" + Id + ".png";
                Carta = await cartaService.GetCartaByIdAsync(Id);
                Name = Carta.personName;
                Texto = Carta.personTexto;
                Txtopc1 = Carta.PersonOpc1;
                Txtopc2 = Carta.PersonOpc2;


            }
            else if (Id>20)
            {
                Id = 1;
                Image = "image" + Id + ".png";
                Name = "Agapetos";
                Texto = "General, o caminho será longo, deveríamos seguir para o Oeste ou para o Noroeste?";
                 Txtopc1 = Carta.PersonOpc1;
                Txtopc2 = Carta.PersonOpc2;
            }     
            
        }

        public async void contadorDias()
        {
           
           
            DiasGuerra = DiasGuerra -  1;
            Convert.ToString(DiasGuerra);
            if (Count == 0 && DiasGuerra == 0) {
                InicioGuerra = true;
                Count = 1;
                DiasGuerra = 5;

            }
            if(DiasGuerra == 0 && Count == 1)
            {
                InicioGuerra = false;
                DiasGuerra = 15;
                count = 0;
                Application.Current.MainPage.DisplayAlert("PARABÉNS", "VOCÊ SOBREVIVEU A GUERRA FINALIZOU O JOGO!", "Voltar do Começo");
                Id = 1;
                Image = "image" + Id + ".png";
                Name = "Agapetos";
                Texto = "General, o caminho será longo, deveríamos seguir para o Oeste ou para o Noroeste?";
                EstatisMantimentos = 100;
                EstatisExercito = 100;
                EstatisExercito = 100;


            }
            
        }

        public void retirarAviso()
        {
            InicioGuerra = false;
        }

        

    }
}
