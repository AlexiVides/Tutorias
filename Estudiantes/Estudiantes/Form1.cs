using Estudiantes.Data;
using Estudiantes.Negocio;
using Estudiantes.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void LoadInformacion()
        {
            ClsEstudiante estudiante = new ClsEstudiante();
            var ok = estudiante.ListFinal();
            ListStudent.Rows.Clear();
            foreach (var iterar in ok)
            {
                ListStudent.Rows.Add(iterar.idEstudiante, iterar.nombresEstudiante, iterar.apellidos, iterar.usuario);
               
            }

        }
        void ClearInformation()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtPassword.Text = "";
            TxtUsuario.Text = "";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                estudiante es = new estudiante();
                es.nombresEstudiante = TxtNombre.Text;
                es.apellidos = TxtApellido.Text;
                es.usuario = TxtUsuario.Text;
                es.contrasenia = TxtPassword.Text;
                ClsEstudiante clsestudiante = new ClsEstudiante();
                clsestudiante.Guardar(es);
                LoadInformacion();
            }
            catch
            {
                MessageBox.Show("Llenar campos");
            }
            
        }
        Materia materia = new Materia();

        private void ListStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInformacion();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            String ID = ListStudent.Rows[ListStudent.CurrentRow.Index].Cells[0].Value.ToString();
            estudiante es = new estudiante();
            es.idEstudiante = Convert.ToInt32(ID);
            es.nombresEstudiante = TxtNombre.Text;
            es.apellidos = TxtApellido.Text;
            es.usuario = TxtUsuario.Text;
            es.contrasenia = TxtPassword.Text;
           
            ClsEstudiante clsestudiante = new ClsEstudiante();
            clsestudiante.UpdateInformation(es);
            LoadInformacion();
            ClearInformation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String ID = ListStudent.Rows[ListStudent.CurrentRow.Index].Cells[0].Value.ToString();
            estudiante es = new estudiante();
            ClsEstudiante clsestudiante = new ClsEstudiante();
            es.idEstudiante = Convert.ToInt32(ID);

            es.nombresEstudiante = TxtNombre.Text;
            es.apellidos = TxtApellido.Text;
            es.usuario = TxtUsuario.Text;
            es.contrasenia = TxtPassword.Text;
            
            clsestudiante.Delete(es);
            LoadInformacion();
        }

        private void ListStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String ID = ListStudent.Rows[ListStudent.CurrentRow.Index].Cells[0].Value.ToString();
            String Nombre = ListStudent.Rows[ListStudent.CurrentRow.Index].Cells[1].Value.ToString();
            String Apellido = ListStudent.Rows[ListStudent.CurrentRow.Index].Cells[2].Value.ToString();
            String Usario = ListStudent.Rows[ListStudent.CurrentRow.Index].Cells[3].Value.ToString();

            TxtNombre.Text = Nombre;
            TxtApellido.Text = Apellido;
            TxtUsuario.Text = Usario;
            //MessageBox.Show(ID);
        }
    }
}
