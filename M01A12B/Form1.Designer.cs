namespace M01A12B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnMos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(12, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(38, 15);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "label1";
            this.lblMsg.Visible = false;
            // 
            // btnMos
            // 
            this.btnMos.Location = new System.Drawing.Point(46, 78);
            this.btnMos.Name = "btnMos";
            this.btnMos.Size = new System.Drawing.Size(162, 36);
            this.btnMos.TabIndex = 1;
            this.btnMos.Text = "Mostrar";
            this.btnMos.UseVisualStyleBackColor = true;
            this.btnMos.Click += new System.EventHandler(this.btnMos_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMos;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 126);
            this.Controls.Add(this.btnMos);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMsg;
        private Button btnMos;
    }
}