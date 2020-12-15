namespace SistemaDeCompetencia.Vista
{         //ATENTI AL GRUPO
    partial class DarAltaCompetencia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_deporte = new System.Windows.Forms.Label();
            this.label_modalidad = new System.Windows.Forms.Label();
            this.comboBox_deporte = new System.Windows.Forms.ComboBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TablaLugares = new System.Windows.Forms.DataGridView();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_tituloLugar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_modalidad = new System.Windows.Forms.ComboBox();
            this.comboBox_formaPutuacion = new System.Windows.Forms.ComboBox();
            this.numericUpDown_tantos = new System.Windows.Forms.NumericUpDown();
            this.label_tantos = new System.Windows.Forms.Label();
            this.numericUpDown_sets = new System.Windows.Forms.NumericUpDown();
            this.label_sets = new System.Windows.Forms.Label();
            this.label_formaPutuacion = new System.Windows.Forms.Label();
            this.numericUpDown_presencia = new System.Windows.Forms.NumericUpDown();
            this.label_presencia = new System.Windows.Forms.Label();
            this.numericUpDown_partEmpatados = new System.Windows.Forms.NumericUpDown();
            this.label_partEmpatados = new System.Windows.Forms.Label();
            this.comboBox_permiso = new System.Windows.Forms.ComboBox();
            this.label_permiso = new System.Windows.Forms.Label();
            this.numericUpDown_partGanados = new System.Windows.Forms.NumericUpDown();
            this.label_partGanados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxReglamento = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaLugares)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_presencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_partEmpatados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_partGanados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(7, 19);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(73, 16);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre (*)";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_nombre.Location = new System.Drawing.Point(102, 15);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(174, 20);
            this.textBox_nombre.TabIndex = 0;
            this.textBox_nombre.TextChanged += new System.EventHandler(this.textBox_nombre_TextChanged);
            this.textBox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombre_KeyPress);
            // 
            // label_deporte
            // 
            this.label_deporte.AutoSize = true;
            this.label_deporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deporte.Location = new System.Drawing.Point(347, 22);
            this.label_deporte.Name = "label_deporte";
            this.label_deporte.Size = new System.Drawing.Size(73, 16);
            this.label_deporte.TabIndex = 2;
            this.label_deporte.Text = "Deporte (*)";
            // 
            // label_modalidad
            // 
            this.label_modalidad.AutoSize = true;
            this.label_modalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modalidad.Location = new System.Drawing.Point(7, 13);
            this.label_modalidad.Name = "label_modalidad";
            this.label_modalidad.Size = new System.Drawing.Size(89, 16);
            this.label_modalidad.TabIndex = 4;
            this.label_modalidad.Text = "Modalidad (*)";
            // 
            // comboBox_deporte
            // 
            this.comboBox_deporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_deporte.FormattingEnabled = true;
            this.comboBox_deporte.Location = new System.Drawing.Point(426, 18);
            this.comboBox_deporte.Name = "comboBox_deporte";
            this.comboBox_deporte.Size = new System.Drawing.Size(174, 21);
            this.comboBox_deporte.TabIndex = 1;
            this.comboBox_deporte.SelectedIndexChanged += new System.EventHandler(this.comboBox_deporte_SelectedIndexChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.Control;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptar.Location = new System.Drawing.Point(440, 631);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(84, 23);
            this.Aceptar.TabIndex = 12;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(544, 631);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(78, 23);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TablaLugares);
            this.panel2.Controls.Add(this.label_nombre);
            this.panel2.Controls.Add(this.label_deporte);
            this.panel2.Controls.Add(this.comboBox_deporte);
            this.panel2.Controls.Add(this.textBox_nombre);
            this.panel2.Controls.Add(this.label_tituloLugar);
            this.panel2.Location = new System.Drawing.Point(12, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 187);
            this.panel2.TabIndex = 14;
            // 
            // TablaLugares
            // 
            this.TablaLugares.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.TablaLugares.AllowUserToAddRows = false;
            this.TablaLugares.AllowUserToDeleteRows = false;
            this.TablaLugares.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.TablaLugares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaLugares.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TablaLugares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TablaLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaLugares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lugar,
            this.Disponibilidad});
            this.TablaLugares.Location = new System.Drawing.Point(28, 80);
            this.TablaLugares.Name = "TablaLugares";
            this.TablaLugares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaLugares.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaLugares.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaLugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TablaLugares.Size = new System.Drawing.Size(551, 91);
            this.TablaLugares.TabIndex = 2;
            this.TablaLugares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaLugares_CellContentClick);
            this.TablaLugares.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaLugares_CellValidated);
            this.TablaLugares.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TablaLugares_CellValidating);
            // 
            // Lugar
            // 
            this.Lugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.Name = "Disponibilidad";
            this.Disponibilidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // label_tituloLugar
            // 
            this.label_tituloLugar.AutoSize = true;
            this.label_tituloLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tituloLugar.Location = new System.Drawing.Point(3, 51);
            this.label_tituloLugar.Name = "label_tituloLugar";
            this.label_tituloLugar.Size = new System.Drawing.Size(289, 16);
            this.label_tituloLugar.TabIndex = 3;
            this.label_tituloLugar.Text = "Lugar de Realizacion de la Competencia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox_modalidad);
            this.panel3.Controls.Add(this.comboBox_formaPutuacion);
            this.panel3.Controls.Add(this.numericUpDown_tantos);
            this.panel3.Controls.Add(this.label_tantos);
            this.panel3.Controls.Add(this.numericUpDown_sets);
            this.panel3.Controls.Add(this.label_sets);
            this.panel3.Controls.Add(this.label_formaPutuacion);
            this.panel3.Controls.Add(this.numericUpDown_presencia);
            this.panel3.Controls.Add(this.label_presencia);
            this.panel3.Controls.Add(this.numericUpDown_partEmpatados);
            this.panel3.Controls.Add(this.label_partEmpatados);
            this.panel3.Controls.Add(this.comboBox_permiso);
            this.panel3.Controls.Add(this.label_permiso);
            this.panel3.Controls.Add(this.numericUpDown_partGanados);
            this.panel3.Controls.Add(this.label_partGanados);
            this.panel3.Controls.Add(this.label_modalidad);
            this.panel3.Location = new System.Drawing.Point(12, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 190);
            this.panel3.TabIndex = 15;
            // 
            // comboBox_modalidad
            // 
            this.comboBox_modalidad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_modalidad.FormattingEnabled = true;
            this.comboBox_modalidad.Location = new System.Drawing.Point(102, 12);
            this.comboBox_modalidad.Name = "comboBox_modalidad";
            this.comboBox_modalidad.Size = new System.Drawing.Size(200, 21);
            this.comboBox_modalidad.TabIndex = 3;
            this.comboBox_modalidad.SelectedIndexChanged += new System.EventHandler(this.comboBox_modalidad_SelectedIndexChanged);
            // 
            // comboBox_formaPutuacion
            // 
            this.comboBox_formaPutuacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_formaPutuacion.Enabled = false;
            this.comboBox_formaPutuacion.FormattingEnabled = true;
            this.comboBox_formaPutuacion.Items.AddRange(new object[] {
            "SETS",
            "PUNTUACION",
            "RESULTADO FINAL"});
            this.comboBox_formaPutuacion.Location = new System.Drawing.Point(183, 134);
            this.comboBox_formaPutuacion.Name = "comboBox_formaPutuacion";
            this.comboBox_formaPutuacion.Size = new System.Drawing.Size(92, 21);
            this.comboBox_formaPutuacion.TabIndex = 8;
            this.comboBox_formaPutuacion.SelectedIndexChanged += new System.EventHandler(this.comboBox_formaPutuacion_SelectedIndexChanged);
            // 
            // numericUpDown_tantos
            // 
            this.numericUpDown_tantos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDown_tantos.Enabled = false;
            this.numericUpDown_tantos.Location = new System.Drawing.Point(492, 162);
            this.numericUpDown_tantos.Name = "numericUpDown_tantos";
            this.numericUpDown_tantos.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_tantos.TabIndex = 10;
            // 
            // label_tantos
            // 
            this.label_tantos.AutoSize = true;
            this.label_tantos.Location = new System.Drawing.Point(323, 162);
            this.label_tantos.Name = "label_tantos";
            this.label_tantos.Size = new System.Drawing.Size(148, 13);
            this.label_tantos.TabIndex = 17;
            this.label_tantos.Text = "Cantidad de tantos Otorgados";
            // 
            // numericUpDown_sets
            // 
            this.numericUpDown_sets.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDown_sets.Enabled = false;
            this.numericUpDown_sets.Location = new System.Drawing.Point(228, 161);
            this.numericUpDown_sets.Name = "numericUpDown_sets";
            this.numericUpDown_sets.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_sets.TabIndex = 9;
            this.numericUpDown_sets.ValueChanged += new System.EventHandler(this.numericUpDown_sets_ValueChanged);
            // 
            // label_sets
            // 
            this.label_sets.AutoSize = true;
            this.label_sets.Location = new System.Drawing.Point(69, 163);
            this.label_sets.Name = "label_sets";
            this.label_sets.Size = new System.Drawing.Size(126, 13);
            this.label_sets.TabIndex = 15;
            this.label_sets.Text = "Cantidad maxima de Sets";
            // 
            // label_formaPutuacion
            // 
            this.label_formaPutuacion.AutoSize = true;
            this.label_formaPutuacion.Location = new System.Drawing.Point(69, 137);
            this.label_formaPutuacion.Name = "label_formaPutuacion";
            this.label_formaPutuacion.Size = new System.Drawing.Size(108, 13);
            this.label_formaPutuacion.TabIndex = 14;
            this.label_formaPutuacion.Text = "Forma de Puntuacion";
            // 
            // numericUpDown_presencia
            // 
            this.numericUpDown_presencia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDown_presencia.Enabled = false;
            this.numericUpDown_presencia.Location = new System.Drawing.Point(228, 108);
            this.numericUpDown_presencia.Name = "numericUpDown_presencia";
            this.numericUpDown_presencia.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_presencia.TabIndex = 7;
            this.numericUpDown_presencia.ValueChanged += new System.EventHandler(this.numericUpDown_presencia_ValueChanged);
            // 
            // label_presencia
            // 
            this.label_presencia.AutoSize = true;
            this.label_presencia.Location = new System.Drawing.Point(69, 110);
            this.label_presencia.Name = "label_presencia";
            this.label_presencia.Size = new System.Drawing.Size(108, 13);
            this.label_presencia.TabIndex = 12;
            this.label_presencia.Text = "Puntos por Presencia";
            // 
            // numericUpDown_partEmpatados
            // 
            this.numericUpDown_partEmpatados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDown_partEmpatados.Enabled = false;
            this.numericUpDown_partEmpatados.Location = new System.Drawing.Point(492, 80);
            this.numericUpDown_partEmpatados.Name = "numericUpDown_partEmpatados";
            this.numericUpDown_partEmpatados.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_partEmpatados.TabIndex = 6;
            this.numericUpDown_partEmpatados.ValueChanged += new System.EventHandler(this.numericUpDown_partEmpatados_ValueChanged);
            // 
            // label_partEmpatados
            // 
            this.label_partEmpatados.AutoSize = true;
            this.label_partEmpatados.Location = new System.Drawing.Point(323, 82);
            this.label_partEmpatados.Name = "label_partEmpatados";
            this.label_partEmpatados.Size = new System.Drawing.Size(154, 13);
            this.label_partEmpatados.TabIndex = 10;
            this.label_partEmpatados.Text = "Puntos por Partidos empatados";
            // 
            // comboBox_permiso
            // 
            this.comboBox_permiso.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_permiso.Enabled = false;
            this.comboBox_permiso.FormattingEnabled = true;
            this.comboBox_permiso.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboBox_permiso.Location = new System.Drawing.Point(183, 79);
            this.comboBox_permiso.Name = "comboBox_permiso";
            this.comboBox_permiso.Size = new System.Drawing.Size(92, 21);
            this.comboBox_permiso.TabIndex = 5;
            this.comboBox_permiso.SelectedIndexChanged += new System.EventHandler(this.comboBox_permiso_SelectedIndexChanged);
            // 
            // label_permiso
            // 
            this.label_permiso.AutoSize = true;
            this.label_permiso.Location = new System.Drawing.Point(69, 82);
            this.label_permiso.Name = "label_permiso";
            this.label_permiso.Size = new System.Drawing.Size(98, 13);
            this.label_permiso.TabIndex = 8;
            this.label_permiso.Text = "Permiso de Empate";
            // 
            // numericUpDown_partGanados
            // 
            this.numericUpDown_partGanados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDown_partGanados.Enabled = false;
            this.numericUpDown_partGanados.Location = new System.Drawing.Point(228, 52);
            this.numericUpDown_partGanados.Name = "numericUpDown_partGanados";
            this.numericUpDown_partGanados.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_partGanados.TabIndex = 4;
            this.numericUpDown_partGanados.ValueChanged += new System.EventHandler(this.numericUpDown_partGanados_ValueChanged);
            // 
            // label_partGanados
            // 
            this.label_partGanados.AutoSize = true;
            this.label_partGanados.Location = new System.Drawing.Point(69, 54);
            this.label_partGanados.Name = "label_partGanados";
            this.label_partGanados.Size = new System.Drawing.Size(143, 13);
            this.label_partGanados.TabIndex = 6;
            this.label_partGanados.Text = "Puntos por Partidos ganados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(111, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sistema de Competencias Deportivas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(*) Completar campos obligatorios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 661);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxReglamento
            // 
            this.textBoxReglamento.Location = new System.Drawing.Point(12, 437);
            this.textBoxReglamento.Multiline = true;
            this.textBoxReglamento.Name = "textBoxReglamento";
            this.textBoxReglamento.Size = new System.Drawing.Size(610, 179);
            this.textBoxReglamento.TabIndex = 1;
            this.textBoxReglamento.Text = "                                                                          Ingrese" +
    " reglamento";
            this.textBoxReglamento.TextChanged += new System.EventHandler(this.textBoxReglamento_TextChanged);
            // 
            // DarAltaCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.textBoxReglamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DarAltaCompetencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de Alta Competencia Deportiva";
            this.Load += new System.EventHandler(this.DarAltaCompetencia_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaLugares)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tantos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_presencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_partEmpatados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_partGanados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_deporte;
        private System.Windows.Forms.Label label_modalidad;
        private System.Windows.Forms.ComboBox comboBox_deporte;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_formaPutuacion;
        private System.Windows.Forms.NumericUpDown numericUpDown_tantos;
        private System.Windows.Forms.Label label_tantos;
        private System.Windows.Forms.NumericUpDown numericUpDown_sets;
        private System.Windows.Forms.Label label_sets;
        private System.Windows.Forms.Label label_formaPutuacion;
        private System.Windows.Forms.NumericUpDown numericUpDown_presencia;
        private System.Windows.Forms.Label label_presencia;
        private System.Windows.Forms.NumericUpDown numericUpDown_partEmpatados;
        private System.Windows.Forms.Label label_partEmpatados;
        private System.Windows.Forms.ComboBox comboBox_permiso;
        private System.Windows.Forms.Label label_permiso;
        private System.Windows.Forms.NumericUpDown numericUpDown_partGanados;
        private System.Windows.Forms.Label label_partGanados;
        private System.Windows.Forms.ComboBox comboBox_modalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tituloLugar;
        private System.Windows.Forms.DataGridView TablaLugares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.TextBox textBoxReglamento;
    }
}

