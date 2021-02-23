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
    public partial class Sexto_Grado : Form
    {
        Conexion cn = new Conexion();
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;
        public Sexto_Grado()
        {
            InitializeComponent();
           
            //acceso a la función conec de la clase conexión
            cn.conec();
            //agrego la variable scn a la cadena conexión
            sCn = cn.cadena;
            //creo la conexión pensándole como argumento la cadena
            conexion = new SqlConnection(sCn);
            //abro la conexión
            cn.SextoGrado(Datos6);
        }

        private void Sexto_Grado_Load(object sender, EventArgs e)
        {   
            //Datos6.DataSource = MostrarDatos();
            textBox1.Visible = false;
        }

        //public DataTable MostrarDatos()
        //{
        //    conexion.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos WHERE IdGrado = 'SG1906'", conexion);
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    ds = new DataSet();
        //    ad.Fill(ds, "tabla");
        //    conexion.Close();
        //    return ds.Tables["tabla"];
        //}

        private void btnguardar6_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtnombres6.Text == "" || txtapellidos6.Text == "")
            {
                MessageBox.Show("Campo nombre o apellidos vacios");
            }
            else
            {
                if (txtnombres6.Text.Substring(0, 1) == " " || txtapellidos6.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("El primer carácter de 'Nombre' y 'Apellido' no puede ser un espacio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string primera_nombre, primera_apellido, pn, pa;
                    string txtn = txtnombres6.Text;
                    string txta = txtapellidos6.Text;
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
                        insert1.Parameters["@nombres_alumno"].Value = txtnombres6.Text;
                        insert1.Parameters.Add(new SqlParameter("@apellidos_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@apellidos_alumno"].Value = txtapellidos6.Text;
                        insert1.Parameters.Add(new SqlParameter("@fecha_nac_alumno", SqlDbType.DateTime));
                        insert1.Parameters["@fecha_nac_alumno"].Value = fechanac6.Value;
                        insert1.Parameters.Add(new SqlParameter("@nombre_responsable_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@nombre_responsable_alumno"].Value = txtresponsable6.Text;
                        insert1.Parameters.Add(new SqlParameter("@numero_documento_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@numero_documento_responsable"].Value = txtdui6.Text;
                        insert1.Parameters.Add(new SqlParameter("@telefono_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@telefono_responsable"].Value = txttel6.Text;
                        insert1.Parameters.Add(new SqlParameter("@direccion_alumno", SqlDbType.Text));
                        insert1.Parameters["@direccion_alumno"].Value = txtdir6.Text;
                        insert1.Parameters.Add(new SqlParameter("@IdGrado", SqlDbType.VarChar));
                        insert1.Parameters["@IdGrado"].Value = "SG1906";
                        insert1.ExecuteNonQuery();
                        //Limpiamos los textBox
                        txtnombres6.Text = "";
                        txtapellidos6.Text = "";
                        txtresponsable6.Text = "";
                        txtdui6.Text = "";
                        txttel6.Text = "";
                        txtdir6.Text = "";
                        MessageBox.Show("Registro agregado");
                        cn.SextoGrado(Datos6);
                        conexion.Close();
                        //Datos6.DataSource = MostrarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);

                    }
                }
                conexion.Close();
            }
        }

        private void Datos6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = Datos6.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            txtnombres6.Text = Convert.ToString(fila.Cells[1].Value);
            txtapellidos6.Text = Convert.ToString(fila.Cells[2].Value);
            fechanac6.Value = Convert.ToDateTime(fila.Cells[3].Value);
            txtresponsable6.Text = Convert.ToString(fila.Cells[4].Value);
            txtdui6.Text = Convert.ToString(fila.Cells[5].Value);
            txttel6.Text = Convert.ToString(fila.Cells[6].Value);
            txtdir6.Text = Convert.ToString(fila.Cells[7].Value);
        }

        private void btneliminar6_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Alumnos WHERE IdAlumno='" + textBox1.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                cn.SextoGrado(Datos6);
                conexion.Close();
                //Datos6.DataSource = MostrarDatos();
                textBox1.Text = "";
                txtnombres6.Text = "";
                txtapellidos6.Text = "";
                txtresponsable6.Text = "";
                txtdui6.Text = "";
                txttel6.Text = "";
                txtdir6.Text = "";
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

        private void btnactualizar6_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Alumnos SET Nombres='" + txtnombres6.Text + "',Apellidos='" + txtapellidos6.Text + "',FechaNacimiento='" + fechanac6.Value + "',NombreResponsable='" + txtresponsable6.Text + "',DuiResponsable='" + txtdui6.Text + "',Telefono='" + txttel6.Text + "',Direccion='" + txtdir6.Text + "'WHERE IdAlumno = '" + textBox1.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                cn.SextoGrado(Datos6);
                conexion.Close();
                //Datos6.DataSource = MostrarDatos();
                textBox1.Text = "";
                txtnombres6.Text = "";
                txtapellidos6.Text = "";
                txtresponsable6.Text = "";
                txtdui6.Text = "";
                txttel6.Text = "";
                txtdir6.Text = "";
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

        private void txtnombres6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellidos6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtresponsable6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       /* private void txtdir6_KeyPress(object sender, KeyPressEventArgs e)
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
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Alumnos WHERE Nombres LIKE '%{0}%' OR Apellidos LIKE '%{1}%' AND IdGrado = 'SG1906'", codigo, codigo), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        private void btnBuscar6_Click(object sender, EventArgs e)
        {
            Datos6.DataSource = ListaBusqueda(txtbuscar6.Text);
        }

        private void btnlimpiar6_Click(object sender, EventArgs e)
        {

        }
    }
}
