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
    public partial class PassCambiar : Form
    {
        ClassNegocio objneg = new ClassNegocio();
        ClassEntidad objent = new ClassEntidad();
        public PassCambiar()
        {
            InitializeComponent();
        }

        void mantpass(String accion)
        {
            objent.codigo = label2.Text;
            objent.nombre = textBox1.Text;
            objent.accion = accion;
            String men = objneg.N_pass(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("¿Deseas cambiar su contraseña?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    mantpass("1");
                    this.Close();
                }
            }
        }

        private void PassCambiar_Load(object sender, EventArgs e)
        {
            label1.Text = Login.usuario_nick;
            label2.Text = Login.usuario_codigo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
