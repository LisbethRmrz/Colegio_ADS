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
    public partial class ActualizarContraseña : Form
    {
        private SqlConnection conexion;
        private SqlCommand insert1;
        private static string usuario;
        private string sCn;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public ActualizarContraseña()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conexion = new SqlConnection(sCn);   
        }

        private void RecuperarBT_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if(ContraseñaNueva.Text == ConfimarContraseña.Text)
            {
                string insertar = "UPDATE Usuarios SET Contraseña = @Contraseña WHERE Usuario = @Usuario";
                insert1 = new SqlCommand(insertar, conexion);
                insert1.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar));
                insert1.Parameters["@Usuario"].Value = Usuario;
                insert1.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
                insert1.Parameters["@Contraseña"].Value = ContraseñaNueva.Text;
                insert1.ExecuteNonQuery();
                MessageBox.Show("Contraseña actualizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Login LG = new Login();
                this.Visible = false;
                LG.Visible = true;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void ActualizarContraseña_Load(object sender, EventArgs e)
        {
            ContraseñaNueva.Focus();
        }
    }
}
