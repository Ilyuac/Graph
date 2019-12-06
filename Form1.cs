using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class MainForm : Form
    {
        #region Global varies

        DrawerGraph G;

        struct ColorGroups
        {
            public Color Color;
            public List<int> Group;
        }

        struct Graph
        {
            public List<Vertex> V;
            public List<Edge> E;

            public int VCount { get { return V.Count; } }

            public int ECount { get { return E.Count; } }
        }
        Graph graph = new Graph();

        int[,] IMatrix, AMatrix;

        int selected1, selected2;

        bool AsSave = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            graph.V = new List<Vertex>();
            G = new DrawerGraph(DrowerPanel.Width, DrowerPanel.Height);
            graph.E = new List<Edge>();
            DrowerPanel.Image = G.GetBitmap();
        }

        private void butArrow_Click(object sender, EventArgs e)
        {
            butVertex.Enabled = true;
            butArrow.Enabled = false;
            butEdge.Enabled = true;
            butDelete.Enabled = true;
            butClear.Enabled = true;

            G.ClearSheet();
            G.DrawGraph(graph.V, graph.E);
            DrowerPanel.Image = G.GetBitmap();
            selected1 = -1;
        }

        private void butVertex_Click(object sender, EventArgs e)
        {
            butVertex.Enabled = false;
            butArrow.Enabled = true;
            butEdge.Enabled = true;
            butDelete.Enabled = true;
            butClear.Enabled = true;

            G.ClearSheet();
            G.DrawGraph(graph.V, graph.E);
            DrowerPanel.Image = G.GetBitmap();
        }

        private void butEdge_Click(object sender, EventArgs e)
        {
            butVertex.Enabled = true;
            butArrow.Enabled = true;
            butEdge.Enabled = false;
            butDelete.Enabled = true;
            butClear.Enabled = true;

            G.ClearSheet();
            G.DrawGraph(graph.V, graph.E);
            DrowerPanel.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            butVertex.Enabled = true;
            butArrow.Enabled = true;
            butEdge.Enabled = true;
            butDelete.Enabled = false;
            butClear.Enabled = true;

            G.ClearSheet();
            G.DrawGraph(graph.V, graph.E);
            DrowerPanel.Image = G.GetBitmap();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            butVertex.Enabled = true;
            butArrow.Enabled = true;
            butEdge.Enabled = true;
            butDelete.Enabled = true;
            butClear.Enabled = true;

            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                graph.V.Clear();
                graph.E.Clear();
                G.ClearSheet();
                DrowerPanel.Image = G.GetBitmap();
            }
        }

        private void butIMatrix_Click(object sender, EventArgs e)
        {
            createIncAndOut();
        }

        private void butAMatrix_Click(object sender, EventArgs e)
        {
            createAdjAndOut();
        }

        private void DrowerPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (butArrow.Enabled == false)
            {
                for (int i = 0; i < graph.VCount; i++)
                {
                    if (Math.Pow((graph.V[i].x - e.X), 2) + Math.Pow((graph.V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 != -1)
                        {
                            selected1 = -1;
                            G.ClearSheet();
                            G.DrawGraph(graph.V, graph.E);
                            DrowerPanel.Image = G.GetBitmap();
                        }
                        if (selected1 == -1)
                        {
                            G.DrawSelectVertex(graph.V[i]);
                            selected1 = i;
                            DrowerPanel.Image = G.GetBitmap();
                            createAdjAndOut();
                            listBoxMatrix.Items.Clear();
                            int degree = 0;
                            for (int j = 0; j < graph.VCount; j++)
                                degree += AMatrix[selected1, j];
                            listBoxMatrix.Items.Add("Степень вершины №" + (selected1 + 1) + " равна " + degree);
                            break;
                        }
                    }
                }
            }
            //нажата кнопка "рисовать вершину"
            if (butVertex.Enabled == false)
            {
                graph.V.Add(new Vertex(e.X, e.Y));
                G.DrawVertex(new Vertex(e.X, e.Y), graph.VCount.ToString());
                DrowerPanel.Image = G.GetBitmap();
            }
            //нажата кнопка "рисовать ребро"
            if (butEdge.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < graph.VCount; i++)
                    {
                        if (Math.Pow((graph.V[i].x - e.X), 2) + Math.Pow((graph.V[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (selected1 == -1)
                            {
                                G.DrawSelectVertex(graph.V[i]);
                                selected1 = i;
                                DrowerPanel.Image = G.GetBitmap();
                                break;
                            }
                            if (selected2 == -1)
                            {
                                G.DrawSelectVertex(graph.V[i]);
                                selected2 = i;
                                graph.E.Add(new Edge(selected1, selected2));
                                G.DrawEdgeorArc(graph.V[selected1], graph.V[selected2], graph.E[graph.ECount - 1], graph.ECount - 1);
                                selected1 = -1;
                                selected2 = -1;
                                DrowerPanel.Image = G.GetBitmap();
                                break;
                            }
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((selected1 != -1) &&
                        (Math.Pow((graph.V[selected1].x - e.X), 2) + Math.Pow((graph.V[selected1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.DrawVertex(graph.V[selected1], (selected1 + 1).ToString());
                        selected1 = -1;
                        DrowerPanel.Image = G.GetBitmap();
                    }
                }
            }
            //нажата кнопка "удалить элемент"
            if (butDelete.Enabled == false)
            {
                bool flag = false; //удалили ли что-нибудь по ЭТОМУ клику
                //ищем, возможно была нажата вершина
                for (int i = 0; i < graph.VCount; i++)
                {
                    if (Math.Pow((graph.V[i].x - e.X), 2) + Math.Pow((graph.V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < graph.ECount; j++)
                        {
                            if ((graph.E[j].Vertex1 == i) || (graph.E[j].Vertex2 == i))
                            {
                                graph.E.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (graph.E[j].Vertex1 > i) graph.E[j].Vertex1--;
                                if (graph.E[j].Vertex2 > i) graph.E[j].Vertex2--;
                            }
                        }
                        graph.V.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                //ищем, возможно было нажато ребро
                if (!flag)
                {
                    for (int i = 0; i < graph.ECount; i++)
                    {
                        if (graph.E[i].Vertex1 == graph.E[i].Vertex2) //если это петля
                        {
                            if ((Math.Pow((graph.V[graph.E[i].Vertex1].x - G.R - e.X), 2) + Math.Pow((graph.V[graph.E[i].Vertex1].y - G.R - e.Y), 2) <= ((G.R + 2) * (G.R + 2))) &&
                                (Math.Pow((graph.V[graph.E[i].Vertex1].x - G.R - e.X), 2) + Math.Pow((graph.V[graph.E[i].Vertex1].y - G.R - e.Y), 2) >= ((G.R - 2) * (G.R - 2))))
                            {
                                graph.E.RemoveAt(i);
                                flag = true;
                                break;
                            }
                        }
                        else //не петля
                        {
                            if (((e.X - graph.V[graph.E[i].Vertex1].x) * (graph.V[graph.E[i].Vertex2].y - graph.V[graph.E[i].Vertex1].y) / (graph.V[graph.E[i].Vertex2].x - graph.V[graph.E[i].Vertex1].x) + graph.V[graph.E[i].Vertex1].y) <= (e.Y + 4) &&
                                ((e.X - graph.V[graph.E[i].Vertex1].x) * (graph.V[graph.E[i].Vertex2].y - graph.V[graph.E[i].Vertex1].y) / (graph.V[graph.E[i].Vertex2].x - graph.V[graph.E[i].Vertex1].x) + graph.V[graph.E[i].Vertex1].y) >= (e.Y - 4))
                            {
                                if ((graph.V[graph.E[i].Vertex1].x <= graph.V[graph.E[i].Vertex2].x && graph.V[graph.E[i].Vertex1].x <= e.X && e.X <= graph.V[graph.E[i].Vertex2].x) ||
                                    (graph.V[graph.E[i].Vertex1].x >= graph.V[graph.E[i].Vertex2].x && graph.V[graph.E[i].Vertex1].x >= e.X && e.X >= graph.V[graph.E[i].Vertex2].x))
                                {
                                    graph.E.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                //если что-то было удалено, то обновляем граф на экране
                if (flag)
                {
                    G.ClearSheet();
                    G.DrawGraph(graph.V, graph.E);
                    DrowerPanel.Image = G.GetBitmap();
                }
            }
        }

        private void createAdjAndOut()
        {
            AMatrix = new int[graph.VCount, graph.VCount];
            G.fillAdjacencyMatrix(graph.VCount, graph.E, AMatrix);
            listBoxMatrix.Items.Clear();
            string sOut = "    ";
            for (int i = 0; i < graph.VCount; i++)
                sOut += (i + 1) + " ";
            listBoxMatrix.Items.Add(sOut);
            for (int i = 0; i < graph.VCount; i++)
            {
                sOut = (i + 1) + " | ";
                for (int j = 0; j < graph.VCount; j++)
                    sOut += AMatrix[i, j] + " ";
                listBoxMatrix.Items.Add(sOut);
            }
        }

        private void createIncAndOut()
        {
            if (graph.ECount > 0)
            {
                IMatrix = new int[graph.VCount, graph.ECount];
                G.fillIncidenceMatrix(graph.VCount, graph.E, IMatrix);
                listBoxMatrix.Items.Clear();
                string sOut = "    ";
                for (int i = 0; i < graph.ECount; i++)
                    sOut += (char)('a' + i) + " ";
                listBoxMatrix.Items.Add(sOut);
                for (int i = 0; i < graph.VCount; i++)
                {
                    sOut = (i + 1) + " | ";
                    for (int j = 0; j < graph.ECount; j++)
                        sOut += IMatrix[i, j] + " ";
                    listBoxMatrix.Items.Add(sOut);
                }
            }
            else
                listBoxMatrix.Items.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO:
            G.GetBitmap().Save("Graph");
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DrowerPanel.Image != null && !AsSave)
            {
                if (MessageBox.Show("Данные не были сохранены и будут потеряны. Желаете сохранить их!", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                     DialogResult.Yes)
                {
                    SaveAs();
                }
                Application.Exit();
            }
        }

        private void неориентированныйГрафToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ориентированныйГрафToolStripMenuItem.Checked = false;
            неориентированныйГрафToolStripMenuItem.Checked = true;

            G = new DrawerGraph(DrowerPanel.Width, DrowerPanel.Height);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Открыть";
            openFile.CheckPathExists = true;
            openFile.CheckFileExists = true;
            //TODO:
        }

        private void ориентированныйГрафToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ориентированныйГрафToolStripMenuItem.Checked = true;
            неориентированныйГрафToolStripMenuItem.Checked = false;

            G = new DrawerGraph(DrowerPanel.Width, DrowerPanel.Height, true);
        }

        public void SaveAs()
        {//TODO:
            if (DrowerPanel.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Сохранить картинку как...";
                saveFile.OverwritePrompt = true;
                saveFile.CheckPathExists = true;
                saveFile.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                saveFile.ShowHelp = true;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DrowerPanel.Image.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaintGraph();
            G.ClearSheet();
            G.DrawGraph(graph.V, graph.E);
            DrowerPanel.Image = G.GetBitmap();
        }

        List<ColorGroups> colorGroups;

        private void PaintGraph()
        {
            CreateGroups();
            AMatrix = new int[graph.VCount, graph.VCount];
            G.fillAdjacencyMatrix(graph.VCount, graph.E, AMatrix);

            List<int> VColor = new List<int>(); int fl;
            int[,] AMCopy = AMatrix;
            int iGroup = 0;
            for (int i = 0; i < AMCopy.GetLength(0); i++)
            {
                fl = 0;
                foreach (int V in VColor)
                {
                    if (i == V)
                    {
                        fl++;
                    }
                }

                if (fl == 0)
                {
                    VColor.Add(i);
                    colorGroups[iGroup].Group.Add(i);

                    for (int j = 0; j < AMCopy.GetLength(1); j++)
                    {
                        if (AMCopy[i, j] == 0)
                        {
                            VColor.Add(j);
                            colorGroups[iGroup].Group.Add(j);
                            for (int s = 0; s < AMCopy.GetLength(1); s++)
                            {
                                try
                                {
                                    AMCopy[i, s] = Math.Abs(AMCopy[i, s]) + Math.Abs(AMCopy[j, s]);
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                    iGroup+=3;
                }
            }

            PaintVertex(colorGroups);
        }
        
        private void CreateGroups()
        {
            colorGroups = new List<ColorGroups>();

            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            foreach (string colorName in colorNames)
            {
                KnownColor knownColor = (KnownColor)Enum.Parse(typeof(KnownColor), colorName);
                if (knownColor > KnownColor.Transparent)
                {
                    ColorGroups colors = new ColorGroups { Color = Color.FromKnownColor(knownColor), Group=new List<int>() };
                    colorGroups.Add(colors);
                }
            }
        }

        private void PaintVertex(List<ColorGroups> colorGroups)
        {
            for (int i = 0; i < graph.VCount; i++)
            {
                foreach (ColorGroups color in colorGroups)
                {
                    foreach (int vertex in color.Group)
                    {
                        if (vertex == i)
                        {
                            graph.V[i].Color = color.Color;
                        }
                    }
                }
            }
        }
    }
}
