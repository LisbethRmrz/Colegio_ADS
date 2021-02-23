using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectov1._0
{
    public partial class alumnos : Form
    {
        public alumnos()
        {
            InitializeComponent();
        }

        private void AbrirFormInPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = contenedorgrados.Controls.OfType<MiForm>().FirstOrDefault();
            //Busca en la coleccion el formulario
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                contenedorgrados.Controls.Add(formulario);
                contenedorgrados.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }

            else
            {
                formulario.BringToFront();
            }
        }

        private void contenedorgrados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Primer_Grado>();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Segundo_Grado>();
        }

        private void tercero_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Tercer_Grado>();
        }

        private void cuarto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Cuarto_Grado>();
        }

        private void quinto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Quinto_Grado>();
        }

        private void sexto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Sexto_Grado>();
        }
    }
}
