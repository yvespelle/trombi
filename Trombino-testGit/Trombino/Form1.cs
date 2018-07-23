using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trombino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(255, 232, 232);
            //this.radioButton1.BackColor = Color.FromArgb(255, 232, 232);
            //this.radioButton2.BackColor = Color.FromArgb(255, 255, 255);
            //this.radioButton3.BackColor = Color.FromArgb(255, 255, 255);
            //this.radioButton4.BackColor = Color.FromArgb(255, 255, 255);
        }


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfficherLesImages();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            //label2.Text = " vous avez choisi : " + nom;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AfficherDetails(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AfficherDetails(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AfficherDetails(3);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AfficherDetails(7);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AfficherDetails(4);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AfficherDetails(5);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AfficherDetails(6);

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            AfficherDetails(35);
        }
    }
}
