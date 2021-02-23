using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyectov1._0
{

            class Conexion
            {
                public string cadena;
                public void conec()
                {
                    cadena = "server = localhost; database = Proyecto_A; integrated security = true; password = 1234";
        }

        public SqlConnection con = new SqlConnection();

        //Para el DGV
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        SqlDataReader dr1;
        SqlDataAdapter da1;
        DataTable dt1;

        SqlDataReader dr2;
        SqlDataAdapter da2;
        DataTable dt2;
        public Conexion()
        {
            con.ConnectionString = cadena;
        }

        public void CargarNotasLenguaje(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='LEN19' and D.IdGrados = 'PG1901'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasLenguaje2(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='LEN19' and D.IdGrados = 'SG1902'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasLenguaje3(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='LEN19' and D.IdGrados = 'TG1903'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasLenguaje4(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='LEN19' and D.IdGrados = 'CG1904'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasLenguaje5(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='LEN19' and D.IdGrados = 'QG1905'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasLenguaje6(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='LEN19' and D.IdGrados = 'SG1906'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasCiencias(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='CIE19' and D.IdGrados = 'PG1901'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasCiencias2(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='CIE19' and D.IdGrados = 'SG1902'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasCiencias3(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='CIE19' and D.IdGrados = 'TG1903'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasCiencias4(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='CIE19' and D.IdGrados = 'CG1904'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasCiencias5(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='CIE19' and D.IdGrados = 'QG1905'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasCiencias6(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='CIE19' and D.IdGrados = 'SG1906'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasMatematicas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='MAT19' and D.IdGrados = 'PG1901'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasMatematicas2(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='MAT19' and D.IdGrados = 'SG1902'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasMatematicas3(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='MAT19' and D.IdGrados = 'TG1903'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasMatematicas4(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='MAT19' and D.IdGrados = 'CG1904'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasMatematicas5(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='MAT19' and D.IdGrados = 'QG1905'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasMatematicas6(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='MAT19' and D.IdGrados = 'SG1906'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasSociales(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='SOC19' and D.IdGrados = 'PG1901'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasSociales2(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='SOC19' and D.IdGrados = 'SG1902'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasSociales3(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='SOC19' and D.IdGrados = 'TG1903'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasSociales4(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='SOC19' and D.IdGrados = 'CG1904'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasSociales5(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='SOC19' and D.IdGrados = 'QG1905'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarNotasSociales6(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select A.IdAlumno, B.Nombres + ' ' + B.Apellidos as Alumno, D.NombreGrado as Grado, C.NombreMateria as Materia, A.nota1 as Nota1, A.nota2 as Nota2, A.nota3 as Nota3, A.promedio as Promedio from notas as A inner join Alumnos as B on A.IdAlumno = B.IdAlumno inner join Grados as D on A.IdGrados = D.IdGrados inner join Materias as C on A.IdMateria = C.IdMateria where C.IdMateria='SOC19' and D.IdGrados = 'SG1906'", cadena);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas");
                ex.ToString();
            }
        }

        public void CargarAlumnos(DataGridView dgv)
        {
            try
            {
                da1 = new SqlDataAdapter("Select Nombres + ' ' + Apellidos as Nombre_Completo, IdAlumno from Alumnos where IdGrado = 'PG1901'", cadena);
                dt1 = new DataTable();
                da1.Fill(dt1);
                dgv.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void CargarAlumnosSegundo(DataGridView dgv)
        {
            try
            {
                da1 = new SqlDataAdapter("Select Nombres + ' ' + Apellidos as Nombre_Completo, IdAlumno from Alumnos where IdGrado = 'SG1902'", cadena);
                dt1 = new DataTable();
                da1.Fill(dt1);
                dgv.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void CargarAlumnos3(DataGridView dgv)
        {
            try
            {
                da1 = new SqlDataAdapter("Select Nombres + ' ' + Apellidos as Nombre_Completo, IdAlumno from Alumnos where IdGrado = 'TG1903'", cadena);
                dt1 = new DataTable();
                da1.Fill(dt1);
                dgv.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void CargarAlumnos4(DataGridView dgv)
        {
            try
            {
                da1 = new SqlDataAdapter("Select Nombres + ' ' + Apellidos as Nombre_Completo, IdAlumno from Alumnos where IdGrado = 'CG1904'", cadena);
                dt1 = new DataTable();
                da1.Fill(dt1);
                dgv.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void CargarAlumnos5(DataGridView dgv)
        {
            try
            {
                da1 = new SqlDataAdapter("Select Nombres + ' ' + Apellidos as Nombre_Completo, IdAlumno from Alumnos where IdGrado = 'QG1905'", cadena);
                dt1 = new DataTable();
                da1.Fill(dt1);
                dgv.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void CargarAlumnos6(DataGridView dgv)
        {
            try
            {
                da1 = new SqlDataAdapter("Select Nombres + ' ' + Apellidos as Nombre_Completo, IdAlumno from Alumnos where IdGrado = 'SG1906'", cadena);
                dt1 = new DataTable();
                da1.Fill(dt1);
                dgv.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        //select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'PG1901'
        public void PrimerGrado(DataGridView dgv)
        {
            try
            {
                da2 = new SqlDataAdapter("Select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'PG1901'", cadena);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dgv.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void SegundoGrado(DataGridView dgv)
        {
            try
            {
                da2 = new SqlDataAdapter("Select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'SG1902'", cadena);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dgv.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void TercerGrado(DataGridView dgv)
        {
            try
            {
                da2 = new SqlDataAdapter("Select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'TG1903'", cadena);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dgv.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void CuartoGrado(DataGridView dgv)
        {
            try
            {
                da2 = new SqlDataAdapter("Select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'CG1904'", cadena);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dgv.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void QuintoGrado(DataGridView dgv)
        {
            try
            {
                da2 = new SqlDataAdapter("Select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'QG1905'", cadena);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dgv.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }

        public void SextoGrado(DataGridView dgv)
        {
            try
            {
                da2 = new SqlDataAdapter("Select A.IdAlumno as Codigo, A.Nombres as Nombres, A.Apellidos AS Apellidos, A.FechaNacimiento as Fecha_de_nacimiento, A.NombreResponsable as Responsable, A.DuiResponsable as Dui_Responsable, A.Telefono as Telefono, A.Direccion as Direccion, B.NombreGrado as Grado from Alumnos as A inner join Grados as B on A.IdGrado = B.IdGrados where B.IdGrados = 'SG1906'", cadena);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dgv.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los Alumnos");
                ex.ToString();
            }
        }
    }
}


