using Xadrez_Console.Xadrez;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Board tab, Cor cor) : base(cor, tab) 
        {

        }

        public override string ToString() 
        {
            return "R";
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

            //mover norte
            posicao.definirValores(Posicao.Linha -1, Posicao.Coluna);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //mover nordeste
            posicao.definirValores(Posicao.Linha -1, Posicao.Coluna +1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //mover leste
            posicao.definirValores(Posicao.Linha, Posicao.Coluna +1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //mover sudeste
            posicao.definirValores(Posicao.Linha +1, Posicao.Coluna +1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //mover sul
            posicao.definirValores(Posicao.Linha +1, Posicao.Coluna);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //mover sudoeste
            posicao.definirValores(Posicao.Linha +1, Posicao.Coluna -1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //mover oeste
            posicao.definirValores(Posicao.Linha, Posicao.Coluna -1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //mover noroeste
            posicao.definirValores(Posicao.Linha -1, Posicao.Coluna -1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }
            return mat;
        }
    }
}
