using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// Интерфейс Вершин графа.
    /// </summary>
    public class Vertex
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public Color Color { get;  set; }

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
            Color = Color.White;
        }
    }

    /// <summary>
    /// Интерфейс ребер графа.
    /// </summary>
    public class Edge
    {
        public int Vertex1 { get; set; }
        public int Vertex2 { get; set; }

        public int Weight { get; set; }

        public Edge(int v1,int v2)
        {
            Vertex1 = v1;
            Vertex2 = v2;
        }
    }

    public abstract class Graph
    {
            public static List<Vertex> V { get; set; }
            public static List<Edge> E { get; set; }

            public static int VCount { get { return V.Count; } }

            public static int ECount { get { return E.Count; } }
    }
    
}
