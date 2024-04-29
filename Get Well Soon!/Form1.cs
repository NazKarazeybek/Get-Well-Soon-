using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Get_Well_Soon_
{
    public partial class Form1 : Form
    {

        private SoundPlayer soundPlayer;
        SoundPlayer bdaySong = new SoundPlayer(Properties.Resources.birthday);

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
            g.DrawString("Card!", georgiaFont, purpleBrush, 200, 290);

            g.DrawString("From: Naz Karazeybek", infoFont, blackBrush, 200, 10);


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            bdaySong.Play();
            for (int i = 0; i < 45; i++)
            {



                int newY = 55 - i * 10;


                Graphics g = this.CreateGraphics();
                g.Clear(Color.LightSkyBlue);

                Pen blackPen = new Pen(Color.Black, 3);
                Pen whitePen = new Pen(Color.White, 5);
                SolidBrush yellowBrush = new SolidBrush(Color.FromArgb(255, 255, 128));

                g.DrawEllipse(whitePen, 30, newY, 180, 200);
                g.FillEllipse(yellowBrush, 30, newY, 180, 200);

                g.DrawLine(blackPen, 120, 260 - i * 10, 180, 420 - i * 10);

                g.DrawRectangle(whitePen, 110, 250 - i * 10, 25, 10);
                g.FillRectangle(yellowBrush, 110, 250 - i * 10, 25, 10);

                System.Threading.Thread.Sleep(100);
                this.Refresh();
            }

            for (int j = -10; j < 40; j++)
            {
                this.Refresh();
                Graphics g = this.CreateGraphics();
                SolidBrush purpleBrush = new SolidBrush(Color.DarkViolet);
                int newX = -j * 10;

                Font georgiaFont = new Font("Georgia", 15, FontStyle.Bold);
                g.DrawString("You're Invited To my Birthday Party!", georgiaFont, purpleBrush, newX, 120);

                g.DrawString("Can't wait to see you there Mr T!", georgiaFont, purpleBrush, newX, 190);

                System.Threading.Thread.Sleep(50);
            }

            this.Close();
        }


    }
}
