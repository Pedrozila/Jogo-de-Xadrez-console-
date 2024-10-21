using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.Tabuleiro;


namespace Xadrez_Console.Xadrez
{
    internal class Peao : Peca
    {
        public Peao(Board tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);
            return p != null && p.Color != Color;
        }

        private bool livre(Posicao pos)
        {
            return Tabuleiro.peca(pos) == null;
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

            if (Color == Cor.Branca)
            {
                posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && livre(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && livre(posicao) && QteMovimentos == 0)
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
            }
            else
            {
                posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && livre(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.posicaoValida(posicao) && livre(posicao) && QteMovimentos == 0)
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    mat[posicao.Linha, posicao.Coluna] = true;
                }
            }
            return mat;
        }
    }
}
        
            