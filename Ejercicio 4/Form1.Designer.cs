namespace Ejercicio_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdPasajero = new TextBox();
            txtNombrePasajero = new TextBox();
            txtApellidoPasajero = new TextBox();
            groupBox1 = new GroupBox();
            btnPasajero = new Button();
            groupBox2 = new GroupBox();
            btnRegistrador = new Button();
            label4 = new Label();
            txtApellidoRegistrador = new TextBox();
            label5 = new Label();
            txtNombreRegistrador = new TextBox();
            label6 = new Label();
            txtIdRegistrador = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 259);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(449, 180);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(544, 259);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(449, 180);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "ID del pasajero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-3, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre del pasajero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 135);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido del pasajero:";
            label3.Click += label3_Click;
            // 
            // txtIdPasajero
            // 
            txtIdPasajero.BorderStyle = BorderStyle.FixedSingle;
            txtIdPasajero.Location = new Point(4, 58);
            txtIdPasajero.Margin = new Padding(2);
            txtIdPasajero.Name = "txtIdPasajero";
            txtIdPasajero.Size = new Size(441, 27);
            txtIdPasajero.TabIndex = 5;
            txtIdPasajero.TextChanged += txtIdPasajero_TextChanged;
            // 
            // txtNombrePasajero
            // 
            txtNombrePasajero.BorderStyle = BorderStyle.FixedSingle;
            txtNombrePasajero.Location = new Point(4, 108);
            txtNombrePasajero.Margin = new Padding(2);
            txtNombrePasajero.Name = "txtNombrePasajero";
            txtNombrePasajero.Size = new Size(441, 27);
            txtNombrePasajero.TabIndex = 6;
            txtNombrePasajero.TextChanged += txtNombrePasajero_TextChanged;
            // 
            // txtApellidoPasajero
            // 
            txtApellidoPasajero.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoPasajero.Location = new Point(4, 158);
            txtApellidoPasajero.Margin = new Padding(2);
            txtApellidoPasajero.Name = "txtApellidoPasajero";
            txtApellidoPasajero.Size = new Size(441, 27);
            txtApellidoPasajero.TabIndex = 7;
            txtApellidoPasajero.TextChanged += txtApellidoPasajero_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPasajero);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtApellidoPasajero);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombrePasajero);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdPasajero);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(449, 245);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pasajero";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPasajero
            // 
            btnPasajero.Location = new Point(152, 189);
            btnPasajero.Margin = new Padding(2);
            btnPasajero.Name = "btnPasajero";
            btnPasajero.Size = new Size(113, 44);
            btnPasajero.TabIndex = 10;
            btnPasajero.Text = "Agregar";
            btnPasajero.UseVisualStyleBackColor = true;
            btnPasajero.Click += btnPasajero_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegistrador);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtApellidoRegistrador);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtNombreRegistrador);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtIdRegistrador);
            groupBox2.Location = new Point(548, 10);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(449, 245);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registrador";
            // 
            // btnRegistrador
            // 
            btnRegistrador.Location = new Point(198, 189);
            btnRegistrador.Margin = new Padding(2);
            btnRegistrador.Name = "btnRegistrador";
            btnRegistrador.Size = new Size(113, 44);
            btnRegistrador.TabIndex = 11;
            btnRegistrador.Text = "Agregar";
            btnRegistrador.UseVisualStyleBackColor = true;
            btnRegistrador.Click += btnRegistrador_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 36);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 2;
            label4.Text = "ID del registrador";
            // 
            // txtApellidoRegistrador
            // 
            txtApellidoRegistrador.BorderStyle = BorderStyle.FixedSingle;
            txtApellidoRegistrador.Location = new Point(5, 158);
            txtApellidoRegistrador.Margin = new Padding(2);
            txtApellidoRegistrador.Name = "txtApellidoRegistrador";
            txtApellidoRegistrador.Size = new Size(440, 27);
            txtApellidoRegistrador.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 3;
            label5.Text = "Nombre del registrador";
            // 
            // txtNombreRegistrador
            // 
            txtNombreRegistrador.BorderStyle = BorderStyle.FixedSingle;
            txtNombreRegistrador.Location = new Point(5, 108);
            txtNombreRegistrador.Margin = new Padding(2);
            txtNombreRegistrador.Name = "txtNombreRegistrador";
            txtNombreRegistrador.Size = new Size(440, 27);
            txtNombreRegistrador.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 135);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(168, 20);
            label6.TabIndex = 4;
            label6.Text = "Apellido del registrador";
            // 
            // txtIdRegistrador
            // 
            txtIdRegistrador.BorderStyle = BorderStyle.FixedSingle;
            txtIdRegistrador.Location = new Point(5, 58);
            txtIdRegistrador.Margin = new Padding(2);
            txtIdRegistrador.Name = "txtIdRegistrador";
            txtIdRegistrador.Size = new Size(440, 27);
            txtIdRegistrador.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(162, 460);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(113, 44);
            button1.TabIndex = 11;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(746, 460);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 12;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 531);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Registros";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdPasajero;
        private TextBox txtNombrePasajero;
        private TextBox txtApellidoPasajero;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtApellidoRegistrador;
        private Label label5;
        private TextBox txtNombreRegistrador;
        private Label label6;
        private TextBox txtIdRegistrador;
        private Button btnPasajero;
        private Button btnRegistrador;
        private Button button1;
        private Button button2;
    }
}