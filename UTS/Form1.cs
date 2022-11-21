using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movesidepanel(Button btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;

        }

        private void addUC(UserControl uc)
        {
            paneltengah.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            paneltengah.Controls.Clear();
            paneltengah.Controls.Add(uc);
        }

        private void home_Click(object sender, EventArgs e)
        {
            movesidepanel(home);
            UChome uChome = new UChome();
            addUC(uChome);
        }

        private void food_Click(object sender, EventArgs e)
        {
            movesidepanel(food);
            UCFood uCFood = new UCFood();
            addUC(uCFood);
        }

        private void drinks_Click(object sender, EventArgs e)
        {
            movesidepanel(drinks);
            UCdrinks uCdrinks = new UCdrinks();
            addUC(uCdrinks);
        }

        private void chat_Click(object sender, EventArgs e)
        {
            movesidepanel(chat);
            UCchat uCChat = new UCchat();
            addUC(uCChat);
            
        }

        private void delivery_Click(object sender, EventArgs e)
        {
            movesidepanel(delivery);
            UCdelivery uCDelivery = new UCdelivery();
            addUC(uCDelivery);
        }

        private void about_Click(object sender, EventArgs e)
        {
            movesidepanel(about);
            UCabout uCAbout = new UCabout();
            addUC(uCAbout);
        }

    }
}
