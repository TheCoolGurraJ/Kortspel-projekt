using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RaffleGame
{
    class Spelare
    {
        private string _namn;
        private int _poang;
        //Spelarens alla kort i en lista
        private List<Kort> _hand = new List<Kort>();
        private GroupBox _groupBox;
        private Button _BtTaBort;

        //Property för namn
        public string Namn
        {
            get { return _namn; }
        }

        //Property för poäng
        public int Poang
        {
            get { return _poang; }
            set { _poang++; }
        }

        //Property för hand
        public List<Kort> Hand
        {
            get { return _hand; }
        }

        public GroupBox GroupBox
        {
            get { return _groupBox; }
            set { _groupBox = value; }

        }

        public Button BtTaBort
        {
            get { return _BtTaBort; }
            set { _BtTaBort = value; }

        }

        //Konstruktor
        public Spelare()
        {
            _namn = "Namnlös";
            _poang = 0;
        }

        //Konstruktor
        public Spelare(string n)
        {
            _namn = n;
        }

        //Visar ett kort i spelarens hand
        public Kort VisaKort(int pos)
        {
            return _hand.ElementAt(pos);
        }
         
        //Ta emot ett kort till spelarens hand
        public void TaEmotKort(Kort K)
        {
            _hand.Add(K);
        }

        //Ger ett kort från spelarens hand
        public Kort GeKort(int pos)
        {
            Kort tmpkort;

            //Kopiera kortet
            tmpkort = _hand.ElementAt(pos);
            //Ta bort kortet från spelarens hand.
            _hand.RemoveAt(pos);
            //Terurnera kortet som ska ges ut.
            return tmpkort;
        }

        public void SorteraKortValor()
        {
            List<Kort> tmpLista = new List<Kort>();

            //Skapar en ny lista med sorterande kort.
            var sorteradLista = from kort in _hand
                                orderby kort.Valor, kort.Farg
                                select kort;

            //Kopierar till listan nyLista
            foreach (Kort kort in sorteradLista)
            {
                tmpLista.Add(kort);
            }

            _hand = tmpLista;
        }

        public void SorteraKortFarg()
        {
            List<Kort> tmpLista = new List<Kort>();

            //Skapar en ny lista med sorterade kort.
            var sorteradLista = from kort in _hand
                                orderby kort.Farg, kort.Valor
                                select kort;

            //Kopierar till hand
            foreach (Kort kort in sorteradLista)
            {
                tmpLista.Add(kort);
            }
            _hand = tmpLista;

        }
    }
}
