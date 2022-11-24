namespace Casasola
{
    partial class Form2
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
            this.DGVcompradores = new System.Windows.Forms.DataGridView();
            this.TxtIdComprador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDomicilioComp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApeNombComp = new System.Windows.Forms.TextBox();
            this.TxtDNIcomp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelcomp = new System.Windows.Forms.TextBox();
            this.BtGuardarComp = new System.Windows.Forms.Button();
            this.BtmodificarComp = new System.Windows.Forms.Button();
            this.BtEliminarComp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtVolver = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcompradores)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVcompradores
            // 
            this.DGVcompradores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DGVcompradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcompradores.Location = new System.Drawing.Point(12, 69);
            this.DGVcompradores.Name = "DGVcompradores";
            this.DGVcompradores.Size = new System.Drawing.Size(537, 208);
            this.DGVcompradores.TabIndex = 11;
            this.DGVcompradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVcompradore_CellClick);
            // 
            // TxtIdComprador
            // 
            this.TxtIdComprador.Enabled = false;
            this.TxtIdComprador.Location = new System.Drawing.Point(149, 302);
            this.TxtIdComprador.Name = "TxtIdComprador";
            this.TxtIdComprador.Size = new System.Drawing.Size(139, 22);
            this.TxtIdComprador.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // TxtDomicilioComp
            // 
            this.TxtDomicilioComp.Location = new System.Drawing.Point(411, 302);
            this.TxtDomicilioComp.Name = "TxtDomicilioComp";
            this.TxtDomicilioComp.Size = new System.Drawing.Size(139, 22);
            this.TxtDomicilioComp.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido y Nombre";
            // 
            // TxtApeNombComp
            // 
            this.TxtApeNombComp.Location = new System.Drawing.Point(149, 344);
            this.TxtApeNombComp.Name = "TxtApeNombComp";
            this.TxtApeNombComp.Size = new System.Drawing.Size(139, 22);
            this.TxtApeNombComp.TabIndex = 1;
            // 
            // TxtDNIcomp
            // 
            this.TxtDNIcomp.Location = new System.Drawing.Point(149, 384);
            this.TxtDNIcomp.Name = "TxtDNIcomp";
            this.TxtDNIcomp.Size = new System.Drawing.Size(139, 22);
            this.TxtDNIcomp.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "IdComprador";
            // 
            // TxtTelcomp
            // 
            this.TxtTelcomp.Location = new System.Drawing.Point(411, 344);
            this.TxtTelcomp.Name = "TxtTelcomp";
            this.TxtTelcomp.Size = new System.Drawing.Size(139, 22);
            this.TxtTelcomp.TabIndex = 4;
            // 
            // BtGuardarComp
            // 
            this.BtGuardarComp.BackColor = System.Drawing.Color.Khaki;
            this.BtGuardarComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGuardarComp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuardarComp.ForeColor = System.Drawing.Color.Black;
            this.BtGuardarComp.Location = new System.Drawing.Point(196, 440);
            this.BtGuardarComp.Name = "BtGuardarComp";
            this.BtGuardarComp.Size = new System.Drawing.Size(200, 41);
            this.BtGuardarComp.TabIndex = 5;
            this.BtGuardarComp.Text = "Guardar";
            this.BtGuardarComp.UseVisualStyleBackColor = false;
            this.BtGuardarComp.Click += new System.EventHandler(this.BtGuardarComp_Click);
            // 
            // BtmodificarComp
            // 
            this.BtmodificarComp.BackColor = System.Drawing.Color.Khaki;
            this.BtmodificarComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtmodificarComp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmodificarComp.ForeColor = System.Drawing.Color.Black;
            this.BtmodificarComp.Location = new System.Drawing.Point(559, 179);
            this.BtmodificarComp.Name = "BtmodificarComp";
            this.BtmodificarComp.Size = new System.Drawing.Size(108, 41);
            this.BtmodificarComp.TabIndex = 7;
            this.BtmodificarComp.Text = "Modificar";
            this.BtmodificarComp.UseVisualStyleBackColor = false;
            this.BtmodificarComp.Click += new System.EventHandler(this.BtmodificarComp_Click);
            // 
            // BtEliminarComp
            // 
            this.BtEliminarComp.BackColor = System.Drawing.Color.Khaki;
            this.BtEliminarComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminarComp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminarComp.ForeColor = System.Drawing.Color.Black;
            this.BtEliminarComp.Location = new System.Drawing.Point(559, 237);
            this.BtEliminarComp.Name = "BtEliminarComp";
            this.BtEliminarComp.Size = new System.Drawing.Size(108, 41);
            this.BtEliminarComp.TabIndex = 8;
            this.BtEliminarComp.Text = "Eliminar";
            this.BtEliminarComp.UseVisualStyleBackColor = false;
            this.BtEliminarComp.Click += new System.EventHandler(this.BtEliminarComp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(221, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "COMPRADORES";
            // 
            // BtVolver
            // 
            this.BtVolver.BackColor = System.Drawing.Color.Khaki;
            this.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVolver.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVolver.ForeColor = System.Drawing.Color.Black;
            this.BtVolver.Location = new System.Drawing.Point(559, 440);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(108, 41);
            this.BtVolver.TabIndex = 12;
            this.BtVolver.Text = "Volver";
            this.BtVolver.UseVisualStyleBackColor = false;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(12, 41);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(537, 22);
            this.TxtBuscar.TabIndex = 10;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CBbuscar
            // 
            this.CBbuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.CBbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBbuscar.ForeColor = System.Drawing.Color.White;
            this.CBbuscar.FormattingEnabled = true;
            this.CBbuscar.Items.AddRange(new object[] {
            "IdCompradores",
            "Apellido y Nombre",
            "DNI",
            "Domicilio",
            "Telefono"});
            this.CBbuscar.Location = new System.Drawing.Point(555, 41);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(112, 24);
            this.CBbuscar.TabIndex = 9;
            this.CBbuscar.Text = "Buscar";
            this.CBbuscar.SelectedIndexChanged += new System.EventHandler(this.CBbuscar_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 493);
            this.Controls.Add(this.CBbuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtEliminarComp);
            this.Controls.Add(this.BtmodificarComp);
            this.Controls.Add(this.BtGuardarComp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTelcomp);
            this.Controls.Add(this.TxtDNIcomp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApeNombComp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDomicilioComp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtIdComprador);
            this.Controls.Add(this.DGVcompradores);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcompradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcompradores;
        private System.Windows.Forms.TextBox TxtIdComprador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDomicilioComp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApeNombComp;
        private System.Windows.Forms.TextBox TxtDNIcomp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelcomp;
        private System.Windows.Forms.Button BtGuardarComp;
        private System.Windows.Forms.Button BtmodificarComp;
        private System.Windows.Forms.Button BtEliminarComp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CBbuscar;
    }
}