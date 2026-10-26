using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_31251021088_Buoi3
{
    internal class Ex_02
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n và k: ");
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            Queue<int> q = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                q.Enqueue(i);
            }

            Console.Write("Thứ tự người bị loại: ");
            while (q.Count > 1)
            {
                for (int i = 1; i < k; i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                Console.Write(q.Dequeue() + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Người còn lại: " + q.Dequeue());
        }        
    }
}
