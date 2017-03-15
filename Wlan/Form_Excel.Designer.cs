namespace Wlan
{
    partial class Form_Excel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_address = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(26, 234);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(100, 21);
            this.txt_address1.TabIndex = 1;
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(255, 234);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(100, 21);
            this.txt_address2.TabIndex = 2;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(161, 175);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "→";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_address
            // 
            this.btn_address.Location = new System.Drawing.Point(440, 232);
            this.btn_address.Name = "btn_address";
            this.btn_address.Size = new System.Drawing.Size(75, 23);
            this.btn_address.TabIndex = 4;
            this.btn_address.Text = "btn_address";
            this.btn_address.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(161, 288);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "←";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(341, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(440, 279);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 21);
            this.txt_price.TabIndex = 7;
            // 
            // Form_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 373);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_address);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.txt_address2);
            this.Controls.Add(this.txt_address1);
            this.Controls.Add(this.label1);
            this.Name = "Form_Excel";
            this.Text = "Form_Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_address;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txt_price;
    }
}