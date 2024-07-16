using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board tab = new Board(8, 8);
            Tela.imprimeirTabuleiro(tab);
            Console.WriteLine();
        }
    }
}
