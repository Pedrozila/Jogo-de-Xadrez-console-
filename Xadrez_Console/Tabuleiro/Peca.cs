using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Console.Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Color { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Board Tabuleiro { get; protected set; }

        public Peca(Cor color, Board tabuleiro)
        {
            Posicao = null;
            Color = color;
            Tabuleiro = tabuleiro;
            QteMovimentos = 0;
        }

        public bool existeMovimentoPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linha; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPossiveis();

        public void incrementarQtdMovimento()
        {
            QteMovimentos ++;
        }
    }
}
