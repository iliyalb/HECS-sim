using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HECS_Client
{
    public partial class Splash : Form
    {
        int r, g, b;

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HECS_Client frm = new HECS_Client();
            if (r < 31)
                r += 1;
            if (g < 131)
                g += 2;
            if (b < 201)
                b += 5;
            this.BackColor = Color.FromArgb(r, g, b);

            if (r >= 29 && g >= 129 && b >= 199)

            {
                this.Hide();
                frm.Closed += (s, args) => this.Close();

                timer1.Enabled = false;
                frm.Show();


            }
            
            
            

        }

        public void showfrm()
        {
            
        }
        public Splash()
        {
            InitializeComponent();
            r = 0;
            g = 0;
            b = 0;
            timer1.Enabled = true;

       


        }
    }
}
