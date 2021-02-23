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
    public partial class Tercer_Grado : Form
    {
        Conexion cn = new Conexion();
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;
        public Tercer_Grado()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            //acceso a la función conec de la clase conexión
            cn.conec();
            //agrego la variable scn a la cadena conexión
            sCn = cn.cadena;
            //creo la conexión pensándole como argumento la cadena
            conexion = new SqlConnection(sCn);
            //abro la conexión
            cn.TercerGrado(Datos3);
        }

        private void Tercer_Grado_Load(object sender, EventArgs e)
        {
            //Datos3.DataSource = MostrarDatos();
            textBox1.Visible = false;
        }
        //public DataTable MostrarDatos()
        //{
        //    conexion.Open();
        //    SqlCommand cmd = new SqlCommand("select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'TG1903'", conexion);
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    ds = new DataSet();
        //    ad.Fill(ds, "tabla");
        //    conexion.Close();
        //    return ds.Tables["tabla"];
        //}

        private void btnguardar3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtnombres3.Text == "" || txtapellidos3.Text == "")
            {
                MessageBox.Show("Campo nombre o apellidos vacios");
            }
            else
            {
                if (txtnombres3.Text.Substring(0, 1) == " " || txtapellidos3.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("El primer carácter de 'Nombre' y 'Apellido' no puede ser un espacio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string primera_nombre, primera_apellido, pn, pa;
                    string txtn = txtnombres3.Text;
                    string txta = txtapellidos3.Text;
                    string c = "";
                    try
                    {
                        primera_nombre = txtn.Substring(0, 1);
                        pn = primera_nombre.ToUpper();
                        primera_apellido = txta.Substring(0, 1);
                        pa = primera_apellido.ToUpper();
                        string con = "DECLARE @cadena varchar(20) EXEC IdAlumno '" + pn + "','" + pa + "',@cadena OUTPUT SELECT [s] = @cadena";
                        da = new SqlDataAdapter(con, conexion);
                        dr = da.SelectCommand.ExecuteReader();
                        while (dr.Read())
                        {
                            c = dr["s"].ToString().Trim();
                        }
                        dr.Close();
                        MessageBox.Show("" + c);
                        string InsertarPrimerGrado;
                        InsertarPrimerGrado = "INSERT INTO Alumnos(IdAlumno,Nombres,Apellidos,FechaNacimiento,NombreResponsable,DuiResponsable,Telefono,Direccion,IdGrado)";
                        InsertarPrimerGrado += "VALUES(@IdAlumno,@nombres_alumno,@apellidos_alumno,@fecha_nac_alumno,@nombre_responsable_alumno,@numero_documento_responsable,@telefono_responsable,@direccion_alumno,@IdGrado)";
                        insert1 = new SqlCommand(InsertarPrimerGrado, conexion);
                        insert1.Parameters.Add(new SqlParameter("@IdAlumno", SqlDbType.VarChar));
                        insert1.Parameters["@IdAlumno"].Value = c;
                        insert1.Parameters.Add(new SqlParameter("@nombres_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@nombres_alumno"].Value = txtnombres3.Text;
                        insert1.Parameters.Add(new SqlParameter("@apellidos_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@apellidos_alumno"].Value = txtapellidos3.Text;
                        insert1.Parameters.Add(new SqlParameter("@fecha_nac_alumno", SqlDbType.DateTime));
                        insert1.Parameters["@fecha_nac_alumno"].Value = fechanac3.Value;
                        insert1.Parameters.Add(new SqlParameter("@nombre_responsable_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@nombre_responsable_alumno"].Value = txtresponsable3.Text;
                        insert1.Parameters.Add(new SqlParameter("@numero_documento_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@numero_documento_responsable"].Value = txtdui3.Text;
                        insert1.Parameters.Add(new SqlParameter("@telefono_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@telefono_responsable"].Value = txttel3.Text;
                        insert1.Parameters.Add(new SqlParameter("@direccion_alumno", SqlDbType.Text));
                        insert1.Parameters["@direccion_alumno"].Value = txtdir3.Text;
                        insert1.Parameters.Add(new SqlParameter("@IdGrado", SqlDbType.VarChar));
                        insert1.Parameters["@IdGrado"].Value = "TG1903";
                        insert1.ExecuteNonQuery();
                        //Limpiamos los textBox
                        txtnombres3.Text = "";
                        txtapellidos3.Text = "";
                        txtresponsable3.Text = "";
                        txtdui3.Text = "";
                        txttel3.Text = "";
                        txtdir3.Text = "";
                        MessageBox.Show("Registro agregado");
                        cn.TercerGrado(Datos3);
                        conexion.Close();
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);

                    }
                }
                conexion.Close();
            }
        }

        private void Datos3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = Datos3.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            txtnombres3.Text = Convert.ToString(fila.Cells[1].Value);
            txtapellidos3.Text = Convert.ToString(fila.Cells[2].Value);
            fechanac3.Value = Convert.ToDateTime(fila.Cells[3].Value);
            txtresponsable3.Text = Convert.ToString(fila.Cells[4].Value);
            txtdui3.Text = Convert.ToString(fila.Cells[5].Value);
            txttel3.Text = Convert.ToString(fila.Cells[6].Value);
            txtdir3.Text = Convert.ToString(fila.Cells[7].Value);
        }

        private void btneliminar3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Alumnos WHERE IdAlumno='" + textBox1.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
                cn.TercerGrado(Datos3);
                textBox1.Text = "";
                txtnombres3.Text = "";
                txtapellidos3.Text = "";
                txtresponsable3.Text = "";
                txtdui3.Text = "";
                txttel3.Text = "";
                txtdir3.Text = "";
                if (filas > 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conexion.Close();
        }

        private void btnactualizar3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Alumnos SET Nombres='" + txtnombres3.Text + "',Apellidos='" + txtapellidos3.Text + "',FechaNacimiento='" + fechanac3.Value + "',NombreResponsable='" + txtresponsable3.Text + "',DuiResponsable='" + txtdui3.Text + "',Telefono='" + txttel3.Text + "',Direccion='" + txtdir3.Text + "'WHERE IdAlumno = '" + textBox1.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                cn.TercerGrado(Datos3);
                conexion.Close();
              
                textBox1.Text = "";
                txtnombres3.Text = "";
                txtapellidos3.Text = "";
                txtresponsable3.Text = "";
                txtdui3.Text = "";
                txttel3.Text = "";
                txtdir3.Text = "";
                if (filas > 0)
                {
                    MessageBox.Show("Actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            conexion.Close();
        }

        private void txtnombres3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellidos3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtresponsable3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        /*
        private void txtdir3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        */

        public DataTable ListaBusqueda(string codigo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Alumnos WHERE Nombres LIKE '%{0}%' OR Apellidos LIKE '%{1}%' AND IdGrado = 'TG1903'", codigo, codigo), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            Datos3.DataSource = ListaBusqueda(txtbuscar3.Text);
        }
    }
}
