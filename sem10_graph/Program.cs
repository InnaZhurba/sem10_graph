using System;
using System.Linq;
using sem10_graph.task_10;

namespace sem10_graph
{
    class Program
    {
        public static int[] intArr_convertor(string[] temp)
        {
            int[] arr = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                arr[i] = Convert.ToInt32(temp[i]);
            }

            return arr;
        }
        public static void task10_UCUDoorPossibilities()
        {
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                return;
            
            int[] n_m = intArr_convertor(str.Split(" "));
            Boolean nmTrigger = true, arrTrigger=true;
            if (n_m == null)
                return;
            
            if ((n_m[0] <= 0 || n_m[0] > 2000) && (n_m[1] <= 0 || n_m[1] > 10000))
                nmTrigger = false;
            
            int[,] arr = new int[n_m[1], 3];
            for (int i = 0; i < n_m[1]; i++)
            {
                int[] temp = intArr_convertor(Console.ReadLine().Split(" "));
                for (int j = 0; j < 3; j++)
                {
                        if (j==2 && temp[j] > 10000)
                            arrTrigger = false;
                        arr[i, j] = temp[j];
                }
            }
            
            if(nmTrigger && arrTrigger)
                Console.WriteLine(BellmanFordAproach.MaxPosibility(arr,n_m[0],n_m[1]));
        }
        static void Main(string[] args)
        {
            task10_UCUDoorPossibilities();
        }
    }
}