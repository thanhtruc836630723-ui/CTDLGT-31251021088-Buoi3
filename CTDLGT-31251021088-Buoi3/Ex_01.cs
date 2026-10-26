using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_31251021088_Buoi3
{
    internal class Ex_01
    {
        public static void Main244(string []args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //Nhập mảng và duyệt mảng
            Console.Write("Nhập nhiệt độ từng ngày: ");
            int[] a = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = a.Length;
            int[] kq = new int[n];
            //Tạo stack
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && a[i] > a[stack.Peek()])
                {
                    int j = stack.Pop();
                    kq[j] = i - j;
                }
                stack.Push(i);
            }
            Console.Write("Kết quả là: ");
            Console.Write(string.Join(" ",kq));
        }
    }
}
