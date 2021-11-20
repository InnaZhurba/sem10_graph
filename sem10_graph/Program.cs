using System;
using System.Collections.Generic;
using System.Linq;
using sem10_graph.task_10;
using sem10_graph.task_8;

namespace sem10_graph
{
    class Program
    {
        public static void task8_EngineCreation()
        {
            int[] p = intArr_convertor(Console.ReadLine().Split(" "));
            if (p.Length < 1 || p.Length > 100000)
                return;
            
            List<int[]> arr = new List<int[]>();
            int sumArrLength = 0;
            
            for (int i = 0; i < p.Length; i++)
            {
                string str = Console.ReadLine();
                int[] tmp = string.IsNullOrWhiteSpace(str) ? null : intArr_convertor(str.Split(" "));
                arr.Add(tmp);
                sumArrLength += tmp?.Length ?? 0;
            }

            if (sumArrLength > 200000)
                return;
            
            EngineCreation engineCreation = new EngineCreation(p,arr);
            Console.WriteLine(engineCreation.TimeOverall(0, 1));
        }
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
            task8_EngineCreation();
            //task10_UCUDoorPossibilities();
        }
    }
}