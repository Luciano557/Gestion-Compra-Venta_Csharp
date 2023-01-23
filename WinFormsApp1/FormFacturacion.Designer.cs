namespace WinFormsApp1
{
    partial class FormFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnmenu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ncant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbvendedores = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.dtgvent = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.erp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnconsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ncant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(488, 444);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(89, 23);
            this.btnmenu.TabIndex = 0;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // ncant
            // 
            this.ncant.Location = new System.Drawing.Point(98, 155);
            this.ncant.Name = "ncant";
            this.ncant.Size = new System.Drawing.Size(142, 23);
            this.ncant.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Consultar Producto";
            // 
            // cmbvendedores
            // 
            this.cmbvendedores.FormattingEnabled = true;
            this.cmbvendedores.Location = new System.Drawing.Point(98, 81);
            this.cmbvendedores.Name = "cmbvendedores";
            this.cmbvendedores.Size = new System.Drawing.Size(142, 23);
            this.cmbvendedores.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seleccionar Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(333, 81);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(119, 23);
            this.txtproducto.TabIndex = 9;
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(333, 154);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(165, 23);
            this.cmbproducto.TabIndex = 10;
            // 
            // dtgvent
            // 
            this.dtgvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvent.Location = new System.Drawing.Point(98, 277);
            this.dtgvent.Name = "dtgvent";
            this.dtgvent.RowTemplate.Height = 25;
            this.dtgvent.Size = new System.Drawing.Size(400, 150);
            this.dtgvent.TabIndex = 11;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(358, 219);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(140, 23);
            this.btnagregar.TabIndex = 12;
            this.btnagregar.Text = "Agregar Venta";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // erp1
            // 
            this.erp1.ContainerControl = this;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(466, 80);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 13;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // FormFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 479);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtgvent);
            this.Controls.Add(this.cmbproducto);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbvendedores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ncant);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnmenu);
            this.Name = "FormFacturacion";
            this.Text = "FormFacturacion";
            this.Load += new System.EventHandler(this.FormFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ncant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnmenu;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown ncant;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbvendedores;
        private Label label5;
        private TextBox txtproducto;
        private ComboBox cmbproducto;
        private DataGridView dtgvent;
        private Button btnagregar;
        private ErrorProvider erp1;
        private Button btnconsultar;
    }
}