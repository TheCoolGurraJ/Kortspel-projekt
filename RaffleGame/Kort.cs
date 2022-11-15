using System.Drawing;

namespace RaffleGame
{
    class Kort
    {
        //Egen datatyp.
        public enum kortfarg
        {
            hjärter = 0,
            klöver = 1,
            ruter = 2,
            spader = 3
        }

        //Klassvariabler 
        private int _valor;
        private kortfarg _farg;
        private Image _bild;

        //Konstruktor.
        public Kort(int f, int v)
        {
            _farg = (kortfarg)f;
            _valor = v;
        }

        //Konstruktor kortlek med bilder.
        public Kort(int f, int v, Image b)
        {
            _farg = (kortfarg)f;
            _valor = v;
            _bild = b;
        }


        //Property för valör. 
        public int Valor
        {
            get { return _valor; }
        }

        //Property för färg.
        public kortfarg Farg
        {
            get { return _farg; }
        }

        //Property för bild.
        public Image Bild
        {
            get { return _bild; }
        }

    }
}
