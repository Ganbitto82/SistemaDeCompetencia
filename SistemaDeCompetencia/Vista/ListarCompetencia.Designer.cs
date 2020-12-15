namespace SistemaDeCompetencia.Vista
{
    partial class ListarCompetencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscar = new System.Windows.Forms.Button();
            this.comboBox_modalidad = new System.Windows.Forms.ComboBox();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.comboBox_deporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Competicion = new System.Windows.Forms.Panel();
            this.button_nueva = new System.Windows.Forms.Button();
            this.button_detalles = new System.Windows.Forms.Button();
            this.tablaDeCompetencias = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Competicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 661);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(109, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sistema de Competencias Deportivas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.comboBox_modalidad);
            this.panel1.Controls.Add(this.comboBox_estado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_nombre);
            this.panel1.Controls.Add(this.comboBox_deporte);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(610, 149);
            this.panel1.TabIndex = 20;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.Control;
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(506, 102);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(77, 29);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_modalidad
            // 
            this.comboBox_modalidad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_modalidad.FormattingEnabled = true;
            this.comboBox_modalidad.Location = new System.Drawing.Point(383, 20);
            this.comboBox_modalidad.Name = "comboBox_modalidad";
            this.comboBox_modalidad.Size = new System.Drawing.Size(200, 21);
            this.comboBox_modalidad.TabIndex = 1;
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Items.AddRange(new object[] {
            "CREADA",
            "PLANIFICACION",
            "EN DISPUTA",
            "FINALIZADA"});
            this.comboBox_estado.Location = new System.Drawing.Point(383, 59);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(200, 21);
            this.comboBox_estado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modalidad:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_nombre.Location = new System.Drawing.Point(79, 21);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(200, 20);
            this.textBox_nombre.TabIndex = 0;
            // 
            // comboBox_deporte
            // 
            this.comboBox_deporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_deporte.FormattingEnabled = true;
            this.comboBox_deporte.Location = new System.Drawing.Point(79, 59);
            this.comboBox_deporte.Name = "comboBox_deporte";
            this.comboBox_deporte.Size = new System.Drawing.Size(200, 21);
            this.comboBox_deporte.TabIndex = 2;
            this.comboBox_deporte.SelectedIndexChanged += new System.EventHandler(this.comboBox_deporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deporte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Competicion
            // 
            this.Competicion.BackColor = System.Drawing.Color.YellowGreen;
            this.Competicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Competicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Competicion.Controls.Add(this.button_nueva);
            this.Competicion.Controls.Add(this.button_detalles);
            this.Competicion.Controls.Add(this.tablaDeCompetencias);
            this.Competicion.Controls.Add(this.label10);
            this.Competicion.Controls.Add(this.label5);
            this.Competicion.Cursor = System.Windows.Forms.Cursors.Default;
            this.Competicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Competicion.Location = new System.Drawing.Point(12, 212);
            this.Competicion.Name = "Competicion";
            this.Competicion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Competicion.Size = new System.Drawing.Size(610, 390);
            this.Competicion.TabIndex = 21;
            // 
            // button_nueva
            // 
            this.button_nueva.BackColor = System.Drawing.SystemColors.Control;
            this.button_nueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nueva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_nueva.Location = new System.Drawing.Point(515, 112);
            this.button_nueva.Name = "button_nueva";
            this.button_nueva.Size = new System.Drawing.Size(77, 29);
            this.button_nueva.TabIndex = 7;
            this.button_nueva.Text = "Nueva";
            this.button_nueva.UseVisualStyleBackColor = false;
            this.button_nueva.Click += new System.EventHandler(this.button_nueva_Click);
            // 
            // button_detalles
            // 
            this.button_detalles.BackColor = System.Drawing.SystemColors.Control;
            this.button_detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_detalles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_detalles.Location = new System.Drawing.Point(515, 58);
            this.button_detalles.Name = "button_detalles";
            this.button_detalles.Size = new System.Drawing.Size(77, 29);
            this.button_detalles.TabIndex = 6;
            this.button_detalles.Text = "Detalles";
            this.button_detalles.UseVisualStyleBackColor = false;
            this.button_detalles.Click += new System.EventHandler(this.button_detalles_Click);
            // 
            // tablaDeCompetencias
            // 
            this.tablaDeCompetencias.AllowUserToAddRows = false;
            this.tablaDeCompetencias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.tablaDeCompetencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDeCompetencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaDeCompetencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDeCompetencias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablaDeCompetencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tablaDeCompetencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tablaDeCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDeCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tablaDeCompetencias.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tablaDeCompetencias.Location = new System.Drawing.Point(16, 58);
            this.tablaDeCompetencias.Name = "tablaDeCompetencias";
            this.tablaDeCompetencias.ReadOnly = true;
            this.tablaDeCompetencias.RowHeadersWidth = 35;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.tablaDeCompetencias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDeCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDeCompetencias.Size = new System.Drawing.Size(484, 306);
            this.tablaDeCompetencias.TabIndex = 5;
            this.tablaDeCompetencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeCompetencias_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de Competencia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Deporte";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modalidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Competencia/s Creada/s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(545, 620);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(77, 29);
            this.button_cancelar.TabIndex = 8;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // ListarCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.Competicion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListarCompetencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Competencias Deportivas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Competicion.ResumeLayout(false);
            this.Competicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_deporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ComboBox comboBox_modalidad;
        private System.Windows.Forms.Panel Competicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.DataGridView tablaDeCompetencias;
        private System.Windows.Forms.Button button_nueva;
        private System.Windows.Forms.Button button_detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}