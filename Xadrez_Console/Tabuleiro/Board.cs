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

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peça aqui");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
        
        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linha || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao invalida");
            }
        }
    }
}
