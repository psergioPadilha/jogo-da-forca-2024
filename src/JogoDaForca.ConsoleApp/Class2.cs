namespace JogoDaForca.ConsoleApp
{
    public class ChanceDesperdicada
    {
        Imagens imagens = new Imagens();
        //int chanceDesperdicada;
        #region Verifica as chances desperdiçadas
        public int VerificarChancesDesperdicadas(bool caracterEncontrado, int chanceDesperdicada)
        {
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
                        Console.Write("game over!!!");
                        Console.ReadLine();
                        break;
                }
            }
            return chanceDesperdicada;
        }
        #endregion
    }
}
