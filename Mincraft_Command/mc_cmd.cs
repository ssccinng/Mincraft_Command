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
    public partial class mc_cmd : Form
    {
        public mc_cmd()
        {
            InitializeComponent();
        }

        private void mc_cmd_Load(object sender, EventArgs e)
        {
            Block_Sourage.Auto(fill_Block);
            Block_Sourage.Auto(chunk_block1);
            Block_Sourage.Auto(chunk_block2);
        }

        private void mcfill_Click(object sender, EventArgs e)
        {

            if (
                Check.Check_V_N(fill_X1.Text) &&
                Check.Check_V_N(fill_X2.Text) &&
                Check.Check_V_N(fill_Y1.Text) &&
                Check.Check_V_N(fill_Y2.Text) &&
                Check.Check_V_N(fill_Z1.Text) &&
                Check.Check_V_N(fill_Z2.Text)
                )
            {
                MC_Command_Set.
                    Allfill_cmd(int.Parse(fill_X1.Text), int.Parse(fill_Y1.Text), int.Parse(fill_Z1.Text), int.Parse(fill_X2.Text), int.Parse(fill_Y2.Text), int.Parse(fill_Z2.Text), fill_Block.Text);
            }
        }

        private void chunk_gene_Click(object sender, EventArgs e)
        {
            if (
                   Check.Check_V_N(chunk_x.Text) &&
                   Check.Check_V_N(chunk_y.Text) &&
                   Check.Check_V_N(chunk_z.Text) &&
                   Check.Check_V_N(chunk_length.Text) &&
                   Check.Check_V_N(chunk_width.Text) &&
                   Check.Check_V_N(chunk_height.Text)
                   )
            {
                MC_Command_Set.
                    chunk_cmd(int.Parse(chunk_x.Text), int.Parse(chunk_y.Text), int.Parse(chunk_z.Text), int.Parse(chunk_length.Text), int.Parse(chunk_width.Text), int.Parse(chunk_height.Text), chunk_block1.Text, chunk_block2.Text);
            }
        }

        private void clear_chunk_gene_Click(object sender, EventArgs e)
        {
            if (
                   Check.Check_V_N(clear_chunk_x.Text) &&
                   Check.Check_V_N(clear_chunk_z.Text) &&
                   Check.Check_V_N(clear_chunk_len.Text) &&
                   Check.Check_V_N(clear_chunk_wid.Text) &&
                   Check.Check_V_N(clear_chunk_di.Text) &&
                   Check.Check_V_N(clear_chunk_top.Text)
                   )
            {
                MC_Command_Set.
                    clear_chunk(int.Parse(clear_chunk_x.Text), int.Parse(clear_chunk_z.Text), int.Parse(clear_chunk_len.Text), int.Parse(clear_chunk_wid.Text), int.Parse(clear_chunk_di.Text), int.Parse(clear_chunk_top.Text));
            }
        }
    }
}
