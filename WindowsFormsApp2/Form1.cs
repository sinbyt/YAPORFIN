using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formInicio : Form
    {
        formInicioGT NuevaPercepcion;
        formNomina NuevaNomina;
        Datos_de_la_empresa NuevoDatos;
        Recibo NuevoRecibo; 
        //formEmpleados NuevoEmpleado;
        public formInicio()
        {
            
            InitializeComponent();
            NuevaPercepcion = new formInicioGT();
            NuevaNomina = new formNomina();
            NuevoDatos = new Datos_de_la_empresa();
            NuevoRecibo = new Recibo();
            //NuevoEmpleado = new formEmpleados();
        }

        private void percepcionesYDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            //NuevaDeduccion.ShowDialog();
        }

        private void btnPercepciones_Click_1(object sender, EventArgs e)
        {
            NuevaPercepcion.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //NuevoEmpleado.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //NuevoEmpleado.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //NuevoBorrado.ShowDialog();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            NuevaNomina.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoDatos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //RECIBO ESTA JSJSJA
        {
            NuevoRecibo.ShowDialog();
        }
    }
}
