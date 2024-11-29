namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class FormGrafoAlgoritmoFloyd
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
            btnAscendente = new Button();
            btnDescendente = new Button();
            label11 = new Label();
            groupBox2 = new GroupBox();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            column0 = new DataGridViewTextBoxColumn();
            cbCriterioOrdenamiento = new ComboBox();
            Column7 = new DataGridViewTextBoxColumn();
            txtprecioventa = new TextBox();
            txtpreciocompra = new TextBox();
            btnAñadir = new Button();
            txtdescripcion = new TextBox();
            txtcodigo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBusqueda = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnEliminar = new Button();
            txtproducto = new TextBox();
            label6 = new Label();
            cbCriterioBusqueda = new ComboBox();
            cbcategoria = new ComboBox();
            dtpfechavencimiento = new DateTimePicker();
            dtpfechaingreso = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            label10 = new Label();
            dgvProducto = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // btnAscendente
            // 
            btnAscendente.Location = new Point(1119, 262);
            btnAscendente.Name = "btnAscendente";
            btnAscendente.Size = new Size(75, 23);
            btnAscendente.TabIndex = 156;
            btnAscendente.Text = "Ascendente";
            btnAscendente.UseVisualStyleBackColor = true;
            btnAscendente.Click += btnAscendente_Click;
            // 
            // btnDescendente
            // 
            btnDescendente.Location = new Point(1203, 262);
            btnDescendente.Name = "btnDescendente";
            btnDescendente.Size = new Size(75, 23);
            btnDescendente.TabIndex = 157;
            btnDescendente.Text = "Descendente";
            btnDescendente.UseVisualStyleBackColor = true;
            btnDescendente.Click += btnDescendente_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Perpetua", 12F);
            label11.Location = new Point(947, 238);
            label11.Name = "label11";
            label11.Size = new Size(57, 18);
            label11.TabIndex = 155;
            label11.Text = "Criterio";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(934, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 83);
            groupBox2.TabIndex = 158;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenamiento";
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio de Compra";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha de Vencimiento";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha de Ingreso";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Categoría";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripción";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del Producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // column0
            // 
            column0.HeaderText = "Código";
            column0.MinimumWidth = 6;
            column0.Name = "column0";
            // 
            // cbCriterioOrdenamiento
            // 
            cbCriterioOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCriterioOrdenamiento.FormattingEnabled = true;
            cbCriterioOrdenamiento.Location = new Point(947, 263);
            cbCriterioOrdenamiento.Margin = new Padding(3, 2, 3, 2);
            cbCriterioOrdenamiento.Name = "cbCriterioOrdenamiento";
            cbCriterioOrdenamiento.Size = new Size(131, 23);
            cbCriterioOrdenamiento.TabIndex = 154;
            // 
            // Column7
            // 
            Column7.HeaderText = "Precio de Venta";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(729, 179);
            txtprecioventa.Margin = new Padding(3, 2, 3, 2);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(119, 23);
            txtprecioventa.TabIndex = 142;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(552, 179);
            txtpreciocompra.Margin = new Padding(3, 2, 3, 2);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(134, 23);
            txtpreciocompra.TabIndex = 141;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(1177, 85);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 130;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(530, 87);
            txtdescripcion.Margin = new Padding(3, 2, 3, 2);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(343, 23);
            txtdescripcion.TabIndex = 140;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(56, 87);
            txtcodigo.Margin = new Padding(3, 2, 3, 2);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(120, 23);
            txtcodigo.TabIndex = 139;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 7);
            label9.Name = "label9";
            label9.Size = new Size(134, 35);
            label9.TabIndex = 138;
            label9.Text = "Inventario ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 16.2F);
            label8.Location = new Point(543, 146);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 137;
            label8.Text = "Precio de Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 16.2F);
            label7.Location = new Point(719, 146);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 136;
            label7.Text = "Precio de Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 16.2F);
            label5.Location = new Point(16, 146);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 135;
            label5.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 16.2F);
            label4.Location = new Point(278, 146);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 134;
            label4.Text = "Fecha de Vencimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 16.2F);
            label2.Location = new Point(255, 61);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 132;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 16.2F);
            label1.Location = new Point(56, 61);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 131;
            label1.Text = "Ingrese Código";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(159, 45);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(186, 23);
            txtBusqueda.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 16.2F);
            label3.Location = new Point(530, 61);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 133;
            label3.Text = "Descripción";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1264, 654);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 153;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1269, 85);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 151;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(256, 87);
            txtproducto.Margin = new Padding(3, 2, 3, 2);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(248, 23);
            txtproducto.TabIndex = 146;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 16.2F);
            label6.Location = new Point(901, 62);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 149;
            label6.Text = "Categoría";
            // 
            // cbCriterioBusqueda
            // 
            cbCriterioBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCriterioBusqueda.FormattingEnabled = true;
            cbCriterioBusqueda.Location = new Point(895, 173);
            cbCriterioBusqueda.Margin = new Padding(3, 2, 3, 2);
            cbCriterioBusqueda.Name = "cbCriterioBusqueda";
            cbCriterioBusqueda.Size = new Size(131, 23);
            cbCriterioBusqueda.TabIndex = 148;
            // 
            // cbcategoria
            // 
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Location = new Point(901, 87);
            cbcategoria.Margin = new Padding(3, 2, 3, 2);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(247, 23);
            cbcategoria.TabIndex = 147;
            // 
            // dtpfechavencimiento
            // 
            dtpfechavencimiento.Location = new Point(277, 179);
            dtpfechavencimiento.Margin = new Padding(3, 2, 3, 2);
            dtpfechavencimiento.Name = "dtpfechavencimiento";
            dtpfechavencimiento.Size = new Size(227, 23);
            dtpfechavencimiento.TabIndex = 145;
            // 
            // dtpfechaingreso
            // 
            dtpfechaingreso.Location = new Point(16, 179);
            dtpfechaingreso.Margin = new Padding(3, 2, 3, 2);
            dtpfechaingreso.Name = "dtpfechaingreso";
            dtpfechaingreso.Size = new Size(227, 23);
            dtpfechaingreso.TabIndex = 144;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Location = new Point(880, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 83);
            groupBox1.TabIndex = 152;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(370, 44);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 102;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Perpetua", 12F);
            label10.Location = new Point(895, 148);
            label10.Name = "label10";
            label10.Size = new Size(57, 18);
            label10.TabIndex = 150;
            label10.Text = "Criterio";
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { column0, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvProducto.Location = new Point(16, 323);
            dgvProducto.Margin = new Padding(3, 2, 3, 2);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.Size = new Size(1332, 323);
            dgvProducto.TabIndex = 143;
            // 
            // FormGrafoAlgoritmoFloyd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnAscendente);
            Controls.Add(btnDescendente);
            Controls.Add(label11);
            Controls.Add(cbCriterioOrdenamiento);
            Controls.Add(txtprecioventa);
            Controls.Add(txtpreciocompra);
            Controls.Add(btnAñadir);
            Controls.Add(txtdescripcion);
            Controls.Add(txtcodigo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(txtproducto);
            Controls.Add(label6);
            Controls.Add(cbCriterioBusqueda);
            Controls.Add(cbcategoria);
            Controls.Add(dtpfechavencimiento);
            Controls.Add(dtpfechaingreso);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(dgvProducto);
            Controls.Add(groupBox2);
            Name = "FormGrafoAlgoritmoFloyd";
            Text = "FormGrafoAlgoritmoFloyd";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAscendente;
        private Button btnDescendente;
        private Label label11;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn column0;
        private ComboBox cbCriterioOrdenamiento;
        private DataGridViewTextBoxColumn Column7;
        private TextBox txtprecioventa;
        private TextBox txtpreciocompra;
        private Button btnAñadir;
        private TextBox txtdescripcion;
        private TextBox txtcodigo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtBusqueda;
        private Label label3;
        private Button btnCancelar;
        private Button btnEliminar;
        private TextBox txtproducto;
        private Label label6;
        private ComboBox cbCriterioBusqueda;
        private ComboBox cbcategoria;
        private DateTimePicker dtpfechavencimiento;
        private DateTimePicker dtpfechaingreso;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private Label label10;
        private DataGridView dgvProducto;
    }
}