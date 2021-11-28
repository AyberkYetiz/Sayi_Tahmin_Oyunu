using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void kontrol()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        int skor;
        int sayi;
        
        private void Basla_Click(object sender, EventArgs e)
        {
            skor = 100;
            lblSkor.Text = "Skor :" + skor.ToString();
            btnTahmin.Enabled = true;
            Random rastgele = new Random();
            sayi = rastgele.Next(101);
            MessageBox.Show("Aklımdan tuttugum sayiyi bul.");
            
            kontrol();


        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (skor != 0)
            {
                Basla.Enabled = false;
                Basla.Visible = false;
                int tahmin = Convert.ToInt16(txtTahmin.Text);
                if (tahmin < sayi)
                {
                    MessageBox.Show("Yukarı");
                    skor -= 10;
                }
                else if (tahmin > sayi)
                {
                    MessageBox.Show("Asagi");
                    skor -= 10;
                }
                else
                {
                    MessageBox.Show("Tebrikler!");
                    Basla.Visible = true;
                    Basla.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox2.Visible = true;
                    panel1.BackColor = Color.Green;
                }
            }
            if(skor==0)
            {
                MessageBox.Show("Hakkiniz kalmadi");
                btnTahmin.Enabled = false;
                Basla.Enabled = true;
                Basla.Visible = true;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                panel1.BackColor = Color.Red;
            }
            lblSkor.Text = "Skor :" + skor.ToString();
            txtTahmin.Clear();


        }
    }
}

