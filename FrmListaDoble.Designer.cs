namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class FrmListaDoble
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
            textproducto = new TextBox();
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
            label6 = new Label();
            cbcategoria = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnAtras = new Button();
            btnAñadir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // textproducto
            // 
            textproducto.Location = new Point(354, 196);
            textproducto.Name = "textproducto";
            textproducto.Size = new Size(328, 27);
            textproducto.TabIndex = 44;
            // 
            // dtpfechavencimiento
            // 
            dtpfechavencimiento.Location = new Point(352, 403);
            dtpfechavencimiento.Name = "dtpfechavencimiento";
            dtpfechavencimiento.Size = new Size(305, 27);
            dtpfechavencimiento.TabIndex = 43;
            // 
            // dtpfechaingreso
            // 
            dtpfechaingreso.Location = new Point(26, 403);
            dtpfechaingreso.Name = "dtpfechaingreso";
            dtpfechaingreso.Size = new Size(298, 27);
            dtpfechaingreso.TabIndex = 42;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvProducto.Location = new Point(26, 492);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(1680, 432);
            dgvProducto.TabIndex = 41;
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
            txtpreciocompra.Location = new Point(1164, 403);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(181, 27);
            txtpreciocompra.TabIndex = 40;
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(884, 403);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(198, 27);
            txtprecioventa.TabIndex = 39;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(884, 196);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(437, 27);
            txtdescripcion.TabIndex = 38;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(26, 196);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(182, 27);
            txtcodigo.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 20);
            label9.Name = "label9";
            label9.Size = new Size(163, 42);
            label9.TabIndex = 36;
            label9.Text = "Inventario ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 16.2F);
            label8.Location = new Point(884, 359);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 35;
            label8.Text = "Precio de Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 16.2F);
            label7.Location = new Point(1164, 359);
            label7.Name = "label7";
            label7.Size = new Size(174, 32);
            label7.TabIndex = 34;
            label7.Text = "Precio de Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 16.2F);
            label6.Location = new Point(1424, 161);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 33;
            label6.Text = "Categoría";
            // 
            // cbcategoria
            // 
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Items.AddRange(new object[] { "Bolsa 1 Lb", "Bolsa 2 Lb", "Paquete", "Vaso" });
            cbcategoria.Location = new Point(1424, 195);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(282, 28);
            cbcategoria.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 16.2F);
            label5.Location = new Point(26, 359);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 31;
            label5.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 16.2F);
            label4.Location = new Point(354, 359);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 30;
            label4.Text = "Fecha de Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 16.2F);
            label3.Location = new Point(884, 161);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 29;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 16.2F);
            label2.Location = new Point(352, 161);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 28;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 16.2F);
            label1.Location = new Point(26, 161);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 27;
            label1.Text = "Ingrese Código";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Perpetua", 14F);
            btnEditar.Location = new Point(483, 979);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(199, 37);
            btnEditar.TabIndex = 49;
            btnEditar.Text = "Editar Producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Perpetua", 14F);
            btnEliminar.Location = new Point(255, 979);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(199, 37);
            btnEliminar.TabIndex = 48;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Perpetua", 14F);
            btnCancelar.Location = new Point(1481, 979);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 37);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Perpetua", 14F);
            btnAtras.Location = new Point(1605, 979);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(101, 37);
            btnAtras.TabIndex = 46;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Perpetua", 14F);
            btnAñadir.Location = new Point(26, 979);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(199, 37);
            btnAñadir.TabIndex = 45;
            btnAñadir.Text = "Añadir Producto";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // FrmListaDoble
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1832, 1055);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtras);
            Controls.Add(btnAñadir);
            Controls.Add(textproducto);
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
            Controls.Add(label6);
            Controls.Add(cbcategoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmListaDoble";
            Text = "FrmListaDoble";
            Load += FrmListaDoble_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textproducto;
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
        private Label label6;
        private ComboBox cbcategoria;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnAtras;
        private Button btnAñadir;
    }
}