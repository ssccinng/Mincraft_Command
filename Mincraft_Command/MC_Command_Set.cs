using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mincraft_Command
{
    public class MC_Command_Set
    {
        private static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        public static void Allfill_cmd(int x1, int y1, int z1, int x2, int y2, int z2, string block)
        {
            StringBuilder code = new StringBuilder();
            if (x1 > x2) Swap(ref x1, ref x2);
            Mini_PCB.Code_to_Cmd.send_str((fill_cmd(x1, y1, z1, x2, y2, z2, block)));
        }

        public static string fill_cmd(int x1, int y1, int z1, int x2, int y2, int z2, string block)
        {
            StringBuilder code = new StringBuilder();
            int lims = Math.Abs((y1 - y2) * (z1 - z2));
            if (lims > 32700)
            {
                code.Append(fill_cmd(x1, y1, z1, x2, y2, (z1 + z2) / 2, block));
                code.Append(fill_cmd(x1, y1, (z1 + z2) / 2, x2, y2, z2, block));
            }
            else
            {
                int start = x1;
                int lenth = 32700 / lims;
                while (true)
                {
                    if (start + lenth < x2)
                    {
                        code.AppendFormat("fill {0} {1} {2} {3} {4} {5} {6}\n", start, y1, z1, start + lenth - 1, y2, z2, block);
                        start += lenth;
                    }
                    else
                    {
                        code.AppendFormat("fill {0} {1} {2} {3} {4} {5} {6}\n", start, y1, z1, x2, y2, z2, block);
                        break;
                    }
                }

            }
            return code.ToString();
        }

        private static void chunk_area(int x, int z, int len, int width, ref int start_x, ref int start_z)
        {
            x /= 16;
            x *= 16;
            z /= 16;
            z *= 16;
            start_x = x - (len + 1) / 2 * 16;
            start_z = z - (width + 1) / 2 * 16;
        }

        public static void chunk_cmd(int x, int y, int z, int len, int width, int height, string block1, string block2)
        {
            StringBuilder code = new StringBuilder();
            int start_x = 0, start_z = 0;
            chunk_area(x, z, len, width, ref start_x, ref start_z);
            for (int i = 0; i < len; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if ((i + j) % 2 == 0)
                    {
                        code.AppendFormat("fill {0} {1} {2} {3} {4} {5} {6}\n", start_x + i * 16, y, start_z + j * 16,
                            start_x + i * 16 + 16, y + height - 1, start_z + j * 16 + 16, block1);
                    }
                    else
                    {
                        code.AppendFormat("fill {0} {1} {2} {3} {4} {5} {6}\n", start_x + i * 16, y, start_z + j * 16,
                            start_x + i * 16 + 16, y + height - 1, start_z + j * 16 + 16, block2);
                    }
                }
            }
            Mini_PCB.Code_to_Cmd.send_str(code.ToString());
        }

        public static void clear_chunk(int x, int z, int len, int width, int di, int top)
        {
            int start_x = 0, start_z = 0;
            chunk_area(x, z, len, width, ref start_x, ref start_z);
            Allfill_cmd(start_x, di, start_z, start_x + 16 * len, top, start_z + 16 * width, "air");
        }
    }
}
