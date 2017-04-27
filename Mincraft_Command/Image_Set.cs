using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mincraft_Command
{
    public class Image_Set
    {
        Hashtable ChunkMark = new Hashtable();
        int tags = 0;

        private static string code_gene(bool x, bool z, bool level, int head, int end, int i, int center_x, int center_y, int center_z, int m1tag, int m2tag, string block, ref BitmapData data)
        {
            if (level)
            {
                if (x)
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n",
                        (head + m2tag - (m2tag != 0 ? (2 * head) : 0) - center_x), 
                        (-center_z), (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y), 
                        (end + m2tag - (m2tag != 0 ? (2 * end) : 0) - center_x), 
                        (-center_z), (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y), block);
                }
                else
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", 
                        (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_x), 
                        (-center_z), (head + m2tag - (m2tag != 0 ? (2 * head) : 0) - center_y), 
                        (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_x), 
                        (-center_z), (end + m2tag - (m2tag != 0 ? (2 * end) : 0) - center_y), block);
                }
            }
            else
            {
                if (x)
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", 
                        (head + m2tag - (m2tag != 0 ? (2 * head) : 0) - center_x), 
                        (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_z), (-center_y), 
                        (end + m2tag - (m2tag != 0 ? (2 * end) : 0) - center_x), 
                        (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_z), (-center_y), block);
                }
                else
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n",
                        (-center_x), (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_z),
                        (head + m2tag - (m2tag != 0 ? (2 * head) : 0) - center_y), (-center_x),
                        (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_z),
                        (end + m2tag - (m2tag != 0 ? (2 * end) : 0) - center_y), block);
                }
            }
        }

        public static void Word_Image(ref Bitmap color_Image, bool x, bool z, bool m1, bool m2, bool level, int center_x, int center_y, int center_z, string block)
        {
            //Bitmap color_Image;
            //try
            //{
            //    color_Image = new Bitmap(Image_Path);
            //}
            //catch
            //{
            //    MessageBox.Show("路径有误!");
            //    return;
            //}
            //color_Image = new Bitmap(Image_Path);
            BitmapData data = color_Image.LockBits(new Rectangle(0, 0, color_Image.Width, color_Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            StringBuilder code = new StringBuilder();
            int head = 0, end = -1;
            int m1tag = 0, m2tag = 0;
            if (!m1)
            {
                m1tag = data.Height;
            }
            if (!m2)
            {
                m2tag = data.Width;
            }

            unsafe
            {
                byte* ptr = (byte*)(data.Scan0);
                for (int i = 0; i < data.Height; i++)
                {
                    for (int j = 0; j < data.Width; j++)
                    {
                        // write the logic implementation here
                        //cc += ptr[0] + " " + ptr[1] + " " + ptr[2] + "\n";
                        if (ptr[0] != 255 && ptr[1] != 255 && ptr[2] != 255)//结束执行一次
                        {
                            end++;
                        }
                        else
                        {
                            if (end >= head)
                            {
                                code.Append(code_gene(x, z, level, head, end, i, center_x, center_y, center_z, m1tag, m2tag, block, ref data));
                                //code.AppendFormat("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", (head + m2tag - (m2tag != 0 ? (2 * head) : 0) - center_x), (-center_z), (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y), (end + m2tag - (m2tag != 0 ? (2 * end) : 0) - center_x), (-center_z), (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y), block);
                                //code += "/fill" + " ~" + (head + m2tag - (m2tag != 0 ? (2 * head) : 0) - center_x) + " ~" + (-center_z) + " ~" + (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y) + " ~" + (end + m2tag - (m2tag != 0 ? (2 * end) : 0) - center_x) + " ~" + (-center_z) + " ~" + (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y) + " " + block + "\n";
                                head = end + 1;
                            }
                            head++;
                            end = head - 1;
                        }
                        ptr += 3;
                    }
                    if (head <= end)
                        code.Append(code_gene(x, z, level, head, end, i, center_x, center_y, center_z, m1tag, m2tag, block, ref data));
                    //code.AppendFormat("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", (head + m2tag - (m2tag != 0 ? (2 * head) : 0) - center_x), (-center_z), (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y), (end + m2tag - (m2tag != 0 ? (2 * end) : 0) - center_x), (-center_z), (i + m1tag - (m1tag != 0 ? (2 * i) : 0) - center_y), block);
                    head = 0;
                    end = -1;
                    ptr += data.Stride - data.Width * 3;
                }
            }

            
            Mini_PCB.Code_to_Cmd.send_str(code.ToString());
        }

        private static string code_gene(bool x, bool z, bool level, int head, int end, int i, int center_x, int center_y, int center_z, int m1tag, int m2tag, int blockId, ref string[,] files, ref BitmapData data)
        {
            if (level)
            {
                if (x)
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", 
                        ((m1tag == 0 ? i : (data.Height - i)) - center_x), (-center_z), 
                        ((m2tag == 0 ? head : (m2tag - head)) - center_y), 
                        ((m1tag == 0 ? i : (data.Height - i)) - center_x), (-center_z), 
                        ((m2tag == 0 ? end : (m2tag - end)) - center_y), files[blockId, 0]);
                }
                else
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", 
                        ((m2tag == 0 ? head : (m2tag - head)) - center_x), (-center_z), 
                        ((m1tag == 0 ? i : (data.Height - i)) - center_y), 
                        ((m2tag == 0 ? end : (m2tag - end)) - center_x), (-center_z), 
                        ((m1tag == 0 ? i : (data.Height - i)) - center_y), files[blockId, 0]);
                }
            }
            else
            {
                if (x)
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", 
                        (-center_x), ((m1tag == 0 ? i : (data.Height - i)) - center_z), 
                        ((m2tag == 0 ? head : (m2tag - head)) - center_y), (-center_x), 
                        ((m1tag == 0 ? i : (data.Height - i)) - center_z), 
                        ((m2tag == 0 ? end : (m2tag - end)) - center_y), files[blockId, 0]);
                }
                else
                {
                    return string.Format("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", 
                        ((m2tag == 0 ? head : (m2tag - head)) - center_x), 
                        ((m1tag == 0 ? i : (data.Height - i)) - center_z), (-center_y), 
                        ((m2tag == 0 ? end : (m2tag - end)) - center_x), 
                        ((m1tag == 0 ? i : (data.Height - i)) - center_z), (-center_y), files[blockId, 0]);
                }
            }
        }

        public static void Colorful_Image(ref Bitmap color_Image, bool x, bool z, bool m1, bool m2, bool level, int center_x, int center_y, int center_z)
        {
            string[,] files = Colorful_Image_sour();
            //Bitmap color_Image;
            //try
            //{
            //    color_Image = new Bitmap(Image_Path);
            //}
            //catch
            //{
            //    MessageBox.Show("路径有误!");
            //    return;
            //}
            BitmapData data = color_Image.LockBits(new Rectangle(0, 0, color_Image.Width, color_Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            StringBuilder code = new StringBuilder();
            int head = 0, end = 0;
            int m1tag = 0, m2tag = 0;
            if (!m1)
            {
                m1tag = data.Height;
            }
            if (m2)
            {
                m2tag = data.Width;
            }
            int block = 0, block1 = 0;
            unsafe
            {
                //int head = 0, end = 0;
                byte* ptr = (byte*)(data.Scan0);
                for (int i = 0; i < data.Height; i++)
                {
                    block1 = FindBlock(ptr[0], ptr[1], ptr[2], ref files);
                    for (int j = 0; j < data.Width; j++)
                    {
                        block = FindBlock(ptr[0], ptr[1], ptr[2], ref files);
                        // write the logic implementation here
                        //cc += ptr[0] + " " + ptr[1] + " " + ptr[2] + "\n";
                        if (block == block1)
                        {
                            end++;
                        }
                        else
                        {
                            code.Append(code_gene(x, z, level, head, end, i, center_x, center_y, center_z, m1tag, m2tag, block1, ref files, ref data));
                            //code.AppendFormat("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", ((m1tag == 0 ? i : (data.Height - i)) - center_x), (-center_z), ((m2tag == 0 ? head : (m2tag - head)) - center_y), ((m1tag == 0 ? i : (data.Height - i)) - center_x), (-center_z), ((m2tag == 0 ? end : (m2tag - end)) - center_y), files[block1, 0]);
                            //code += "/fill" + " ~" + ((m1tag == 0 ? i : (data.Height - i)) - center_x) + " ~" + (-center_z) + " ~" + ((m2tag == 0 ? head : (m2tag - head)) - center_y) + " ~" + ((m1tag == 0 ? i : (data.Height - i)) - center_x) + " ~" + (-center_z) + " ~" + ((m2tag == 0 ? end : (m2tag - end)) - center_y) + " " + block1 + "\n";
                            head = end + 1;
                            end = head;
                            block1 = block;
                        }
                        ptr += 3;
                    }
                    if (head <= end)
                    {
                        code.Append(code_gene(x, z, level, head, end, i, center_x, center_y, center_z, m1tag, m2tag, block1, ref files, ref data));
                        //code.AppendFormat("/fill ~{0} ~{1} ~{2} ~{3} ~{4} ~{5} {6}\n", ((m1tag == 0 ? i : (data.Height - i)) - center_x), (-center_z), ((m2tag == 0 ? head : (m2tag - head)) - center_y), ((m1tag == 0 ? i : (data.Height - i)) - center_x), (-center_z), ((m2tag == 0 ? end : (m2tag - end)) - center_y), files[block1, 0]);
                    }
                    head = 0;
                    end = 0;
                    ptr += data.Stride - data.Width * 3;
                }
            }
            Mini_PCB.Code_to_Cmd.send_str(code.ToString());
        }

        //private static string [,,] block_color = new string[256, 256, 256];

        static int FindBlock(int x, int y, int z, ref string[,] files)
        {
            //if (block_color[x, y, z] != null) return block_color[x, y, z];
            int min = 1000000000;
            int min_i = 0;
            for (int i = 0; i < files.Length / 4; ++i)
            {
                int temp = diss(x, y, z, int.Parse(files[i, 1]), int.Parse(files[i, 2]), int.Parse(files[i, 3]));
                if (min > temp)
                {
                    min = temp;
                    min_i = i;
                }
            }
            return min_i;
            //return files[min_i, 0];
        }

        static int diss(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            int dist;
            dist = Math.Abs(x1 - x2) + Math.Abs(y1 - y2) + Math.Abs(z1 - z2);
            return dist;
        }

        static string[,] Colorful_Image_sour()
        {
            //string Path = "C:\\Users\\Administrator\\Desktop\\素材\\mc";
            //string Path = "E:\\ptcDraw\\材质\\mc";
            string Path = System.Environment.CurrentDirectory + "\\mc";
            string[] strs = System.IO.Directory.GetFiles(Path);
            string[,] files = new string[strs.Length, 4];
            int index = 0;
            foreach (string file in strs)
            {
                int g = 0, b = 0, r = 0;
                System.IO.FileInfo fi = new System.IO.FileInfo(file);
                Bitmap All_Image = new Bitmap(Path + "\\" + fi.Name);
                BitmapData data = All_Image.LockBits(new Rectangle(0, 0, All_Image.Width, All_Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                unsafe
                {
                    byte* ptr = (byte*)(data.Scan0);
                    for (int i = 0; i < data.Height; i++)
                    {
                        for (int j = 0; j < data.Width; j++)
                        {
                            // write the logic implementation here
                            //cc += ptr[0] + " " + ptr[1] + " " + ptr[2] + "\n";
                            b += ptr[0];
                            g += ptr[1];
                            r += ptr[2];
                            ptr += 3;
                        }
                        ptr += data.Stride - data.Width * 3;
                    }
                }
                b /= data.Height * data.Width;
                g /= data.Height * data.Width;
                r /= data.Height * data.Width;
                files[index, 0] = fi.Name.Split('.')[0];
                files[index, 1] = b.ToString();
                files[index, 2] = g.ToString();
                files[index, 3] = r.ToString();
                index++;
            }
            return files;
        }
    }
}
