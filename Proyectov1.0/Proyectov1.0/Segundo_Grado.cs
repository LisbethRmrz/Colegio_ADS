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
    public partial class Segundo_Grado : Form
    {
        Conexion cn = new Conexion();
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;
        public Segundo_Grado()
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

            cn.SegundoGrado(Datos2);
        }



        private void Segundo_Grado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
          //  this.alumnosTableAdapter.Fill(this.proyectoDataSet.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet3.Alumnos' Puede moverla o quitarla según sea necesario.
            //this.alumnosTableAdapter.Fill(this.proyectoDataSet3.Alumnos);
            //Datos2.DataSource = MostrarDatos();
            textBox1.Visible = false;
        }
        //public DataTable MostrarDatos()
        //{
        //    conexion.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM Alumnos  WHERE IdGrado = 'SG1902'", conexion);
        //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
        //    ds = new DataSet();
        //    ad.Fill(ds, "tabla");
        //    conexion.Close();
        //    return ds.Tables["tabla"];
        //}

        private void btnguardar2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtnombres2.Text == "" || txtapellidos2.Text == "" || fechanac2.Text == "" || txtresponsable2.Text == "" || txtdui2.Text == "" || fechanac2.Text == "" || txtdir2.Text == "")
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                if (txtnombres2.Text.Substring(0, 1) == " " || txtapellidos2.Text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("El primer carácter de 'Nombre' y 'Apellido' no puede ser un espacio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string primera_nombre, primera_apellido, pn, pa;
                    string txtn = txtnombres2.Text;
                    string txta = txtapellidos2.Text;
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
                        insert1.Parameters["@nombres_alumno"].Value = txtnombres2.Text;
                        insert1.Parameters.Add(new SqlParameter("@apellidos_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@apellidos_alumno"].Value = txtapellidos2.Text;
                        insert1.Parameters.Add(new SqlParameter("@fecha_nac_alumno", SqlDbType.DateTime));
                        insert1.Parameters["@fecha_nac_alumno"].Value = fechanac2.Value;
                        insert1.Parameters.Add(new SqlParameter("@nombre_responsable_alumno", SqlDbType.VarChar));
                        insert1.Parameters["@nombre_responsable_alumno"].Value = txtresponsable2.Text;
                        insert1.Parameters.Add(new SqlParameter("@numero_documento_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@numero_documento_responsable"].Value = txtdui2.Text;
                        insert1.Parameters.Add(new SqlParameter("@telefono_responsable", SqlDbType.VarChar));
                        insert1.Parameters["@telefono_responsable"].Value = txttel2.Text;
                        insert1.Parameters.Add(new SqlParameter("@direccion_alumno", SqlDbType.Text));
                        insert1.Parameters["@direccion_alumno"].Value = txtdir2.Text;
                        insert1.Parameters.Add(new SqlParameter("@IdGrado", SqlDbType.VarChar));
                        insert1.Parameters["@IdGrado"].Value = "SG1902";
                        insert1.ExecuteNonQuery();
                        //Limpiamos los textBox
                        txtnombres2.Text = "";
                        txtapellidos2.Text = "";
                        txtresponsable2.Text = "";
                        txtdui2.Text = "";
                        txttel2.Text = "";
                        txtdir2.Text = "";
                        MessageBox.Show("Registro agregado");
                        cn.SegundoGrado(Datos2);
                        conexion.Close();
                        //Datos2.DataSource = MostrarDatos();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);

                    }
                }
                conexion.Close();
            }
        }

        private void Datos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = Datos2.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(fila.Cells[0].Value);
            txtnombres2.Text = Convert.ToString(fila.Cells[1].Value);
            txtapellidos2.Text = Convert.ToString(fila.Cells[2].Value);
            fechanac2.Value = Convert.ToDateTime(fila.Cells[3].Value);
            txtresponsable2.Text = Convert.ToString(fila.Cells[4].Value);
            txtdui2.Text = Convert.ToString(fila.Cells[5].Value);
            txttel2.Text = Convert.ToString(fila.Cells[6].Value);
            txtdir2.Text = Convert.ToString(fila.Cells[7].Value);
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Alumnos WHERE IdAlumno='" + textBox1.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                cn.SegundoGrado(Datos2);
                conexion.Close();
                //Datos2.DataSource = MostrarDatos();
                textBox1.Text = "";
                txtnombres2.Text = "";
                txtapellidos2.Text = "";
                txtresponsable2.Text = "";
                txtdui2.Text = "";
                txttel2.Text = "";
                txtdir2.Text = "";
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

        private void btnactualizar2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Alumnos SET Nombres='" + txtnombres2.Text + "',Apellidos='" + txtapellidos2.Text + "',FechaNacimiento='" + fechanac2.Value + "',NombreResponsable='" + txtresponsable2.Text + "',DuiResponsable='" + txtdui2.Text + "',Telefono='" + txttel2.Text + "',Direccion='" + txtdir2.Text + "'WHERE IdAlumno = '" + textBox1.Text + "'", conexion);
                int filas = cmd.ExecuteNonQuery();
                cn.SegundoGrado(Datos2);
                conexion.Close();
                //Datos2.DataSource = MostrarDatos();
                textBox1.Text = "";
                txtnombres2.Text = "";
                txtapellidos2.Text = "";
                txtresponsable2.Text = "";
                txtdui2.Text = "";
                txttel2.Text = "";
                txtdir2.Text = "";
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

        private void txtnombres2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellidos2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtresponsable2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtdir2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbuscar2_TextChanged(object sender, EventArgs e)
        {
            /*if (txtbuscar2.Text != "")
            {
                Datos2.CurrentCell = null;
                foreach (DataGridViewRow r in Datos2.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in Datos2.Rows)
                {
                    foreach (DataGridViewCell t in r.Cells)
                    {
                        if ((t.ToString().ToUpper()).IndexOf(txtbuscar2.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                
            }*/
        }

        //             METODOS PARA BUSCAR
        public DataTable ListaBusqueda(string codigo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Alumnos WHERE Nombres LIKE '%{0}%' OR Apellidos LIKE '%{1}%' AND IdGrado = 'SG1902'", codigo, codigo), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        private void Btnbuscar2_Click(object sender, EventArgs e)
        {
            Datos2.DataSource = ListaBusqueda(txtbuscar2.Text);
        }

        private void panelDatosprimero_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
