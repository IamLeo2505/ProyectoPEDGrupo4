namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class FormArbolBinario
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
            txtprecioventa = new TextBox();
            txtpreciocompra = new TextBox();
            txtdescripcion = new TextBox();
            txtcodigo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            txtproducto = new TextBox();
            label6 = new Label();
            cbcategoria = new ComboBox();
            dtpfechavencimiento = new DateTimePicker();
            dtpfechaingreso = new DateTimePicker();
            btnAñadir = new Button();
            panel1 = new Panel();
            btnatras = new Button();
            SuspendLayout();
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(821, 235);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(135, 27);
            txtprecioventa.TabIndex = 113;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(618, 235);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(153, 27);
            txtpreciocompra.TabIndex = 112;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(593, 112);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(391, 27);
            txtdescripcion.TabIndex = 111;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(51, 112);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(137, 27);
            txtcodigo.TabIndex = 110;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 5);
            label9.Name = "label9";
            label9.Size = new Size(163, 42);
            label9.TabIndex = 109;
            label9.Text = "Inventario ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 16.2F);
            label8.Location = new Point(608, 191);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 108;
            label8.Text = "Precio de Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 16.2F);
            label7.Location = new Point(809, 191);
            label7.Name = "label7";
            label7.Size = new Size(174, 32);
            label7.TabIndex = 107;
            label7.Text = "Precio de Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 16.2F);
            label5.Location = new Point(6, 191);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 106;
            label5.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 16.2F);
            label4.Location = new Point(305, 191);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 105;
            label4.Text = "Fecha de Vencimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 16.2F);
            label2.Location = new Point(279, 77);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 103;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 16.2F);
            label1.Location = new Point(51, 77);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 102;
            label1.Text = "Ingrese Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 16.2F);
            label3.Location = new Point(593, 77);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 104;
            label3.Text = "Descripción";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1432, 868);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 124;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(280, 112);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(283, 27);
            txtproducto.TabIndex = 117;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 16.2F);
            label6.Location = new Point(1017, 79);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 120;
            label6.Text = "Categoría";
            // 
            // cbcategoria
            // 
            cbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Items.AddRange(new object[] { "Bolsa 1 Lb", "Bolsa 2 Lb", "Vaso", "Paquete" });
            cbcategoria.Location = new Point(1017, 112);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(282, 28);
            cbcategoria.TabIndex = 118;
            // 
            // dtpfechavencimiento
            // 
            dtpfechavencimiento.Location = new Point(304, 235);
            dtpfechavencimiento.Name = "dtpfechavencimiento";
            dtpfechavencimiento.Size = new Size(259, 27);
            dtpfechavencimiento.TabIndex = 116;
            // 
            // dtpfechaingreso
            // 
            dtpfechaingreso.Location = new Point(6, 235);
            dtpfechaingreso.Name = "dtpfechaingreso";
            dtpfechaingreso.Size = new Size(259, 27);
            dtpfechaingreso.TabIndex = 115;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(1333, 109);
            btnAñadir.Margin = new Padding(3, 4, 3, 4);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(86, 31);
            btnAñadir.TabIndex = 95;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(452, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 546);
            panel1.TabIndex = 126;
            panel1.Paint += panel1_Paint;
            // 
            // btnatras
            // 
            btnatras.Location = new Point(1333, 868);
            btnatras.Margin = new Padding(3, 4, 3, 4);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(86, 31);
            btnatras.TabIndex = 127;
            btnatras.Text = "Atrás";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // FormArbolBinario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 912);
            Controls.Add(btnatras);
            Controls.Add(panel1);
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
            Controls.Add(txtproducto);
            Controls.Add(label6);
            Controls.Add(cbcategoria);
            Controls.Add(dtpfechavencimiento);
            Controls.Add(dtpfechaingreso);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormArbolBinario";
            Text = "FormArbolBinario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtprecioventa;
        private TextBox txtpreciocompra;
        private TextBox txtdescripcion;
        private TextBox txtcodigo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox txtBusqueda;
        private Label label3;
        private DataGridViewTextBoxColumn Column7;
        private Button btnCancelar;
        private Button btnEliminar;
        private TextBox txtproducto;
        private Label label10;
        private Label label6;
        private ComboBox cbCriterioBusqueda;
        private ComboBox cbcategoria;
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
        private Button btnAñadir;
        private Button btnAscendente;
        private Button btnDescendente;
        private Label label11;
        private ComboBox cbCriterioOrdenamiento;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button btnatras;
    }
}