using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass3C
{

    public partial class Form1 : Form
    {
        private int[] valid;
        private int[] VP;
        private int[] mod;
        private string[] protec;
        private int[] frame;

        private int index = 0;

        const int SIZE = 64;

        public Form1()
        {
            InitializeComponent();
            valid = new int[SIZE];
            VP = new int[SIZE];
            mod = new int[SIZE];
            protec = new string[SIZE];
            frame = new int[SIZE];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dummy data
            Random rand = new Random();
            for (int i=0; i < 8; i++)
            {
                valid[i] = 1;
                mod[i] = rand.Next(0, 20);
                VP[i] = rand.Next(0, 1000);
                frame[i] = rand.Next(0, 500);

                index++;
            }
            protec[0] = "RW";
            protec[1] = "R X";
            protec[2] = "RW";
            protec[3] = "RW";
            protec[4] = "R X";
            protec[5] = "R X";
            protec[6] = "RW";
            protec[7] = "RW";
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            rtbOut.Clear();
            rtbOut.AppendText("Valid" + "\tVirtual Page" + "\tModified" + "\tProtection" + "\tPage Frame\n");
            for(int i = 0; i < index; i++)
            {
                rtbOut.AppendText("" + valid[i] + "\t" + VP[i] + "\t" + mod[i] + "\t" + protec[i] + "\t" + frame[i] + "\n");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        { 
            if( tbxFrame.Text == "" || tbxMod.Text == "" || tbxProt.Text == "" || tbxVP.Text == "")
            {
                MessageBox.Show("Please enter data into all boxes");
            }
            else
            {
                protec[index] = tbxProt.Text;
                valid[index] = 1;
                mod[index] = Convert.ToInt32(tbxMod.Text);
                VP[index] = Convert.ToInt32(tbxVP.Text);
                frame[index] = Convert.ToInt32(tbxFrame.Text);
                index++;
            }
        }
    }
}
