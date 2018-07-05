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
            this.panelEstudiante = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelSubReporte = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnrepEstudiantes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.panelEstudiante.SuspendLayout();
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
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1024, 38);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // pictureRestaurar
            // 
            this.pictureRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pictureRestaurar.Image")));
            this.pictureRestaurar.Location = new System.Drawing.Point(956, 8);
            this.pictureRestaurar.Name = "pictureRestaurar";
            this.pictureRestaurar.Size = new System.Drawing.Size(25, 25);
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
            this.pictureMaximizar.Location = new System.Drawing.Point(956, 8);
            this.pictureMaximizar.Name = "pictureMaximizar";
            this.pictureMaximizar.Size = new System.Drawing.Size(25, 25);
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
            this.pictureMinimizar.Location = new System.Drawing.Point(925, 8);
            this.pictureMinimizar.Name = "pictureMinimizar";
            this.pictureMinimizar.Size = new System.Drawing.Size(25, 25);
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
            this.btCerrar.Location = new System.Drawing.Point(987, 8);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(25, 25);
            this.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btCerrar.TabIndex = 0;
            this.btCerrar.TabStop = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.panelEstudiante);
            this.menuVertical.Controls.Add(this.panelSubReporte);
            this.menuVertical.Controls.Add(this.panel3);
            this.menuVertical.Controls.Add(this.btnReportes);
            this.menuVertical.Controls.Add(this.panel2);
            this.menuVertical.Controls.Add(this.button2);
            this.menuVertical.Controls.Add(this.panel1);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 38);
            this.menuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(220, 730);
            this.menuVertical.TabIndex = 1;
            this.menuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.menuVertical_Paint);
            // 
            // panelEstudiante
            // 
            this.panelEstudiante.Controls.Add(this.panel7);
            this.panelEstudiante.Controls.Add(this.panel6);
            this.panelEstudiante.Controls.Add(this.button4);
            this.panelEstudiante.Controls.Add(this.button3);
            this.panelEstudiante.Location = new System.Drawing.Point(24, 97);
            this.panelEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.panelEstudiante.Name = "panelEstudiante";
            this.panelEstudiante.Size = new System.Drawing.Size(196, 122);
            this.panelEstudiante.TabIndex = 5;
            this.panelEstudiante.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Blue;
            this.panel7.Location = new System.Drawing.Point(-5, 33);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 36);
            this.panel7.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(-4, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 36);
            this.panel6.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(2, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Modificar Estudiantes";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Insertar Estudiantes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelSubReporte
            // 
            this.panelSubReporte.Controls.Add(this.panel5);
            this.panelSubReporte.Controls.Add(this.btnrepEstudiantes);
            this.panelSubReporte.Location = new System.Drawing.Point(24, 324);
            this.panelSubReporte.Margin = new System.Windows.Forms.Padding(2);
            this.panelSubReporte.Name = "panelSubReporte";
            this.panelSubReporte.Size = new System.Drawing.Size(196, 107);
            this.panelSubReporte.TabIndex = 0;
            this.panelSubReporte.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(-4, 3);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 36);
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
            this.btnrepEstudiantes.Location = new System.Drawing.Point(3, 3);
            this.btnrepEstudiantes.Name = "btnrepEstudiantes";
            this.btnrepEstudiantes.Size = new System.Drawing.Size(194, 36);
            this.btnrepEstudiantes.TabIndex = 6;
            this.btnrepEstudiantes.Text = "Reportes Estudiantes";
            this.btnrepEstudiantes.UseVisualStyleBackColor = false;
            this.btnrepEstudiantes.Click += new System.EventHandler(this.btnrepEstudiantes_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(2, 283);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 36);
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
            this.btnReportes.Location = new System.Drawing.Point(10, 283);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(207, 36);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(2, 241);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 36);
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
            this.button2.Location = new System.Drawing.Point(10, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Categorías";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(2, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 36);
            this.panel1.TabIndex = 0;
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
            this.button1.Location = new System.Drawing.Point(10, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Estudiantes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(220, 38);
            this.panelcontenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(804, 730);
            this.panelcontenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCerrar)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.panelEstudiante.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelEstudiante;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}

