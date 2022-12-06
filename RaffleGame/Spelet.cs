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
using System.IO;


namespace RaffleGame
{
    public partial class Spelet : Form
    {

        //lista över alla spelare så att vi lätt kan iterera över de.
        List<Spelare> SpelarList = new List<Spelare>();

        //den spelare som har sin tur just nu.
        Spelare currSpelare;

        //Skapa en ny kortlek.
        Kortlek kortlek = new Kortlek(true);

        List<PictureBox> PbSpelareAttTaBort = new List<PictureBox>();
        Gamemode gamemode = new Gamemode();
        Image redx;
        public Spelet()
        {
            InitializeComponent();

            //tilldelar vårt kryss sin bild
            DirectoryInfo sokvag = new DirectoryInfo("röttkryss"); // Sökväg till bilderna.
            FileInfo[] bildArr = sokvag.GetFiles("*.png", SearchOption.TopDirectoryOnly);
            redx = (Image.FromFile(bildArr[0].FullName));
        }

        //Skapar vår lista av spelare från de vi skapade från startsidan.
        public void SkapaSpelarList(Spelare sp1, Spelare sp2)
        {
            SpelarList.Add(sp1);
            SpelarList.Add(sp2);
        }
        public void SkapaSpelarList(Spelare sp1, Spelare sp2, Spelare sp3)
        {
            SpelarList.Add(sp1);
            SpelarList.Add(sp2);
            SpelarList.Add(sp3);

        }

        public void SpelSetup()
        {
            //Sätt varje spelares namn i deras respektive ruta.
            GbSp1.Text = SpelarList[0].Namn;
            GbSp2.Text = SpelarList[1].Namn;

            //Koppla ihop varje spelares groupbox till deras property.
            SpelarList[0].GroupBox = GbSp1;
            SpelarList[1].GroupBox = GbSp2;

            //Koplla ihop knappen för att ta bort med spelarnas properties.
            SpelarList[0].BtTaBort = BtTaBortsp1;
            SpelarList[1].BtTaBort = BtTaBortsp2;

            //om vi har 3 spelare.
            if (SpelarList.Count > 2)
            {
                GbSp3.Text = SpelarList[2].Namn;
                SpelarList[2].GroupBox = GbSp3;
                SpelarList[2].BtTaBort = BtTaBortsp3;
            }
            else
            {
                GbSp3.Visible = false;
                BtTaBortsp3.Visible = false;
            }

            //viktigt att blanda innan man spelar :)
            kortlek.BlandaKortlek();

            //Starta spelet efteråt.
            StartaSpelet();
        }

        private void StartaSpelet()
        {
            //först på tur är spelare nmr 1
            currSpelare = SpelarList[0];

            InaktiveraAndraSpelare();
            //Ge kort till alla spelare och visa de i deras händer.
            for(int i = 0; i<SpelarList.Count;i++)
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

        private void BestämVinnare()
        {
            Spelare Vinnaren = new Spelare();
            Lbl_gamemode.Text = "Gamemodet är: "+gamemode.mode.ToString();

            switch(gamemode.mode)
            {
                case Gamemode.Mode.HighestValue:
                    Vinnaren = gamemode.HighestValueVinnare(SpelarList);
                    break;

                case Gamemode.Mode.LowestValue:
                    Vinnaren = gamemode.LowestValueVinnare(SpelarList);
                    break;

                case Gamemode.Mode.MostOfBlack:
                    Vinnaren = gamemode.MostOfBlackVinnare(SpelarList);
                    break;

                case Gamemode.Mode.MostOfRed:
                    Vinnaren = gamemode.MostOfRedVinnare(SpelarList);
                    break;

                case Gamemode.Mode.MostOfPair:
                    Vinnaren = gamemode.MostOfPairVinnare(SpelarList);
                    break;
            }
            if(Vinnaren.Namn == "Namnlös")
                Lbl_Winner.Text = "ingen eftersom det blev oavgjort.";
            else
                Lbl_Winner.Text = "Vinnaren är: " + Vinnaren.Namn;    

            Lbl_explain.Visible = true;
        }

        private void PbSpelare_Click(object sender, EventArgs e)
        {
            PictureBox PbSpelare = sender as PictureBox;
            //Ta bort kortet från denna position.
            if (currSpelare.GroupBox.Controls.Contains(PbSpelare))
            {
                PbSpelareAttTaBort.Add(PbSpelare);
                //grafik för att visa att kortet är markerat
                Graphics g = PbSpelare.CreateGraphics();
                Pen pen = new Pen(Color.Red, 7f);
                Point start = new Point(PbSpelare.Bounds.X-PbSpelare.Left, PbSpelare.Bounds.Y-PbSpelare.Top);
                Point end = new Point(PbSpelare.Bounds.X - PbSpelare.Left + PbSpelare.Right - PbSpelare.Left, PbSpelare.Bounds.Y +PbSpelare.Bottom-PbSpelare.Top-PbSpelare.Top);

                g.DrawLine(pen, start, end);
                g.Dispose();
            }

        }

        //Nästa spelare på tur
        private void NästaSpelare()
        {
            PbSpelareAttTaBort.Clear();
            int currSpelareIndex = SpelarList.IndexOf(currSpelare);

            if ( currSpelareIndex >= SpelarList.Count-1)
            {
                //om vi dragit igenom att spelare
                BestämVinnare();
            }
            else
            {
                //om inte, nästa spelare och inaktivera resten.
                SpelarList[currSpelareIndex] = currSpelare;
                currSpelare = SpelarList[currSpelareIndex + 1];
                InaktiveraAndraSpelare();
            }
        }
        //inaktivera funktionerna så att bara en spelare kan spela på en gång.
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
            //Ta bort alla våra kort från vår hand och groupbox om de blev markerade under markeringsprocessen.
            foreach (PictureBox PbSpelare in PbSpelareAttTaBort)
            {
                int NyttKortIndex = currSpelare.GroupBox.Controls.IndexOf(PbSpelare);
                //Tar bort kortet
                currSpelare.GeKort(NyttKortIndex);

                Kort kort = kortlek.GeKort();
                currSpelare.TaEmotKort(kort);
                //Tar bort kortet från groupboxen
                PbSpelare.Image = kort.Bild;
            }
            NästaSpelare();
        }   

        private void bt_regler_Click(object sender, EventArgs e)
        {
            //Knapp för reglerna.
            Regler popup = new Regler();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}
