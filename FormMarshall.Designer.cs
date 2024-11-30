namespace ProyectoFinalEstructuraDatosGrupo4
{
    partial class FormMarshall
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
            button4 = new Button();
            button5 = new Button();
            btnAgrega = new Button();
            panelGrafo = new Panel();
            button3 = new Button();
            groupBox2 = new GroupBox();
            txtNodoOrigen = new TextBox();
            txtDistancia = new TextBox();
            txtNodoDestino = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            txtProducto = new TextBox();
            txtIdNodo = new TextBox();
            btnAgregarNodo = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonShadow;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(677, 258);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(110, 30);
            button4.TabIndex = 91;
            button4.Text = "Resultados";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnCalcularMarshall_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonShadow;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(677, 409);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(112, 30);
            button5.TabIndex = 92;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnAgrega
            // 
            btnAgrega.BackColor = SystemColors.ButtonShadow;
            btnAgrega.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgrega.Location = new Point(677, 176);
            btnAgrega.Margin = new Padding(2);
            btnAgrega.Name = "btnAgrega";
            btnAgrega.Size = new Size(110, 30);
            btnAgrega.TabIndex = 89;
            btnAgrega.Text = "Guardar";
            btnAgrega.UseVisualStyleBackColor = false;
            btnAgrega.Click += btnAgregarConexion_Click;
            // 
            // panelGrafo
            // 
            panelGrafo.BackColor = Color.White;
            panelGrafo.Location = new Point(13, 178);
            panelGrafo.Margin = new Padding(4, 3, 4, 3);
            panelGrafo.Name = "panelGrafo";
            panelGrafo.Size = new Size(658, 220);
            panelGrafo.TabIndex = 95;
            panelGrafo.Paint += panelGrafo_Paint;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(677, 219);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(110, 30);
            button3.TabIndex = 90;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnEliminarConexion_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.MenuHighlight;
            groupBox2.Controls.Add(txtNodoOrigen);
            groupBox2.Controls.Add(txtDistancia);
            groupBox2.Controls.Add(txtNodoDestino);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Perpetua", 11.25F, FontStyle.Bold);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(328, 17);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(459, 145);
            groupBox2.TabIndex = 94;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recorrido entre los vertices";
            // 
            // txtNodoOrigen
            // 
            txtNodoOrigen.Location = new Point(97, 29);
            txtNodoOrigen.Margin = new Padding(2);
            txtNodoOrigen.Name = "txtNodoOrigen";
            txtNodoOrigen.Size = new Size(116, 25);
            txtNodoOrigen.TabIndex = 66;
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(331, 31);
            txtDistancia.Margin = new Padding(4, 3, 4, 3);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(116, 25);
            txtDistancia.TabIndex = 5;
            // 
            // txtNodoDestino
            // 
            txtNodoDestino.Location = new Point(97, 67);
            txtNodoDestino.Margin = new Padding(4, 3, 4, 3);
            txtNodoDestino.Name = "txtNodoDestino";
            txtNodoDestino.Size = new Size(116, 25);
            txtNodoDestino.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 2;
            label5.Text = "Recorrido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 67);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 1;
            label4.Text = "Vertice B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 0;
            label2.Text = "Vertice A";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.MenuHighlight;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProducto);
            groupBox1.Controls.Add(txtIdNodo);
            groupBox1.Controls.Add(btnAgregarNodo);
            groupBox1.Font = new Font("Perpetua", 11.25F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(19, 17);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(290, 145);
            groupBox1.TabIndex = 93;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vertice";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 17);
            label1.TabIndex = 53;
            label1.Text = "id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 55;
            label3.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(164, 48);
            txtProducto.Margin = new Padding(4, 3, 4, 3);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(103, 25);
            txtProducto.TabIndex = 6;
            // 
            // txtIdNodo
            // 
            txtIdNodo.Location = new Point(18, 48);
            txtIdNodo.Margin = new Padding(2);
            txtIdNodo.Name = "txtIdNodo";
            txtIdNodo.Size = new Size(103, 25);
            txtIdNodo.TabIndex = 64;
            // 
            // btnAgregarNodo
            // 
            btnAgregarNodo.BackColor = SystemColors.ButtonShadow;
            btnAgregarNodo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarNodo.ForeColor = SystemColors.ControlText;
            btnAgregarNodo.Location = new Point(16, 95);
            btnAgregarNodo.Margin = new Padding(2);
            btnAgregarNodo.Name = "btnAgregarNodo";
            btnAgregarNodo.Size = new Size(86, 30);
            btnAgregarNodo.TabIndex = 75;
            btnAgregarNodo.Text = "Agregar";
            btnAgregarNodo.UseVisualStyleBackColor = false;
            btnAgregarNodo.Click += btnAgregarNodo_Click;
            // 
            // FormMarshall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(btnAgrega);
            Controls.Add(panelGrafo);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMarshall";
            Text = "FormMarshall";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button5;
        private Button btnAgrega;
        private Panel panelGrafo;
        private Button button3;
        private GroupBox groupBox2;
        private TextBox txtNodoOrigen;
        private TextBox txtDistancia;
        private TextBox txtNodoDestino;
        private Label label5;
        private Label label4;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private TextBox txtProducto;
        private TextBox txtIdNodo;
        private Button btnAgregarNodo;
    }
}