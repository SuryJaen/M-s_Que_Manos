using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Más_Que_Manos
{
    public partial class frm_panel : Form
    {
        public frm_panel()
        {
            InitializeComponent();
        }

        private void frm_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
