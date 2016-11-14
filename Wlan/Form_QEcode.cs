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
        private int m = 0;
        private void btn_QEcode_Click(object sender, EventArgs e)
        {
            String text = txt_in.Text.Trim();

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;//设置生成的图片的样式
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;

            options.CharacterSet = "UTF-8";//内容编码

            options.Width = 250;//宽度
            options.Height = 250;//高度
            options.Margin = 1;//边距
            writer.Options = options;

            if (text != null && text != "")
            {
                Bitmap map = writer.Write(text);
                string filename = @"D:\generate1.png";
               
                map.Save(filename, ImageFormat.Png);
                map.Dispose();

            }
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            string pngaddress = @"D:\generate1.png";
            Bitmap bmp = new Bitmap(pngaddress);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            Graphics draw = Graphics.FromImage(bmp2);
            draw.DrawImage(bmp, 0, 0);

            this.PicB_show.Image = bmp2;
            draw.Dispose();
            bmp.Dispose();
            
           
        }
    }
}
