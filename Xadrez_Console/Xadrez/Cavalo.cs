using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Tabuleiro;


namespace Xadrez_Console.Xadrez
{
    internal class Cavalo : Peca
    {
        public Cavalo(Board tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "C";
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

            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna - 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.definirValores(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.definirValores(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.definirValores(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.definirValores(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }


            return mat;
        }

    }
}
