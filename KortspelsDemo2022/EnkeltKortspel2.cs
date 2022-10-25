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
    public partial class EnkeltKortspel2 : Form
    {
        private Kortlek kortlek = new Kortlek();//Skapa en ny kortlek.

        public EnkeltKortspel2()
        {
            InitializeComponent();
        }

        private void BtDraKort_Click(object sender, EventArgs e)
        {
            Kort ettKort;
            ettKort = kortlek.GeKort();
            TbK1f.Text=ettKort.Farg.ToString();
            TbK1v.Text = ettKort.Valor.ToString();

            ettKort = kortlek.GeKort();
            TbK2f.Text = ettKort.Farg.ToString();
            TbK2v.Text = ettKort.Valor.ToString();

            ettKort = kortlek.GeKort();
            TbK3f.Text = ettKort.Farg.ToString();
            TbK3v.Text = ettKort.Valor.ToString();
        }
    }
}
