using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Proyectov1._0
{
    public partial class Login : Form
    {
        private SqlConnection conexion;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;
        public Login()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conexion = new SqlConnection(sCn);        
        }
        //Cadena de conexion con sql
        SqlConnection con = new SqlConnection(@"Data Source=S05-PC04\TECHNOTEL;Initial Catalog=Proyecto;Integrated Security=True; password=123456");
       
        //Metodo para el inicio de sesion
        public void login(string usuario, string contraseña)
        {
            conexion.Open();
            int es = 0;
            string consulta = "SELECT COUNT(*) AS total FROM Usuarios WHERE Usuario='" + usuario + "' AND Contraseña='" + contraseña+ "'";
            da = new SqlDataAdapter(consulta, conexion);
            dr = da.SelectCommand.ExecuteReader();
            while (dr.Read())
            {
                es = (int)dr["total"];
            }
            dr.Close();
            if (es != 0)
            {
                string consulta1 = "SELECT Usuario,TipoUsuario FROM Usuarios WHERE Usuario='" + usuario + "' AND Contraseña='" + contraseña + "'";
                da = new SqlDataAdapter(consulta1, conexion);
                dr = da.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                    string rol = dr["TipoUsuario"].ToString().Trim();
                    string nombre = dr["Usuario"].ToString().Trim();
                    string TipoUsuario = dr["TipoUsuario"].ToString().Trim();
                    MessageBox.Show("Bienvenid@: " + TipoUsuario + "", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (rol == "Director(a)")
                    {
                        MenuPrincipal MP = new MenuPrincipal();
                        MP.Visible = true;
                        this.Visible = false;
                    }
                    else if(rol == "DocentePG1901")
                    {
                        DocPrimerGrado PG = new DocPrimerGrado();
                        PG.Visible = true;
                        this.Visible = false;
                    }

                    else if(rol == "DocenteSG1902")
                    {
                        DocenteSegundo SG = new DocenteSegundo();
                        SG.Visible = true;
                        this.Visible = false;
                    }

                    else if (rol == "DocenteTG1903")
                    {
                        DocenteTercero TG = new DocenteTercero();
                        TG.Visible = true;
                        this.Visible = false;
                    }

                    else if (rol == "DocenteCG1904")
                    {
                        DocenteCuarto CG = new DocenteCuarto();
                        CG.Visible = true;
                        this.Visible = false;
                    }

                    else if (rol == "DocenteQG1905")
                    {
                        DocenteQuinto QG = new DocenteQuinto();
                        QG.Visible = true;
                        this.Visible = false;
                    }

                    else if (rol == "DocenteSG1906")
                    {
                        DocenteSexto S6G = new DocenteSexto();
                        S6G.Visible = true;
                        this.Visible = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontraseña.Clear();
            }
            dr.Close();
            conexion.Close();
        } 
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        private void btnalumnos_Click(object sender, EventArgs e)
        {
            login(this.txtusuario.Text, this.txtcontraseña.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RecuperarContraseña RC = new RecuperarContraseña();
            RC.Visible = true;
        }
    }
}
