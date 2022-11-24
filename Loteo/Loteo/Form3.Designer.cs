namespace Casasola
{
    partial class Form3
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
            this.BtVolver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtModificar = new System.Windows.Forms.Button();
            this.BtGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCantLotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDniSocio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApeyNomSocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelSocio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDomicilioSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSocios = new System.Windows.Forms.TextBox();
            this.DGVsocios = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CBBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVsocios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtVolver
            // 
            this.BtVolver.BackColor = System.Drawing.Color.Khaki;
            this.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVolver.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVolver.ForeColor = System.Drawing.Color.Black;
            this.BtVolver.Location = new System.Drawing.Point(573, 446);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(95, 41);
            this.BtVolver.TabIndex = 11;
            this.BtVolver.Text = "Volver";
            this.BtVolver.UseVisualStyleBackColor = false;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(262, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "SOCIOS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.BackColor = System.Drawing.Color.Khaki;
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtEliminar.Location = new System.Drawing.Point(570, 246);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(97, 41);
            this.BtEliminar.TabIndex = 7;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtModificar
            // 
            this.BtModificar.BackColor = System.Drawing.Color.Khaki;
            this.BtModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtModificar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtModificar.ForeColor = System.Drawing.Color.Black;
            this.BtModificar.Location = new System.Drawing.Point(570, 186);
            this.BtModificar.Name = "BtModificar";
            this.BtModificar.Size = new System.Drawing.Size(95, 41);
            this.BtModificar.TabIndex = 6;
            this.BtModificar.Text = "Modificar";
            this.BtModificar.UseVisualStyleBackColor = false;
            this.BtModificar.Click += new System.EventHandler(this.BtModificar_Click);
            // 
            // BtGuardar
            // 
            this.BtGuardar.BackColor = System.Drawing.Color.Khaki;
            this.BtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGuardar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtGuardar.Location = new System.Drawing.Point(198, 446);
            this.BtGuardar.Name = "BtGuardar";
            this.BtGuardar.Size = new System.Drawing.Size(200, 41);
            this.BtGuardar.TabIndex = 5;
            this.BtGuardar.Text = "Guardar";
            this.BtGuardar.UseVisualStyleBackColor = false;
            this.BtGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "IDSocios";
            // 
            // TxtCantLotes
            // 
            this.TxtCantLotes.Location = new System.Drawing.Point(424, 393);
            this.TxtCantLotes.Name = "TxtCantLotes";
            this.TxtCantLotes.Size = new System.Drawing.Size(139, 22);
            this.TxtCantLotes.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "DNI";
            // 
            // TxtDniSocio
            // 
            this.TxtDniSocio.Location = new System.Drawing.Point(138, 391);
            this.TxtDniSocio.Name = "TxtDniSocio";
            this.TxtDniSocio.Size = new System.Drawing.Size(139, 22);
            this.TxtDniSocio.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Apellido y Nombre";
            // 
            // TxtApeyNomSocio
            // 
            this.TxtApeyNomSocio.Location = new System.Drawing.Point(138, 347);
            this.TxtApeyNomSocio.Name = "TxtApeyNomSocio";
            this.TxtApeyNomSocio.Size = new System.Drawing.Size(139, 22);
            this.TxtApeyNomSocio.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefono";
            // 
            // TxtTelSocio
            // 
            this.TxtTelSocio.Location = new System.Drawing.Point(424, 350);
            this.TxtTelSocio.Name = "TxtTelSocio";
            this.TxtTelSocio.Size = new System.Drawing.Size(139, 22);
            this.TxtTelSocio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(353, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Domicilio";
            // 
            // TxtDomicilioSocio
            // 
            this.TxtDomicilioSocio.Location = new System.Drawing.Point(424, 309);
            this.TxtDomicilioSocio.Name = "TxtDomicilioSocio";
            this.TxtDomicilioSocio.Size = new System.Drawing.Size(139, 22);
            this.TxtDomicilioSocio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad de Lotes";
            // 
            // txtIdSocios
            // 
            this.txtIdSocios.Enabled = false;
            this.txtIdSocios.Location = new System.Drawing.Point(138, 306);
            this.txtIdSocios.Name = "txtIdSocios";
            this.txtIdSocios.Size = new System.Drawing.Size(139, 22);
            this.txtIdSocios.TabIndex = 12;
            // 
            // DGVsocios
            // 
            this.DGVsocios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DGVsocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVsocios.Location = new System.Drawing.Point(26, 78);
            this.DGVsocios.Name = "DGVsocios";
            this.DGVsocios.Size = new System.Drawing.Size(537, 208);
            this.DGVsocios.TabIndex = 10;
            this.DGVsocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVsocios_CellClick);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(26, 52);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(537, 22);
            this.TxtBuscar.TabIndex = 9;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CBBuscar
            // 
            this.CBBuscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.CBBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBBuscar.ForeColor = System.Drawing.Color.White;
            this.CBBuscar.FormattingEnabled = true;
            this.CBBuscar.Items.AddRange(new object[] {
            "IdSocios\t",
            "Apellido y Nombre\t",
            "DNI",
            "Domicilio",
            "Telefono",
            "Cantidad Lotes"});
            this.CBBuscar.Location = new System.Drawing.Point(570, 52);
            this.CBBuscar.Name = "CBBuscar";
            this.CBBuscar.Size = new System.Drawing.Size(95, 24);
            this.CBBuscar.TabIndex = 8;
            this.CBBuscar.Text = "Buscar";
            this.CBBuscar.SelectedIndexChanged += new System.EventHandler(this.CBBuscar_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 493);
            this.Controls.Add(this.CBBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtModificar);
            this.Controls.Add(this.BtGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCantLotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDniSocio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApeyNomSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTelSocio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDomicilioSocio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdSocios);
            this.Controls.Add(this.DGVsocios);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVsocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtVolver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button BtModificar;
        private System.Windows.Forms.Button BtGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCantLotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDniSocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApeyNomSocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTelSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDomicilioSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSocios;
        private System.Windows.Forms.DataGridView DGVsocios;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CBBuscar;
    }
}