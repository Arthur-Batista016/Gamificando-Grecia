using Jogo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using Jogo.Services;
using System.Runtime.Intrinsics.X86;
using Jogo.Views;

namespace Jogo.ViewModels
{
    internal partial class CartaViewModel : ObservableObject
    {
        [ObservableProperty]
        private int id=1;

        [ObservableProperty]
        private bool inicio = true;

        [ObservableProperty]
        private Carta carta;

        [ObservableProperty]
        private Medidor medidor;

        [ObservableProperty]
        private string corTxt = "black";


        [ObservableProperty]
        private string texto = "General, o caminho será longo, deveríamos seguir para o Oeste ou para o Noroeste.";

        [ObservableProperty]
        private string image = "image1.png";

        [ObservableProperty]
        private string name = "Agapetos";

        [ObservableProperty]
        private int idMedidor = 0;


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
        private string momentoGuerra= "DIAS ATÉ A GUERRA:";

        [ObservableProperty]
        private int count = 0;

        [ObservableProperty]
        private bool inicioGuerra;

        [ObservableProperty]
        private bool fimGuerra;

        [ObservableProperty]
        private bool derrota;

        [ObservableProperty]
        private string motivoDerrota;


        [ObservableProperty]
        private string txtopc1 = "Vamos, para o Oeste";

        [ObservableProperty]
        private string txtopc2 = "Continuem no Noroeste";

        private int retorno = 0;

        [ObservableProperty]
        private string finalTxt1;

        [ObservableProperty]
        private string finalTxt2;

        [ObservableProperty]
        private string finalTxt3;

        CartaService cartaService;
        MedidorService medidorService;

        public ICommand GetCartaCommand { get; }
        public ICommand TrocarCartaCommand { get; }

        public ICommand Opcao1 { get; }
        public ICommand Opcao2 { get; }

        public ICommand FecharAvisoCommand { get; }

        private readonly INavigation _navigation;

        public CartaViewModel()
        {

            
            cartaService = new CartaService();
            medidorService = new MedidorService();
            Opcao1 = new Command(() =>
            {
                ModificarMedidor(1);
                TrocarCarta();
                contadorDias(1);
            });
            Opcao2 = new Command(() =>
            {
                ModificarMedidor(2);
                TrocarCarta();
                contadorDias(2);
            });

            FecharAvisoCommand = new Command(retirarAviso);
            
        }

       

        public async void ModificarMedidor(int opcao)
        {
            if (IdMedidor % 2 != 0) 
            {
                
                 IdMedidor += 1; 
                
            }
      
            if (opcao == 1)
            {
                
                IdMedidor += 1;
                
                
            }
            else if (opcao == 2 )
            {
                IdMedidor += 2;
               

            }
            Medidor = await medidorService.GetMedidorByIdAsync(idMedidor);

            EstatisExercito = Math.Min(EstatisExercito + Medidor.EstatisExercito, 100);
            EstatisMantimentos = Math.Min(EstatisMantimentos + Medidor.EstatisMantimentos, 100);
            EstatisConfianca = Math.Min(EstatisConfianca + Medidor.EstatisConfianca, 100);
            Convert.ToString(EstatisExercito);
            Convert.ToString(EstatisConfianca);
            Convert.ToString(EstatisMantimentos);

          if(EstatisMantimentos <= 0)
            {
                EstatisMantimentos = 0;
                Derrota = true;
                MotivoDerrota = "VOCE PERDEU TODOS OS SEUS MANTIMENTOS";
               
            }
            if (EstatisConfianca <= 0)
            {
                EstatisConfianca = 0;
                Derrota = true;
                MotivoDerrota = "VOCE PERDEU A CONFIANÇA DO SEU POVO";
                
            }
            else if (EstatisExercito <= 0)
            {
                EstatisExercito = 0;
                Derrota = true;
                MotivoDerrota = "VOCE PERDEU TODO O SEU EXÉRCITO";
               

            }

            

            if(IdMedidor >= 40)
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


            if(Id == 2 ||Id == 3 |Id==4|| Id == 6 || Id == 7 || Id == 14) {
                CorTxt = "White";
            }

          
            else
            {
                CorTxt = "black";
            }


            
        }

        public async void contadorDias(int opcao)
        {
           
           
            DiasGuerra = DiasGuerra -  1;
            Convert.ToString(DiasGuerra);
            if (Count == 0 && DiasGuerra == 0) {
                MomentoGuerra = "DIAS PARA O FIM DA GUERRA:";
                InicioGuerra = true;
                Count = 1;
                DiasGuerra = 5;

            }
            if(DiasGuerra == 0 && Count == 1)
            {
                /* arrumar para o medido manter-se no 0 e quando for para o menu, e iniciar um novo jogo, volte ao inicio padrao*/
                if (Derrota == false)
                {
                    InicioGuerra = false;
                    FimGuerra = true;
                   
                }
                else if(Derrota == true) {
                    InicioGuerra = false;
                    FimGuerra = false;
                   
                }
               
                if(opcao  == 1)
                {
                    FinalTxt1 = "GOOD ENDING";
                    FinalTxt2 = "Fazendo o impossível, o Rei Leônidas derrotou os 300 mil persas com seus 300 homens e alcançou a glória";
                    FinalTxt3 = "Bom trabalho... você defendeu seu povo!";

                }
                else if(opcao == 2)
                {
                    FinalTxt1 = "BAD ENDING";
                    FinalTxt2 = "Em um ato de misericórdia, o Rei Leônidas decidiu poupar os persas restantes, mas sofreu um ataque surpresa e morreu em combate...";
                    FinalTxt3 = "Você vencerá a guerra, mas à custo de sua vida... Siga em frente, Leônidas...";
                }

            }
            
        }



        public async void  retirarAviso()
        {
            InicioGuerra = false;
            FimGuerra = false;
            Derrota = false;
            Inicio = false;
          
        }

        

    }
}
