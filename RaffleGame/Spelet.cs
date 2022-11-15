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

namespace KortspelsDemo2022
{
    public partial class TestMedSpelare : Form
    {
        Spelare sp1 = new Spelare("Ahmed");
        Spelare sp2 = new Spelare("Peter");
        Spelare sp3 = new Spelare("Nicklas");

        //lista över alla spelare så att vi lätt kan iterera över de.
        Spelare[] SpelarList = new Spelare[3];

        //den spelare som har sin tur just nu.
        Spelare currSpelare;

        //Skapa en ny kortlek.
        Kortlek kortlek = new Kortlek(true);
        public TestMedSpelare()
        {
            InitializeComponent();

            GbSp1.Text = sp1.Namn;
            GbSp2.Text = sp2.Namn;
            GbSp3.Text = sp3.Namn;

            //Koppla ihop varje spelares groupbox till deras property.
            sp1.GroupBox = GbSp1;
            sp2.GroupBox = GbSp2;
            sp3.GroupBox = GbSp3;

            //Koplla ihop knappen för att ta bort med spelarnas properties.
            sp1.BtTaBort = BtTaBortsp1;
            sp2.BtTaBort = BtTaBortsp2;
            sp3.BtTaBort = BtTaBortsp3;

            //Sätt in alla spelare i listan
            SpelarList[0] = sp1;
            SpelarList[1] = sp2;
            SpelarList[2] = sp3;

            //viktigt att blanda innan man spelar :)
            kortlek.BlandaKortlek();

            //först på tur är spelare nmr 1
            currSpelare = SpelarList[0];

            StartaSpelet();

        }

        private void StartaSpelet()
        {
            InaktiveraAndraSpelare();
            //Ge kort till alla spelare och visa de i deras händer.
            for(int i = 0; i<SpelarList.Length;i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Kort kort = kortlek.GeKort();
                    SpelarList[i].TaEmotKort(kort);

                    //Visa bilden i spelarens hand.
                    PictureBox PbSpelare = SpelarList[i].GroupBox.Controls[k] as PictureBox;
                    PbSpelare.Image = kort.Bild;
                    PbSpelare.Click += PbSpelare_Click;
                    
                }
            }


        }

        private void PbSpelare_Click(object sender, EventArgs e)
        {
            PictureBox PbSpelare = sender as PictureBox;
            //Ta bort kortet från denna position.
            int Pbindex = currSpelare.GroupBox.Controls.IndexOf(PbSpelare);
            
        }

        private void NästaSpelare()
        {
            int currSpelareIndex = SpelarList.ToList().IndexOf(currSpelare);

            if ( currSpelareIndex >= 2)
            {
                //klart
            }
            else
            {
                currSpelare = SpelarList[currSpelareIndex + 1];
            }
             


        }

        private void InaktiveraAndraSpelare()
        {
            //Göm alla andra ta bort knappar förutom nuvarande spelares tur.
            foreach (Spelare spelare in SpelarList)
            {
                if (spelare != currSpelare)
                {
                    //Inaktiver andra spelares funktionaliteter.
                    spelare.BtTaBort.Enabled = false;
                    foreach(PictureBox Pb in spelare.GroupBox.Controls)
                    {
                        Pb.Enabled = false;
                    }
                }
                else
                {
                    //Aktivera nuvarande spelares funktionaltiteter.
                    spelare.BtTaBort.Enabled = true;
                    foreach (PictureBox Pb in spelare.GroupBox.Controls)
                    {
                        Pb.Enabled = true;
                    }
                }

            }
        }

        private void BtTaBort_Click(object sender, EventArgs e)
        {

        }

        private void bt_regler_Click(object sender, EventArgs e)
        {
            Regler popup = new Regler();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
