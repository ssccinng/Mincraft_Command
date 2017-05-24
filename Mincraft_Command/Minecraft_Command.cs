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
    public partial class Minecraft_Main : Form
    {
        public Minecraft_Main()
        {
            InitializeComponent();
        }
        
        private void Minecraft_Main_Load(object sender, EventArgs e)
        {
            
        }
        geometry geometry1 = null;
        private void geometry_Click(object sender, EventArgs e)
        {
            
            if (geometry1 == null|| geometry1.IsDisposed)
            {
                geometry1 = new geometry();
                geometry1.Show();
            }
            else
            {
                geometry1.Activate();
            }
        }
        Pixel_Art Pixel_Art1 = null;
        private void label1_Click(object sender, EventArgs e)
        {
            
            if (Pixel_Art1 == null || Pixel_Art1.IsDisposed)
            {
                Pixel_Art1 = new Mincraft_Command.Pixel_Art();
                Pixel_Art1.Show();
            }
            else
            {
                Pixel_Art1.Activate();
            }

            
        }
        mc_cmd mc_cmd1 = null;
        private void mc_cmd_Click(object sender, EventArgs e)
        {
            if (mc_cmd1 == null || mc_cmd1.IsDisposed)
            {
                mc_cmd1 = new Mincraft_Command.mc_cmd();
                mc_cmd1.Show();
            }
            else
            {
                mc_cmd1.Activate();
            }

        }
    }
}
