using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidad;


namespace WindowsFormsAppVaidrollTeam
{
    public partial class Alumnos : Form
    {

        ClassNegocio objneg = new ClassNegocio();
        ClassEntidad objent = new ClassEntidad();
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listaralumnos();

            cbocurso.DataSource = objneg.N_listar_curso();
            cbocurso.ValueMember = "id_cursos";
            cbocurso.DisplayMember = "curso_nombre";

            cbosalon.DataSource = objneg.N_listar_salon();
            cbosalon.ValueMember = "id_salon";
            cbosalon.DisplayMember = "salon_nombre";


        }

        void mantalumno(String accion)
        {
            objent.id_alumno = txtcodigo.Text;
            objent.nombre = txtnombre.Text;
            objent.telefono = Convert.ToInt32(txttel.Text);
            objent.matricula = Convert.ToInt32(txtmatricula.Text);
            objent.id_curso = cbocurso.SelectedValue.ToString();
            objent.id_salon = cbosalon.SelectedValue.ToString();
            objent.accion = accion;
            String men = objneg.N_mantenimientoalumno(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar() 
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txttel.Text = "";
            txtmatricula.Text = "";
            cbocurso.SelectedIndex = 0;
            cbosalon.SelectedIndex = 0;
            dataGridView1.DataSource = objneg.N_listaralumnos();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    mantalumno("1");
                    limpiar();
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este alumno?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
          System.Windows.Forms.DialogResult.Yes)
            {
                mantalumno("2");
                limpiar();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este alumno?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
          System.Windows.Forms.DialogResult.Yes)
            {
                mantalumno("3");
                limpiar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
            txttel.Text = dataGridView1[2, fila].Value.ToString();
            txtmatricula.Text =dataGridView1[3, fila].Value.ToString();
            cbocurso.SelectedValue = dataGridView1[4, fila].Value.ToString();
            cbosalon.SelectedValue = dataGridView1[6, fila].Value.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            objent.nombre = textBox8.Text + "%";
            DataTable dt = new DataTable();
            dt = objneg.N_buscaralumnos(objent);
            dataGridView1.DataSource = dt;
        }
    }
}
