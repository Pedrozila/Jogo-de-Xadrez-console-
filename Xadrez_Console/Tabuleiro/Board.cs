using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Console.Tabuleiro
{
    internal class Board
    {
        public int Linha { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Board(int linha, int colunas)
        {
            Linha = linha;
            Colunas = colunas;
            pecas = new Peca[linha, Colunas];
        }

        public Peca peca(int linha, int colunas) 
        {
            return pecas[linha, colunas];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
