
using Empleado.codigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado
{
    public partial class GUI_Principal : Form
    {
        private Empresa empresa;       
       
        private Trabajador trabajadorUno;
        private Trabajador trabajadorDos;

        public GUI_Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //empleado 1

        private void btn_aniadir_Click(object sender, EventArgs e)
        {
            String nombre = txt_nombre.Text;
            double sueldo = Double.Parse(txt_salario.Text);
            int edad = Int32.Parse(txt_edad.Text);

            trabajadorUno = new Trabajador(nombre, sueldo, edad);

            MessageBox.Show("Agregado");

            borrarCampoTrabajadorUno();
        }
        //empleado 2
        private void btn_aniadirDos_Click(object sender, EventArgs e)
        {
            String nombre = txt_nombreDos.Text;
            double sueldo = Double.Parse(txt_salarioDos.Text);
            int edad = Int32.Parse(txt_edadDos.Text);

            trabajadorDos = new Trabajador(nombre, sueldo, edad);

            MessageBox.Show("Agregado");

            borrarCampoTrabajadorDos();
        }

        private void borrarCampoTrabajadorUno()
        {
            txt_nombre.Text = "";
            txt_salario.Text = "";
            txt_edad.Text = "";
        }
        private void borrarCampoTrabajadorDos()
        {
            txt_nombreDos.Clear();
            txt_salarioDos.Clear();
            txt_edadDos.Clear();
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            String masViejo = empresa.darMasViejo();
            txt_Mayor.Text = masViejo;
        }

        private void btn_borrartodo_Click(object sender, EventArgs e)
        {
            borrarCampoTrabajadorUno();
            borrarCampoTrabajadorDos();
        }

        private void btn_modificarUno_Click(object sender, EventArgs e)
        {
            String nombreEditar = txt_modNomUno.Text;

            trabajadorUno.setNombre(nombreEditar);

            MessageBox.Show("Editado correctamente");
        }

        private void btn_modificarDos_Click(object sender, EventArgs e)
        {
            String nombreEditar = txt_modNomDos.Text;

            trabajadorDos.setNombre(nombreEditar);

            MessageBox.Show("Editado correctamente");
        }

        private void btn_agregarEmpresa_Click(object sender, EventArgs e)
        {
            String nombreEmpresa = txt_nombreEmpresa.Text;
            string direccion = txt_Direccion.Text;

            empresa = new Empresa(nombreEmpresa, direccion, trabajadorUno, trabajadorDos);
            

            
        }
    }
}
