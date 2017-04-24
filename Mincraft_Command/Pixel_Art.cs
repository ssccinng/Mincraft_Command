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
    public partial class Pixel_Art : Form
    {
        public Pixel_Art()
        {
            InitializeComponent();
        }

        Image_Model_set modes;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Word_Path.Text = open.FileName;
            }
        }

        public class mor
        {
            public static string Word_Path;
            public static string Word_Block;
            public static int type;
        }

        private void Pixel_Art_Load(object sender, EventArgs e)
        {
            Block_Sourage.Auto(Word_Block);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mor.Word_Path = Word_Path.Text;
            mor.Word_Block = Word_Block.Text;
            mor.type = 0;
            if (modes == null || modes.IsDisposed)
            {
                modes = new Image_Model_set();
                modes.Show();
            }
            else
            {
                modes.Activate();
            }
        }

        private void Pixel_Art_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void Pixel_Art_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image_Path.Text = open.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mor.Word_Path = Image_Path.Text;
            mor.type = 1;
            if (modes == null || modes.IsDisposed)
            {
                modes = new Image_Model_set();
                modes.Show();
            }
            else
            {
                modes.Activate();
            }
        }
    }
}
