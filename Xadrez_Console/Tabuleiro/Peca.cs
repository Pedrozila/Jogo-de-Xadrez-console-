using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Console.Tabuleiro
{
    internal class Peca
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
    }
}
