using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilesikGetiriHesaplamaV2
{
    public partial class Form1 : Form
    {
  
        int vade;
        decimal karYuzdesi, anaPara, toplamPara;
        string zamanDilimi;
        Color arkaPlanrengi, labelRengi, yaziRengi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           menuStrip1.BackColor=Color.FromArgb(55,149,189);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = " ";
            label3.Text = "Kar Yüzdesi"+ label3.Text +" "+"("+ comboBox1.Text + ")";
            label11.Text = "Son" + comboBox1.Text + "Gelen Para";
         zamanDilimi= comboBox1.Text;

            if (comboBox1.Text=="Ay")
            label10.Text = "Aylık Eklenecek Miktar";
            if (comboBox1.Text == "Gun")
                label10.Text = "Günlük Eklenecek Miktar";
            if (comboBox1.Text == "Yıl")
                label10.Text = "Yıllık Eklenecek Miktar";
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            yaziRengi = colorDialog1.Color;
            this.ForeColor = yaziRengi;
        }

        private void labelRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            labelRengi = colorDialog1.Color;
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    this.ForeColor = labelRengi;

                }
            }
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {

            anaPara = decimal.Parse(txt_anaPara.Text);
            vade = int.Parse(txt_vade.Text);
            karYuzdesi = decimal.Parse(txt_karYuzdesi.Text);
            toplamPara = anaPara;
            bilesikGetiri(karYuzdesi,anaPara,toplamPara,vade,zamanDilimi);

        }

        private void arkaPlanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            arkaPlanrengi = colorDialog1.Color;
            this.BackColor = arkaPlanrengi;
            menuStrip1.BackColor = arkaPlanrengi;
        }

        public void bilesikGetiri(decimal _karYuzdesi,decimal _anaPara,decimal _toplamPara,int vade,string _zamanDilimi)
        {
            decimal sonGelenPara = _anaPara;
            for (int i = 1; i < vade; i++)
            {
                sonGelenPara = (sonGelenPara * _karYuzdesi / 100) + sonGelenPara;
                //MessageBox.Show("Vade :" + i + "Son Gelen Para " + sonGelenPara.ToString());
                _toplamPara = _toplamPara + sonGelenPara;
                //MessageBox.Show("Toplam Para" + _toplamPara.ToString());
            }
            lbl_sonGelenPara.Text = sonGelenPara.ToString();
            lbl_toplamPara.Text = _toplamPara.ToString();
            lbl_kacKatinaCikti.Text = (_toplamPara / _anaPara).ToString();
            lbl_neKadarArtti.Text=(_toplamPara-_anaPara).ToString();
            lbl_yuzdeKacArtti.Text = ((_toplamPara - _anaPara) * 100 / _anaPara).ToString();
            lbl_yuzdeKacOldu.Text=(_toplamPara- _anaPara).ToString();
            //switch (zamanDilimi)
            //{
            //    case "Gün":
            //        for (int i = 1; i <= vade; i++)
            //        {


            //        }
            //        break;
            //case "Ay":
            //for (int i = 1; i <= vade; i++)
            //{
            //    sonGelenPara = (sonGelenPara * _karYuzdesi / 100) + sonGelenPara;
            //    MessageBox.Show("Vade :" + i + "Son Gelen Para " + sonGelenPara.ToString());
            //    _toplamPara = _toplamPara + sonGelenPara;
            //    MessageBox.Show("Toplam Para" + _toplamPara.ToString());
            //}


            //        break;
            //    case "Yıl":                 
            //        for (int i = 1; i <= vade; i++)
            //        {


            //        }
            //        break;
            //}
        }
        public void ekleyerekBilesikGetiri(decimal _karYuzdesi, decimal _anaPara, decimal _toplamPara, int vade, string _zamanDilimi)
        {

        }
    }
}
