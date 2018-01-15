using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using System.Drawing.Imaging;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Security.Cryptography;

namespace BatchToqrcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbpwd.Visible = false;
            btpwd.Visible = false;
            tburls.ReadOnly = true;
            
        }


        private void tburls_Click(object sender, EventArgs e)
        {
            if (tburls.ReadOnly == true)
            {
                tbpwd.Visible = true;
                btpwd.Visible = true;
            }
           
        }

        private void tbpwd_Click(object sender, EventArgs e)
        {
            tbpwd.Text = "";
        }

        private void btpwd_Click(object sender, EventArgs e)
        {
            if (tbpwd.Visible)
            {
                if (tbpwd.Text == "")
                {
                    MessageBox.Show("解锁密码不能为空");
                    tbpwd.Focus();
                    return;
                }

                if (tbpwd.Text.Length < 6)
                {
                    MessageBox.Show("解锁密码太短");
                    tbpwd.Focus();
                    return;
                }

                string input = tbpwd.Text.Trim();

                byte[] result = Encoding.Default.GetBytes(input);    //tbPass为输入密码的文本框
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(result);
                string pwdstr = BitConverter.ToString(output).Replace("-", "");  //tbMd5pass为输出加密文本的文本框


                if (pwdstr == "C8C2D00CE9CA0FFDF6B07D41B1B79858")
                {
                    tburls.ReadOnly = false;
                    tbpwd.Visible = false;
                    btpwd.Visible = false;
                }
                else {
                    MessageBox.Show("解锁密码有误");
                    tbpwd.Focus();
                    return;
                }

            }
            else {
                MessageBox.Show("非法解锁");
                btpwd.Visible = false;
                return;
            }
           
        }

       

        private void tbbgno_Leave(object sender, EventArgs e)
        {
            if (tbbgno.Text == "")
            {
                MessageBox.Show("起始编号不能为空");
                tbbgno.Focus();
                return;
            }

            string pattern = @"^\d*$";
            if (!Regex.IsMatch(tbbgno.Text, pattern)) {
                MessageBox.Show("起始编号为正整数");
                tbbgno.Focus();
                tbbgno.Text = "";
                return;
            }


            if (Convert.ToInt32(tbbgno.Text) == 0)
            {
                MessageBox.Show("起始编号不能为零");
                tbbgno.Focus();
                tbbgno.Text = "";
                return;
            }


            if (Convert.ToInt32(tbbgno.Text) < 0)
            {
                MessageBox.Show("起始编号应大于零");
                tbbgno.Focus();
                tbbgno.Text = "";
                return;
            }  

            Int32 bgno = Convert.ToInt32(tbbgno.Text);
            int no = Convert.ToInt32(tbno.Text);

            tbendno.Text = (bgno + no-1).ToString();
        }

        private void tbno_Leave(object sender, EventArgs e)
        {
            if (tbno.Text == "")
            {
                MessageBox.Show("数量不能为空");
                tbno.Focus();
                return;
            }

            string pattern = @"^\d*$";
            if (!Regex.IsMatch(tbno.Text, pattern))
            {
                MessageBox.Show("数量为正整数");
                tbno.Focus();
                tbno.Text = "";
                return;
            }

            if (Convert.ToInt32(tbno.Text) == 0)
            {
                MessageBox.Show("数量不能为零");
                tbno.Focus();
                tbno.Text = "";
                return;
            }


            if (Convert.ToInt32(tbno.Text) < 0)
            {
                MessageBox.Show("数量应大于零");
                tbno.Focus();
                tbno.Text = "";
                return;
            }


            Int32 bgno = Convert.ToInt32(tbbgno.Text);
            int no = Convert.ToInt32(tbno.Text);

            tbendno.Text = (bgno + no-1).ToString();
        }

        private void btrestart_Click(object sender, EventArgs e)
        {
            tbbgno.Text = "51210001";
            Int32 bgno = Convert.ToInt32(tbbgno.Text);
            int no = Convert.ToInt32(tbno.Text);

            tbendno.Text = (bgno + no-1).ToString();
        }

        private void btrun_Click(object sender, EventArgs e)
        {
            Int32 bgno = Convert.ToInt32(tbbgno.Text);
            Int32 endno = Convert.ToInt32(tbendno.Text);
            for (int i = bgno; i <= endno; i++) {
                createQrCode(tburls.Text + "?b=" + i,i);
            }
        }

        /// <summary>
        /// 生成二维码的方法
        /// </summary>
        /// <param name="str">二维码包含的内容</param>
        /// <param name="moduleSize">二维码大小</param>
        /// <param name="no">编号</param>
        private void createQrCode(string content, int no, int moduleSize = 9)
        {
            //QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            //QrCode qrCode = new QrCode();
            //qrEncoder.TryEncode(str, out qrCode);

            string filename = DateTime.Now.ToString("d");
            filename = filename.Replace("/", "");
            filename = filename.Replace(":", "");
            filename = filename.Replace("-", "");
            filename = filename.Replace(".", "");
            filename = filename.Replace(" ", "");
            string filepath = System.AppDomain.CurrentDomain.BaseDirectory + filename ;

            if (!Directory.Exists(filepath))
                Directory.CreateDirectory(filepath);

            string fileName = filepath + "\\" + no + ".png";
            //Renderer renderer = new Renderer(5, Brushes.Black, Brushes.White);
            //renderer.CreateImageFile(qrCode.Matrix, @filename, ImageFormat.Png);





            //ErrorCorrectionLevel 误差校正水平
            //QuietZoneModules     空白区域

            var encoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = encoder.Encode(content);
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(moduleSize, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            
            //MemoryStream memoryStream = new MemoryStream();
            //render.WriteToStream(qrCode.Matrix, ImageFormat.Jpeg, memoryStream);
            
            //return memoryStream;

            //生成图片的代码
            DrawingSize dSize = render.SizeCalculator.GetSize(qrCode.Matrix.Width);
            Bitmap map = new Bitmap(dSize.CodeWidth, dSize.CodeWidth);
            Graphics g = Graphics.FromImage(map);
            render.Draw(g, qrCode.Matrix);
            map.Save(fileName, ImageFormat.Png);//fileName为存放的图片路径




        }

        
    }
}
