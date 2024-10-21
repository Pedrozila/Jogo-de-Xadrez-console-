using Xadrez_Console.Xadrez;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez
{
    internal class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(Board tab, Cor cor, PartidaDeXadrez partida) : base(cor, tab) 
        {
            this.partida = partida;
        }

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

        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = Tabuleiro.peca(Posicao);
            return p != null && p is Torre && p.Color == Color && p.QteMovimentos == 0;
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

            //Jogada Especial Roque 
            if (QteMovimentos == 0 && !partida.xeque)
            {
                //Roque pequeno
                Posicao PosT1 = new Posicao(posicao.Linha, posicao.Coluna + 3);
                if (testeTorreParaRoque(PosT1))
                {
                    Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna + 1);
                    Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna + 2);
                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null)
                    {
                        mat[posicao.linha, posicao.Coluna + 2] = true;
                    }
                }
                //Roque grande
                Posicao PosT2 = new Posicao(posicao.Linha, posicao.Coluna - 4);
                if (testeTorreParaRoque(PosT1))
                {
                    Posicao p1 = new Posicao(posicao.Linha, posicao.Coluna - 1);
                    Posicao p2 = new Posicao(posicao.Linha, posicao.Coluna - 2);
                    Posicao p3 = new Posicao(posicao.Linha, posicao.Coluna - 3);
                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null && Tabuleiro.peca(p3) == null) 
                    {
                        mat[posicao.linha, posicao.Coluna - 2] = true;
                    }
                }
            }


            return mat;
        }
    }
}
