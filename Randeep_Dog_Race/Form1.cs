using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randeep_Dog_Race
{
    public partial class Form1 : Form
    {

        GameSetup obj = new GameSetup();

        int win = 0;

        public Form1()
        {
            InitializeComponent();
            pb1.Image = Properties.Resources.pb1;
            pb2.Image = Properties.Resources.pb2;
            pb3.Image = Properties.Resources.pb3;
            pb4.Image = Properties.Resources.pb4;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
        // this is the button 1 task which is used to set the bet of the player 
        private void button1_Click(object sender, EventArgs e)
        {
            if (!cbPlayer.Text.ToString().Equals(""))
            {
                int index = cbPlayer.SelectedIndex;
                if (index == 0 && bet.Value <= obj.Randeep)
                {
                    cbPlayer.Items[index] = "Randeep choose " + Dog.Value + " for the bet with Amount " + bet.Value;
                }
                else if (index == 1 && bet.Value <= obj.Harman)
                {
                    cbPlayer.Items[index] = "Harman choose " + Dog.Value + " for the bet with Amount " + bet.Value;
                }
                else if (index == 2 && bet.Value <= obj.Param)
                {
                    cbPlayer.Items[index] = "Param choose " + Dog.Value + " for the bet with Amount " + bet.Value;
                }
                else
                {
                    MessageBox.Show("check your amount ");
                }

                button2.Visible = true;

            }
            else {
                MessageBox.Show("Select the Player first ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //th whole race depend uponthe timer 
        private void timer1_Tick(object sender, EventArgs e)
        {

            pb1.Left += obj.run();
            pb2.Left += obj.run();
            pb3.Left += obj.run();
            pb4.Left += obj.run();

            if (pb1.Left>630) {
                timer1.Stop();
                MessageBox.Show("Dog 1 ");
                win = 1;
                obj.result(cbPlayer, 1);
                pb1.Left = 0;
                pb2.Left = 0;
                pb3.Left = 0;
                pb4.Left = 0;
                cbPlayer.Text = "";
                bet.Value = 50;
                Dog.Value = 1;
                button2.Visible = false;
            }

            if (pb2.Left>630) {
                timer1.Stop();
                MessageBox.Show("Dog 2 ");
                win = 2;
                obj.result(cbPlayer, 2);
                pb1.Left = 0;
                pb2.Left = 0;
                pb3.Left = 0;
                pb4.Left = 0;
                cbPlayer.Text = "";
                bet.Value = 50;
                Dog.Value = 1;
                button2.Visible = false;
            }
            if (pb3.Left>630) {
                timer1.Stop();
                MessageBox.Show("Dog 3");
                win = 3;
                obj.result(cbPlayer, 3);
                pb1.Left = 0;
                pb2.Left = 0;
                pb3.Left = 0;
                pb4.Left = 0;
                cbPlayer.Text = "";
                bet.Value = 50;
                Dog.Value = 1;
                button2.Visible = false;
            }
            if (pb4.Left > 630)
            {
                timer1.Stop();
                MessageBox.Show("Dog 4 ");
                win = 4;
                obj.result(cbPlayer, 4);
                pb1.Left = 0;
                pb2.Left = 0;
                pb3.Left = 0;
                pb4.Left = 0;
                cbPlayer.Text = "";
                bet.Value = 50;
                Dog.Value = 1;
                button2.Visible = false;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
