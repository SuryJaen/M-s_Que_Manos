using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Más_Que_Manos
{
    public partial class frmInicio : Form
    {
        private Timer timer;
        private int tiempoTotal = 5000;


        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

            barraprogreso.Visible = true;
            barraprogreso.Maximum = 5000;
            barraprogreso.ForeColor= Color.Red;
                //.FromArgb( 255, 128,0);
            //barraprogreso.Minimum = 0;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            barraprogreso.Value += timer.Interval;
            if (barraprogreso.Value >= tiempoTotal)
            {
                timer.Stop();
                barraprogreso.Visible = false;

                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();

            }
        }

    }
}
