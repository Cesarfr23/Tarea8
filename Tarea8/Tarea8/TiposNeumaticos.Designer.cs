namespace Tarea8
{
    partial class TiposNeumaticos
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
            this.TiposListBox = new System.Windows.Forms.ListBox();
            this.TiposButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TiposListBox
            // 
            this.TiposListBox.FormattingEnabled = true;
            this.TiposListBox.Location = new System.Drawing.Point(37, 154);
            this.TiposListBox.Name = "TiposListBox";
            this.TiposListBox.Size = new System.Drawing.Size(462, 160);
            this.TiposListBox.TabIndex = 0;
            // 
            // TiposButton
            // 
            this.TiposButton.Location = new System.Drawing.Point(37, 80);
            this.TiposButton.Name = "TiposButton";
            this.TiposButton.Size = new System.Drawing.Size(75, 23);
            this.TiposButton.TabIndex = 1;
            this.TiposButton.Text = "Tipos";
            this.TiposButton.UseVisualStyleBackColor = true;
            this.TiposButton.Click += new System.EventHandler(this.TiposButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipos De Neumaticos";
            // 
            // TiposNeumaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TiposButton);
            this.Controls.Add(this.TiposListBox);
            this.Name = "TiposNeumaticos";
            this.Text = "TiposNeumaticos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TiposListBox;
        private System.Windows.Forms.Button TiposButton;
        private System.Windows.Forms.Label label1;
    }
}