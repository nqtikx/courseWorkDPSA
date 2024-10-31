using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сursac.temerev.model
{
    class Drawing
    {

        private const int radius = 30;
        private string symbols = "";
        private int temp = 1;
        private List<string> listOneSym = new List<string>();

        private readonly Font font = new Font("Malgun Gothic", 13, FontStyle.Bold);
        private Pen nodePen = new Pen(Color.Black, 3);
        private Pen linePen = new Pen(Color.Black, 2);

        private Point center = new Point(550, 50);
        private Point dynamicPoint = new Point(550, 50);

        public void DrawCircle(Graphics g, Pen pen, float centerX, float centerY, float radius)
        {
            g.FillEllipse(Brushes.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
            g.FillEllipse(Brushes.WhiteSmoke, centerX - radius, centerY - radius, radius * 2, radius * 2);
        }

        public void DrawFirstNode(Graphics g, Point center)
        {
            DrawCircle(g, nodePen, center.X, center.Y, radius);
        }

        public void DrawNode(Graphics g, Point center, Node nodes, string strSymbol)
        {
            DrawCircle(g, nodePen, center.X, center.Y, radius);

            try
            {
                if (temp == 1)
                {
                    if (strSymbol.ToString() == "1")
                    {
                        g.DrawString(nodes.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                        listOneSym.Add("1");
                        temp++;
                    }
                    else if (strSymbol.ToString() == "0")
                    {
                        g.DrawString(nodes.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                        listOneSym.Add("0");
                        temp++;
                    }
                }

                else if (temp == 2)
                {
                    if (listOneSym[0] == "1")
                    {
                        if (strSymbol.ToString() == "1")
                        {
                            g.DrawString(nodes.Right.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                            listOneSym.Add("1");
                            temp++;
                        }

                        else if (strSymbol.ToString() == "0")
                        {
                            g.DrawString(nodes.Right.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                            listOneSym.Add("0");
                            temp++;
                        }

                    }

                    else if (listOneSym[0] == "0")
                    {
                        if (strSymbol.ToString() == "1")
                        {
                            g.DrawString(nodes.Left.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                            listOneSym.Add("1");
                            temp++;
                        }
                        else if (strSymbol.ToString() == "0")
                        {
                            g.DrawString(nodes.Left.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                            listOneSym.Add("0");
                            temp++;
                        }
                    }
                }

                else if (temp == 3)
                {
                    if (listOneSym[0] == "1")
                    {
                        if (listOneSym[1] == "1")
                        {
                            if (strSymbol.ToString() == "1")
                            {
                                g.DrawString(nodes.Right.Right.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("1");
                                temp++;
                            }

                            else if (strSymbol.ToString() == "0")
                            {
                                g.DrawString(nodes.Right.Right.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("0");
                                temp++;
                            }

                        }

                        else if (listOneSym[1] == "0")
                        {
                            if (strSymbol.ToString() == "1")
                            {
                                g.DrawString(nodes.Right.Left.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("1");
                                temp++;
                            }

                            else if (strSymbol.ToString() == "0")
                            {
                                g.DrawString(nodes.Right.Left.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("0");
                                temp++;
                            }
                        }


                    }

                    else if (listOneSym[0] == "0")
                    {
                        if (listOneSym[1] == "1")
                        {
                            if (strSymbol.ToString() == "1")
                            {
                                g.DrawString(nodes.Left.Right.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("1");
                                temp++;
                            }

                            else if (strSymbol.ToString() == "0")
                            {
                                g.DrawString(nodes.Left.Right.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("0");
                                temp++;
                            }

                        }

                        else if (listOneSym[1] == "0")
                        {
                            if (strSymbol.ToString() == "1")
                            {
                                g.DrawString(nodes.Left.Left.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("1");
                                temp++;
                            }

                            else if (strSymbol.ToString() == "0")
                            {
                                g.DrawString(nodes.Left.Left.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                listOneSym.Add("0");
                                temp++;
                            }
                        }
                    }

                }

                else if (temp == 4)
                {
                    if (listOneSym[0] == "1")
                    {
                        if (listOneSym[1] == "1")
                        {
                            if (listOneSym[2] == "1")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Right.Right.Right.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Right.Right.Right.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }

                            else if (listOneSym[2] == "0")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Right.Right.Left.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Right.Right.Left.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }

                        }

                        else if (listOneSym[1] == "0")
                        {
                            if (listOneSym[2] == "1")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Right.Left.Right.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Right.Left.Right.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }

                            else if (listOneSym[2] == "0")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Right.Left.Left.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Right.Left.Left.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }
                        }
                    }

                    else if (listOneSym[0] == "0")
                    {
                        if (listOneSym[1] == "1")
                        {
                            if (listOneSym[2] == "1")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Left.Right.Right.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Left.Right.Right.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }

                            if (listOneSym[2] == "0")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Left.Right.Left.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Left.Right.Left.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }
                        }

                        else if (listOneSym[1] == "0")
                        {
                            if (listOneSym[2] == "1")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Left.Left.Right.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Left.Left.Right.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }

                            if (listOneSym[2] == "0")
                            {
                                if (strSymbol.ToString() == "1")
                                {
                                    g.DrawString(nodes.Left.Left.Left.Right.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("1");
                                    temp++;
                                }

                                else if (strSymbol.ToString() == "0")
                                {
                                    g.DrawString(nodes.Left.Left.Left.Left.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);
                                    listOneSym.Add("0");
                                    temp++;
                                }
                            }
                        }
                    }
                }
            }

            catch (NullReferenceException)
            {

            }
        }

        public void DrawNode(Graphics g, Point center, char symb)
        {
            g.DrawString(symb.ToString(), font, Brushes.Black, center.X + 30, center.Y - 160);
        }


        public void DrawLeftLine(Graphics g, Point point, int j)
        {
            Point firstPoint = new Point(point.X, point.Y + radius);

            if (j == 0)
            {
                Point secondPoint = new Point(point.X - 320, point.Y + 80);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("0", font, Brushes.Red, secondPoint.X + 140, secondPoint.Y - 45);
            }

            else if (j == 1)
            {
                Point secondPoint = new Point(point.X - 165, point.Y + 70);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("0", font, Brushes.Red, secondPoint.X + 70, secondPoint.Y - 45);
            }

            else if (j == 2)
            {
                Point secondPoint = new Point(point.X - 80, point.Y + 70);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("0", font, Brushes.Red, secondPoint.X + 30, secondPoint.Y - 45);
            }

            else
            {
                Point secondPoint = new Point(point.X - 40, point.Y + 110);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("0", font, Brushes.Red, secondPoint.X + 12, secondPoint.Y - 70);
            }
        }

        public void DrawRightLine(Graphics g, Point point, int j)
        {
            Point firstPoint = new Point(point.X, point.Y + radius);

            if (j == 0)
            {
                Point secondPoint = new Point(point.X + 320, point.Y + 80);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("1", font, Brushes.Red, secondPoint.X - 160, secondPoint.Y - 45);
            }

            else if (j == 1)
            {
                Point secondPoint = new Point(point.X + 165, point.Y + 70);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("1", font, Brushes.Red, secondPoint.X - 90, secondPoint.Y - 45);
            }

            else if (j == 2)
            {
                Point secondPoint = new Point(point.X + 80, point.Y + 70);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("1", font, Brushes.Red, secondPoint.X - 45, secondPoint.Y - 45);
            }

            else
            {
                Point secondPoint = new Point(point.X + 40, point.Y + 110);
                g.DrawLine(linePen, firstPoint, secondPoint);
                g.DrawString("1", font, Brushes.Red, secondPoint.X - 25, secondPoint.Y - 70);
            }
        }



        public void Draw(Graphics g, string[] encode, Node nodes, Dictionary<char, int> dict)
        {
            DrawFirstNode(g, center);
            g.DrawString(nodes.Frequency.ToString(), font, Brushes.Red, center.X - 15, center.Y + 2);

            for (int i = 0; i < encode.Length; i++)
            {
                string str = encode[i];

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        DrawRightLine(g, new Point(center.X, center.Y), j);

                        if (j == 0)
                        {
                            DrawNode(g, new Point(center.X + 320, center.Y + 110), nodes, str[j].ToString());
                            center.X += 320;
                            center.Y += 110;
                        }

                        else if (j == 1)
                        {
                            DrawNode(g, new Point(center.X + 165, center.Y + 100), nodes, str[j].ToString());
                            center.X += 165;
                            center.Y += 100;
                        }

                        else if (j == 2)
                        {
                            DrawNode(g, new Point(center.X + 80, center.Y + 100), nodes, str[j].ToString());
                            center.X += 80;
                            center.Y += 100;
                        }

                        else
                        {
                            DrawNode(g, new Point(center.X + 40, center.Y + 140), nodes, str[j].ToString());
                            center.X += 40;
                            center.Y += 140;
                        }
                    }

                    else
                    {
                        DrawLeftLine(g, new Point(center.X, center.Y), j);

                        if (j == 0)
                        {
                            DrawNode(g, new Point(center.X - 320, center.Y + 110), nodes, str[j].ToString());
                            center.X -= 320;
                            center.Y += 110;
                        }

                        else if (j == 1)
                        {
                            DrawNode(g, new Point(center.X - 165, center.Y + 100), nodes, str[j].ToString());
                            center.X -= 165;
                            center.Y += 100;
                        }

                        else if (j == 2)
                        {
                            DrawNode(g, new Point(center.X - 80, center.Y + 100), nodes, str[j].ToString());
                            center.X -= 80;
                            center.Y += 100;
                        }

                        else
                        {
                            DrawNode(g, new Point(center.X - 40, center.Y + 140), nodes, str[j].ToString());
                            center.X -= 40;
                            center.Y += 140;
                        }
                    }

                    if (j == (str.Length - 1))
                    {
                        char Symb = dict.ElementAt(i).Key;
                        DrawNode(g, new Point(center.X - 40, center.Y + 140), Symb);
                    }
                }

                center.X = dynamicPoint.X;
                center.Y = dynamicPoint.Y;

                temp = 1;
            }
        }

    }
}
