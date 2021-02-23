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
    public partial class Primer_Grado : Form
    {
        Conexion cn = new Conexion();
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;

        public Primer_Grado()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            //acceso a la función conec de la clase conexión
            cn.conec();
            //agrego la variable scn a la cadena conexión
            sCn = cn.cadena;
            //creo la conexión pensándole como argumento la cadena
            conexion = new SqlConnection(sCn);
            cn.PrimerGrado(Datos1);
            //abro la conexión
   
        }

        private void Primer_Grado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet2.Alumnos' Puede moverla o quitarla según sea necesario.
            //this.alumnosTableAdapter1.Fill(this.proyectoDataSet2.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
            // this.alumnosTableAdapter.Fill(this.proyectoDataSet1.Alumnos);
          
            textBox1.Visible = false;
        }

        //public DataTable MostrarDatos()
        //{
        //    conexion.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos WHERE IdGrado = 'PG1901'", conexion);
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    ds = new DataSet();
        //    ad.Fill(ds, "tabla");
        //    conexion.Close();
        //    return ds.Tables["tabla"];
        //}

        private void btnguardar1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtnombres1.Text == "" || txtapellidos1.Text == ""|| fechanac1.Text == "" || txtresponsable1.Text == "" || txtdui1.Text == "" || maskedTextBox2.Text == "" || txtdir1.Text == "") 
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                if (txtnombres1.Text.Substring(0, 1) == " " || txtapellidos1.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("El primer carácter de 'Nombre' y 'Apellido' no puede ser un espacio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string primera_nombre, primera_apellido, pn, pa;
                    string txtn = txtnombres1.Text;
                    string txta = txtapellidos1.Text;
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
                        insert1.Parameters["@nombres_alumno"].Value = txtnombres1.Text;
                        insert1.Parameters.Add(new SqlParameter("@apellidos_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@apellidos_alumno"].Value = txtapellidos1.Text;
                        insert1.Parameters.Add(new SqlParameter("@fecha_nac_alumno", SqlDbType.DateTime));
                        insert1.Parameters["@fecha_nac_alumno"].Value = fechanac1.Value;
                        insert1.Parameters.Add(new SqlParameter("@nombre_responsable_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@nombre_responsable_alumno"].Value = txtresponsable1.Text;
                        insert1.Parameters.Add(new SqlParameter("@numero_documento_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@numero_documento_responsable"].Value = txtdui1.Text;
                        insert1.Parameters.Add(new SqlParameter("@telefono_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@telefono_responsable"].Value = maskedTextBox2.Text;
                        insert1.Parameters.Add(new SqlParameter("@direccion_alumno", SqlDbType.Text));
                        insert1.Parameters["@direccion_alumno"].Value = txtdir1.Text;
                        insert1.Parameters.Add(new SqlParameter("@IdGrado", SqlDbType.VarChar));
                        insert1.Parameters["@IdGrado"].Value = "PG1901";
                        insert1.ExecuteNonQuery();
                        //Limpiamos los textBox
                        txtnombres1.Text = "";
                        txtapellidos1.Text = "";
                        txtresponsable1.Text = "";
                        txtdui1.Text = "";
                        maskedTextBox2.Text = "";
                        txtdir1.Text = "";
                        MessageBox.Show("Registro agregado");
                        conexion.Close();
                        cn.PrimerGrado(Datos1);
                        //Datos1.DataSource = MostrarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);

                    }
                }
                conexion.Close();
            }
           
        }

        //private void Datos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow fila = Datos1.Rows[e.RowIndex];
        //    textBox1.Text = Convert.ToString(fila.Cells[0].Value);
        //    txtnombres1.Text = Convert.ToString(fila.Cells[1].Value);
        //    txtapellidos1.Text = Convert.ToString(fila.Cells[2].Value);
        //    fechanac1.Value = Convert.ToDateTime(fila.Cells[3].Value);
        //    txtresponsable1.Text = Convert.ToString(fila.Cells[4].Value);
        //    txtdui1.Text = Convert.ToString(fila.Cells[5].Value);     
        //    txtdui1.Text = Convert.ToString(fila.Cells[6].Value);
        //    txtdir1.Text = Convert.ToString(fila.Cells[7].Value);
        //}

        private void btneliminar1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Alumnos WHERE IdAlumno='"+textBox1.Text+"'", conexion);
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
                //Datos1.DataSource = MostrarDatos();
                cn.PrimerGrado(Datos1);
                textBox1.Text= "";
                txtnombres1.Text = "";
                txtapellidos1.Text = "";
                txtresponsable1.Text = "";
                txtdui1.Text = "";
                txtdui1.Text = "";
                txtdir1.Text = "";
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

        private void btnactualizar1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Alumnos SET Nombres='" + txtnombres1.Text + "',Apellidos='" + txtapellidos1.Text + "',FechaNacimiento='" + fechanac1.Value + "',NombreResponsable='" + txtresponsable1.Text + "',DuiResponsable='" + txtdui1.Text + "',Telefono='" + txtdui1.Text + "',Direccion='" + txtdir1.Text + "'WHERE IdAlumno = '" + textBox1.Text+"'", conexion);
                int filas = cmd.ExecuteNonQuery();
                conexion.Close();
                //Datos1.DataSource = MostrarDatos();
                cn.PrimerGrado(Datos1);
                textBox1.Text= "";
                txtnombres1.Text = "";
                txtapellidos1.Text = "";
                txtresponsable1.Text = "";
                txtdui1.Text = "";
                txtdui1.Text = "";
                txtdir1.Text = "";
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

        private void txtnombres1_KeyPress(object sender, KeyPressEventArgs e)
        {
     if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar !=(char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtapellidos1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


   

        private void txtdir1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtresponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnombres1_TextChanged(object sender, EventArgs e)
        {

        }

        public DataTable ListaBusqueda(string codigo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Alumnos WHERE Nombres LIKE '%{0}%' OR Apellidos LIKE '%{1}%' AND IdGrado = 'PG1901'", codigo, codigo), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Datos1.DataSource = ListaBusqueda(txtbuscar1.Text);
        }

        private void fechanac1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Datos1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = Datos1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            txtnombres1.Text = Convert.ToString(fila.Cells[1].Value);
            txtapellidos1.Text = Convert.ToString(fila.Cells[2].Value);
            fechanac1.Value = Convert.ToDateTime(fila.Cells[3].Value);
            txtresponsable1.Text = Convert.ToString(fila.Cells[4].Value);
            txtdui1.Text = Convert.ToString(fila.Cells[5].Value);
            maskedTextBox2.Text = Convert.ToString(fila.Cells[6].Value);
            txtdir1.Text = Convert.ToString(fila.Cells[7].Value);
        }
    }
}

