using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Wlan.DataAutoInput;

namespace Wlan
{
    public partial class Form_pwd_confirm : Form
    {
        private pwdconfirm confirm;
        public Form_pwd_confirm(pwdconfirm confirm)
        {
            InitializeComponent();
            this.confirm = confirm;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int pwd=Int32.Parse( txt_pwd.Text.Trim());
            confirm(pwd);
        }
    }
}
