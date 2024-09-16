using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Tabuleiro;


namespace Xadrez_Console.Xadrez
{
    internal class Dama : Peca
    {
        public Dama(Board tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "D";
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

            // Esquerda
            posicao.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha, posicao.Coluna - 1);
            }

            // Direita
            posicao.definirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha, posicao.Coluna + 1);
            }

            // Acima
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha - 1, posicao.Coluna);
            }

            // Abaixo
            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha + 1, posicao.Coluna);
            }

            // NO
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha - 1, posicao.Coluna - 1);
            }

            // NE
            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha - 1, posicao.Coluna + 1);
            }

            // SE
            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha + 1, posicao.Coluna + 1);
            }

            // SO
            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Color != Color)
                {
                    break;
                }
                posicao.definirValores(posicao.Linha + 1, posicao.Coluna - 1);
            }
            return mat;
        }

    }
}