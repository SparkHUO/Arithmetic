using System;
using System.Collections.Generic;


namespace LeetcodeTest
{
    internal class Program
    {

        //static int[] array = new int[] { 10, 5, 99, 10, 0, 1, 1001, 2, 55, 64, 13, 21, 17, 3 };
        static int[][] array = new int[][] { new int[] {5,1,9,11 }, new int[] { 2, 4, 8,10 }, new int[] { 13, 3, 6,7 },new int[] {15,14,12,16 } };
       
        static void Main(string[] args)
        {
            //QuickSort(array,0,array.Length-1);
            //ShowArray(array);

           

            for (int i = 0; i < array[0].Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            Rotate(array);
            Console.WriteLine();

            for (int i = 0; i < array[0].Length; i++)
            {
                for (int j = 0; j < array[0].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        public static void Rotate(int[][] matrix)
        {
            int length = matrix[0].Length;
            //上下边界进行交换；
            for (int i = 0; i < length; i++)
            {
                int temp = matrix[0][i];
                matrix[0][i] = matrix[length - 1][i];
                matrix[length - 1][i] = temp;
            }
            int t = 0;
            while (t < length)
            {
                for (int i = t+1; i < length; i++)
                {
                    int temp = matrix[t][i];
                    matrix[t][i] = matrix[i][t];
                    matrix[i][t] = temp;
                }
                t++;
            }
        }



        private static void ShowArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// 快速排序：最坏时间复杂度：O(n²)  ，空间复杂度O(1)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void QuickSort(int[] array,int left,int right)
        {
            if (left<right)     //递归的结束条件
            {
                int temp = array[left]; //先挖出一个基准数
                int i = left;
                int j = right;
                while (i < j)     //一直循环到i = j时，将array[i] = temp;
                {
                    while (i < j)
                    {
                        if (array[j] <= temp)
                        {
                            array[i] = array[j];
                            break;
                        }
                        j--;
                    }
                    while (i < j)
                    {
                        if (array[i] > temp)
                        {
                            array[j] = array[i];
                            break;
                        }
                        i++;
                    }
                }
                array[i] = temp;
                QuickSort(array, left, i - 1);
                QuickSort(array, i + 1, array.Length - 1);
            }
        }



        /// <summary>
        /// 冒泡排序，时间复杂度O(n²)，空间复杂度O(1)
        /// </summary>
        /// <param name="array"></param>
        private static void BubbleSort(int[] array)
        {
            bool flag = false;
            for (int i = 0; i < array.Length-1; i++)
            {
                flag = false;
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }
                if (flag==false)
                {
                    break;
                }
            }
        }


        /// <summary>
        /// 插入排序：，时间复杂度O(n²)，空间复杂度O(1)
        /// </summary>
        /// <param name="array"></param>
        private static void InsertSort(int[] array)       
        {

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                    else break;
                }
            }
        }




        /// <summary>
        /// 希尔排序:是插入排序的一种优化，时间复杂度O(n²) ，空间复杂度O(1)
        /// </summary>
        /// <param name="array"></param>
        private static void ShellSort(int[] array)
        {
            int step = array.Length / 2;
            int temp = 0;
            while (step>=1)
            {
                for (int i = step; i < array.Length; i++)
                {
                    for (int j = i; j >= step; j-=step)
                    {
                        if (array[j] < array[j-step])
                        {
                            temp = array[j];
                            array[j] = array[j-step];
                            array[j - step] = temp;
                        }
                    }
                }
                step /= 2;
            }
        }


        /// <summary>
        /// 堆排序：
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        private static void HeapSort(int[] array)
        {
            //构造初始大顶堆
            for (int i = array.Length/2-1; i >=0 ; i--)
            {
                AdjustHeap(array, i, array.Length);
            }

            for (int i = array.Length - 1; i >0 ; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                AdjustHeap(array, 0, i);
            }
        }
        private static void AdjustHeap(int[] array,int parent,int length)
        {
            int temp = array[parent];
            int child = parent * 2 + 1;
            while (child<length)
            {
                if (child + 1 < length && array[child + 1] > array[child])
                {
                    child++;
                }
                if (temp > array[child])
                {
                    break;
                }
                array[parent] = array[child];
                parent = child;
                child = parent * 2 +1;
            }
            array[parent] = temp;
        }


        /// <summary>
        /// 二叉排序树：
        /// </summary>
        /// <param name="array"></param>
        private static void BinaryTreeSort(int[] array)
        {
            TreeNode tree = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                tree.Insert(array[i]);
            }

            tree.MiddleSearch();
            
        }
        
        /// <summary>
        /// 数字反转
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int ReverseNumber(int num)  //123 
        {
            int res = 0;
            while (num>0)
            {
                int temp = num % 10;
                res = res * 10 + temp;
                num = num / 10;
            }
            return res;
        }



      


    }


   







}
