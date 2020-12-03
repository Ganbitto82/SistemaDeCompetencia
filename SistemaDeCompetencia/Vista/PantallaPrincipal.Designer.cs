namespace SistemaDeCompetencia.Vista
{
    partial class PantallaPrincipal
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
            this.button_cu03 = new System.Windows.Forms.Button();
            this.button_cu07 = new System.Windows.Forms.Button();
            this.button_cu13 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cu03
            // 
            this.button_cu03.BackColor = System.Drawing.Color.Black;
            this.button_cu03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cu03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cu03.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cu03.Location = new System.Drawing.Point(10, 237);
            this.button_cu03.Name = "button_cu03";
            this.button_cu03.Size = new System.Drawing.Size(127, 45);
            this.button_cu03.TabIndex = 19;
            this.button_cu03.Text = "Listar Competencias Deportivas";
            this.button_cu03.UseVisualStyleBackColor = false;
            this.button_cu03.Click += new System.EventHandler(this.button_cu03_Click);
            // 
            // button_cu07
            // 
            this.button_cu07.BackColor = System.Drawing.Color.Black;
            this.button_cu07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cu07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cu07.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cu07.Location = new System.Drawing.Point(10, 288);
            this.button_cu07.Name = "button_cu07";
            this.button_cu07.Size = new System.Drawing.Size(127, 45);
            this.button_cu07.TabIndex = 20;
            this.button_cu07.Text = "Modificar datos de Usuario";
            this.button_cu07.UseVisualStyleBackColor = false;
            this.button_cu07.Click += new System.EventHandler(this.button_cu07_Click);
            // 
            // button_cu13
            // 
            this.button_cu13.BackColor = System.Drawing.Color.Black;
            this.button_cu13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cu13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cu13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_cu13.Location = new System.Drawing.Point(10, 186);
            this.button_cu13.Name = "button_cu13";
            this.button_cu13.Size = new System.Drawing.Size(127, 45);
            this.button_cu13.TabIndex = 21;
            this.button_cu13.Text = "Listar Lugares de Realizacion";
            this.button_cu13.UseVisualStyleBackColor = false;
            this.button_cu13.Click += new System.EventHandler(this.button_cu13_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaDeCompetencia.Properties.Resources.inicio2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cu13);
            this.Controls.Add(this.button_cu07);
            this.Controls.Add(this.button_cu03);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cu03;
        private System.Windows.Forms.Button button_cu07;
        private System.Windows.Forms.Button button_cu13;
        private System.Windows.Forms.Button button1;
    }
}