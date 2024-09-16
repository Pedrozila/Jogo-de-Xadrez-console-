namespace Xadrez_Console.Tabuleiro
{
    internal class Posicao
    {
        internal int linha;

        public int Linha { get; set; }
        public int Coluna { get; set;}

        public Posicao()
        {
        }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + "," + Coluna;
        }

        public void definirValores(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
    }

}
