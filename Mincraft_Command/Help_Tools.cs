using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mincraft_Command
{
    public partial class Help_Tools : Form
    {
        public Help_Tools()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                GIFImage_Path.Text = open.FileName;
                //GIF_Path.Text = Path.GetFileName(Path.GetDirectoryName(GIFImage_Path.Text)); ;
                int cnt = 0;
                for (int i = GIFImage_Path.Text.Length - 1; i >= 0; --i)
                {
                    if (GIFImage_Path.Text[i] == '\\')
                    {
                        break;
                    }
                    cnt++;
                }
                GIF_Path.Text = GIFImage_Path.Text.Remove(GIFImage_Path.Text.Length - cnt, cnt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                GIF_Path.Text = open.FileName;
            }
        }

        private void GIF_Break_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(GIF_Path.Text + Path.GetFileNameWithoutExtension(GIFImage_Path.Text));
                dir.Create();//自行判断一下是否存在。
                Image gif = Image.FromFile(GIFImage_Path.Text);
                FrameDimension fd = new FrameDimension(gif.FrameDimensionsList[0]);

                //获取帧数(gif图片可能包含多帧，其它格式图片一般仅一帧)
                int count = gif.GetFrameCount(fd);

                //以Jpeg格式保存各帧
                for (int i = 0; i < count; i++)
                {
                    gif.SelectActiveFrame(fd, i);
                    string imgpath = GIF_Path.Text + Path.GetFileNameWithoutExtension(GIFImage_Path.Text) + "\\" + i + ".jpg";
                    gif.Save(imgpath, ImageFormat.Jpeg);
                }
                MessageBox.Show("生成完毕！");
            }
            catch
            {
                MessageBox.Show("请检查图片路径！");
            }

        }
    }
}
