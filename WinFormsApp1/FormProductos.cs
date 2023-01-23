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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio frm1 = new FormInicio();
            frm1.Show();
        }

        private void brnagregar_Click(object sender, EventArgs e)
        {
            Listaproducto.productos.Add(new subListaProducto()
            {
                NombrePr = txtnombre.Text,
                PrecioCosto = Convert.ToInt32(txtprecio.Text),   
                     
            });
            actualizarDatos();
        }


        private void actualizarDatos()
        {
            dtg1.DataSource = null;
            dtg1.DataSource = Listaproducto.productos;
        }



    }
}
