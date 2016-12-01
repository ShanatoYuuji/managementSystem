using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wlan
{
    
    public partial class Form_Crawler : Form
    {
        int count = 0;
        public Form_Crawler()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            int pageCount = 2;
            string keyword = "lat";
            for(int i = 0; i < pageCount; i++)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(
                    "http://image.baidu.com/search/index?tn=baiduimage&ipn=r&ct=201326592&cl=2&lm=-1&st=-1&fm=result&fr=&sf=1&fmq=1466307565574_R&pv=&ic=0&nc=1&z=&se=1&showtab=0&fb=0&width=&height=&face=0&istype=2&ie=utf-8&word=" + keyword.ToString());
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                }
            }
        }
        
    }
}
