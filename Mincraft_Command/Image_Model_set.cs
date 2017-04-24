using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mincraft_Command
{
    public partial class Image_Model_set : Form
    {
        public Image_Model_set()
        {
            InitializeComponent();
        }
        Bitmap color_Image;

        private void button1_Click(object sender, EventArgs e)
        {

            //Form1 frmB = new Form1();
            if (Check.Check_V_N(Center_x.Text) &&
                Check.Check_V_N(Center_y.Text) &&
                Check.Check_V_N(Center_z.Text) 
                )
            {
                //cmd_gene.Model_Set.Colorful_Image(Model_Set.app.Image_Path, Draw_x.Checked, Draw_z.Checked, Draw_mode1.Checked, Draw_mode2.Checked, level.Checked, int.Parse(center_y.Text), int.Parse(center_x.Text), int.Parse(center_z.Text) + 2);
                if (Mincraft_Command.Pixel_Art.mor.type == 0)
                    Mincraft_Command.Image_Set.Word_Image(color_Image, Draw_x.Checked, Draw_z.Checked, Draw_mode1.Checked, Draw_mode2.Checked, level.Checked, int.Parse(Center_x.Text), int.Parse(Center_y.Text), int.Parse(Center_z.Text) + 2, Pixel_Art.mor.Word_Block);
                else
                    Mincraft_Command.Image_Set.Colorful_Image(color_Image, Draw_x.Checked, Draw_z.Checked, Draw_mode1.Checked, Draw_mode2.Checked, level.Checked, int.Parse(Center_y.Text), int.Parse(Center_x.Text), int.Parse(Center_z.Text) + 2);
                Dispose();
                this.Close();
            }
        }

        private void Image_Model_set_Load(object sender, EventArgs e)
        {
            
            try
            {
                color_Image = new Bitmap(Pixel_Art.mor.Word_Path);
                Width1.Text = "宽=" + color_Image.Width.ToString();
                Height1.Text = "长=" + color_Image.Height.ToString();
            }
            catch
            {
                MessageBox.Show("路径有误!");
                Close();
            }
        }

        private void Image_Model_set_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
