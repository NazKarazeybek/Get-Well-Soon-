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
        // Declare a SoundPlayer to play the birthday song
        private SoundPlayer soundPlayer;
        SoundPlayer bdaySong = new SoundPlayer(Properties.Resources.birthday);
        SoundPlayer cheering = new SoundPlayer(Properties.Resources.cheering);

        // Declare pens, brushes, fonts, and graphics object globally
        private Graphics g;
        private Pen blackPen;
        private Pen whitePen;
        private SolidBrush blackBrush;
        private SolidBrush purpleBrush;
        private SolidBrush yellowBrush;
        private Font georgiaFont;
        private Font infoFont;

        public Form1()
        {
            InitializeComponent();
            InitializeDrawingTools();
        }
        private void InitializeDrawingTools()
        {
            g = this.CreateGraphics();
            blackPen = new Pen(Color.Black, 3);
            whitePen = new Pen(Color.White, 5);
            blackBrush = new SolidBrush(Color.Black);
            purpleBrush = new SolidBrush(Color.DarkViolet);
            yellowBrush = new SolidBrush(Color.FromArgb(255, 255, 128));
            georgiaFont = new Font("Georgia", 25, FontStyle.Bold);
            infoFont = new Font("Georgia", 10, FontStyle.Bold);
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            //play sound
            cheering.Play();

            //drawing, texts and colours (on screen)
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
            // Play the birthday song
            bdaySong.Play();

            // Animate the drawing moving upwards
            for (int i = 0; i < 45; i++)
            {
                // Calculate new Y position for the ellipse and other elements
                int newY = 55 - i * 10;

                //drawing and colour components
                g.Clear(Color.LightSkyBlue);
                g.DrawEllipse(whitePen, 30, newY, 180, 200);
                g.FillEllipse(yellowBrush, 30, newY, 180, 200);
                g.DrawLine(blackPen, 120, 260 - i * 10, 180, 420 - i * 10);
                g.DrawRectangle(whitePen, 110, 250 - i * 10, 25, 10);
                g.FillRectangle(yellowBrush, 110, 250 - i * 10, 25, 10);

                // Pause for 100 milliseconds to create the animation effect
                System.Threading.Thread.Sleep(100);
                // Refresh the form to update the drawing
                this.Refresh();
            }
            // Animate the text moving horizontally
            Font georgiaFontSmall = new Font("Georgia", 15, FontStyle.Bold);

            for (int j = -10; j < 40; j++)
            {
                // Refresh the form to clear previous drawings
                this.Refresh();
                // Calculate new X position for the text
                int newX = -j * 10;

                g.DrawString("You're Invited To my Birthday Party!", georgiaFont, purpleBrush, newX, 120);
                g.DrawString("Can't wait to see you there Mr T!", georgiaFont, purpleBrush, newX, 190);

                // Pause for 50 milliseconds to create the animation effect
                System.Threading.Thread.Sleep(50);
            }

            // Close the form after the animation
            this.Close();
        }
    }
}
