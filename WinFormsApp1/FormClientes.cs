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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio frm1 = new FormInicio();
            new FormInicio();
            frm1.Show();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
        lstclientes.clientes1.Add(txtclient.Text);
            lstclientes.clientes1.Sort();
            actualizarDatos();
    }
    private void actualizarDatos()
    {
        lstclient.DataSource = null;
        lstclient.DataSource = lstclientes.clientes1;
    }

        private void txtclient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnagregar.PerformClick();
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            if (lstclientes.clientes1.Count > 0)
            {
                actualizarDatos();
            }
            txtclient.CharacterCasing = CharacterCasing.Upper; 
        }
    }
}
