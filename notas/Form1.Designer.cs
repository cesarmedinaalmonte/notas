namespace notas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePreSeleccionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaHistoricoAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePreSeleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 358);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE ASIGNATURAS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Consulta de Calificaciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 446);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(509, 37);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.consultaDePreSeleccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F);
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDePreSeleccionToolStripMenuItem1,
            this.consultaDeCalificacionesToolStripMenuItem,
            this.consultaHistoricoAcademicoToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial", 12F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 25);
            this.toolStripMenuItem1.Text = "Consultas ";
            // 
            // consultaDePreSeleccionToolStripMenuItem1
            // 
            this.consultaDePreSeleccionToolStripMenuItem1.Name = "consultaDePreSeleccionToolStripMenuItem1";
            this.consultaDePreSeleccionToolStripMenuItem1.Size = new System.Drawing.Size(286, 22);
            this.consultaDePreSeleccionToolStripMenuItem1.Text = "Consulta de Calificaciones";
            // 
            // consultaDeCalificacionesToolStripMenuItem
            // 
            this.consultaDeCalificacionesToolStripMenuItem.Name = "consultaDeCalificacionesToolStripMenuItem";
            this.consultaDeCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.consultaDeCalificacionesToolStripMenuItem.Text = "Consulta de Pre/ Seleccion";
            this.consultaDeCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeCalificacionesToolStripMenuItem_Click);
            // 
            // consultaHistoricoAcademicoToolStripMenuItem
            // 
            this.consultaHistoricoAcademicoToolStripMenuItem.Name = "consultaHistoricoAcademicoToolStripMenuItem";
            this.consultaHistoricoAcademicoToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.consultaHistoricoAcademicoToolStripMenuItem.Text = "Consulta Historico Academico";
            this.consultaHistoricoAcademicoToolStripMenuItem.Click += new System.EventHandler(this.consultaHistoricoAcademicoToolStripMenuItem_Click);
            // 
            // consultaDePreSeleccionToolStripMenuItem
            // 
            this.consultaDePreSeleccionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.consultaDePreSeleccionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultaDePreSeleccionToolStripMenuItem.Name = "consultaDePreSeleccionToolStripMenuItem";
            this.consultaDePreSeleccionToolStripMenuItem.Size = new System.Drawing.Size(215, 25);
            this.consultaDePreSeleccionToolStripMenuItem.Text = "Preseleccion de Asignaturas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaDePreSeleccionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeCalificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePreSeleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaHistoricoAcademicoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

