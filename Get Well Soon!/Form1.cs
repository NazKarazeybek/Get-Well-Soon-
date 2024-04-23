using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_Well_Soon_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 3);
            Pen whitePen = new Pen(Color.White, 5);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush purpleBrush = new SolidBrush(Color.DarkViolet);
            SolidBrush yellowBrush = new SolidBrush(Color.FromArgb(255, 255, 128));
            Font georgiaFont = new Font("Georgia", 25, FontStyle.Bold);
            Font infoFont = new Font("Georgia", 10, FontStyle.Bold);

            g.Clear(Color.LightSkyBlue);

            g.DrawLine(blackPen, 120, 240, 180, 400);

            g.DrawEllipse(whitePen, 30, 30, 180, 200);
            g.FillEllipse(yellowBrush, 30, 30, 180, 200);

            g.DrawRectangle(whitePen, 110, 230, 25, 10);
            g.FillRectangle(yellowBrush, 110, 230, 25, 10);

            g.DrawString("Birthday", georgiaFont, purpleBrush, 180, 240);
            g.DrawString("Card!", georgiaFont, purpleBrush, 210, 290);

            g.DrawString("By: Naz Karazeybek", infoFont, blackBrush, 220, 10);


        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
