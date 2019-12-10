using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public abstract class Travaler
    {
        public struct Route
        {
            public List<int> Vertaxs;
            public int Weight;
        }

        struct EvaluationVertex
        {
            public int EvaluationEdge;
            public int Row;
            public int Column;
        }
        static List<EvaluationVertex> evaluations = new List<EvaluationVertex>();

        static List<int> routes = new List<int>();

        static int[,] Matrix = GetMatrix();
        static int[,] CopyMatrix = Matrix;
        static int[] Column = new int[Matrix.GetLength(0)];
        static int[] Row = new int[Matrix.GetLength(1)];

        public static Route GetShortRoute(int vertax)
        {
            Route ShortRoute = new Route();

            routes.Add(vertax);
            Reducion();
            ShortRoute.Vertaxs = routes;
            for(int i=0;i<routes.Count-1;i++)
            {
                ShortRoute.Weight += Matrix[routes[i], routes[i + 1]];
            }

            return ShortRoute;
        }

        private static void Reducion()
        {
            Minimalizate(CopyMatrix);

            for (int i = 0; i < Graph.VCount; i++)
            {
                for (int j = 0; j < Graph.VCount; j++)
                {
                    if (CopyMatrix[i, j] != 0)
                    {
                        CopyMatrix[i, j] -= Column[i];
                        CopyMatrix[j, i] -= Row[i];
                    }
                }
            }

            Evaluation();
        }

        private static void Evaluation()
        {
            for (int i = 0; i < Graph.VCount; i++)
            {
                for (int j = 0; j < Graph.VCount; j++)
                {
                    if (CopyMatrix[i, j] == 0)
                    {
                        evaluations.Add(new EvaluationVertex { EvaluationEdge = Minimalizate(j, i, CopyMatrix), Row = i, Column = j });
                    }
                }
            }

            int max = -1, num = 0; ;
            for (int i=0;i< evaluations.Count;i++)
            {
                if (max < evaluations[i].EvaluationEdge)
                {
                    max = evaluations[i].EvaluationEdge;
                    num = 0;
                }
            }
            EvaluationVertex evaluation = evaluations[num];
            Clear(true, evaluation.Row);
            Clear(false, evaluation.Column);
            routes.Add(evaluation.Column);
            if(routes[0] != evaluation.Column)
            {
                Reducion();
            }
        }

        private static void Clear(bool row_column, int num)
        {
            for (int i = 0; i < Graph.VCount; i++)
            {
                if (row_column)
                {
                    CopyMatrix[num, i] = -1;
                }
                else
                {
                    CopyMatrix[i, num] = -1;
                }
            }
        }

        private static int Minimalizate(int[,] matrix)
        {
            int var1 = 0, var2 = 0;
            for (int i = 0; i < Graph.VCount; i++)
            {
                var1 = Column[i] = MinColumn(i, matrix);
                var2 = Row[i] = MinRow(i, matrix);
            }
            return var1 + var2;
        }

        private static int Minimalizate(int column,int row,int[,] matrix)
        {
            int var1 = 0, var2 = 0;
            for (int i = 0; i < Graph.VCount; i++)
            {
                var1=Column[row] = MinColumn(column, matrix);
                var2=Row[column] = MinRow(row, matrix);
            }
            return var1 + var2;
        }

        private static int MinColumn(int colum, int[,] matrix)
        {
            int min = int.MaxValue;

            for (int i = 0; i < Graph.VCount; i++)
            {
                if (matrix[i, colum] < min && matrix[i, colum]>=0)
                {
                    min = matrix[i, colum];
                }

            }

            return min;
        }

        private static int MinRow(int row, int[,] matrix)
        {
            int min = int.MaxValue;

            for (int i = 0; i < Graph.VCount; i++)
            {
                if (matrix[i, row] < min && matrix[row, i] >= 0)
                {
                    min = matrix[row, i];
                }

            }

            return min;
        }

        private static int[,] GetMatrix()
        {
            int[,] Matrix = new int[Graph.VCount, Graph.VCount];

            for (int i = 0; i < Graph.VCount; i++)
            {
                for (int j = 0; j < Graph.VCount; j++)
                {
                    Matrix[i, j] = 0;
                }
            }

            for (int i = 0; i < Graph.VCount; i++)
            {
                for (int j = 0; j < Graph.VCount; j++)
                {
                    foreach (Edge edge in Graph.E)
                    {
                        if (edge.Vertex1 == i && edge.Vertex2 == j)
                        {
                            Matrix[i, j] = edge.Weight;
                        }
                    }
                }
            }

            return Matrix;
        }
    }
}
