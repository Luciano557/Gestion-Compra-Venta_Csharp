using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormVendedores : Form
    {
 
        public FormVendedores()
        {
            InitializeComponent();
        }

        private void FormVendedores_Load(object sender, EventArgs e)
        {
            if (lista11.vendedores1.Count > 0)
            {
                actualizarDatos();
            }
            txtnombre.CharacterCasing = CharacterCasing.Upper; //fuerzo a que escriba en mayusculas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio frm1 = new FormInicio();
            frm1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            lista11.vendedores1.Add(txtnombre.Text);
            lista11.vendedores1.Sort();
            actualizarDatos();

        }
        private void actualizarDatos()
        {
            lst1.DataSource = null;
            lst1.DataSource = lista11.vendedores1;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button2.PerformClick();
            }
        }
    }

 
}
