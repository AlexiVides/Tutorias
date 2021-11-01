using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Vista
{
    public partial class MenuAplicacion : Form
    {
        public MenuAplicacion()
        {
            InitializeComponent();
        }

        private void formularioEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void formularioProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            materia.MdiParent = this;
            materia.Show();
        }

        private void vistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrListaConsultaEstudiante frListaConsultaEstudiante = new FrListaConsultaEstudiante();
            frListaConsultaEstudiante.MdiParent = this;
            frListaConsultaEstudiante.Show();
        }
    }
}
