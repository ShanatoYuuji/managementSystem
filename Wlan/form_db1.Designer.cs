namespace Wlan
{
    partial class Form_db1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_db1));
            this.Dgv_db1 = new System.Windows.Forms.DataGridView();
            this.btn_select_all = new System.Windows.Forms.Button();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.btn_cmd = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_cnname = new System.Windows.Forms.TextBox();
            this.txt_staff = new System.Windows.Forms.TextBox();
            this.txt_LocalLink = new System.Windows.Forms.TextBox();
            this.txt_D_link = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_in_author = new System.Windows.Forms.TextBox();
            this.txt_in_Dlink = new System.Windows.Forms.TextBox();
            this.txt_in_locallink = new System.Windows.Forms.TextBox();
            this.txt_in_staff = new System.Windows.Forms.TextBox();
            this.txt_in_cnname = new System.Windows.Forms.TextBox();
            this.txt_in_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_auto_input = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_db1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_db1
            // 
            this.Dgv_db1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_db1.Location = new System.Drawing.Point(12, 12);
            this.Dgv_db1.Name = "Dgv_db1";
            this.Dgv_db1.RowTemplate.Height = 23;
            this.Dgv_db1.Size = new System.Drawing.Size(744, 209);
            this.Dgv_db1.TabIndex = 0;
            this.Dgv_db1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_db1_CellClick);
            // 
            // btn_select_all
            // 
            this.btn_select_all.Location = new System.Drawing.Point(12, 473);
            this.btn_select_all.Name = "btn_select_all";
            this.btn_select_all.Size = new System.Drawing.Size(75, 23);
            this.btn_select_all.TabIndex = 1;
            this.btn_select_all.Text = "全部显示";
            this.btn_select_all.UseVisualStyleBackColor = true;
            this.btn_select_all.Click += new System.EventHandler(this.btn_select_all_Click);
            // 
            // txt_cmd
            // 
            this.txt_cmd.Location = new System.Drawing.Point(12, 227);
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.Size = new System.Drawing.Size(744, 21);
            this.txt_cmd.TabIndex = 2;
            // 
            // btn_cmd
            // 
            this.btn_cmd.Location = new System.Drawing.Point(135, 473);
            this.btn_cmd.Name = "btn_cmd";
            this.btn_cmd.Size = new System.Drawing.Size(75, 23);
            this.btn_cmd.TabIndex = 3;
            this.btn_cmd.Text = "执行命令";
            this.btn_cmd.UseVisualStyleBackColor = true;
            this.btn_cmd.Click += new System.EventHandler(this.btn_cmd_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(258, 473);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "打开地址";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "名字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "中文名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Staff：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "本地地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "磁力链接：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "作者：";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(381, 473);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "修改";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(504, 473);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "插入";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(100, 260);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 13;
            // 
            // txt_cnname
            // 
            this.txt_cnname.Location = new System.Drawing.Point(100, 293);
            this.txt_cnname.Name = "txt_cnname";
            this.txt_cnname.Size = new System.Drawing.Size(100, 21);
            this.txt_cnname.TabIndex = 14;
            // 
            // txt_staff
            // 
            this.txt_staff.Location = new System.Drawing.Point(100, 326);
            this.txt_staff.Name = "txt_staff";
            this.txt_staff.Size = new System.Drawing.Size(100, 21);
            this.txt_staff.TabIndex = 15;
            // 
            // txt_LocalLink
            // 
            this.txt_LocalLink.Location = new System.Drawing.Point(100, 359);
            this.txt_LocalLink.Name = "txt_LocalLink";
            this.txt_LocalLink.Size = new System.Drawing.Size(100, 21);
            this.txt_LocalLink.TabIndex = 16;
            // 
            // txt_D_link
            // 
            this.txt_D_link.Location = new System.Drawing.Point(100, 392);
            this.txt_D_link.Name = "txt_D_link";
            this.txt_D_link.Size = new System.Drawing.Size(100, 21);
            this.txt_D_link.TabIndex = 17;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(100, 425);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(100, 21);
            this.txt_author.TabIndex = 18;
            // 
            // txt_in_author
            // 
            this.txt_in_author.Location = new System.Drawing.Point(572, 419);
            this.txt_in_author.Name = "txt_in_author";
            this.txt_in_author.Size = new System.Drawing.Size(100, 21);
            this.txt_in_author.TabIndex = 24;
            // 
            // txt_in_Dlink
            // 
            this.txt_in_Dlink.Location = new System.Drawing.Point(572, 386);
            this.txt_in_Dlink.Name = "txt_in_Dlink";
            this.txt_in_Dlink.Size = new System.Drawing.Size(100, 21);
            this.txt_in_Dlink.TabIndex = 23;
            // 
            // txt_in_locallink
            // 
            this.txt_in_locallink.Location = new System.Drawing.Point(572, 353);
            this.txt_in_locallink.Name = "txt_in_locallink";
            this.txt_in_locallink.Size = new System.Drawing.Size(100, 21);
            this.txt_in_locallink.TabIndex = 22;
            // 
            // txt_in_staff
            // 
            this.txt_in_staff.Location = new System.Drawing.Point(572, 320);
            this.txt_in_staff.Name = "txt_in_staff";
            this.txt_in_staff.Size = new System.Drawing.Size(100, 21);
            this.txt_in_staff.TabIndex = 21;
            // 
            // txt_in_cnname
            // 
            this.txt_in_cnname.Location = new System.Drawing.Point(572, 287);
            this.txt_in_cnname.Name = "txt_in_cnname";
            this.txt_in_cnname.Size = new System.Drawing.Size(100, 21);
            this.txt_in_cnname.TabIndex = 20;
            // 
            // txt_in_name
            // 
            this.txt_in_name.Location = new System.Drawing.Point(572, 254);
            this.txt_in_name.Name = "txt_in_name";
            this.txt_in_name.Size = new System.Drawing.Size(100, 21);
            this.txt_in_name.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "作者：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "磁力链接：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "本地地址：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "Staff：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "中文名：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "名字：";
            // 
            // btn_auto_input
            // 
            this.btn_auto_input.Location = new System.Drawing.Point(627, 473);
            this.btn_auto_input.Name = "btn_auto_input";
            this.btn_auto_input.Size = new System.Drawing.Size(75, 23);
            this.btn_auto_input.TabIndex = 31;
            this.btn_auto_input.Text = "自动录入";
            this.btn_auto_input.UseVisualStyleBackColor = true;
            this.btn_auto_input.Click += new System.EventHandler(this.btn_auto_input_Click);
            // 
            // Form_db1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 521);
            this.Controls.Add(this.btn_auto_input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_in_author);
            this.Controls.Add(this.txt_in_Dlink);
            this.Controls.Add(this.txt_in_locallink);
            this.Controls.Add(this.txt_in_staff);
            this.Controls.Add(this.txt_in_cnname);
            this.Controls.Add(this.txt_in_name);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_D_link);
            this.Controls.Add(this.txt_LocalLink);
            this.Controls.Add(this.txt_staff);
            this.Controls.Add(this.txt_cnname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_cmd);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.btn_select_all);
            this.Controls.Add(this.Dgv_db1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_db1";
            this.Text = "form_db1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_db1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_db1;
        private System.Windows.Forms.Button btn_select_all;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.Button btn_cmd;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_cnname;
        private System.Windows.Forms.TextBox txt_staff;
        private System.Windows.Forms.TextBox txt_LocalLink;
        private System.Windows.Forms.TextBox txt_D_link;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_in_author;
        private System.Windows.Forms.TextBox txt_in_Dlink;
        private System.Windows.Forms.TextBox txt_in_locallink;
        private System.Windows.Forms.TextBox txt_in_staff;
        private System.Windows.Forms.TextBox txt_in_cnname;
        private System.Windows.Forms.TextBox txt_in_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_auto_input;
    }
}