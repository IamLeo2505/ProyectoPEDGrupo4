namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class FormListaSimple
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
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnAñadir = new Button();
            label10 = new Label();
            label6 = new Label();
            cbCriterio = new ComboBox();
            cbcategoria = new ComboBox();
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
            txtprecioventa = new TextBox();
            txtpreciocompra = new TextBox();
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
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            txtBusqueda = new TextBox();
            groupBox2 = new GroupBox();
            rbtFinal = new RadioButton();
            rbtInicio = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1429, 857);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 100;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1434, 195);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 96;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(29, 39);
            btnAñadir.Margin = new Padding(3, 4, 3, 4);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(86, 31);
            btnAñadir.TabIndex = 95;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Perpetua", 12F);
            label10.Location = new Point(1006, 284);
            label10.Name = "label10";
            label10.Size = new Size(69, 23);
            label10.TabIndex = 94;
            label10.Text = "Criterio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 16.2F);
            label6.Location = new Point(1184, 77);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 93;
            label6.Text = "Categoría";
            // 
            // cbCriterio
            // 
            cbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCriterio.FormattingEnabled = true;
            cbCriterio.Location = new Point(1006, 317);
            cbCriterio.Name = "cbCriterio";
            cbCriterio.Size = new Size(149, 28);
            cbCriterio.TabIndex = 92;
            // 
            // cbcategoria
            // 
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(1184, 111);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(282, 28);
            cbcategoria.TabIndex = 91;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(328, 111);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(283, 27);
            txtproducto.TabIndex = 90;
            // 
            // dtpfechavencimiento
            // 
            dtpfechavencimiento.Location = new Point(328, 291);
            dtpfechavencimiento.Name = "dtpfechavencimiento";
            dtpfechavencimiento.Size = new Size(259, 27);
            dtpfechavencimiento.TabIndex = 89;
            // 
            // dtpfechaingreso
            // 
            dtpfechaingreso.Location = new Point(2, 291);
            dtpfechaingreso.Name = "dtpfechaingreso";
            dtpfechaingreso.Size = new Size(259, 27);
            dtpfechaingreso.TabIndex = 88;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvProducto.Location = new Point(2, 392);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(1522, 431);
            dgvProducto.TabIndex = 87;
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
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(837, 291);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(135, 27);
            txtprecioventa.TabIndex = 86;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(634, 291);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(153, 27);
            txtpreciocompra.TabIndex = 85;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(682, 111);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(391, 27);
            txtdescripcion.TabIndex = 84;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(1, 111);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(137, 27);
            txtcodigo.TabIndex = 83;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1, 4);
            label9.Name = "label9";
            label9.Size = new Size(163, 42);
            label9.TabIndex = 82;
            label9.Text = "Inventario ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 16.2F);
            label8.Location = new Point(624, 247);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 81;
            label8.Text = "Precio de Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 16.2F);
            label7.Location = new Point(825, 247);
            label7.Name = "label7";
            label7.Size = new Size(174, 32);
            label7.TabIndex = 80;
            label7.Text = "Precio de Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 16.2F);
            label5.Location = new Point(2, 247);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 79;
            label5.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 16.2F);
            label4.Location = new Point(329, 247);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 78;
            label4.Text = "Fecha de Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 16.2F);
            label3.Location = new Point(682, 76);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 77;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 16.2F);
            label2.Location = new Point(327, 76);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 76;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 16.2F);
            label1.Location = new Point(1, 76);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 75;
            label1.Text = "Ingrese Código";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Location = new Point(990, 255);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(530, 111);
            groupBox1.TabIndex = 99;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(423, 59);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 102;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(182, 60);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(212, 27);
            txtBusqueda.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtFinal);
            groupBox2.Controls.Add(rbtInicio);
            groupBox2.Controls.Add(btnAñadir);
            groupBox2.Location = new Point(1125, 156);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(290, 91);
            groupBox2.TabIndex = 101;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ubicación en donde Añadir";
            // 
            // rbtFinal
            // 
            rbtFinal.AutoSize = true;
            rbtFinal.Location = new Point(215, 40);
            rbtFinal.Margin = new Padding(3, 4, 3, 4);
            rbtFinal.Name = "rbtFinal";
            rbtFinal.Size = new Size(61, 24);
            rbtFinal.TabIndex = 1;
            rbtFinal.TabStop = true;
            rbtFinal.Text = "Final";
            rbtFinal.UseVisualStyleBackColor = true;
            // 
            // rbtInicio
            // 
            rbtInicio.AutoSize = true;
            rbtInicio.Location = new Point(135, 40);
            rbtInicio.Margin = new Padding(3, 4, 3, 4);
            rbtInicio.Name = "rbtInicio";
            rbtInicio.Size = new Size(66, 24);
            rbtInicio.TabIndex = 0;
            rbtInicio.TabStop = true;
            rbtInicio.Text = "Inicio";
            rbtInicio.UseVisualStyleBackColor = true;
            // 
            // FormListaSimple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 904);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(cbCriterio);
            Controls.Add(cbcategoria);
            Controls.Add(txtproducto);
            Controls.Add(dtpfechavencimiento);
            Controls.Add(dtpfechaingreso);
            Controls.Add(dgvProducto);
            Controls.Add(txtprecioventa);
            Controls.Add(txtpreciocompra);
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
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormListaSimple";
            Text = "FormListaSimple";
            Load += FormListaSimple_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnAñadir;
        private Label label10;
        private Label label6;
        private ComboBox cbCriterio;
        private ComboBox cbcategoria;
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
        private TextBox txtprecioventa;
        private TextBox txtpreciocompra;
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
        private GroupBox groupBox1;
        private TextBox txtBusqueda;
        private GroupBox groupBox2;
        private RadioButton rbtFinal;
        private RadioButton rbtInicio;
        private Button btnBuscar;
    }
}