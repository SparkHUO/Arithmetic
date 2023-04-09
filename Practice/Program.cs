using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Practice
{
    internal class Program
    {
        //static int[] array = new int[] { 10, 53, 99, 10, 36, 11, 22, 55, 16, 53, 121 };
        //static int[] test = new int[] { 1, 1, 1, 0, 0 };
        static string str1 = "100,3,2,1,10";
        static string str2 = "-50,4,5,6,55";

        static string str3 = "abcaABC";


        static void Main(string[] args)
        {


            Console.Write("Second Commit and Push!");
            Console.Write("Function01!");

        }

        static List<int> ConcatAndSort(string str1, string str2)
        { 
            List<int> list = new List<int>();
            string[] strArray1 = str1.Split(',');
            string[] strArray2 = str2.Split(',');

            for(int i =0;i<strArray1.Length;i++)
            {
                list.Add(StringToInt(strArray1[i]));
            }
            for (int i = 0; i < strArray2.Length; i++)
            {
                list.Add(StringToInt(strArray2[i]));
            }

            list.Sort();
            list.Reverse();
            return list;

        }

        static int StringToInt(string str)
        {
            int res = 0;
            char[] chars = str.ToCharArray();
            if (chars[0] == '-')
            {
                for (int i = 1; i < chars.Length; i++)
                {
                    res = res * 10 - (chars[i] - '0');
                }
            }
            else 
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    res = res * 10 + (chars[i] - '0');
                }
            }
            return res;
        }


        static int CountString(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int res = 0;
            for (int i=0;i<str.Length;i++)
            {
                if (!dic.ContainsKey(str[i]))
                {
                    dic.Add(str[i], 1);
                }
                else 
                {
                    dic[str[i]]++;
                    if (dic[str[i]] > res) res = dic[str[i]];
                }
            }
            return res;
        }



        static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


        public static void BubbleSort(int[] array)
        {
            int temp = 0;
            bool flag = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                flag = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }
        }
        public static void InsertSort(int[] array)
        {
            int temp = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }
        }
        public static void ShellSort(int[] array)
        {
            int temp = 0;
            int step = array.Length / 2;

            while (step != 0)
            {
                for (int i = step; i < array.Length; i++)
                {
                    for (int j = i; j >= step && array[j] < array[j - step]; j = j - step)
                    {
                        temp = array[j];
                        array[j] = array[j - step];
                        array[j - step] = temp;
                    }
                }
                step /= 2;
            }


        }
        public static void QuickSort(int[] array, int left, int right)
        {
            int temp = array[left];
            int i = left;
            int j = right;
            if (left < right)
            {
                while (i < j)
                {
                    while (i < j)
                    {
                        if (array[j] <= temp)
                        {
                            array[i] = array[j]; break;
                        }
                        j--;
                    }
                    while (i < j)
                    {
                        if (array[i] > temp)
                        {
                            array[j] = array[i]; break;
                        }
                        i++;
                    }
                }
                array[i] = temp;
                QuickSort(array, left, i - 1);
                QuickSort(array, i + 1, right);
            }
        }
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public static void HeapSort(int[] array)
        {
            int temp = 0;
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                HeapAdjust(array, i, array.Length);
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                HeapAdjust(array, 0, i);
            }
        }
        public static void HeapAdjust(int[] array, int parent, int length)
        {
            int temp = array[parent];
            int child = parent * 2 + 1;
            while (child < length)
            {
                if (child + 1 < length && array[child + 1] > array[child])
                {
                    child++;
                }
                if (array[child] < temp) break;
                array[parent] = array[child];
                parent = child;
                child = parent * 2 + 1;
            }
            array[parent] = temp;
        }

        public static void TreeSort(int[] array)
        {
            List<int> list = new List<int>();
            BiTree biTree = new BiTree(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                biTree.Insert(array[i]);
            }
            biTree.MidTraversal(list);
            list.CopyTo(array);
        }

    }

    public class BiTree
    {
        int Val { get; set; }
        BiTree Left { get; set; }
        BiTree Right { get; set; }

        public BiTree(int value, BiTree left = null, BiTree right = null)
        {
            Val = value;
            Left = left;
            Right = right;
        }

        public void Insert(int value)
        {
            if (value<=Val)
            {
                if (Left == null)
                {
                    Left = new BiTree(value); return;
                }
                else { Left.Insert(value); }
            }
            else
            {
                if (Right == null)
                {
                    Right = new BiTree(value); return;
                }
                else { Right.Insert(value); }
            }
        }

        public void MidTraversal(List<int> list)
        {
            Left?.MidTraversal(list);
            list.Add(Val);
            Right?.MidTraversal(list);
        }



    }


}
