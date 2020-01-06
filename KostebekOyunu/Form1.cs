using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostebekOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int puan = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0, y = 0, z = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + z.ToString();
                    btn.Width = btn.Height = 50;
                    btn.BackColor = Color.SaddleBrown;
                    btn.Location = new Point(3 + x, 3 + y);
                    btn.Click += Btn_Click;
                    btn.MouseLeave += Btn_MouseLeave;
                    pnlTarla.Controls.Add(btn);
                    x += 56;
                    z++;
                }
                y += 56;
                x = 0;
            }
        }
        private void Btn_MouseLeave(object sender,EventArgs e)
        {
            Button ilkRengeDon = (Button)sender;
            if (ilkRengeDon.BackColor!=Color.Goldenrod)
            {
                ilkRengeDon.BackColor = Color.SaddleBrown;
            }
        }
        bool tiklandimi = true;
        private void Btn_Click(object sender,EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (tiklanan.BackColor==Color.Goldenrod&&tiklandimi)
            {
                lblPuan.Text = "PUAN=   " + (++puan).ToString();
                tiklanan.BackColor = Color.DarkOliveGreen;
                tiklandimi = false;
            }
            else if (!tiklandimi)
            {
                lblPuan.Text = "PUAN=   " + (--puan).ToString();
            }
            else if (BaslaDurdur)
            {
                lblPuan.Text = "PUAN=   " + (--puan).ToString();
                tiklanan.BackColor = Color.Maroon;
            }
        }
        int kahverengi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int kostebek = rnd.Next(0, 101);
            pnlTarla.Controls[kostebek].BackColor = Color.Goldenrod;
            pnlTarla.Controls[kahverengi].BackColor = Color.SaddleBrown;
            kahverengi = kostebek;
            tiklandimi = true;
            if (puan<0)
            {
                timer1.Interval = 2000;
            }
            else if (puan>=0 && puan<25)
            {
                timer1.Interval = 1500;
            }
            else
            {
                timer1.Interval = 1000;
            }
        }
        bool BaslaDurdur = false;
        private void button1_Click(object sender, EventArgs e)
        {
            btnBaslaDurdur.Enabled = true;
            if (BaslaDurdur)
            {
                btnBaslaDurdur.Text = "Başla";
                BaslaDurdur = false;
            }
            else
            {
                btnBaslaDurdur.Text = "Durdur";
                BaslaDurdur = true;
            }
            timer1.Enabled = !timer1.Enabled;
            tiklandimi = false;
        }
       
    }
}
