namespace facturacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvglista = new System.Windows.Forms.DataGridView();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IBIprecio = new System.Windows.Forms.Label();
            this.IBInombre = new System.Windows.Forms.Label();
            this.IBIcodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IBItotalapagar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IBIdevolucion = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnvender = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvglista)).BeginInit();
            this.SuspendLayout();
            // 
            // dvglista
            // 
            this.dvglista.AllowUserToAddRows = false;
            this.dvglista.AllowUserToDeleteRows = false;
            this.dvglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvglista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvglista.Location = new System.Drawing.Point(76, 207);
            this.dvglista.Name = "dvglista";
            this.dvglista.ReadOnly = true;
            this.dvglista.Size = new System.Drawing.Size(516, 150);
            this.dvglista.TabIndex = 0;
            this.dvglista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvglista_CellContentClick);
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Items.AddRange(new object[] {
            "zapatos",
            "zapatillas",
            "medias"});
            this.cmbproducto.Location = new System.Drawing.Point(143, 69);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(121, 21);
            this.cmbproducto.TabIndex = 1;
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "precio";
            // 
            // IBIprecio
            // 
            this.IBIprecio.AutoSize = true;
            this.IBIprecio.Location = new System.Drawing.Point(141, 155);
            this.IBIprecio.Name = "IBIprecio";
            this.IBIprecio.Size = new System.Drawing.Size(10, 13);
            this.IBIprecio.TabIndex = 6;
            this.IBIprecio.Text = "-";
            // 
            // IBInombre
            // 
            this.IBInombre.AutoSize = true;
            this.IBInombre.Location = new System.Drawing.Point(141, 129);
            this.IBInombre.Name = "IBInombre";
            this.IBInombre.Size = new System.Drawing.Size(10, 13);
            this.IBInombre.TabIndex = 7;
            this.IBInombre.Text = "-";
            // 
            // IBIcodigo
            // 
            this.IBIcodigo.AutoSize = true;
            this.IBIcodigo.Location = new System.Drawing.Point(141, 101);
            this.IBIcodigo.Name = "IBIcodigo";
            this.IBIcodigo.Size = new System.Drawing.Size(10, 13);
            this.IBIcodigo.TabIndex = 8;
            this.IBIcodigo.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "total a pagar";
            // 
            // IBItotalapagar
            // 
            this.IBItotalapagar.AutoSize = true;
            this.IBItotalapagar.Location = new System.Drawing.Point(89, 436);
            this.IBItotalapagar.Name = "IBItotalapagar";
            this.IBItotalapagar.Size = new System.Drawing.Size(10, 13);
            this.IBItotalapagar.TabIndex = 11;
            this.IBItotalapagar.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "efectivo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "devolucion";
            // 
            // IBIdevolucion
            // 
            this.IBIdevolucion.AutoSize = true;
            this.IBIdevolucion.Location = new System.Drawing.Point(432, 444);
            this.IBIdevolucion.Name = "IBIdevolucion";
            this.IBIdevolucion.Size = new System.Drawing.Size(10, 13);
            this.IBIdevolucion.TabIndex = 14;
            this.IBIdevolucion.Text = "-";
            this.IBIdevolucion.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(140, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Nombre del estudiante";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(545, 83);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 41);
            this.btnagregar.TabIndex = 16;
            this.btnagregar.Text = "agregar factura";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(544, 129);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(128, 43);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "eliminar Producto";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnvender
            // 
            this.btnvender.Location = new System.Drawing.Point(267, 466);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(136, 34);
            this.btnvender.TabIndex = 18;
            this.btnvender.Text = "vender";
            this.btnvender.UseVisualStyleBackColor = true;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(143, 181);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 19;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // txtefectivo
            // 
            this.txtefectivo.Location = new System.Drawing.Point(267, 433);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(100, 20);
            this.txtefectivo.TabIndex = 20;
            this.txtefectivo.TextChanged += new System.EventHandler(this.txtefectivo_TextChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(417, 91);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 21;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 529);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnvender);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.IBIdevolucion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IBItotalapagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IBIcodigo);
            this.Controls.Add(this.IBInombre);
            this.Controls.Add(this.IBIprecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbproducto);
            this.Controls.Add(this.dvglista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvglista;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IBIprecio;
        private System.Windows.Forms.Label IBInombre;
        private System.Windows.Forms.Label IBIcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IBItotalapagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label IBIdevolucion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnvender;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnbuscar;
    }
}

