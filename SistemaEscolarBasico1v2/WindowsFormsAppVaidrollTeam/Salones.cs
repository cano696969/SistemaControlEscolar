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
    public partial class Salones : Form
    {
        ClassNegocio objneg = new ClassNegocio();
        ClassEntidad objent = new ClassEntidad();
        public Salones()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void mantsalon(String accion)
        {
            objent.codigo = txtcodigo.Text;
            objent.nombre = txtnombre.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimientosalon(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void limpiar()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
        }
        private void Salones_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_salon();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    mantsalon("1");
                    dataGridView1.DataSource = objneg.N_listar_salon();
                    limpiar();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas modificar este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
          System.Windows.Forms.DialogResult.Yes)
            {
                mantsalon("2");
                dataGridView1.DataSource = objneg.N_listar_salon();
                limpiar();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas eliminar este salon?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
         System.Windows.Forms.DialogResult.Yes)
            {
                mantsalon("3");
                dataGridView1.DataSource = objneg.N_listar_salon();
                limpiar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
        }
    }
}
