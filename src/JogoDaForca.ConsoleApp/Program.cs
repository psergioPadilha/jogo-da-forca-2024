namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static string[] palavrasChaves = new string[30];
        static int chance = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                //CriarImagemInicial();
                //Console.WriteLine();
                //CriarSegundaImagem();
                //Console.WriteLine();
                //CriarTerceiraImagem();
                //Console.WriteLine();
                //CriarQuartaImagem();
                //Console.WriteLine();
                //CriarQuintaImagem();
                //Console.WriteLine();

                palavrasChaves = CarregarPalavrasChaves();

                string palavraSorteada = SortearPalavra();

                //EntradaDoJogador(palavraSorteada);

                CriarImagemInicial();
                //Console.WriteLine(palavraSorteada);
                //Console.WriteLine();
                //Console.Write("Qual o seu palpite: ");
                //char palpite = char.Parse(Console.ReadLine().ToUpper());
                char palpite;
                //int caracter = 0;
                int posicaoDoCaracter = 0;
                bool caracterEncontrado = false;
                //int posicao = 0;
                

                Console.WriteLine(palavraSorteada);
                char[] caracteresEncontrados = new char[palavraSorteada.Length];
                Console.WriteLine();
                Console.Write("Qual o seu palpite: ");
                palpite = char.Parse(Console.ReadLine().ToUpper());

                while (chance < 4)
                {
                    for (int i = 0; i < palavraSorteada.Length; i++)
                    {
                        if (palpite == palavraSorteada[i])
                        {
                            caracteresEncontrados[i] = palavraSorteada[i];
                            caracterEncontrado = true;
                        }
                    }
                    if (caracterEncontrado == true)
                    {
                        switch (chance)
                        {
                            case 0:
                                CriarImagemInicial();
                                Console.WriteLine(caracteresEncontrados);
                                break;
                            case 1:
                                CriarSegundaImagem();
                                Console.WriteLine(caracteresEncontrados);
                                break;
                            case 2:
                                CriarTerceiraImagem();
                                Console.WriteLine(caracteresEncontrados);
                                break;
                            case 3:
                                CriarQuartaImagem();
                                Console.WriteLine(caracteresEncontrados);
                                break;
                            case 4:
                                CriarQuintaImagem();
                                Console.WriteLine(caracteresEncontrados);
                                break;
                        }
                    }
                    if (caracterEncontrado == false)
                    {
                        chance++;
                        switch (chance)
                        {
                            case 1:
                                CriarSegundaImagem();
                                break;
                            case 2:
                                CriarTerceiraImagem();
                                break;
                            case 3:
                                CriarQuartaImagem();
                                break;
                            case 4:
                                CriarQuintaImagem();
                                break;
                        }
                    }
                    Console.WriteLine(palavraSorteada);
                    Console.WriteLine();
                    Console.Write("Qual o seu palpite: ");
                    palpite = char.Parse(Console.ReadLine().ToUpper());
                    caracterEncontrado = false;
                }
                Console.ReadLine();
            }
        }

        static void EntradaDoJogador(string palavraSorteada)
        {
            
        }

        #region Faz o sorteio da palavra secreta
        private static string SortearPalavra()
        {
            Random random = new Random();
            int enderecoDaPalavra = random.Next(palavrasChaves.Length);
            string palavraSorteada = (palavrasChaves[enderecoDaPalavra]);
            return palavraSorteada;
        }
        #endregion

        #region Apresenta as palavras contidas no array
        private static void ApresentarPalavrasChaves()
        {
            for (int i = 0; i < palavrasChaves.Length; i++)
            {
                Console.WriteLine((i + 1) + "º - " + palavrasChaves[i]);
            }
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

        #region Cria a imagem inicial
        static void CriarImagemInicial()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |/        |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem com a cabeça
        static void CriarSegundaImagem()
        {
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |/        |");
            Console.WriteLine(" |         0");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem a cabeça e o corpo
        static void CriarTerceiraImagem()
        {
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |/        |");
            Console.WriteLine(" |         0");
            Console.WriteLine(" |         X");
            Console.WriteLine(" |         X");
            Console.WriteLine(" |         X");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem com a cabeça, o corpo e os braços
        static void CriarQuartaImagem()
        {
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |/        |");
            Console.WriteLine(" |         0");
            Console.WriteLine(" |        /X\\");
            Console.WriteLine(" |       / X \\");
            Console.WriteLine(" |         X");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem com a cabeça, o corpo, os braços e as pernas
        static void CriarQuintaImagem()
        {
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |/        |");
            Console.WriteLine(" |         0");
            Console.WriteLine(" |        /X\\");
            Console.WriteLine(" |       / X \\");
            Console.WriteLine(" |         X");
            Console.WriteLine(" |        | |");
            Console.WriteLine(" |        | |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion
    }
}