using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace Wlan
{
    public partial class Form_QEcode : Form
    {
        public Form_QEcode()
        {
            InitializeComponent();
        }

        private void btn_QEcode_Click(object sender, EventArgs e)
        {
            String text = txt_in.Text.Trim();
           
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;//设置生成的图片的样式
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;

            options.CharacterSet = "UTF-8";//内容编码

            options.Width = 350;//宽度
            options.Height = 350;//高度

            options.Margin = 1;//边距
            writer.Options = options;

            Bitmap map = writer.Write(text);
            string filename = @"D:\generate1.png";
            map.Save(filename, ImageFormat.Png);
            map.Dispose();
        }
    }
}
