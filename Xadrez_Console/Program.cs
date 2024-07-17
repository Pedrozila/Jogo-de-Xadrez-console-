using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando tabuleiro
            Board tab = new Board(8, 8);

            //colocando uma peça
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));



            //imprimindo tabuleiro na tela
            Tela.imprimeirTabuleiro(tab);
            Console.WriteLine();
        }
    }
}
