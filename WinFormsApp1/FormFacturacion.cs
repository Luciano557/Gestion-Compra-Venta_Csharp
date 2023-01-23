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
    public partial class FormFacturacion : Form
    {


        public FormFacturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio frm = new FormInicio();
            frm.Show();
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            cmbvendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            actualizarVendedores();
        }



        private void actualizarVendedores()

        {
            cmbvendedores.Items.Clear(); 
            cmbvendedores.Items.AddRange(lista11.vendedores1.ToArray()); 
            cmbvendedores.SelectedIndex = 0; 
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if(ValidarNombre() == false)
            {
                return;

            }


        }

        private bool ValidarNombre()
        {
            if(string.IsNullOrEmpty(txtproducto.Text))
            {
                erp1.SetError(txtproducto, "debe ingresar un producto");
                return false;
            }
            else
            {
                erp1.SetError(txtproducto, "");
                return true;    
            }
        }
        private void btnconsultar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;

            }



      






            /*
            string txt1 = txtproducto.Text;
            bool isExist = productos.Find(txt1);
            if (isExist)
            {
                Console.WriteLine("Element found in the list");
                
            }
            else
            {
                Console.WriteLine("Element not found in the given list");
            }

            */


            
            subListaProducto producto2 = GetProducto(txtproducto.Text);
            if(producto2 == null)
            {
                erp1.SetError(txtproducto, "El producto no esta disponible");
                txtproducto.Focus();
                return;
            }
            else
            
                erp1.SetError(txtproducto, "");
                txtproducto.Text = producto2.NombrePr;
                cmbproducto.SelectedItem = producto2.NombrePr;
            
        }
        List<subListaProducto> productos = new List<subListaProducto>();
        private subListaProducto GetProducto(string nombre)
        {
            return productos.Find(prod1 => prod1.NombrePr.Contains(nombre));
            
        }
    }
}
