namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static string[] palavrasChaves = new string[30];
        public static int chanceDesperdicada = 0;
        public static ChanceDesperdicada chance = new ChanceDesperdicada();

        static void Main(string[] args)
        {
            while (true)
            {
                char palpite;
                chanceDesperdicada = 0;
                int controleDeAcertos = 0;
                bool caracterEncontrado = false;

                palavrasChaves = CarregarPalavrasChaves();

                string palavraSorteada = SortearPalavra();

                char[] caracteresEncontrados = new char[palavraSorteada.Length];

                PreenchaerCaracteresEncontrados(caracteresEncontrados);

                Imagens imagens = new Imagens();

                imagens.CriarImagemInicial();

                palpite = LerEntradaDoUsuario(caracteresEncontrados);

                Jogar(palavraSorteada, caracteresEncontrados, ref palpite, ref controleDeAcertos, ref caracterEncontrado);
            }
        }

        #region Jogo
        private static void Jogar(string palavraSorteada, char[] caracteresEncontrados, ref char palpite, ref int controleDeAcertos,
            ref bool caracterEncontrado)
        {
            while ((chanceDesperdicada < 4) && (controleDeAcertos < palavraSorteada.Length))
            {
                controleDeAcertos = VerificarSePalpiteJaFoiEncontrado(caracteresEncontrados, palpite, controleDeAcertos);
                VerificarSePalpiteEstaEntreAsLetrasDaPalavraSecreta(palavraSorteada, caracteresEncontrados, palpite, ref controleDeAcertos,
                    ref caracterEncontrado);
                
                chanceDesperdicada = chance.VerificarChancesDesperdicadas(caracterEncontrado, chanceDesperdicada);
                MensagemDeAcertoDaPalavraSecreta(caracteresEncontrados, controleDeAcertos);
                MensagemDeErroDaPalavraSecreta(palavraSorteada, caracteresEncontrados, ref palpite, controleDeAcertos, ref caracterEncontrado);
            }
        }
        #endregion

        #region Mensagem de erro da palavra secreta
        private static void MensagemDeErroDaPalavraSecreta(string palavraSorteada, char[] caracteresEncontrados, ref char palpite,
            int controleDeAcertos, ref bool caracterEncontrado)
        {
            if ((chanceDesperdicada != 4) && (controleDeAcertos < palavraSorteada.Length))
            {
                palpite = LerEntradaDoUsuario(caracteresEncontrados);
                caracterEncontrado = false;
            }
        }
        #endregion

        #region Mensagem de acerto da palavra secreta
        private static void MensagemDeAcertoDaPalavraSecreta(char[] caracteresEncontrados, int controleDeAcertos)
        {
            if (controleDeAcertos == caracteresEncontrados.Length)
            {
                Console.Write("PARABÉNS, VOCÊ DESCOBRIL A PALAVRA SECRETA!!!");
                Console.ReadLine();
            }
        }
        #endregion

        #region Verifica as chances desperdiçadas
        private static void VerificarChancesDesperdicadas(bool caracterEncontrado)
        {
            Imagens imagens = new Imagens();
            if (caracterEncontrado == true)
            {
                switch (chanceDesperdicada)
                {
                    case 0:
                        imagens.CriarImagemInicial();
                        break;
                    case 1:
                        imagens.CriarSegundaImagem();
                        break;
                    case 2:
                        imagens.CriarTerceiraImagem();
                        break;
                    case 3:
                        imagens.CriarQuartaImagem();
                        break;
                    case 4:
                        imagens.CriarQuintaImagem();
                        break;
                }
            }
            if (caracterEncontrado == false)
            {
                chanceDesperdicada++;
                switch (chanceDesperdicada)
                {
                    case 1:
                        imagens.CriarSegundaImagem();
                        break;
                    case 2:
                        imagens.CriarTerceiraImagem();
                        break;
                    case 3:
                        imagens.CriarQuartaImagem();
                        break;
                    case 4:
                        imagens.CriarQuintaImagem();
                        Console.Write("GAME OVER!!!");
                        Console.ReadLine();
                        break;
                }
            }
        }
        #endregion

        #region Verifica se o palpite feito pelo usuário está entre as letras da palavra secreta
        private static void VerificarSePalpiteEstaEntreAsLetrasDaPalavraSecreta(string palavraSorteada, char[] caracteresEncontrados, 
            char palpite, ref int controleDeAcertos, ref bool caracterEncontrado)
        {
            for (int i = 0; i < palavraSorteada.Length; i++)
            {
                if (palpite == palavraSorteada[i])
                {
                    caracteresEncontrados[i] = palavraSorteada[i];
                    caracterEncontrado = true;
                    controleDeAcertos++;
                }
            }
        }
        #endregion

        #region Verifica se o plapite feito pelo usuário já foi encontrado antes
        private static int VerificarSePalpiteJaFoiEncontrado(char[] caracteresEncontrados, char palpite, int controleDeAcertos)
        {
            for (int i = 0; i < caracteresEncontrados.Length; i++)
            {
                if (palpite == caracteresEncontrados[i])
                {
                    controleDeAcertos--;
                }
            }

            return controleDeAcertos;
        }
        #endregion

        #region Lê as entradas das letras digitadas pelo usuário
        private static char LerEntradaDoUsuario(char[] caracteresEncontrados)
        {
            char palpite;
            Console.WriteLine(caracteresEncontrados);
            Console.WriteLine();
            Console.Write("Qual o seu palpite: ");
            palpite = char.Parse(Console.ReadLine().ToUpper());
            return palpite;
        }
        #endregion

        #region Preenche os caracteres encontrados
        private static void PreenchaerCaracteresEncontrados(char[] caracteresEncontrados)
        {
            for (int i = 0; i < caracteresEncontrados.Length; i++)
            {
                caracteresEncontrados[i] = '_';
            }
        }
        #endregion

        #region Faz o sorteio da palavra secreta
        private static string SortearPalavra()
        {
            Random random = new Random();
            int enderecoDaPalavra = random.Next(palavrasChaves.Length);
            string palavraSorteada = (palavrasChaves[enderecoDaPalavra]);
            return palavraSorteada;
        }
        #endregion

        #region Carrega as palavras que deveram ser advinhadas em um array
        private static string[] CarregarPalavrasChaves()
        {
            string palavra = "ABACATE;ABACAXI;ACEROLA;AÇAÍ;ARAÇA;AMEIXA;BACABA;BACURI;BANANA;CAJÁ;CAJÚ;CARAMBOLA;CUPUAÇU;GRAVIOLA;GOIABA;JABUTICABA;" +
                "JENIPAPO;MAÇÃ;MANGABA;MANGA;MARACUJÁ;MURICI;PEQUI;PITANGA;PITAYA;SAPOTI;TANGERINA;UMBU;UVA;UVAIA";
            palavrasChaves = palavra.Split(';');
            return palavrasChaves;
        }
        #endregion
    }
}