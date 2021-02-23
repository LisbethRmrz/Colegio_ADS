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
    public partial class Leng1 : Form
    {

        Conexion cn = new Conexion();
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;

        

        public Leng1()
        {
            InitializeComponent();
            cn.conec();
            sCn = cn.cadena;
            conexion = new SqlConnection(sCn);
            cn.CargarAlumnos(AlumnosPrimero);
        }

        private void btnguardarleng_Click(object sender, EventArgs e)
        {

            conexion.Open();
            if (txtestudiante.Text == "" || nota1leng.Text == "" || nota2leng.Text == "" || nota3leng.Text == "")
            { MessageBox.Show("Campos Vacios"); }
            else
            {
                try
                {
                    decimal proml, n1, n2, n3;
                    n1 = Convert.ToDecimal(nota1leng.Text);
                    n2 = Convert.ToDecimal(nota2leng.Text);
                    n3 = Convert.ToDecimal(nota3leng.Text);
                    proml = (n1 + n2 + n3) / 3;

                    string InsertarLenguaje1;
                    InsertarLenguaje1 = "insert into Notas(IdAlumno,IdGrados,IdMateria,nota1,nota2,nota3,promedio)";
                    InsertarLenguaje1 += "values(@IdAlumno,@IdGrados,@IdMateria,@nota1,@nota2,@nota3,@promedio)";
                    insert1 = new SqlCommand(InsertarLenguaje1, conexion);
                    insert1.Parameters.Add(new SqlParameter("@IdAlumno", SqlDbType.VarChar));
                    insert1.Parameters["@IdAlumno"].Value = txtestudiante.Text; ; ;
                    insert1.Parameters.Add(new SqlParameter("@IdGrados", SqlDbType.VarChar));
                    insert1.Parameters["@IdGrados"].Value = "PG1901";
                    insert1.Parameters.Add(new SqlParameter("@IdMateria", SqlDbType.VarChar));
                    insert1.Parameters["@IdMateria"].Value = "LEN19";
                    insert1.Parameters.Add("@nota1", SqlDbType.Decimal);
                    insert1.Parameters["@nota1"].Value = n1;
                    insert1.Parameters.Add("@nota2", SqlDbType.Decimal);
                    insert1.Parameters["@nota2"].Value = n2;
                    insert1.Parameters.Add("@nota3", SqlDbType.Decimal);
                    insert1.Parameters["@nota3"].Value = n3;
                    insert1.Parameters.Add("@promedio", SqlDbType.Decimal);
                    insert1.Parameters["@promedio"].Value = proml;
                    insert1.ExecuteNonQuery();
                    //Limpiando textbox

                    txtestudiante.Text = "";
                    nota1leng.Text = "";
                    nota2leng.Text = "";
                    nota3leng.Text = "";
                    cn.CargarNotasLenguaje(dgvlenguaje1);

                    MessageBox.Show("Notas agregadas correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }
            conexion.Close();
        }

        private void Leng1_Load(object sender, EventArgs e)
        {
            conexion.Open();

            cn.CargarAlumnos(AlumnosPrimero);

            cn.CargarNotasLenguaje(dgvlenguaje1);

            conexion.Close();

        }

        private void alumnoslenguaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = AlumnosPrimero.Rows[e.RowIndex];
            txtestudiante.Text = Convert.ToString(fila.Cells[1].Value);
        }

        private void dgvlenguaje1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvlenguaje1.Rows[e.RowIndex];
            txtestudiante.Text = Convert.ToString(fila.Cells[0].Value);
            nota1leng.Text = Convert.ToString(fila.Cells[4].Value);
            nota2leng.Text = Convert.ToString(fila.Cells[5].Value);
            nota3leng.Text = Convert.ToString(fila.Cells[6].Value);
        }

        private void btnlimpiarleng_Click(object sender, EventArgs e)
        {
            txtestudiante.Text = "";
            nota1leng.Text = "";
            nota2leng.Text = "";
            nota3leng.Text = "";
        }

        private void btneliminar1_Click(object sender, EventArgs e)
        {
            if (txtestudiante.Text == "")
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                conexion.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from Notas where IdAlumno='" + txtestudiante.Text + "' and IdMateria = 'LEN19'", conexion);
                    int filas = cmd.ExecuteNonQuery();
                    cn.CargarNotasLenguaje(dgvlenguaje1);
                    txtestudiante.Text = "";
                    nota1leng.Text = "";
                    nota2leng.Text = "";
                    nota3leng.Text = "";

                    if (filas > 0)
                    {
                        MessageBox.Show("Notas eliminadas exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        }

        private void btnactualizarleng_Click(object sender, EventArgs e)
        {
            if (txtestudiante.Text == "")
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                decimal proml, n1, n2, n3;
            n1 = Convert.ToDecimal(nota1leng.Text);
            n2 = Convert.ToDecimal(nota2leng.Text);
            n3 = Convert.ToDecimal(nota3leng.Text);
            proml = (n1 + n2 + n3) / 3;

           
                conexion.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Notas SET nota1='" + n1 + "',nota2='" + n2 + "',nota3='" + n3 + "',promedio='" + proml + "'where IdAlumno ='" + txtestudiante.Text + "' and IdMateria = 'LEN19'", conexion);
                    int filas = cmd.ExecuteNonQuery();
                    cn.CargarNotasLenguaje(dgvlenguaje1);
                    txtestudiante.Text = "";
                    nota1leng.Text = "";
                    nota2leng.Text = "";
                    nota3leng.Text = "";

                    if (filas > 0)
                    {
                        MessageBox.Show("Notas actualizadas correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        }
    }
}
