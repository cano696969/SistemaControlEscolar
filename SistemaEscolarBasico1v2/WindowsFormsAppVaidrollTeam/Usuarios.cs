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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        ClassNegocio objneg = new ClassNegocio();
        ClassEntidad objent = new ClassEntidad();
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_usuarios();

            cbotipo.DataSource = objneg.N_listar_tipo();
            cbotipo.ValueMember = "id_tipo";
            cbotipo.DisplayMember = "tipo_nombre";
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            objent.nombre = textBox8.Text + "%";
            DataTable dt = new DataTable();
            dt = objneg.N_buscarusuario(objent);
            dataGridView1.DataSource = dt;
        }

        void mantusuario(String accion)
        {

            objent.codigo = txtcodigo.Text;
            objent.nombre = txtnombre.Text;
            objent.usuario = txtusuario.Text;
            objent.id_tipo = cbotipo.SelectedValue.ToString();
            objent.accion = accion;
            String men = objneg.N_mantenimientousuario(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            txtcodigo.Text="";
            txtusuario.Text = "";
            txtnombre.Text = "";
            cbotipo.SelectedIndex = 0;

        }
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    mantusuario("1");
                    dataGridView1.DataSource = objneg.N_listar_usuarios();
                    limpiar();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar a este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
              System.Windows.Forms.DialogResult.Yes)
            {
                mantusuario("2");
                dataGridView1.DataSource = objneg.N_listar_usuarios();
                limpiar();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar a este usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
              System.Windows.Forms.DialogResult.Yes)
            {
                mantusuario("3");
                dataGridView1.DataSource = objneg.N_listar_usuarios();
                limpiar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
            txtusuario.Text = dataGridView1[2, fila].Value.ToString();
            cbotipo.SelectedValue = dataGridView1[3, fila].Value.ToString();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
