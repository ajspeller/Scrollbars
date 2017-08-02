namespace Scrollbars
{
    partial class FrmScrollbars
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
            this.HsbDemo = new System.Windows.Forms.HScrollBar();
            this.LblDemo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // HsbDemo
            // 
            this.HsbDemo.LargeChange = 1;
            this.HsbDemo.Location = new System.Drawing.Point(70, 53);
            this.HsbDemo.Maximum = 50;
            this.HsbDemo.Name = "HsbDemo";
            this.HsbDemo.Size = new System.Drawing.Size(329, 43);
            this.HsbDemo.TabIndex = 0;
            this.HsbDemo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbDemo_Scroll);
            // 
            // LblDemo
            // 
            this.LblDemo.AutoSize = true;
            this.LblDemo.Location = new System.Drawing.Point(119, 162);
            this.LblDemo.Name = "LblDemo";
            this.LblDemo.Size = new System.Drawing.Size(35, 13);
            this.LblDemo.TabIndex = 1;
            this.LblDemo.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 236);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(366, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // FrmScrollbars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 482);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LblDemo);
            this.Controls.Add(this.HsbDemo);
            this.Name = "FrmScrollbars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrollbars";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar HsbDemo;
        private System.Windows.Forms.Label LblDemo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

