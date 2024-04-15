using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //admin
            if (Login.area == "A0001") 
            
            {
                btnalmacen.Enabled = true;
                btnventas.Enabled = true;
                btncompras.Enabled = true;

                lblCargo.Text = "Administrador";
            }

            //Ventas
            else if (Login.area == "A0002")

            {
                btnalmacen.Enabled = false;
                btnventas.Enabled = true;
                btncompras.Enabled = false;

                lblCargo.Text = "Ventas";
            }
            //Compras
            else if (Login.area == "A0003")

            {
                btnalmacen.Enabled = false;
                btnventas.Enabled = false;
                btncompras.Enabled = true;

                lblCargo.Text = "Compras";
            }

            lblnombre.Text = Login.usuario_nombre;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
