namespace interfaces
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
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.pictureRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureMaximizar = new System.Windows.Forms.PictureBox();
            this.pictureMinimizar = new System.Windows.Forms.PictureBox();
            this.btCerrar = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelSubReporte = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnrepEstudiantes = new System.Windows.Forms.Button();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.panelSubReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.barraTitulo.Controls.Add(this.pictureRestaurar);
            this.barraTitulo.Controls.Add(this.pictureMaximizar);
            this.barraTitulo.Controls.Add(this.pictureMinimizar);
            this.barraTitulo.Controls.Add(this.btCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1365, 47);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // pictureRestaurar
            // 
            this.pictureRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureRestaurar.Image")));
            this.pictureRestaurar.Location = new System.Drawing.Point(1275, 10);
            this.pictureRestaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureRestaurar.Name = "pictureRestaurar";
            this.pictureRestaurar.Size = new System.Drawing.Size(33, 31);
            this.pictureRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRestaurar.TabIndex = 3;
            this.pictureRestaurar.TabStop = false;
            this.pictureRestaurar.Visible = false;
            this.pictureRestaurar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureMaximizar
            // 
            this.pictureMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureMaximizar.Image")));
            this.pictureMaximizar.Location = new System.Drawing.Point(1275, 10);
            this.pictureMaximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureMaximizar.Name = "pictureMaximizar";
            this.pictureMaximizar.Size = new System.Drawing.Size(33, 31);
            this.pictureMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMaximizar.TabIndex = 2;
            this.pictureMaximizar.TabStop = false;
            this.pictureMaximizar.Click += new System.EventHandler(this.pictureMaximizar_Click);
            // 
            // pictureMinimizar
            // 
            this.pictureMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimizar.Image")));
            this.pictureMinimizar.Location = new System.Drawing.Point(1233, 10);
            this.pictureMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureMinimizar.Name = "pictureMinimizar";
            this.pictureMinimizar.Size = new System.Drawing.Size(33, 31);
            this.pictureMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimizar.TabIndex = 1;
            this.pictureMinimizar.TabStop = false;
            this.pictureMinimizar.Click += new System.EventHandler(this.pictureMinimizar_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btCerrar.Image")));
            this.btCerrar.Location = new System.Drawing.Point(1316, 10);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(33, 31);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 0;
            this.btCerrar.TabStop = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.panelSubReporte);
            this.menuVertical.Controls.Add(this.panel3);
            this.menuVertical.Controls.Add(this.btnReportes);
            this.menuVertical.Controls.Add(this.panel2);
            this.menuVertical.Controls.Add(this.button2);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 47);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(293, 898);
            this.menuVertical.TabIndex = 1;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Estudiantes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(293, 47);
            this.panelcontenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1072, 898);
            this.panelcontenedor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(3, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(3, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 44);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Categorías";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(3, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 44);
            this.panel3.TabIndex = 3;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(13, 233);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(276, 44);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSubReporte
            // 
            this.panelSubReporte.Controls.Add(this.panel5);
            this.panelSubReporte.Controls.Add(this.btnrepEstudiantes);
            this.panelSubReporte.Location = new System.Drawing.Point(31, 284);
            this.panelSubReporte.Name = "panelSubReporte";
            this.panelSubReporte.Size = new System.Drawing.Size(262, 132);
            this.panelSubReporte.TabIndex = 0;
            this.panelSubReporte.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(-6, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 44);
            this.panel5.TabIndex = 5;
            // 
            // btnrepEstudiantes
            // 
            this.btnrepEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnrepEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnrepEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrepEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrepEstudiantes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepEstudiantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrepEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnrepEstudiantes.Image")));
            this.btnrepEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrepEstudiantes.Location = new System.Drawing.Point(4, 4);
            this.btnrepEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.btnrepEstudiantes.Name = "btnrepEstudiantes";
            this.btnrepEstudiantes.Size = new System.Drawing.Size(258, 44);
            this.btnrepEstudiantes.TabIndex = 6;
            this.btnrepEstudiantes.Text = "Reportes Estudiantes";
            this.btnrepEstudiantes.UseVisualStyleBackColor = false;
            this.btnrepEstudiantes.Click += new System.EventHandler(this.btnrepEstudiantes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 945);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.panelSubReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox btCerrar;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox pictureMaximizar;
        private System.Windows.Forms.PictureBox pictureMinimizar;
        private System.Windows.Forms.PictureBox pictureRestaurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelSubReporte;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnrepEstudiantes;
    }
}

