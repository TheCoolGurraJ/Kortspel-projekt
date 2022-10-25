using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KortspelsDemo2022
{
    public partial class TestMedSpelare : Form
    {
        //Skapa en spelare med namn: Nisse.
        Spelare sp1 = new Spelare("Nisse");
        //Skapa en spelare utan namn.
        Spelare sp2 = new Spelare();
        //Skapa en ny kortlek.
        Kortlek kortlek = new Kortlek(true);
        public TestMedSpelare()
        {
            InitializeComponent();
            //Skriv spelare 1 namn i gridboxen
            GbSp1.Text = sp1.Namn;
            //Skriv spelare 2 namn i gridboxen
            GbSp2.Text = sp2.Namn;
        }


        private void BtGe3kortSp1_Click_1(object sender, EventArgs e)
        {

            //Spelare 1 får ett kort från kortleken
            sp1.TaEmotKort(kortlek.GeKort());
            //Spelare 1 får ett kort från kortleken
            sp1.TaEmotKort(kortlek.GeKort());
            //Spelare 1 får ett kort från kortleken
            sp1.TaEmotKort(kortlek.GeKort());

            //Visa spelare 1 kort nr 1 i pb
            PbSp1K1.Image = sp1.VisaKort(0).Bild;
            //Visa spelare 1 kort nr 2 i pb
            PbSp1K2.Image = sp1.VisaKort(1).Bild;
            //Visa spelare 1 kort nr 3 i pb
            PbSp1K3.Image = sp1.VisaKort(2).Bild;

            //Lås knappen
            BtGe3kortSp1.Enabled = false;

        }

        private void BtSorteraSp1_Click(object sender, EventArgs e)
        {
            //Visa spelare 1 kort nr 1 i pb
            PbSp1K1.Image = sp1.VisaKort(0).Bild;
            //Visa spelare 1 kort nr 1 i pb
            PbSp1K1.Image = sp1.VisaKort(1).Bild;
            //Visa spelare 1 kort nr 1 i pb
            PbSp1K1.Image = sp1.VisaKort(2).Bild;

        }

        private void BtGe5kortSp2_Click_1(object sender, EventArgs e)
        {
            //Spelare 2 får ett kort från kortleken
            sp2.TaEmotKort(kortlek.GeKort());
            //Spelare 2 får ett kort från kortleken
            sp2.TaEmotKort(kortlek.GeKort());
            //Spelare 2 får ett kort från kortleken
            sp2.TaEmotKort(kortlek.GeKort());
            //Spelare 2 får ett kort från kortleken
            sp2.TaEmotKort(kortlek.GeKort());
            //Spelare 2 får ett kort från kortleken
            sp2.TaEmotKort(kortlek.GeKort());

            //Visa spelare 2 kort nr 1 i pb
            PbSp2K1.Image = sp2.VisaKort(0).Bild;
            //Visa spelare 2 kort nr 2 i pb
            PbSp2K2.Image = sp2.VisaKort(1).Bild;
            //Visa spelare 2 kort nr 3 i pb
            PbSp2K3.Image = sp2.VisaKort(2).Bild;
            //Visa spelare 2 kort nr 4 i pb
            PbSp2K4.Image = sp2.VisaKort(3).Bild;
            //Visa spelare 2 kort nr 5 i pb
            PbSp2K5.Image = sp2.VisaKort(4).Bild;


            //Lås knappen
            BtGe5kortSp2.Enabled = false;
        }
    }
}
