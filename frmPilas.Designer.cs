﻿namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class frmPilas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbcategoria = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtcodigo = new TextBox();
            txtdescripcion = new TextBox();
            btnAñadir = new Button();
            txtprecioventa = new TextBox();
            txtpreciocompra = new TextBox();
            btnAtras = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnVU = new Button();
            dgvProducto = new DataGridView();
            column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            dtpfechaingreso = new DateTimePicker();
            dtpfechavencimiento = new DateTimePicker();
            textproducto = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 16.2F);
            label1.Location = new Point(32, 124);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 16.2F);
            label2.Location = new Point(317, 124);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 16.2F);
            label3.Location = new Point(782, 124);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 16.2F);
            label4.Location = new Point(318, 272);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Vencimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 16.2F);
            label5.Location = new Point(32, 272);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Ingreso";
            // 
            // cbcategoria
            // 
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(1255, 150);
            cbcategoria.Margin = new Padding(3, 2, 3, 2);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(247, 23);
            cbcategoria.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 16.2F);
            label6.Location = new Point(1255, 124);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 6;
            label6.Text = "Categoría";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 16.2F);
            label7.Location = new Point(1027, 272);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 7;
            label7.Text = "Precio de Venta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 16.2F);
            label8.Location = new Point(782, 272);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 8;
            label8.Text = "Precio de Compra";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 18);
            label9.Name = "label9";
            label9.Size = new Size(134, 35);
            label9.TabIndex = 9;
            label9.Text = "Inventario ";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(32, 150);
            txtcodigo.Margin = new Padding(3, 2, 3, 2);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(160, 23);
            txtcodigo.TabIndex = 10;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(782, 150);
            txtdescripcion.Margin = new Padding(3, 2, 3, 2);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(383, 23);
            txtdescripcion.TabIndex = 11;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Perpetua", 14F);
            btnAñadir.Location = new Point(32, 754);
            btnAñadir.Margin = new Padding(3, 2, 3, 2);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(174, 28);
            btnAñadir.TabIndex = 12;
            btnAñadir.Text = "Añadir Producto";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(782, 305);
            txtprecioventa.Margin = new Padding(3, 2, 3, 2);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(174, 23);
            txtprecioventa.TabIndex = 15;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(1027, 305);
            txtpreciocompra.Margin = new Padding(3, 2, 3, 2);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(159, 23);
            txtpreciocompra.TabIndex = 16;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Perpetua", 14F);
            btnAtras.Location = new Point(1413, 754);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(88, 28);
            btnAtras.TabIndex = 19;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Perpetua", 14F);
            btnCancelar.Location = new Point(1305, 754);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 28);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Perpetua", 14F);
            btnEliminar.Location = new Point(232, 754);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(174, 28);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVU
            // 
            btnVU.Font = new Font("Perpetua", 14F);
            btnVU.Location = new Point(431, 754);
            btnVU.Margin = new Padding(3, 2, 3, 2);
            btnVU.Name = "btnVU";
            btnVU.Size = new Size(174, 28);
            btnVU.TabIndex = 22;
            btnVU.Text = "Ver Último";
            btnVU.UseVisualStyleBackColor = true;
            btnVU.Click += btnVU_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvProducto.Location = new Point(32, 381);
            dgvProducto.Margin = new Padding(3, 2, 3, 2);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(1470, 324);
            dgvProducto.TabIndex = 23;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
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
            // dtpfechaingreso
            // 
            dtpfechaingreso.Location = new Point(32, 305);
            dtpfechaingreso.Margin = new Padding(3, 2, 3, 2);
            dtpfechaingreso.Name = "dtpfechaingreso";
            dtpfechaingreso.Size = new Size(261, 23);
            dtpfechaingreso.TabIndex = 24;
            // 
            // dtpfechavencimiento
            // 
            dtpfechavencimiento.Location = new Point(317, 305);
            dtpfechavencimiento.Margin = new Padding(3, 2, 3, 2);
            dtpfechavencimiento.Name = "dtpfechavencimiento";
            dtpfechavencimiento.Size = new Size(267, 23);
            dtpfechavencimiento.TabIndex = 25;
            // 
            // textproducto
            // 
            textproducto.Location = new Point(318, 150);
            textproducto.Margin = new Padding(3, 2, 3, 2);
            textproducto.Name = "textproducto";
            textproducto.Size = new Size(288, 23);
            textproducto.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmPilas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 562);
            Controls.Add(textproducto);
            Controls.Add(dtpfechavencimiento);
            Controls.Add(dtpfechaingreso);
            Controls.Add(dgvProducto);
            Controls.Add(btnVU);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAtras);
            Controls.Add(txtpreciocompra);
            Controls.Add(txtprecioventa);
            Controls.Add(btnAñadir);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPilas";
            Text = "frmPilas";
            Load += frmPilas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbcategoria;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtcodigo;
        private TextBox txtdescripcion;
        private Button btnAñadir;
        private TextBox txtproducto;
        private TextBox txtprecioventa;
        private TextBox txtpreciocompra;
        private Button btnAtras;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnVU;
        private DataGridView dgvProducto;
        private DateTimePicker dtpfechaingreso;
        private DateTimePicker dtpfechavencimiento;
        private DataGridViewTextBoxColumn column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox textproducto;
        private ContextMenuStrip contextMenuStrip1;
    }
}