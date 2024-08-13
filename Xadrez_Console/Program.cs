using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimeirTabuleiro(partida.tab);
                        Console.WriteLine();

                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando Jogada: " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimeirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                }
            
                //imprimindo tabuleiro na tela
                Tela.imprimeirTabuleiro(partida.tab);
                Console.WriteLine();
            }
            catch (TabuleiroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
             
        }
    }
}
