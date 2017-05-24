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
    public partial class geometry : Form
    {
        public geometry()
        {
            InitializeComponent();
        }

        private void Line_X1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Line_Gene_Click(object sender, EventArgs e)
        {
            if (
                Check.Check_V_N(Line_X1.Text) &&
                Check.Check_V_N(Line_Y1.Text) &&
                Check.Check_V_N(Line_Z1.Text) &&
                Check.Check_V_N(Line_X2.Text) &&
                Check.Check_V_N(Line_Y2.Text) &&
                Check.Check_V_N(Line_Z2.Text) 
                )
            {
                Mincraft_Command.Geometry_Set.Line_Draw(int.Parse(Line_X1.Text), int.Parse(Line_Y1.Text), int.Parse(Line_Z1.Text), int.Parse(Line_X2.Text), int.Parse(Line_Y2.Text), int.Parse(Line_Z2.Text), Line_Block.Text);
            }
        }

        private void geometry_Load(object sender, EventArgs e)
        {
            Block_Sourage.Auto(Line_Block);
            Block_Sourage.Auto(block_);
            Block_Sourage.Auto(GraLine_Block);
            Block_Sourage.Auto(circle_block);
        }

        private void geometry_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fill_.Checked)
            {

            }
            else
            {
                Geometry_Set._3line_hollow(int.Parse(x_1.Text), int.Parse(y_1.Text), int.Parse(z_1.Text), int.Parse(x_2.Text), int.Parse(y_2.Text), int.Parse(z_2.Text), int.Parse(x_3.Text), int.Parse(y_3.Text), int.Parse(z_3.Text), block_.Text);
            }
        }

        private void GraLineBu_Click(object sender, EventArgs e)
        {
            if (
                Check.Check_V_N(GraLinex1.Text) &&
                Check.Check_V_N(GraLinex2.Text) &&
                Check.Check_V_N(GraLiney1.Text) &&
                Check.Check_V_N(GraLiney2.Text) &&
                Check.Check_V_N(GraLinez1.Text) &&
                Check.Check_V_N(GraLinez2.Text) &&
                Check.Check_V_DN(GraLineS.Text)
                )
            {
                Geometry_Set.GraLine_Draw(int.Parse(GraLinex1.Text), int.Parse(GraLiney1.Text), int.Parse(GraLinez1.Text), int.Parse(GraLinex2.Text), int.Parse(GraLiney2.Text), int.Parse(GraLinez2.Text), double.Parse(GraLineS.Text), GraLine_Block.Text);
            }
                
        }

        private void Line_Z1__Click(object sender, EventArgs e)
        {

        }

        private void Line_Y1__Click(object sender, EventArgs e)
        {

        }

        private void Line_X1__Click(object sender, EventArgs e)
        {

        }

        private void circle_gene_Click(object sender, EventArgs e)
        {
            if (
                Check.Check_V_N(circle_x.Text) &&
                Check.Check_V_N(circle_y.Text) &&
                Check.Check_V_N(circle_z.Text) &&
                Check.Check_V_N(circle_a.Text) &&
                Check.Check_V_N(circle_b.Text) 
                )
            {
                Geometry_Set.circle_Draw(int.Parse(circle_x.Text), int.Parse(circle_y.Text), int.Parse(circle_z.Text), int.Parse(circle_a.Text), int.Parse(circle_b.Text), circlemodel1.Text, circlemodel2.Text, circle_block.Text);
            }
        }
    }
}
      