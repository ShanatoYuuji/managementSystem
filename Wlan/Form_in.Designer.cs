namespace Wlan
{
    partial class Form_in
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_in));
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.lab_change = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.tab_wlan = new System.Windows.Forms.TabControl();
            this.tab_pwaln = new System.Windows.Forms.TabPage();
            this.tabp_url = new System.Windows.Forms.TabPage();
            this.tab_ptime = new System.Windows.Forms.TabPage();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.dtp_close = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_know = new System.Windows.Forms.TextBox();
            this.btn_know = new System.Windows.Forms.Button();
            this.btn_db1 = new System.Windows.Forms.Button();
            this.tab_wlan.SuspendLayout();
            this.tab_pwaln.SuspendLayout();
            this.tabp_url.SuspendLayout();
            this.tab_ptime.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(8, 85);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(100, 23);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "加载开启无线网";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(177, 17);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(8, 131);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(99, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "关闭无线网";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(177, 46);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(100, 21);
            this.txt_pwd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "开启无线网名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "无线网密码(必须大于8位)";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(15, 34);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(100, 21);
            this.txt_url.TabIndex = 6;
            // 
            // lab_change
            // 
            this.lab_change.AutoSize = true;
            this.lab_change.Location = new System.Drawing.Point(13, 103);
            this.lab_change.Name = "lab_change";
            this.lab_change.Size = new System.Drawing.Size(89, 12);
            this.lab_change.TabIndex = 7;
            this.lab_change.Text = "神社转磁力链接";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(166, 32);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 8;
            this.btn_change.Text = "转链接";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.change_Click);
            // 
            // tab_wlan
            // 
            this.tab_wlan.Controls.Add(this.tab_pwaln);
            this.tab_wlan.Controls.Add(this.tabp_url);
            this.tab_wlan.Controls.Add(this.tab_ptime);
            this.tab_wlan.Controls.Add(this.tabPage1);
            this.tab_wlan.Location = new System.Drawing.Point(12, 12);
            this.tab_wlan.Name = "tab_wlan";
            this.tab_wlan.SelectedIndex = 0;
            this.tab_wlan.Size = new System.Drawing.Size(377, 224);
            this.tab_wlan.TabIndex = 10;
            // 
            // tab_pwaln
            // 
            this.tab_pwaln.Controls.Add(this.label1);
            this.tab_pwaln.Controls.Add(this.txt_name);
            this.tab_pwaln.Controls.Add(this.label2);
            this.tab_pwaln.Controls.Add(this.txt_pwd);
            this.tab_pwaln.Controls.Add(this.btn_close);
            this.tab_pwaln.Controls.Add(this.btn_open);
            this.tab_pwaln.Location = new System.Drawing.Point(4, 22);
            this.tab_pwaln.Name = "tab_pwaln";
            this.tab_pwaln.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pwaln.Size = new System.Drawing.Size(369, 198);
            this.tab_pwaln.TabIndex = 0;
            this.tab_pwaln.Text = "无线网用";
            this.tab_pwaln.UseVisualStyleBackColor = true;
            // 
            // tabp_url
            // 
            this.tabp_url.Controls.Add(this.btn_change);
            this.tabp_url.Controls.Add(this.lab_change);
            this.tabp_url.Controls.Add(this.txt_url);
            this.tabp_url.Location = new System.Drawing.Point(4, 22);
            this.tabp_url.Name = "tabp_url";
            this.tabp_url.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_url.Size = new System.Drawing.Size(339, 198);
            this.tabp_url.TabIndex = 1;
            this.tabp_url.Text = "磁力链接转换";
            this.tabp_url.UseVisualStyleBackColor = true;
            // 
            // tab_ptime
            // 
            this.tab_ptime.Controls.Add(this.btn_shutdown);
            this.tab_ptime.Controls.Add(this.dtp_close);
            this.tab_ptime.Location = new System.Drawing.Point(4, 22);
            this.tab_ptime.Name = "tab_ptime";
            this.tab_ptime.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ptime.Size = new System.Drawing.Size(339, 198);
            this.tab_ptime.TabIndex = 2;
            this.tab_ptime.Text = "定时关机";
            this.tab_ptime.UseVisualStyleBackColor = true;
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Location = new System.Drawing.Point(26, 125);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(75, 23);
            this.btn_shutdown.TabIndex = 1;
            this.btn_shutdown.Text = "定时关机";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.btn_shutdown_Click);
            // 
            // dtp_close
            // 
            this.dtp_close.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_close.Location = new System.Drawing.Point(26, 28);
            this.dtp_close.Name = "dtp_close";
            this.dtp_close.Size = new System.Drawing.Size(200, 21);
            this.dtp_close.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_know);
            this.tabPage1.Controls.Add(this.btn_know);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 198);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "闰年";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_know
            // 
            this.txt_know.Location = new System.Drawing.Point(40, 43);
            this.txt_know.Name = "txt_know";
            this.txt_know.Size = new System.Drawing.Size(100, 21);
            this.txt_know.TabIndex = 1;
            // 
            // btn_know
            // 
            this.btn_know.Location = new System.Drawing.Point(213, 131);
            this.btn_know.Name = "btn_know";
            this.btn_know.Size = new System.Drawing.Size(75, 23);
            this.btn_know.TabIndex = 0;
            this.btn_know.Text = "确定";
            this.btn_know.UseVisualStyleBackColor = true;
            this.btn_know.Click += new System.EventHandler(this.btn_know_Click);
            // 
            // btn_db1
            // 
            this.btn_db1.Location = new System.Drawing.Point(24, 261);
            this.btn_db1.Name = "btn_db1";
            this.btn_db1.Size = new System.Drawing.Size(75, 23);
            this.btn_db1.TabIndex = 11;
            this.btn_db1.Text = "db1";
            this.btn_db1.UseVisualStyleBackColor = true;
            this.btn_db1.Click += new System.EventHandler(this.btn_db1_Click);
            // 
            // Form_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 314);
            this.Controls.Add(this.btn_db1);
            this.Controls.Add(this.tab_wlan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_in";
            this.Text = "控制面";
            this.tab_wlan.ResumeLayout(false);
            this.tab_pwaln.ResumeLayout(false);
            this.tab_pwaln.PerformLayout();
            this.tabp_url.ResumeLayout(false);
            this.tabp_url.PerformLayout();
            this.tab_ptime.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label lab_change;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TabControl tab_wlan;
        private System.Windows.Forms.TabPage tab_pwaln;
        private System.Windows.Forms.TabPage tabp_url;
        private System.Windows.Forms.TabPage tab_ptime;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.DateTimePicker dtp_close;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_know;
        private System.Windows.Forms.Button btn_know;
        private System.Windows.Forms.Button btn_db1;
    }
}

