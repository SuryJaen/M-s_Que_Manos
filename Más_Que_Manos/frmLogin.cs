using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Más_Que_Manos
{
    public partial class frmLogin : Form
    {

        private string local_usuario = "Sury";
        private string local_correo = "jaensury123@gmail.com";
        private string local_contrasena = "keanu0112";

        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btn_continuar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string correo = txt_correo.Text;
            string contrasena = txt_contrasena.Text;

            if (local_usuario == usuario && local_correo == correo && local_contrasena == contrasena)
            {
                this.Hide();
                //MessageBox.Show(" Credenciales correctos ", " Mensaje ");
                frm_panel menu = new frm_panel();
                menu.Show();
            }
            else
                MessageBox.Show("Por favor revisar si sus credenciales son correctos", "Mensaje");
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
