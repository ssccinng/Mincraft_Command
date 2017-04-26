using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mini_PCB
{
    public class Code_to_Cmd
    {
        public class code_to_show
        {
            public static string [] Code;
        }
        static string[] Change_Code(ref string code)
        {
            if (code == "") return null;
            while (code[code.Length - 1] == '\n' || code[code.Length - 1] == '\r' || code[code.Length - 1] == ' ')
            {
                code = code.Remove(code.Length - 1);
            }
            string[] cmd;
            int index = 0;
            string cmdh = "/summon falling_block ~ ~1.5 ~ {Time:1,Block:minecraft:redstone_block,Motion:[0d,-1d,0d],Passengers:[{id:falling_block,Time:1,Block:minecraft:activator_rail,Passengers:[{id:commandblock_minecart,Command:blockdata ~ ~-2 ~ {auto:0b,Command:\"\"}},\n";
            string temp = "{id:commandblock_minecart,Command:";
            string[] Code = code.Split('\n');
            cmd = new string[code.Length / 10000 + 1];
            for (int i = 0; i < cmd.Length; ++i)
            {
                cmd[i] = "";
            }
            cmd[0] = cmdh;
            for (int i = 0; i < Code.Length; ++i)
            {
                while (Code[i][Code[i].Length - 1] == '\n' || Code[i][Code[i].Length - 1] == '\r' || Code[i][Code[i].Length - 1] == ' ')
                {
                    Code[i] = Code[i].Remove(Code[i].Length - 1);
                }
                cmd[index] += temp + Code[i] + "},\n";
                if (cmd[index].Length > 30000)
                {
                    cmd[index] += "{id:commandblock_minecart,Command:setblock ~ ~1 ~ command_block 0 replace {auto:1b,Command:fill ~ ~ ~ ~ ~-2 ~ air}},{id:commandblock_minecart,Command:kill @e[type=commandblock_minecart,r=1]}]}]}";
                    index++;
                    cmd[index] = cmdh;
                }
            }
            cmd[index] += "{id:commandblock_minecart,Command:setblock ~ ~1 ~ command_block 0 replace {auto:1b,Command:fill ~ ~ ~ ~ ~-2 ~ air}},{id:commandblock_minecart,Command:kill @e[type=commandblock_minecart,r=1]}]}]}";
            return cmd;
        }

        public static void send_str(string code)
        {
            show_form(Mini_PCB.Code_to_Cmd.Change_Code(ref code));
        }
        static void show_form(string[] code)
        {
            Mincraft_Command.OOC OOC = null;
            code_to_show.Code = code;
            
            if (OOC == null || OOC.IsDisposed)
            {
                OOC = new Mincraft_Command.OOC();
                OOC.Show();
            }
            else
            {
                OOC.Activate();
            }
        }


        private static void Cmd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
