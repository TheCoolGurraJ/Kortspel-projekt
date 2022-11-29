using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rules_popup;

namespace RaffleGame
{
    public partial class Startsidan : Form
    {
        int antalSpelare = 0;
        public Startsidan()
        {
            InitializeComponent();
        }

        private void Bt2Spelare_Click(object sender, EventArgs e)
        {
            VisaInput(2);
        }

        private void Bt3Spelare_Click(object sender, EventArgs e)
        {
            VisaInput(3);
        }

        private void VisaInput(int antal)
        {
            Bt2Spelare.Visible = false;
            Bt3Spelare.Visible = false;

            Bt_Klart.Visible = true;

            Lbl_instruktioner.Text = "Vänligen fyll i era namn i rutorna nedan.";

            Lbl_Sp1.Visible = true;
            Lbl_Sp2.Visible = true;

            Tb_Sp1.Visible = true;
            Tb_Sp2.Visible = true;

            if(antal == 3)
            {
                Lbl_Sp3.Visible = true;
                Tb_Sp3.Visible = true;
            }

            antalSpelare = antal;
        }

        private void Bt_Klart_Click(object sender, EventArgs e)
        {
            Spelet spelet = new Spelet();

            Spelare spelare1 = new Spelare(Tb_Sp1.Text);
            Spelare spelare2 = new Spelare(Tb_Sp2.Text);

            if (antalSpelare == 3)
            {
                Spelare spelare3 = new Spelare(Tb_Sp3.Text);
                spelet.SkapaSpelarList(spelare1, spelare2, spelare3);
            }
            else
            {
                spelet.SkapaSpelarList(spelare1, spelare2);
            }
            spelet.SpelSetup();
            spelet.ShowDialog();
            Close();

        }

        private void Tb_Sp3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Sp3_Click(object sender, EventArgs e)
        {

        }
    }
}
