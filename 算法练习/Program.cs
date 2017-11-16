using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 5, 3, 4, 6, 9, 7, 1, 2, 0 };
            //InsertSort(a, a.Length);
            //BubbleSort(a, a.Length);
            //SelectSort(a, a.Length);
            QuickSort(a, 0, a.Length - 1);
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 插入排序，稳定，算法复杂度为O(n^2)。
        /// </summary>
        static void InsertSort(int[] a,int n)
        {
            int temp;
            int i, j;
            for (i = 0; i < n; i++)
            {
                temp = a[i];
                //从后向前循环，将a[0]~a[i-1]中大于temp的值后移
                for (j = i - 1; j >= 0; j--)
                {
                    if (a[j] < temp) break;
                    else
                        a[j + 1] = a[j];
                }
                a[j + 1] = temp;    //最后将要插入的元素插入到合适的位置
            }
        }
        /// <summary>
        /// 冒泡排序，稳定，复杂度O(n^2)
        /// </summary>
        static void BubbleSort(int[] a, int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 选择排序，不稳定，复杂度O(n^2)
        /// </summary>
        static void SelectSort(int[] a, int n)
        {
            int minIndex;   //最小元素下标
            int temp;

            for(int i = 0; i < n-1; i++)
            {
                minIndex = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (a[minIndex] > a[j])
                        minIndex = j;
                }
                temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }
        }
        /// <summary>
        /// 快速排序：不稳定，时间复杂度 最理想 O(nlogn) 最差时间O(n^2)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static void QuickSort(int[] a, int left, int right)
        {
            if (left >= right) return;

            int i = left;
            int j = right;
            int key = a[left];

            while (i < j)
            {
                while (i < j && key < a[j])
                {
                    j--;
                }
                if (key > a[j]) a[i] = a[j];
                while (i < j && key > a[i])
                {
                    i++;
                }
                if (key < a[i]) a[j] = a[i];
            }
            a[i] = key;
            QuickSort(a, left, i - 1);
            QuickSort(a, i + 1, right);
        }

        //堆排序：不稳定，时间复杂度 O(nlog n)
        //归并排序：稳定，时间复杂度 O(nlog n)
        //希尔排序：不稳定，时间复杂度 平均时间O(nlogn)最差时间O(n^s)
    }
}
