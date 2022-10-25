using System;
using System.Windows.Forms;

namespace KortspelsDemo2022
{
    public partial class EnkeltKortspel : Form
    {
        private Kortlek kortlek = new Kortlek(); //Skapa en ny kortlek med bilder.

        public EnkeltKortspel()
        {
            InitializeComponent();
        }

        private void BtDraKort_Click(object sender, EventArgs e)
        {
            Kort ettKort; //Instansvariabel.
            ettKort = kortlek.GeKort(); //Översta kortet i kortleken läggs i "ettKort".

            TbK1f.Text = ettKort.Farg.ToString(); //Visa kortets färg.
            TbK1v.Text = ettKort.Valor.ToString(); //Visa kortets valör.
        }
    }
}
