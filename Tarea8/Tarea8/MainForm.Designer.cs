namespace Tarea8
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructuraToolStripMenuItem,
            this.estructuraToolStripMenuItem1,
            this.estructuraToolStripMenuItem2,
            this.estructuraToolStripMenuItem3,
            this.estructuraToolStripMenuItem4});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // estructuraToolStripMenuItem
            // 
            this.estructuraToolStripMenuItem.Name = "estructuraToolStripMenuItem";
            this.estructuraToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.estructuraToolStripMenuItem.Text = "1- Estructura Guarda Productos";
            this.estructuraToolStripMenuItem.Click += new System.EventHandler(this.estructuraToolStripMenuItem_Click);
            // 
            // estructuraToolStripMenuItem1
            // 
            this.estructuraToolStripMenuItem1.Name = "estructuraToolStripMenuItem1";
            this.estructuraToolStripMenuItem1.Size = new System.Drawing.Size(360, 22);
            this.estructuraToolStripMenuItem1.Text = "2- Estructura Guarda Informacion Cunta Bancaria";
            this.estructuraToolStripMenuItem1.Click += new System.EventHandler(this.estructuraToolStripMenuItem1_Click);
            // 
            // estructuraToolStripMenuItem2
            // 
            this.estructuraToolStripMenuItem2.Name = "estructuraToolStripMenuItem2";
            this.estructuraToolStripMenuItem2.Size = new System.Drawing.Size(360, 22);
            this.estructuraToolStripMenuItem2.Text = "3- Estructura Guarda Informacion Mascota y su Dueno";
            this.estructuraToolStripMenuItem2.Click += new System.EventHandler(this.estructuraToolStripMenuItem2_Click);
            // 
            // estructuraToolStripMenuItem3
            // 
            this.estructuraToolStripMenuItem3.Name = "estructuraToolStripMenuItem3";
            this.estructuraToolStripMenuItem3.Size = new System.Drawing.Size(360, 22);
            this.estructuraToolStripMenuItem3.Text = "4- Estructura Tipos de Neumaticos";
            this.estructuraToolStripMenuItem3.Click += new System.EventHandler(this.estructuraToolStripMenuItem3_Click);
            // 
            // estructuraToolStripMenuItem4
            // 
            this.estructuraToolStripMenuItem4.Name = "estructuraToolStripMenuItem4";
            this.estructuraToolStripMenuItem4.Size = new System.Drawing.Size(360, 22);
            this.estructuraToolStripMenuItem4.Text = "5- Estructura Tipos de Estrellas ";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 397);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estructuraToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem estructuraToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem estructuraToolStripMenuItem4;
    }
}

