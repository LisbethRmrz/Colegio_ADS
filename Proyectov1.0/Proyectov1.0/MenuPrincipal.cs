﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyectov1._0
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //
        int lx, ly;
        int sw, sh;

        private void AbrirFormInPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = contenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //Busca en la coleccion el formulario
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                contenedor.Controls.Add(formulario);
                contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }

            else
            {
                formulario.BringToFront();
            }
        }


        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (panelmenu.Width == 250)
            {
               panelmenu.Width = 73;
            }
            else
            {
                panelmenu.Width = 250;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btndocentes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Docentes>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<inicioalumnos>();
        }

        private void pictureinicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<inicioalumnos>();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            pictureinicio_Click(null, e);
        }

        private void btnalumnos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<alumnos>();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<inicioalumnos>();
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            btnrestart.Visible = false;
            btnmax.Visible = true;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btnrestart.Visible = true;
            btnmax.Visible = false;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
    }
}
