namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class GrafoDijkstra
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
            paneldijsktra = new Panel();
            btncancelar = new Button();
            btnSalir = new Button();
            btnagregar = new Button();
            SuspendLayout();
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(238, 132);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(329, 27);
            txtproducto.TabIndex = 43;
            // 
            // dtpfechavencimiento
            // 
            dtpfechavencimiento.Location = new Point(322, 248);
            dtpfechavencimiento.Name = "dtpfechavencimiento";
            dtpfechavencimiento.Size = new Size(305, 27);
            dtpfechavencimiento.TabIndex = 42;
            // 
            // dtpfechaingreso
            // 
            dtpfechaingreso.Location = new Point(-1, 248);
            dtpfechaingreso.Name = "dtpfechaingreso";
            dtpfechaingreso.Size = new Size(298, 27);
            dtpfechaingreso.TabIndex = 41;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(922, 248);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(181, 27);
            txtpreciocompra.TabIndex = 40;
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(680, 248);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(198, 27);
            txtprecioventa.TabIndex = 39;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(605, 132);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(437, 27);
            txtdescripcion.TabIndex = 38;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(8, 132);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(182, 27);
            txtcodigo.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Perpetua", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 21);
            label9.Name = "label9";
            label9.Size = new Size(163, 42);
            label9.TabIndex = 36;
            label9.Text = "Inventario ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Perpetua", 16.2F);
            label8.Location = new Point(680, 204);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 35;
            label8.Text = "Precio de Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua", 16.2F);
            label7.Location = new Point(922, 204);
            label7.Name = "label7";
            label7.Size = new Size(174, 32);
            label7.TabIndex = 34;
            label7.Text = "Precio de Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua", 16.2F);
            label6.Location = new Point(1091, 97);
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
            cbcategoria.Location = new Point(1091, 132);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(282, 28);
            cbcategoria.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua", 16.2F);
            label5.Location = new Point(-1, 204);
            label5.Name = "label5";
            label5.Size = new Size(182, 32);
            label5.TabIndex = 31;
            label5.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua", 16.2F);
            label4.Location = new Point(323, 204);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 30;
            label4.Text = "Fecha de Vencimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 16.2F);
            label3.Location = new Point(605, 97);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 29;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 16.2F);
            label2.Location = new Point(237, 97);
            label2.Name = "label2";
            label2.Size = new Size(238, 32);
            label2.TabIndex = 28;
            label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 16.2F);
            label1.Location = new Point(8, 97);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 27;
            label1.Text = "Ingrese Código";
            // 
            // paneldijsktra
            // 
            paneldijsktra.Location = new Point(417, 314);
            paneldijsktra.Name = "paneldijsktra";
            paneldijsktra.Size = new Size(679, 369);
            paneldijsktra.TabIndex = 44;
            paneldijsktra.Paint += paneldijsktra_Paint;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(1282, 732);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(94, 29);
            btncancelar.TabIndex = 45;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1168, 732);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 46;
            btnSalir.Text = "Atrás";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(1142, 246);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(94, 29);
            btnagregar.TabIndex = 47;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // GrafoDijkstra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 771);
            Controls.Add(btnagregar);
            Controls.Add(btnSalir);
            Controls.Add(btncancelar);
            Controls.Add(paneldijsktra);
            Controls.Add(txtproducto);
            Controls.Add(dtpfechavencimiento);
            Controls.Add(dtpfechaingreso);
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
            Name = "GrafoDijkstra";
            Text = "GrafoDijkstra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtproducto;
        private DateTimePicker dtpfechavencimiento;
        private DateTimePicker dtpfechaingreso;
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
        private Panel paneldijsktra;
        private Button btncancelar;
        private Button btnSalir;
        private Button btnagregar;
    }
}