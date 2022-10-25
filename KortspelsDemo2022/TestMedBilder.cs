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
    public partial class TestMedBilder : Form
    {
        Kortlek kortlek = new Kortlek(true);
        Kort kort1;
        Kort kort2;

        public TestMedBilder()
        {
            InitializeComponent();
        }

        private void BtVisaKort_Click(object sender, EventArgs e)
        {
            kort1 = kortlek.GeKort();
            PbK1.Image = kort1.Bild;

            kort2 = kortlek.GeKort();
            PbK2.Image = kort2.Bild;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kort1.Valor>kort2.Valor)
            {
                TbHogstaKort.Text = kort1.Farg + " " + kort1.Valor + " är högst";
            }
            else if (kort1.Valor < kort2.Valor)
            {
                TbHogstaKort.Text = kort2.Farg + " " + kort2.Valor + " är högst"; ;
            }
            else
            {
                TbHogstaKort.Text = "Korten är lika stora!";
            }
        }
    }
}
