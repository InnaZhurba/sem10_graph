using System.Collections.Generic;

namespace sem10_graph.task_8
{
    public class EngineCreation
    {
        private int[] p;//time cost
        private List<int[]> arr;

        public EngineCreation(int[] p, List<int[]> arr)
        {
            this.p = p;
            this.arr = arr;
        }

        public int TimeOverall(int sum, int numInd)
        {
            numInd--;
            sum += p[numInd];
            if (arr[numInd] == null) 
                return sum;
            for (int i = 0; i < arr[numInd].Length; i++)
                sum = TimeOverall(sum, arr[numInd][i]);
            return sum;
        }
    }
}