namespace Wlan
{
    partial class Form_QEcode
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
            this.btn_QEcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QEcode
            // 
            this.btn_QEcode.Location = new System.Drawing.Point(114, 361);
            this.btn_QEcode.Name = "btn_QEcode";
            this.btn_QEcode.Size = new System.Drawing.Size(75, 23);
            this.btn_QEcode.TabIndex = 0;
            this.btn_QEcode.Text = "二维码";
            this.btn_QEcode.UseVisualStyleBackColor = true;
            this.btn_QEcode.Click += new System.EventHandler(this.btn_QEcode_Click);
            // 
            // Form_QEcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 440);
            this.Controls.Add(this.btn_QEcode);
            this.Name = "Form_QEcode";
            this.Text = "Form_QEcode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QEcode;
    }
}