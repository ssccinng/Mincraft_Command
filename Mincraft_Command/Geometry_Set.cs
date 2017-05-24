using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mincraft_Command
{
    public class Geometry_Set
    {
        static StringBuilder Line_Draw_code(int x1, int y1, int z1, int x2, int y2, int z2, string block)
        {
            
            StringBuilder code = new StringBuilder();
            int ds1 = Math.Abs(x1 - x2);
            int ds2 = Math.Abs(y1 - y2);
            int ds3 = Math.Abs(z1 - z2);
            int head_x, head_y, head_z;
            int a, b;
            if (ds1 > ds2 && ds1 > ds3)
            {
                int start = Min(x1, x2), end = x1 + x2 - start;
                head_x = start; head_y = Next_line(x1, y1, x2, y2, start); head_z = Next_line(x1, z1, x2, z2, start);
                for (int i = start + 1; i < end; i++)
                {
                    a = Next_line(x1, z1, x2, z2, i); b = Next_line(x1, y1, x2, y2, i);
                    if (a != head_z || b != head_y)
                    {
                        if (i - head_x == 1)
                            code.AppendFormat("/setblock {0} {1} {2} {3}\n", head_x, head_y, head_z, block);
                        else
                            code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", head_x, head_y, head_z, i - 1, head_y, head_z, block);
                        head_x = i; head_y = b; head_z = a;
                    }
                }
                code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", head_x, head_y, head_z, end, head_y, head_z, block);
            }
            else
            {
                if (ds2 > ds3)
                {
                    int start = Min(y1, y2), end = y1 + y2 - start;
                    head_y = start; head_x = Next_line(y1, x1, y2, x2, start); head_z = Next_line(y1, z1, y2, z2, start);
                    for (int i = start + 1; i < end; i++)
                    {
                        a = Next_line(y1, x1, y2, x2, i); b = Next_line(y1, z1, y2, z2, i);
                        if (a != head_x || b != head_z)
                        {
                            if (i - head_y == 1)
                                code.AppendFormat("/setblock {0} {1} {2} {3}\n", head_x, head_y, head_z, block);
                            else
                                code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", head_x, head_y, head_z, head_x, i - 1, head_z, block);
                            head_y = i; head_x = a; head_z = b;
                        }
                    }
                    code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", head_x, head_y, head_z, head_x, end, head_z, block);
                }
                else
                {
                    int start = Min(z1, z2), end = z1 + z2 - start;
                    head_z = start; head_x = Next_line(z1, x1, z2, x2, start); head_y = Next_line(z1, y1, z2, y2, start);
                    for (int i = start + 1; i < end; i++)
                    {
                        a = Next_line(z1, x1, z2, x2, i); b = Next_line(z1, y1, z2, y2, i);
                        if (a != head_x || b != head_y)
                        {
                            if (i - head_z == 1)
                                code.AppendFormat("/setblock {0} {1} {2} {3}\n", head_x, head_y, head_z, block);
                            else
                                code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", head_x, head_y, head_z, head_x, head_y, i - 1, block);
                            head_z = i; head_x = a; head_y = b;
                        }
                    }
                    code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", head_x, head_y, head_z, head_x, head_y, end, block);
                }
            }
            return code;
            //Mini_PCB.Code_to_Cmd.send_str(code.ToString());
        }

        private static int Next_line(int x1, int z1, int x2, int z2, int x)
        {
            return (x - x1) * (z2 - z1) / (x2 - x1) + z1;
        }

        private static int Min(int a, int b)
        {
            return a > b ? b : a;
        }

        public static void _3line_hollow(int x1, int y1, int z1, int x2, int y2, int z2, int x3, int y3, int z3, string block)
        {
            StringBuilder code = new StringBuilder();
            code.Append(Line_Draw_code(x1, y1, z1, x2, y2, z2, block));
            code.Append(Line_Draw_code(x1, y1, z1, x3, y3, z3, block));
            code.Append(Line_Draw_code(x3, y3, z3, x2, y2, z2, block));
            Mini_PCB.Code_to_Cmd.send_str(code.ToString());
        }

        public static void Line_Draw(int x1, int y1, int z1, int x2, int y2, int z2, string block)
        {
            Mini_PCB.Code_to_Cmd.send_str(Line_Draw_code(x1, y1, z1, x2, y2, z2, block).ToString());
        }

        private static double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
        }

        private static double UValue(double s, int l)
        {
            return 6 * (s - l) / l;
        }

        private static double RightValue(double s, int l,int h)
        {
            return Math.Sqrt(s * s - h * h) / l;
        }

        private static double AValue(double s, int l, int h)
        {
            return l / (Math.Pow(((-1 / 6 + Math.Sqrt(1 / 36 - (1 - RightValue(s, l, h)) / 30)) * 60), 2));
        }

        static StringBuilder GraLine_Draw_code(int x1, int y1, int z1, int x2, int y2, int z2, double s, string block)
        {
            s *= Dist(x1, y1, z1, x2, y2, z2);
            s /= 2;
            int l = Math.Abs(x1 - x2) / 2;
            int hitpoint = (x2 + x1) / 2;
            double a = aValue(UValue(s, l), l);
            double C = y1 - (a * Math.Cosh((x1 - hitpoint) / a));
            StringBuilder code = new StringBuilder();
            int start = Min(x1, x2), end = x1 + x2 - start;
            for (int i = start; i <= end; ++i)
            {
                code.AppendFormat("/setblock {0} {1} {2} {3}\n", i, (int)(a * Math.Cosh((i - hitpoint) / a) + C), z1, block);
            }
            return code;
        }

        private static double aValue(double u, int l)
        {
            return l / Math.Sqrt((((((2.0 / 525) * u) - (1.0 / 20)) * u) + 1) * u);
        }

        public static void GraLine_Draw(int x1, int y1, int z1, int x2, int y2, int z2, double s, string block)
        {
            Mini_PCB.Code_to_Cmd.send_str(GraLine_Draw_code(x1, y1, z1, x2, y2, z2, s, block).ToString());
        }

        public static void circle_Draw(int x, int y, int z, int a, int b, string model1, string model2, string block)
        {
            StringBuilder code = new StringBuilder();
            int r2 = a * a;
            int normal = b;
            if (model1 == "XOZ")
            {
                if (model2 == "fill")
                {
                    for (int i = 0; i <= a; ++i)
                    {
                        int sb = (int)(Math.Sqrt(r2 - i * i) * b / a);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x + i, y, z + sb, x + i, y, z - sb, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x - i, y, z + sb, x - i, y, z - sb, block);
                    }
                }
                else
                {
                    for (int i = 0; i <= a; ++i)
                    {
                        int sb = (int)(Math.Sqrt(r2 - i * i) * b / a);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x + i, y, z + normal, x + i, y, z + sb, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x - i, y, z - normal, x - i, y, z - sb, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x + i, y, z - normal, x + i, y, z - sb, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x - i, y, z + normal, x - i, y, z + sb, block);
                        normal = sb;
                    }
                }
            }
            else if (model1 == "XOY")
            {
                if (model2 == "fill")
                {
                    for (int i = 0; i <= a; ++i)
                    {
                        int sb = (int)(Math.Sqrt(r2 - i * i) * b / a);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x + i, y + sb, z, x + i, y - sb, z, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x - i, y + sb, z, x - i, y - sb, z, block);
                    }
                }
                else
                {
                    for (int i = 0; i <= a; ++i)
                    {
                        int sb = (int)(Math.Sqrt(r2 - i * i) * b / a);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x + i, y + normal, z, x + i, y + sb, z, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x - i, y - normal, z, x - i, y - sb, z, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x + i, y - normal, z, x + i, y - sb, z, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x - i, y + normal, z, x - i, y + sb, z, block);
                        normal = sb;
                    }
                }
            }
            else
            {
                if (model2 == "fill")
                {
                    for (int i = 0; i <= a; ++i)
                    {
                        int sb = (int)(Math.Sqrt(r2 - i * i) * b / a);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x, y + sb, z + i, x, y - sb, z + i, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x, y + sb, z - i, x, y - sb, z - i, block);
                    }
                    
                }
                else
                {
                    for (int i = 0; i <= a; ++i)
                    {
                        int sb = (int)(Math.Sqrt(r2 - i * i) * b / a);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x, y + normal, z + i, x, y + sb, z + i, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x, y - normal, z - i, x, y - sb, z - i, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x, y - normal, z + i, x, y - sb, z + i, block);
                        code.AppendFormat("/fill {0} {1} {2} {3} {4} {5} {6}\n", x, y + normal, z - i, x, y + sb, z - i, block);
                        normal = sb;
                    }

                }
            }
            Mini_PCB.Code_to_Cmd.send_str(code.ToString());
        }

        //private string circle_code_fill(int x, int y, int z, string blcok)
        //{

        //    return string.Format("fill {} {}")
        //}
    }
}
