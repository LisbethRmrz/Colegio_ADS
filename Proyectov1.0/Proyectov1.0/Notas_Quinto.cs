using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyectov1._0
{
    public partial class Notas_Quinto : Form
    {
        Conexion cn = new Conexion();
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;
        public Notas_Quinto()
        {
            InitializeComponent();
            cn.conec();
            sCn = cn.cadena;
            conexion = new SqlConnection(sCn);
        }

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

        private void MatePrimero_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Mate5>();
        }

        private void LenguajePrimero_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Lenguaje5>();
        }

        private void CienciasPrimero_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Ciencias5>();
        }

        private void SocialesPrimero_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<Sociales5>();
        }
    }
}
