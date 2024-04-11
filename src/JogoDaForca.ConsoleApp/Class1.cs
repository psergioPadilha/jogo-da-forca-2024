
namespace JogoDaForca.ConsoleApp
{

    public class Imagens
    {
        #region Cabeçalho
        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("*             JOGO DA FORCA            *");
            Console.WriteLine("****************************************");
        }
        #endregion

        #region Cria a imagem inicial
        public void CriarImagemInicial()
        {
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |  /      |");
            Console.WriteLine(" | /");
            Console.WriteLine(" |/");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem com a cabeça
        public void CriarSegundaImagem()
        {
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |  /      |");
            Console.WriteLine(" | /       0");
            Console.WriteLine(" |/");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem com a cabeça e o corpo
        public void CriarTerceiraImagem()
        {
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |  /      |");
            Console.WriteLine(" | /       0");
            Console.WriteLine(" |/        X");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem com a cabeça, o corpo e os braços
        public void CriarQuartaImagem()
        {
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |  /      |");
            Console.WriteLine(" | /       0");
            Console.WriteLine(" |/       /X\\");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion

        #region Cria a imagem com a cabeça, o corpo, os braços e as pernas
        public void CriarQuintaImagem()
        {
            Cabecalho();
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(" |  /      |");
            Console.WriteLine(" | /       0");
            Console.WriteLine(" |/       /X\\");
            Console.WriteLine(" |        / \\");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine(" |");
            Console.WriteLine("_|____");
            Console.WriteLine();
        }
        #endregion
    }
}
