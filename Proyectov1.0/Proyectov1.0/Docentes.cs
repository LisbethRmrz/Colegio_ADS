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
    public partial class Docentes : Form
    {
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;



        public Docentes()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conexion = new SqlConnection(sCn);
        }



        public void CargarGrid()
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtnombres.Text == "" || txtapellidos.Text == "" || DUIText.Text == "" || txttel.Text == "" || txtdir.Text == "")
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                if(txtnombres.Text.Substring(0,1) == " " || txtapellidos.Text.Substring(0, 1) == " " )
                    {
                    MessageBox.Show("El primer caracter de Nombre y Apellido no puede ser un espacio");
                    }
                else
                {
                    string primera_nombre, primera_apellido, pn, pa;
                    string txtn = txtnombres.Text;
                    string txta = txtapellidos.Text;
                    string C = "";
                    try
                    {
                        primera_nombre = txtn.Substring(0, 1);
                        pn = primera_nombre.ToUpper();
                        primera_apellido = txta.Substring(0, 1);
                        pa = primera_apellido.ToUpper();
                        string con = "DECLARE @cadena varchar(20) EXEC IdDocente '" + pn + "','" + pa + "',@cadena OUTPUT SELECT [s] = @cadena";
                        da = new SqlDataAdapter(con, conexion);
                        dr = da.SelectCommand.ExecuteReader();
                        while(dr.Read())
                        {
                            C = dr["s"].ToString().Trim();
                        }
                        dr.Close();
                        MessageBox.Show("" + C);
                        string InsertarDocente;
                        InsertarDocente = "INSERT INTO Docentes(IdDocente, Nombres, Apellidos, FechaNacimiento, Dui, Telefono, Direccion, GradoResponsable)";
                        InsertarDocente += "VALUES (@IdDocente, @nombres_docente, @apellidos_docente, @fecha_nac_docente, @dui_docente, @telefono_docente, @direccion_docente, @grado_responsable_docente)";
                        insert1 = new SqlCommand(InsertarDocente, conexion);
                        insert1.Parameters.Add(new SqlParameter("@IdDocente", SqlDbType.VarChar));
                        insert1.Parameters["@IdDocente"].Value = C;
                        insert1.Parameters.Add(new SqlParameter("@nombres_docente", SqlDbType.VarChar));
                        insert1.Parameters["@nombres_docente"].Value = txtnombres.Text;
                        insert1.Parameters.Add(new SqlParameter("@apellidos_docente", SqlDbType.VarChar));
                        insert1.Parameters["@apellidos_docente"].Value = txtapellidos.Text;
                        insert1.Parameters.Add(new SqlParameter("@fecha_nac_docente", SqlDbType.DateTime));
                        insert1.Parameters["@fecha_nac_docente"].Value = fechanac.Text;
                        insert1.Parameters.Add(new SqlParameter("@dui_docente", SqlDbType.VarChar));
                        insert1.Parameters["@dui_docente"].Value = DUIText.Text;
                        insert1.Parameters.Add(new SqlParameter("@telefono_docente", SqlDbType.VarChar));
                        insert1.Parameters["@telefono_docente"].Value = txttel.Text;
                        insert1.Parameters.Add(new SqlParameter("@direccion_docente", SqlDbType.Text));
                        insert1.Parameters["@direccion_docente"].Value = txtdir.Text;
                        insert1.Parameters.Add(new SqlParameter("@grado_responsable_docente", SqlDbType.Char));
                        insert1.Parameters["@grado_responsable_docente"].Value = combogrados.Text;
                        insert1.ExecuteNonQuery();

                        //Limpiamos los textbox
                        txtnombres.Text = "";
                        txtapellidos.Text = "";
                        DUIText.Text = "";
                        fechanac.Text = "";
                        txttel.Text = "";
                        txtdir.Text = "";
                        combogrados.Text = "";
                        MessageBox.Show("Registro agregado");
                        conexion.Close();
                        DocentesDG.DataSource = MostrarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }

                }
                conexion.Close();
            }
        }
        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Docentes", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void Docentes_Load(object sender, EventArgs e)
        {
            conexion.Open();
                string seleccion = "SELECT IdGrados FROM Grados";
                da = new SqlDataAdapter(seleccion, conexion);
                dr = da.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                    combogrados.Items.Add(dr["IdGrados"].ToString().Trim());
                }
                dr.Close();
            conexion.Close();
            combogrados.SelectedIndex = 0;
            DUIText.Mask = "########-#";
            DocentesDG.DataSource = MostrarDatos();
            CodigoText.Visible = false;
        }

        private void Datosdocentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtnombres.Text == "" || txtapellidos.Text == "")
            {
                MessageBox.Show("Campo nombre o apellidos vacios");
            }
            else
            {
                if (txtnombres.Text.Substring(0, 1) == " " || txtapellidos.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("El primer carácter de 'Nombre' y 'Apellido' no puede ser un espacio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string primera_nombre, primera_apellido, pn, pa;
                    string txtn = txtnombres.Text;
                    string txta = txtapellidos.Text;
                    string c = "";
                    try
                    {
                        primera_nombre = txtn.Substring(0, 1);
                        pn = primera_nombre.ToUpper();
                        primera_apellido = txta.Substring(0, 1);
                        pa = primera_apellido.ToUpper();
                        string con = "DECLARE @cadena varchar(20) EXEC IdDocente '" + pn + "','" + pa + "',@cadena OUTPUT SELECT [s] = @cadena";
                        da = new SqlDataAdapter(con, conexion);
                        dr = da.SelectCommand.ExecuteReader();
                        while (dr.Read())
                        {
                            c = dr["s"].ToString().Trim();
                        }
                        dr.Close();
                        string InsertarPrimerGrado;
                        InsertarPrimerGrado = "INSERT INTO Docentes(IdDocente,Nombres,Apellidos,FechaNacimiento,Dui,Telefono,Direccion,GradoResponsable)";
                        InsertarPrimerGrado += "VALUES(@IdDocente,@Nombres,@Apellidos,@FechaNacimiento,@Dui,@Telefono,@Direccion,@GradoResponsable)";
                        insert1 = new SqlCommand(InsertarPrimerGrado, conexion);
                        insert1.Parameters.Add(new SqlParameter("@IdDocente", SqlDbType.VarChar));
                        insert1.Parameters["@IdDocente"].Value = c;
                        insert1.Parameters.Add(new SqlParameter("@Nombres", SqlDbType.VarChar));
                        insert1.Parameters["@Nombres"].Value = txtnombres.Text;
                        insert1.Parameters.Add(new SqlParameter("@Apellidos", SqlDbType.VarChar));
                        insert1.Parameters["@Apellidos"].Value = txtapellidos.Text;
                        insert1.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.DateTime));
                        insert1.Parameters["@FechaNacimiento"].Value = fechanac.Value;
                        insert1.Parameters.Add(new SqlParameter("@Dui", SqlDbType.VarChar));
                        insert1.Parameters["@Dui"].Value = DUIText.Text;
                        insert1.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
                        insert1.Parameters["@Telefono"].Value = txttel.Text;
                        insert1.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
                        insert1.Parameters["@Direccion"].Value = txtdir.Text;
                        insert1.Parameters.Add(new SqlParameter("@GradoResponsable", SqlDbType.Text));
                        insert1.Parameters["@GradoResponsable"].Value = combogrados.SelectedItem.ToString();
                        insert1.ExecuteNonQuery();

                        string insertar = "INSERT INTO Usuarios(Usuario,Contraseña,TipoUsuario) VALUES (@Usuario,@Contraseña,@TipoUsuario)";
                        insert1 = new SqlCommand(insertar, conexion);
                        insert1.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar));
                        insert1.Parameters["@Usuario"].Value = c;
                        insert1.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
                        insert1.Parameters["@Contraseña"].Value = ContraseñaText.Text;
                        insert1.Parameters.Add(new SqlParameter("@TipoUsuario", SqlDbType.VarChar));
                        insert1.Parameters["@TipoUsuario"].Value = "Docente" + combogrados.SelectedItem.ToString();
                        insert1.ExecuteNonQuery();

                        //Limpiamos los textBox
                        txtnombres.Text = "";
                        txtapellidos.Text = "";
                        DUIText.Text = "";
                        txttel.Text = "";
                        txtdir.Text = "";
                    
                        MessageBox.Show("Docente registrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        conexion.Close();
                        DocentesDG.DataSource = MostrarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);

                    }
                }
                conexion.Close();
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Docentes WHERE IdDocente='" + CodigoText.Text + "'", conexion);
                SqlCommand cmdusers = new SqlCommand("Delete from Usuarios where Usuario= '" + CodigoText.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                int fila = cmdusers.ExecuteNonQuery();
                conexion.Close();
                DocentesDG.DataSource = MostrarDatos();
                CodigoText.Text = "";
                txtnombres.Text = "";
                txtapellidos.Text = "";
                DUIText.Text = "";
                txttel.Text = "";
                txtdir.Text = "";
                if (filas > 0)
                {
                    MessageBox.Show("Docente eliminado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Error al eliminar.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conexion.Close();
        }

        private void DocentesDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DocentesDG.Rows[e.RowIndex];
            CodigoText.Text = Convert.ToString(fila.Cells[0].Value);
            txtnombres.Text = Convert.ToString(fila.Cells[1].Value);
            txtapellidos.Text = Convert.ToString(fila.Cells[2].Value);
            fechanac.Value = Convert.ToDateTime(fila.Cells[3].Value);
            DUIText.Text = Convert.ToString(fila.Cells[4].Value);
            txttel.Text = Convert.ToString(fila.Cells[5].Value);
            txtdir.Text = Convert.ToString(fila.Cells[6].Value);
            combogrados.Text = Convert.ToString(fila.Cells[7].Value);

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Docentes SET Nombres='" + txtnombres.Text + "',Apellidos='" + txtapellidos.Text + "',Dui ='" + DUIText.Text + "',Telefono ='" + txttel.Text + "',Direccion ='" + txtdir.Text + "',GradoResponsable ='" + combogrados.SelectedItem.ToString() + "'WHERE IdDocente = '" + CodigoText.Text + "'", conexion);
                SqlCommand cmdusers = new SqlCommand("update Usuarios set Contraseña='" + ContraseñaText.Text + "',TipoUsuario='Docente" + combogrados.SelectedItem.ToString() + "'" + " where Usuario='" + CodigoText.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                int fila = cmdusers.ExecuteNonQuery();
                conexion.Close();
                DocentesDG.DataSource = MostrarDatos();
                CodigoText.Text = "";
                txtnombres.Text = "";
                txtapellidos.Text = "";
                DUIText.Text = "";
                txttel.Text = "";
                txtdir.Text = "";
        
                if (filas > 0)
                {
                    MessageBox.Show("Docente actualizado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Error al actualizar.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conexion.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
