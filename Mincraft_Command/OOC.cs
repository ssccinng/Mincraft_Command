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
    public partial class OOC : Form
    {
        public OOC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                Clipboard.SetDataObject(textBox1.Text);
            if (index != len) textBox1.Text = show[index++];
            else
            {
                Dispose();
                Close();
            }
            Text = "OOC(" + index + "/" + len + ")";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        string [] show = Mini_PCB.Code_to_Cmd.code_to_show.Code;
        int index = 1, len = 0;

        private void OOC_ResizeEnd(object sender, EventArgs e)
        {
            textBox1.Width = Width - 25;
            textBox1.Height = Height - 125;
            button1.Top = Height - 90;
            button1.Left = Width / 2 - 72;
        }

        private void OOC_Load(object sender, EventArgs e)
        {
            textBox1.Width = Width - 25;
            textBox1.Height = Height - 125;
            button1.Top = Height - 90;
            button1.Left = Width / 2 - 72;
            foreach (string i in show)
            {
                if (i != "") len++;
            }
            Text = "OOC(1/" + len + ")";
            textBox1.Text = show[0];
        }
    }
}
