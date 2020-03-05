using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinball
{
    public partial class Form1 : Form
    {
        private Start start1;
        private Alien alien1;
        private batman66 batman661;
        private twd twd1;
        private congo congo1;
        private drwho drwho1;
        private about about1;
        private got got1;
        private tom tom1;

        public Form1()
        {
            InitializeComponent();
            start1 = new Start();
            alien1 = new Alien();
            batman661 = new batman66();
            twd1 = new twd();
            congo1 = new congo();
            drwho1 = new drwho();
            about1 = new about();
            got1 = new got();
            tom1 = new tom();

            comboBox1.Items.Add("Alien");
            comboBox1.Items.Add("Batman '66");
            comboBox1.Items.Add("Congo");
            comboBox1.Items.Add("Dr Who");
            comboBox1.Items.Add("Game of Thrones");
            comboBox1.Items.Add("Theatre of Magic");
            comboBox1.Items.Add("The Walking Dead");

            this.panel3.Controls.Add(start1);
            this.panel3.Controls.Add(alien1);
            this.panel3.Controls.Add(batman661);
            this.panel3.Controls.Add(twd1);
            this.panel3.Controls.Add(congo1);
            this.panel3.Controls.Add(drwho1);
            this.panel3.Controls.Add(about1);
            this.panel3.Controls.Add(got1);
            this.panel3.Controls.Add(tom1);

            start1.BringToFront();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Alien")
            {
                alien1.BringToFront();
            }
            
            else if (comboBox1.Text == "Batman '66")
            {
                batman661.BringToFront();
            }
            
            else if (comboBox1.Text == "Congo")
            {
                congo1.BringToFront();
            }

            else if(comboBox1.Text == "Dr Who")
            {
                drwho1.BringToFront();
            }

            else if(comboBox1.Text =="Game of Thrones")
            {
                got1.BringToFront();
            }


            else if(comboBox1.Text =="The Walking Dead")
            {
                twd1.BringToFront();
            }

            else if(comboBox1.Text =="Theatre of Magic")
            {
                tom1.BringToFront();
            }

            else 


                start1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             start1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            about1.BringToFront();
        }
    }
}
