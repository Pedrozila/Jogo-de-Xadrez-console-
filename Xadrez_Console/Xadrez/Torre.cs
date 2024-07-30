using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Board tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p == null || p.Color != this.Color;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linha, Tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            //acima 
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != this.Color)
                {
                    break;
                }

                posicao.Linha = posicao.Linha - 1;
            }

            //abaixo
            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != this.Color)
                {
                    break;
                }

                posicao.Linha = posicao.Linha + 1;
            }

            //direita
            posicao.definirValores(Posicao.Linha, Posicao.Coluna +1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != this.Color)
                {
                    break;
                }

                posicao.Coluna = posicao.Coluna +1;
            }


            //esquerda
            posicao.definirValores(Posicao.Linha, Posicao.Coluna -1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != this.Color)
                {
                    break;
                }

                posicao.Coluna = posicao.Coluna -1;
            }

            return mat;
            
        }

    }
}
