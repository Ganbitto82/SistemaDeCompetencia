namespace SistemaDeCompetencia.Vista
{
    partial class VerCompentencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_Modalidad = new System.Windows.Forms.TextBox();
            this.textBox_Deporte = new System.Windows.Forms.TextBox();
            this.textBox_Estado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablaEncuentro = new System.Windows.Forms.DataGridView();
            this.encuentroParticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncuentroParticipante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaParticipante = new System.Windows.Forms.DataGridView();
            this.Participante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_DarDeBaja = new System.Windows.Forms.Button();
            this.button_fixture = new System.Windows.Forms.Button();
            this.button_tablaPosicion = new System.Windows.Forms.Button();
            this.button_generar = new System.Windows.Forms.Button();
            this.button_participantes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEncuentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaParticipante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.label7.TabIndex = 21;
            this.label7.Text = "Sistema de Competencias Deportivas";
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(451, 620);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(77, 29);
            this.salir.TabIndex = 36;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(545, 620);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(77, 29);
            this.button_cancelar.TabIndex = 35;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(22, 21);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(198, 18);
            this.label_nombre.TabIndex = 22;
            this.label_nombre.Text = "Datos de la Competencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Deporte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Modalidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Participantes:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_nombre.Enabled = false;
            this.textBox_nombre.Location = new System.Drawing.Point(219, 63);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(238, 20);
            this.textBox_nombre.TabIndex = 29;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            // 
            // textBox_Modalidad
            // 
            this.textBox_Modalidad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Modalidad.Enabled = false;
            this.textBox_Modalidad.Location = new System.Drawing.Point(219, 104);
            this.textBox_Modalidad.Name = "textBox_Modalidad";
            this.textBox_Modalidad.Size = new System.Drawing.Size(238, 20);
            this.textBox_Modalidad.TabIndex = 30;
            this.textBox_Modalidad.TextChanged += new System.EventHandler(this.textBox_Modalidad_TextChanged);
            // 
            // textBox_Deporte
            // 
            this.textBox_Deporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Deporte.Enabled = false;
            this.textBox_Deporte.Location = new System.Drawing.Point(219, 146);
            this.textBox_Deporte.Name = "textBox_Deporte";
            this.textBox_Deporte.Size = new System.Drawing.Size(238, 20);
            this.textBox_Deporte.TabIndex = 31;
            this.textBox_Deporte.TextChanged += new System.EventHandler(this.textBox_Deporte_TextChanged);
            // 
            // textBox_Estado
            // 
            this.textBox_Estado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_Estado.Enabled = false;
            this.textBox_Estado.Location = new System.Drawing.Point(219, 187);
            this.textBox_Estado.Name = "textBox_Estado";
            this.textBox_Estado.Size = new System.Drawing.Size(238, 20);
            this.textBox_Estado.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TablaEncuentro);
            this.panel1.Controls.Add(this.TablaParticipante);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_Estado);
            this.panel1.Controls.Add(this.textBox_Deporte);
            this.panel1.Controls.Add(this.textBox_Modalidad);
            this.panel1.Controls.Add(this.textBox_nombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_nombre);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(493, 535);
            this.panel1.TabIndex = 22;
            // 
            // TablaEncuentro
            // 
            this.TablaEncuentro.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.TablaEncuentro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaEncuentro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEncuentro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.encuentroParticipante,
            this.Vs,
            this.EncuentroParticipante2});
            this.TablaEncuentro.Location = new System.Drawing.Point(58, 387);
            this.TablaEncuentro.Name = "TablaEncuentro";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEncuentro.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaEncuentro.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaEncuentro.Size = new System.Drawing.Size(364, 121);
            this.TablaEncuentro.TabIndex = 39;
            // 
            // encuentroParticipante
            // 
            this.encuentroParticipante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.encuentroParticipante.HeaderText = "Participante";
            this.encuentroParticipante.Name = "encuentroParticipante";
            // 
            // Vs
            // 
            this.Vs.HeaderText = "Vs";
            this.Vs.Name = "Vs";
            // 
            // EncuentroParticipante2
            // 
            this.EncuentroParticipante2.HeaderText = "Participante";
            this.EncuentroParticipante2.Name = "EncuentroParticipante2";
            // 
            // TablaParticipante
            // 
            this.TablaParticipante.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.TablaParticipante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TablaParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaParticipante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Participante});
            this.TablaParticipante.Location = new System.Drawing.Point(56, 259);
            this.TablaParticipante.Name = "TablaParticipante";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablaParticipante.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TablaParticipante.Size = new System.Drawing.Size(367, 93);
            this.TablaParticipante.TabIndex = 38;
            this.TablaParticipante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaParticipante_CellContentClick);
            // 
            // Participante
            // 
            this.Participante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Participante.HeaderText = "Participantes";
            this.Participante.Name = "Participante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Proximos encuentros:";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // button_modificar
            // 
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.Location = new System.Drawing.Point(520, 86);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(102, 29);
            this.button_modificar.TabIndex = 37;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_DarDeBaja
            // 
            this.button_DarDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DarDeBaja.Location = new System.Drawing.Point(520, 129);
            this.button_DarDeBaja.Name = "button_DarDeBaja";
            this.button_DarDeBaja.Size = new System.Drawing.Size(102, 29);
            this.button_DarDeBaja.TabIndex = 38;
            this.button_DarDeBaja.Text = "DardeBaja";
            this.button_DarDeBaja.UseVisualStyleBackColor = true;
            // 
            // button_fixture
            // 
            this.button_fixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fixture.Location = new System.Drawing.Point(520, 170);
            this.button_fixture.Name = "button_fixture";
            this.button_fixture.Size = new System.Drawing.Size(102, 29);
            this.button_fixture.TabIndex = 39;
            this.button_fixture.Text = "VerFixture";
            this.button_fixture.UseVisualStyleBackColor = true;
            // 
            // button_tablaPosicion
            // 
            this.button_tablaPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tablaPosicion.Location = new System.Drawing.Point(520, 212);
            this.button_tablaPosicion.Name = "button_tablaPosicion";
            this.button_tablaPosicion.Size = new System.Drawing.Size(102, 29);
            this.button_tablaPosicion.TabIndex = 40;
            this.button_tablaPosicion.Text = "TablaPosicion";
            this.button_tablaPosicion.UseVisualStyleBackColor = true;
            // 
            // button_generar
            // 
            this.button_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generar.Location = new System.Drawing.Point(520, 253);
            this.button_generar.Name = "button_generar";
            this.button_generar.Size = new System.Drawing.Size(102, 29);
            this.button_generar.TabIndex = 41;
            this.button_generar.Text = "GenerarFixture";
            this.button_generar.UseVisualStyleBackColor = true;
            this.button_generar.Click += new System.EventHandler(this.button_generar_Click);
            // 
            // button_participantes
            // 
            this.button_participantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_participantes.Location = new System.Drawing.Point(520, 293);
            this.button_participantes.Name = "button_participantes";
            this.button_participantes.Size = new System.Drawing.Size(102, 29);
            this.button_participantes.TabIndex = 42;
            this.button_participantes.Text = "VerParticipante";
            this.button_participantes.UseVisualStyleBackColor = true;
            this.button_participantes.Click += new System.EventHandler(this.button_participantes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 661);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // VerCompentencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.button_participantes);
            this.Controls.Add(this.button_generar);
            this.Controls.Add(this.button_tablaPosicion);
            this.Controls.Add(this.button_fixture);
            this.Controls.Add(this.button_DarDeBaja);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VerCompentencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEncuentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaParticipante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_Modalidad;
        private System.Windows.Forms.TextBox textBox_Deporte;
        private System.Windows.Forms.TextBox textBox_Estado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_DarDeBaja;
        private System.Windows.Forms.Button button_fixture;
        private System.Windows.Forms.Button button_tablaPosicion;
        private System.Windows.Forms.Button button_generar;
        private System.Windows.Forms.Button button_participantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView TablaParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participante;
        private System.Windows.Forms.DataGridView TablaEncuentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn encuentroParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vs;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncuentroParticipante2;
    }
}