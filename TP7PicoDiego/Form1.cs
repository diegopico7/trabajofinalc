using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP7PicoDiego
{
    public partial class Form1 : Form
    {


        EmpleadosDAL oEmpleadosDAL;





        public Form1()
        {
            oEmpleadosDAL = new EmpleadosDAL();

            InitializeComponent();
            LlegarGrid();
        
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //obtener info de la interfaz grafica

            

            MessageBox.Show("Conectado....");
            oEmpleadosDAL.Agregar(RecuperarInformacion());
            LlegarGrid();

        }
    
    private EmpleadosBLL RecuperarInformacion()
        {
            EmpleadosBLL oEmpleado = new EmpleadosBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oEmpleado.ID = ID;
            int Edad = 0;
            int.TryParse(txtEdad.Text, out Edad);

            int Casado = 0;
            int.TryParse(chkCasado.Text, out Casado);


            decimal Salario = 0;
            decimal.TryParse(txtSalario.Text, out Salario);



            oEmpleado.NombreCompleto = txtNombreCompleto.Text;
            oEmpleado.DNI = txtDni.Text;
            oEmpleado.Edad = Edad;
            oEmpleado.Casado = Casado;
            oEmpleado.Salario = Salario;

            //MessageBox.Show(oEmpleado.ID.ToString());
            //MessageBox.Show(oEmpleado.NombreCompleto);
            //MessageBox.Show(oEmpleado.DNI);
            //MessageBox.Show(oEmpleado.Edad.ToString());
            //MessageBox.Show(oEmpleado.Casado.ToString());
            //MessageBox.Show(oEmpleado.Salario.ToString());

            return oEmpleado;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            txtID.Text = dgvEmpleados.Rows[indice].Cells[0].Value.ToString();
            txtNombreCompleto.Text = dgvEmpleados.Rows[indice].Cells[1].Value.ToString();
            txtDni.Text = dgvEmpleados.Rows[indice].Cells[2].Value.ToString();
            txtEdad.Text = dgvEmpleados.Rows[indice].Cells[3].Value.ToString();
            chkCasado.Text = dgvEmpleados.Rows[indice].Cells[4].Value.ToString();
            txtSalario.Text = dgvEmpleados.Rows[indice].Cells[5].Value.ToString();


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oEmpleadosDAL.Eliminar(RecuperarInformacion());
            LlegarGrid();
        }

        public void LlegarGrid()
        {
            dgvEmpleados.DataSource = oEmpleadosDAL.MostrarEmpleados().Tables[0];
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkCasado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
