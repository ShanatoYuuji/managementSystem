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
            this.txt_in = new System.Windows.Forms.TextBox();
            this.lab_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_QEcode
            // 
            this.btn_QEcode.Location = new System.Drawing.Point(272, 211);
            this.btn_QEcode.Name = "btn_QEcode";
            this.btn_QEcode.Size = new System.Drawing.Size(75, 23);
            this.btn_QEcode.TabIndex = 0;
            this.btn_QEcode.Text = "二维码";
            this.btn_QEcode.UseVisualStyleBackColor = true;
            this.btn_QEcode.Click += new System.EventHandler(this.btn_QEcode_Click);
            // 
            // txt_in
            // 
            this.txt_in.Location = new System.Drawing.Point(196, 119);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(261, 21);
            this.txt_in.TabIndex = 1;
            // 
            // lab_txt
            // 
            this.lab_txt.AutoSize = true;
            this.lab_txt.Location = new System.Drawing.Point(35, 122);
            this.lab_txt.Name = "lab_txt";
            this.lab_txt.Size = new System.Drawing.Size(113, 12);
            this.lab_txt.TabIndex = 2;
            this.lab_txt.Text = "请输入你要的语句：";
            // 
            // Form_QEcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 323);
            this.Controls.Add(this.lab_txt);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.btn_QEcode);
            this.Name = "Form_QEcode";
            this.Text = "Form_QEcode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QEcode;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Label lab_txt;
    }
}