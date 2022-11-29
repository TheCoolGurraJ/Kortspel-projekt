using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;

namespace RaffleGame
{
    public class Kortlek
    {
        private List<Kort> hogen = new List<Kort>(); //Lista med alla kort i kortleken.
        private List<Image> kortBilder = new List<Image>(); //Lista med alla kortbilder.


        //Konstruktor för Kortlek.
        public Kortlek()
        {
            //Skapar 52 nya kort.
            for (int f = 0; f <= 3; f++) //Färg
            {
                for (int v = 2; v <= 14; v++) //Valör
                {
                    hogen.Add(new Kort(f, v)); //Skapar ett nytt kort.
                }
            }

            BlandaKortlek(); //Blanda kortleken
        }

        //Konstruktor för Kortlek.
        public Kortlek(bool medBild)
        {
            int bildNr = 0;

            hamtaBilder(); //Läs in bilderna till en lista.

            //Skapar 52 nya kort med bilder.
            for (int f = 0; f <= 3; f++)
                for (int v = 2; v <= 14; v++)
                {
                    Image b = kortBilder.ElementAt(bildNr); //Hämta en bild från bildlistan.
                    b.Tag = f.ToString() + v.ToString();

                    hogen.Add(new Kort(f, v, b)); //Skapar ett nytt kort.
                    bildNr++; //Öka bildnummer med ett.
                }
            BlandaKortlek(); //Blanda kortleken
        }


        //Konstruktor för Kortlek.

        //Ger ut det översta kortet i kortleken.
        public Kort GeKort()
        {
            Kort kort = hogen.ElementAt(0); //Kopia av översta kortet i kortleken.
            hogen.RemoveAt(0); //Radera översta kortet i kortleken.

            if (hogen.Count < 1)
                return null;
            else
                return kort; //Returnera kortet
        }

        //Blandar kortleken
        public void BlandaKortlek()
        {
            List<Kort> tmpLek = new List<Kort>(); //Temporär lista.
            int slump; //Slumpad plats i listan.
            Random rnd = new Random();

            //Kopiera ett slumpvalt kort i högen till en temporär lista 
            //tills alla kort i högen är kopierade.
            for (int pos = hogen.Count() - 1; pos >= 0; pos--)
            {
                slump = rnd.Next(0, pos + 1); //Slumpa en pos för tempListan.
                tmpLek.Add(hogen.ElementAt(slump)); //Kopiera ett kort från en slumpad plats 
                                                    //(pos) listan till en temporär lista.
                hogen.Remove(hogen.ElementAt(slump)); //Ta bort kortet från listan.
            }
            hogen.Clear(); //Töm listan.

            //Kopiera tillbaka från temporär lista (tmpLek).
            foreach (Kort tmpKort in tmpLek)
                hogen.Add(tmpKort);
        }

        //Hämtar bilder till korten.
        private void hamtaBilder()
        {
            DirectoryInfo sokvag = new DirectoryInfo("kortBilder"); // Sökväg till bilderna.
            FileInfo[] bildArr = sokvag.GetFiles("*.png", SearchOption.TopDirectoryOnly);

            //Läser in bilderna till listan.
            foreach (FileInfo bild in bildArr)
                kortBilder.Add(Image.FromFile(bild.FullName));
        }
    }
}
