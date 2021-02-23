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
    public partial class Soci1 : Form
    {
        Conexion cn = new Conexion();
        private SqlConnection conexion;
        private SqlCommand insert1;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private string sCn;
        public Soci1()
        {
            InitializeComponent();
            cn.conec();
            sCn = cn.cadena;
            conexion = new SqlConnection(sCn);
            cn.CargarAlumnos(AlumnosPrimero);
        }

        private void Soci1_Load(object sender, EventArgs e)
        {
            conexion.Open();

            cn.CargarAlumnos(AlumnosPrimero);

            cn.CargarNotasSociales(dgvsociales);

            conexion.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtestudiante.Text == "" || nota1.Text == "" || nota2.Text == "" || nota3.Text == "")
            { MessageBox.Show("Campos Vacios"); }
            else
            {
                try
                {
                    decimal proml, n1, n2, n3;
                    n1 = Convert.ToDecimal(nota1.Text);
                    n2 = Convert.ToDecimal(nota2.Text);
                    n3 = Convert.ToDecimal(nota3.Text);
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
                    insert1.Parameters["@IdMateria"].Value = "SOC19";
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
                    nota1.Text = "";
                    nota2.Text = "";
                    nota3.Text = "";
                    cn.CargarNotasSociales(dgvsociales);

                    MessageBox.Show("Notas agregadas correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
            }
            conexion.Close();
        }

        private void AlumnosPrimero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = AlumnosPrimero.Rows[e.RowIndex];
            txtestudiante.Text = Convert.ToString(fila.Cells[1].Value);
        }

        private void dgvsociales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvsociales.Rows[e.RowIndex];
            txtestudiante.Text = Convert.ToString(fila.Cells[0].Value);
            nota1.Text = Convert.ToString(fila.Cells[4].Value);
            nota2.Text = Convert.ToString(fila.Cells[5].Value);
            nota3.Text = Convert.ToString(fila.Cells[6].Value);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtestudiante.Text = "";
            nota1.Text = "";
            nota2.Text = "";
            nota3.Text = "";
        }

        private void eliminar_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from Notas where IdAlumno='" + txtestudiante.Text + "' and IdMateria = 'SOC19'", conexion);
                    int filas = cmd.ExecuteNonQuery();
                    cn.CargarNotasSociales(dgvsociales);
                    txtestudiante.Text = "";
                    nota1.Text = "";
                    nota2.Text = "";
                    nota3.Text = "";

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

        private void actualizar_Click(object sender, EventArgs e)
        {

            if (txtestudiante.Text == "")
            {
                MessageBox.Show("Seleccione un registro");
            }
            else
            {
                decimal proml, n1, n2, n3;
            n1 = Convert.ToDecimal(nota1.Text);
            n2 = Convert.ToDecimal(nota2.Text);
            n3 = Convert.ToDecimal(nota3.Text);
            proml = (n1 + n2 + n3) / 3;

                conexion.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Notas SET nota1='" + n1 + "',nota2='" + n2 + "',nota3='" + n3 + "',promedio='" + proml + "'where IdAlumno ='" + txtestudiante.Text + "' and IdMateria = 'SOC19'", conexion);
                    int filas = cmd.ExecuteNonQuery();
                    cn.CargarNotasSociales(dgvsociales);
                    txtestudiante.Text = "";
                    nota1.Text = "";
                    nota2.Text = "";
                    nota3.Text = "";

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
