using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace sem10_graph.task_10
{
    public class BellmanFordAproach
    {
        private static Dictionary<int,int> edges = new();

        private static void InitializeEdges(int n)
        {
            for (int i = 0; i < n; i++)
            {
                edges.Add(i+1,0);
            }
        }
        public static int MaxPosibility(int[,] arr, int n, int m)//arr[m,3); //edges[n,2]
        {
            InitializeEdges(n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int tempSum = edges[arr[i, 0]] + arr[i, 2];
                    if (tempSum > edges[arr[i, 1]])
                        edges[arr[i, 1]] = tempSum;
                }
            }
            
            return edges.Values.Max();
        }
    }
}