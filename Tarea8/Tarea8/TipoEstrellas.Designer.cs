namespace Tarea8
{
    partial class TipoEstrellas
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
            this.TipoButton = new System.Windows.Forms.Button();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.TipoEstrellasListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TipoButton
            // 
            this.TipoButton.Location = new System.Drawing.Point(61, 100);
            this.TipoButton.Name = "TipoButton";
            this.TipoButton.Size = new System.Drawing.Size(120, 23);
            this.TipoButton.TabIndex = 0;
            this.TipoButton.Text = "Tipo de Estrellas";
            this.TipoButton.UseVisualStyleBackColor = true;
            this.TipoButton.Click += new System.EventHandler(this.TipoButton_Click);
            // 
            // TipoLabel
            // 
            this.TipoLabel.AutoSize = true;
            this.TipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoLabel.Location = new System.Drawing.Point(220, 21);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(161, 24);
            this.TipoLabel.TabIndex = 1;
            this.TipoLabel.Text = "Tipos De Estrellas";
            // 
            // TipoEstrellasListBox
            // 
            this.TipoEstrellasListBox.FormattingEnabled = true;
            this.TipoEstrellasListBox.Location = new System.Drawing.Point(61, 180);
            this.TipoEstrellasListBox.Name = "TipoEstrellasListBox";
            this.TipoEstrellasListBox.Size = new System.Drawing.Size(276, 134);
            this.TipoEstrellasListBox.TabIndex = 2;
            // 
            // TipoEstrellas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 338);
            this.Controls.Add(this.TipoEstrellasListBox);
            this.Controls.Add(this.TipoLabel);
            this.Controls.Add(this.TipoButton);
            this.Name = "TipoEstrellas";
            this.Text = "TipoEstrellas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TipoButton;
        private System.Windows.Forms.Label TipoLabel;
        private System.Windows.Forms.ListBox TipoEstrellasListBox;
    }
}