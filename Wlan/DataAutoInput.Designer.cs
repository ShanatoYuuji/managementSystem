namespace Wlan
{
    partial class DataAutoInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataAutoInput));
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label_tab = new System.Windows.Forms.Label();
            this.btn_on = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(133, 17);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(158, 21);
            this.txt_address.TabIndex = 0;
            // 
            // label_tab
            // 
            this.label_tab.AutoSize = true;
            this.label_tab.Location = new System.Drawing.Point(39, 23);
            this.label_tab.Name = "label_tab";
            this.label_tab.Size = new System.Drawing.Size(41, 12);
            this.label_tab.TabIndex = 1;
            this.label_tab.Text = "地址：";
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(31, 81);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(75, 23);
            this.btn_on.TabIndex = 2;
            this.btn_on.Text = "开始录入";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // DataAutoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 137);
            this.Controls.Add(this.btn_on);
            this.Controls.Add(this.label_tab);
            this.Controls.Add(this.txt_address);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataAutoInput";
            this.Text = "DataAutoInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label_tab;
        private System.Windows.Forms.Button btn_on;
    }
}