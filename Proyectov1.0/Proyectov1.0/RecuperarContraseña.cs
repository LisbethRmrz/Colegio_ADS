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
    public partial class RecuperarContraseña : Form
    {
            private SqlConnection conexion;
            private SqlDataAdapter da;
            private SqlDataReader dr;
            private string sCn;

        public RecuperarContraseña()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conexion = new SqlConnection(sCn);
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {
            UsuarioText.Focus();
            VerificacionLabel.Visible = false;
            DUIText.Enabled = false;
            RecuperarBT.Enabled = false;
            DUIText.Mask = "########-#";
        }

        private void UsuarioText_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT COUNT(*) AS Total FROM Usuarios WHERE Usuario = '" + UsuarioText.Text + "' AND  TipoUsuario = 'Docente'";
            da = new SqlDataAdapter(consulta, conexion);
            dr = da.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                if (UsuarioText.Text == "")
                {
                    VerificacionLabel.Visible = false;
                }
                else if (Convert.ToInt32(dr["Total"].ToString().Trim()) == 0)
                {
                    VerificacionLabel.Visible = true;
                    VerificacionLabel.Text = "Usuario no existente.";
                    DUIText.Enabled = false;
                    UsuarioText.Focus();
                }         
                else
                {
                    VerificacionLabel.Visible = true;
                    VerificacionLabel.Text = "Usuario encontrado exitosamente.";
                    DUIText.Enabled = true;
                    DUIText.Focus();
                }
            }
            dr.Close();
            conexion.Close();
        }

        private void DUIText_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT COUNT(*) AS Total FROM Docentes WHERE IdDocente = '" + UsuarioText.Text + "' AND Dui='" + DUIText.Text + "'";
            da = new SqlDataAdapter(consulta, conexion);
            dr = da.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr["Total"].ToString().Trim()) == 0)
                {
                    RecuperarBT.Enabled = false;
                }
                else
                {
                    RecuperarBT.Enabled = true;
                }
            }
            dr.Close();
            conexion.Close();
            
        }

        private void RecuperarBT_Click(object sender, EventArgs e)
        {
            ActualizarContraseña AC = new ActualizarContraseña();
            AC.Usuario = UsuarioText.Text;
            this.Visible = false;
            AC.Visible = true;
        }

       

       
    }
}
