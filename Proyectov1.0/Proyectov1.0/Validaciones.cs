using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectov1._0
{
  public  class Validaciones
    {

        public bool ValidarCampos(GroupBox G, ErrorProvider PR)
        {
            bool valido = true;
            foreach (Control C in G.Controls)
            {
                if (C is TextBox && C.Text == string.Empty)
                {
                    PR.SetError(C,"No se aceptan campos vacios !!!");
                    valido = false;
                }
            }
            return valido;
        }

        public bool ValidarEdad(DateTimePicker dp)
        {
            bool Valido = false;

            int FNacimiento = Convert.ToInt32(dp.Value.Year);
            int FActual = Convert.ToInt32(System.DateTime.Now.Year);
            int Edad = FActual - FNacimiento;

            if (Edad >5 && Edad < 9)
            {
                Valido = true;
            }
            else {
                MessageBox.Show("Rango de Edad solo entre 6 y 8 años","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return Valido;
        }

    }
}
