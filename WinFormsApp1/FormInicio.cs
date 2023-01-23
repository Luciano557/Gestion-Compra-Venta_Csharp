using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FormVendedores frm = new FormVendedores();
            frm.Show();
            button4.Enabled = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientes frm = new FormClientes();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFacturacion frm = new FormFacturacion();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProductos frm = new FormProductos();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            //FormInformes frm = new FormInformes();
            //frm.Show();
        }


    }
}



