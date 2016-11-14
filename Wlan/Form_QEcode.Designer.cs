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
            this.btn_show = new System.Windows.Forms.Button();
            this.PicB_show = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicB_show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_QEcode
            // 
            this.btn_QEcode.Location = new System.Drawing.Point(398, 158);
            this.btn_QEcode.Name = "btn_QEcode";
            this.btn_QEcode.Size = new System.Drawing.Size(75, 23);
            this.btn_QEcode.TabIndex = 0;
            this.btn_QEcode.Text = "生成二维码";
            this.btn_QEcode.UseVisualStyleBackColor = true;
            this.btn_QEcode.Click += new System.EventHandler(this.btn_QEcode_Click);
            // 
            // txt_in
            // 
            this.txt_in.Location = new System.Drawing.Point(398, 102);
            this.txt_in.Name = "txt_in";
            this.txt_in.Size = new System.Drawing.Size(261, 21);
            this.txt_in.TabIndex = 1;
            // 
            // lab_txt
            // 
            this.lab_txt.AutoSize = true;
            this.lab_txt.Location = new System.Drawing.Point(396, 38);
            this.lab_txt.Name = "lab_txt";
            this.lab_txt.Size = new System.Drawing.Size(113, 12);
            this.lab_txt.TabIndex = 2;
            this.lab_txt.Text = "请输入你要的语句：";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(398, 238);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 3;
            this.btn_show.Text = "显示二维码";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // PicB_show
            // 
            this.PicB_show.Location = new System.Drawing.Point(77, 24);
            this.PicB_show.Name = "PicB_show";
            this.PicB_show.Size = new System.Drawing.Size(250, 250);
            this.PicB_show.TabIndex = 4;
            this.PicB_show.TabStop = false;
            // 
            // Form_QEcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 338);
            this.Controls.Add(this.PicB_show);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lab_txt);
            this.Controls.Add(this.txt_in);
            this.Controls.Add(this.btn_QEcode);
            this.Name = "Form_QEcode";
            this.Text = "Form_QEcode";
            ((System.ComponentModel.ISupportInitialize)(this.PicB_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QEcode;
        private System.Windows.Forms.TextBox txt_in;
        private System.Windows.Forms.Label lab_txt;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.PictureBox PicB_show;
    }
}