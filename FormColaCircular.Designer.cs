namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class FormColaCircular
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
            txtproducto = new TextBox();
            dtpfechavencimiento = new DateTimePicker();
            dtpfechaingreso = new DateTimePicker();
            dgvProducto = new DataGridView();
            column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            txtpreciocompra = new TextBox();
            txtprecioventa = new TextBox();
            txtdescripcion = new TextBox();
            txtcodigo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            cbcategoria = new ComboBox();
            btnAñadir = new Button();
            btnVerInicio = new Button();
            btnVerFinal = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(289, 109);
            txtproducto.Margin = new Padding(3, 2, 3, 2);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(248, 23);
            txtproducto.TabIndex = 42;
            // 
            // dtpfechavencimiento
            // 
            dtpfechavencimiento.Location = new Point(289, 218);
            dtpfechavencimiento.Margin = new Padding(3, 2, 3, 2);
            dtpfechavencimiento.Name = "dtpfechavencimiento";
            dtpfechavencimiento.Size = new Size(227, 23);
            dtpfechavencimiento.TabIndex = 41;
            // 
            // dtpfechaingreso
            // 
            dtpfechaingreso.Location = new Point(4, 218);
            dtpfechaingreso.Margin = new Padding(3, 2, 3, 2);
            dtpfechaingreso.Name = "dtpfechaingreso";
            dtpfechaingreso.Size = new Size(227, 23);
            dtpfechaingreso.TabIndex = 40;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvProducto.Location = new Point(4, 294);
            dgvProducto.Margin = new Padding(3, 2, 3, 2);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(1362, 323);
            dgvProducto.TabIndex = 39;
            // 
            // column0
            // 
            column0.HeaderText = "Código";
            column0.MinimumWidth = 6;
            column0.Name = "column0";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del Producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripción";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoría";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha de Ingreso";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha de Vencimiento";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio de Compra";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Precio de Venta";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(845, 218);
            txtpreciocompra.Margin = new Padding(3, 2, 3, 2);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(119, 23);
            txtpreciocompra.TabIndex = 38;
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(600, 218);
            txtprecioventa.Margin = new Padding(3, 2, 3, 2);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(134, 23);
            txtprecioventa.TabIndex = 37;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(599, 109);
            txtdescripcion.Margin = new Padding(3, 2, 3, 2);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(343, 23);
            txtdescripcion.TabIndex = 36;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(3, 109);
            txtcodigo.Margin = new Padding(3, 2, 3, 2);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(120, 23);
            txtcodigo.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(134, 35);
            label9.TabIndex = 34;
            label9.Text = "Inventario ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 16.2F);
            label8.Location = new Point(600, 185);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 33;
            label8.Text = "Precio de Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 16.2F);
            label7.Location = new Point(835, 185);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 32;
            label7.Text = "Precio de Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 16.2F);
            label5.Location = new Point(4, 185);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 31;
            label5.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 16.2F);
            label4.Location = new Point(290, 185);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 30;
            label4.Text = "Fecha de Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 16.2F);
            label3.Location = new Point(599, 83);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 29;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 16.2F);
            label2.Location = new Point(288, 83);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 28;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 16.2F);
            label1.Location = new Point(3, 83);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 27;
            label1.Text = "Ingrese Código";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 16.2F);
            label6.Location = new Point(1038, 84);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 44;
            label6.Text = "Categoría";
            // 
            // cbcategoria
            // 
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(1038, 109);
            cbcategoria.Margin = new Padding(3, 2, 3, 2);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(247, 23);
            cbcategoria.TabIndex = 43;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(1016, 160);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 45;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += button1_Click;
            // 
            // btnVerInicio
            // 
            btnVerInicio.Location = new Point(1020, 234);
            btnVerInicio.Name = "btnVerInicio";
            btnVerInicio.Size = new Size(75, 23);
            btnVerInicio.TabIndex = 46;
            btnVerInicio.Text = "Ver Inicio";
            btnVerInicio.UseVisualStyleBackColor = true;
            btnVerInicio.Click += btnVerInicio_Click;
            // 
            // btnVerFinal
            // 
            btnVerFinal.Location = new Point(1203, 239);
            btnVerFinal.Name = "btnVerFinal";
            btnVerFinal.Size = new Size(75, 23);
            btnVerFinal.TabIndex = 47;
            btnVerFinal.Text = "Ver Final";
            btnVerFinal.UseVisualStyleBackColor = true;
            btnVerFinal.Click += btnVerFinal_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1204, 162);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1283, 637);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 75;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormColaCircular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 670);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVerFinal);
            Controls.Add(btnVerInicio);
            Controls.Add(btnAñadir);
            Controls.Add(label6);
            Controls.Add(cbcategoria);
            Controls.Add(txtproducto);
            Controls.Add(dtpfechavencimiento);
            Controls.Add(dtpfechaingreso);
            Controls.Add(dgvProducto);
            Controls.Add(txtpreciocompra);
            Controls.Add(txtprecioventa);
            Controls.Add(txtdescripcion);
            Controls.Add(txtcodigo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormColaCircular";
            Text = "FormColaCircular";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtproducto;
        private DateTimePicker dtpfechavencimiento;
        private DateTimePicker dtpfechaingreso;
        private DataGridView dgvProducto;
        private DataGridViewTextBoxColumn column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox txtpreciocompra;
        private TextBox txtprecioventa;
        private TextBox txtdescripcion;
        private TextBox txtcodigo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox cbcategoria;
        private Button btnAñadir;
        private Button btnVerInicio;
        private Button btnVerFinal;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}