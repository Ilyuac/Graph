using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class DrawerGraph
    {
        Bitmap bitmap;
        Pen BlackPen, RedPen,ArrowBlackPen;
        Graphics Graphics;
        Brush brush;
        Font Font;
        PointF point;
        public int R = 20;
        const int P=9;
        bool EdgeorArc = false;

        public DrawerGraph(int widht, int heidht,bool EdgeorArc=false)
        {
            this.EdgeorArc = EdgeorArc;
            bitmap = new Bitmap(widht, heidht);
            Graphics = Graphics.FromImage(bitmap);
            ClearSheet();
            BlackPen = new Pen(Color.Black);
            BlackPen.Width = 2;
            RedPen = new Pen(Color.Red);
            RedPen.Width = 2;
            if(EdgeorArc)
            {
                //GraphicsPath graphicsPath1 = new GraphicsPath();
                //graphicsPath1.AddLine(0, 0, 3, 0);
                //graphicsPath1.AddLine(0, 0, 3, 4);
                //graphicsPath1.AddLine(0, 0, 3, -4);
                
                ArrowBlackPen = new Pen(Color.Brown);
                ArrowBlackPen.Width = 2;
                
                //ArrowBlackPen.CustomEndCap = new CustomLineCap(null, graphicsPath1,LineCap.ArrowAnchor); 
            }

            Font = new Font("Arial",15);
            brush = Brushes.Black;
        }

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void ClearSheet()
        {
            Graphics.Clear(Color.White);
        }

        public void DrawVertex(Vertex vertex,string number)
        {
            
            Graphics.FillEllipse(new SolidBrush(vertex.Color),(vertex.x-R),(vertex.y-R),2*R,2*R);
            Graphics.DrawEllipse(BlackPen, (vertex.x - R), (vertex.y - R), 2 * R, 2 * R);
            point = new PointF(vertex.x - P, vertex.y - P);
            Graphics.DrawString(number,Font,brush,point);
        }

        public void DrawSelectVertex(Vertex vertex)
        {
            Graphics.DrawEllipse(RedPen, (vertex.x - R), (vertex.y - R), 2 * R, 2 * R);
        }

        public void DrawEdgeorArc(Vertex V1, Vertex V2, Edge E, int numberE)
        {
            if (EdgeorArc)
            {
                if (E.Vertex1 == E.Vertex2)
                {
                    Graphics.DrawArc(ArrowBlackPen, (V1.x - 2 * R), (V1.y - 2 * R), 2 * R, 2 * R, 90, 270);
                    point = new PointF(V1.x - (int)(2.75 * R), V1.y - (int)(2.75 * R));
                    Graphics.DrawString(((char)('a' + numberE)).ToString(), Font, brush, point);
                    DrawVertex(V1, (E.Vertex1 + 1).ToString());
                }
                else
                {
                    Graphics.DrawLine(ArrowBlackPen, V1.x, V1.y, V2.x, V2.y);
                    point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                    Graphics.DrawString(((char)('a' + numberE)).ToString(), Font, brush, point);
                    DrawVertex(V1, (E.Vertex1 + 1).ToString());
                    DrawVertex(V2, (E.Vertex2 + 1).ToString());
                }
            }
            else
            {
                if (E.Vertex1 == E.Vertex2)
                {
                    Graphics.DrawArc(BlackPen, (V1.x - 2 * R), (V1.y - 2 * R), 2 * R, 2 * R, 90, 270);
                    point = new PointF(V1.x - (int)(2.75 * R), V1.y - (int)(2.75 * R));
                    Graphics.DrawString(((char)('a' + numberE)).ToString(), Font, brush, point);
                    DrawVertex(V1, (E.Vertex1 + 1).ToString());
                }
                else
                {
                    Graphics.DrawLine(BlackPen, V1.x, V1.y, V2.x, V2.y);
                    point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                    Graphics.DrawString(((char)('a' + numberE)).ToString(), Font, brush, point);
                    DrawVertex(V1, (E.Vertex1 + 1).ToString());
                    DrawVertex(V2, (E.Vertex2 + 1).ToString());
                }
            }
        }

        public void DrawGraph(List<Vertex> V, List<Edge> E)
        {
            //рисуем дуги
            if (EdgeorArc)
            {
                for (int i = 0; i < E.Count; i++)
                {
                    if (E[i].Vertex1 == E[i].Vertex2)
                    {
                        Graphics.DrawArc(ArrowBlackPen, (V[E[i].Vertex1].x - 2 * R), (V[E[i].Vertex1].y - 2 * R), 2 * R, 2 * R, 90, 270);
                        point = new PointF(V[E[i].Vertex1].x - (int)(2.75 * R), V[E[i].Vertex1].y - (int)(2.75 * R));
                        Graphics.DrawString(((char)('a' + i)).ToString(), Font, brush, point);
                    }
                    else
                    {
                        Graphics.DrawLine(ArrowBlackPen, V[E[i].Vertex1].x, V[E[i].Vertex1].y, V[E[i].Vertex2].x, V[E[i].Vertex2].y);
                        point = new PointF((V[E[i].Vertex1].x + V[E[i].Vertex2].x) / 2, (V[E[i].Vertex1].y + V[E[i].Vertex2].y) / 2);
                        Graphics.DrawString(((char)('a' + i)).ToString(), Font, brush, point);
                    }
                }
            }
            else
            {
                for (int i = 0; i < E.Count; i++)
                {
                    if (E[i].Vertex1 == E[i].Vertex2)
                    {
                        Graphics.DrawArc(BlackPen, (V[E[i].Vertex1].x - 2 * R), (V[E[i].Vertex1].y - 2 * R), 2 * R, 2 * R, 90, 270);
                        point = new PointF(V[E[i].Vertex1].x - (int)(2.75 * R), V[E[i].Vertex1].y - (int)(2.75 * R));
                        Graphics.DrawString(((char)('a' + i)).ToString(), Font, brush, point);
                    }
                    else
                    {
                        Graphics.DrawLine(BlackPen, V[E[i].Vertex1].x, V[E[i].Vertex1].y, V[E[i].Vertex2].x, V[E[i].Vertex2].y);
                        point = new PointF((V[E[i].Vertex1].x + V[E[i].Vertex2].x) / 2, (V[E[i].Vertex1].y + V[E[i].Vertex2].y) / 2);
                        Graphics.DrawString(((char)('a' + i)).ToString(), Font, brush, point);
                    }
                }
            }
            //рисуем вершины
            for (int i = 0; i < V.Count; i++)
            {
                DrawVertex(V[i], (i + 1).ToString());
            }
        }

        //заполняет матрицу смежности
        public void fillAdjacencyMatrix(int numberV, List<Edge> E, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < numberV; j++)
                    matrix[i, j] = 0;
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].Vertex1, E[i].Vertex2] = 1;
                if(!EdgeorArc)
                    matrix[E[i].Vertex2, E[i].Vertex1] = 1;
            }
        }

        //заполняет матрицу инцидентности
        public void fillIncidenceMatrix(int numberV, List<Edge> E, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < E.Count; j++)
                    matrix[i, j] = 0;
            if (EdgeorArc)
            {
                for (int i = 0; i < E.Count; i++)
                {
                    matrix[E[i].Vertex1, i] = 1;
                    matrix[E[i].Vertex2, i] = -1;
                }
            }
            else
            {
                for (int i = 0; i < E.Count; i++)
                {
                    matrix[E[i].Vertex1, i] = 1;
                    matrix[E[i].Vertex2, i] = 1;
                }
            }
        }
    }
}
