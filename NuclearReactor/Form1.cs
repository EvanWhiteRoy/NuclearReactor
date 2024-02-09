using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            reactor1StateLabel.BackColor = Color.Red;
            reactor5.BackColor = Color.Red;
            startButton.BackColor = Color.Red;
            Nuclear3.BackColor = Color.Red;
            Nuclear3.Text = "Meltdown";
            Nuclear3.ForeColor = Color.White;
            
           

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor5.BackColor = Color.White;
            Nuclear3.BackColor = Color.White;
            Nuclear3.ForeColor = Color.Red;



            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.Red;
            reactor5.BackColor = Color.Red;
            Nuclear3.BackColor = Color.Red;
            Nuclear3.ForeColor = Color.White;


            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor5.BackColor = Color.White;
            Nuclear3.BackColor = Color.White;
            Nuclear3.ForeColor = Color.Red;


            reactor1StateLabel.BackColor = Color.White;
            reactor5.BackColor = Color.White;




        }

        private void reactorLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
