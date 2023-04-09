using System;

namespace Arithmetic
{
    internal class Program
    {
        static int index = 0; //轮次
        static void Main(string[] args)
        {
            //int[] array = new int[] { 8, 5, 7, 10, 56, 3, 100 };
            int[] array = new int[] { 5,1,8,3,4,2,0,11,10};
            //AdjustHeap(array, 0, array.Length);

            //BubbleSort(array);  //冒泡排序
            //InsertSort(array);   //插入排序
            //ShellSort(array); //希尔排序
            HeapSort(array);    //堆排序
            //BinaryTreeSort(array);  //二叉排序树
            //QuickSort(array, 0, array.Length-1);  //快速排序；


            ShowArray(array);



        }

        static void ShowArray(int[] arr)
        {
            Console.Write("轮次：" + index++ + "数组：");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }



        /// <summary>
        /// 冒泡排序，排序的轮次是数组的长度减一次，时间复杂度：O(n²) ，空间复杂度：O(1),空间的占用在方法之外
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        static void BubbleSort(int[] arr)
        {
            int temp = arr[0];
            bool flag = false; //标志位：本轮是否发生了交换，如果没发生交换则直接ruturn,
            for (int i = 0; i < arr.Length - 1; i++)
            {
                flag = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }
        }


        /// <summary>
        /// 插入排序：从索引1开始，向前依次比较，直到找到中间位置插入。时间复杂度：O(n²)；空间复杂度：O(1);最好时间复杂度：O(n);
        /// </summary>
        /// <param name="arr"></param>
        static void InsertSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++) //一共要比较数组长度-1次
            {
                for (int j = i + 1; j > 0 && arr[j] < arr[j - 1]; j--)  //寻找中间位置插入
                {

                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
                ShowArray(arr);
            }
        }


        /// <summary>
        /// 希尔排序：最坏时间复杂度：O(n²) ;最好的时间复杂度：O(n)；空间复杂度：O(1)
        /// </summary>
        /// <param name="arr"></param>
        static void ShellSort(int[] arr)
        {
            int step = arr.Length / 2;  //设置步长
            int temp = 0;
            while (step > 0)   //此处提供的时间复杂度是O(logn)
            {
                for (int j = step; j < arr.Length; j++)
                {
                    for (int i = j; i >= step && arr[i] < arr[i - step]; i -= step)
                    {
                        temp = arr[i];
                        arr[i] = arr[i - step];
                        arr[i - step] = temp;
                    }
                }
                ShowArray(arr);
                step = step / 2;
            }
        }


        /// <summary>
        /// 堆排序：时间复杂度O(nlogn);空间复杂度：O(1)
        /// </summary>
        /// <param name="list"></param>
        static void HeapSort(int[] list)
        {
            //构建初始堆
            for (int i = list.Length / 2 - 1; i >= 0; i--)    //第一个非叶子节点，向上比较
            {
                AdjustHeap(list, i, list.Length);
            }
            //进行n-1次循环，完成排序
            for (int i = list.Length - 1; i > 0; i--)
            {
                //最后一个元素和第一个元素进行交换
                int temp = list[i];
                list[i] = list[0];
                list[0] = temp;

                //筛选R【0】节点，得到i-1个节点的堆
                AdjustHeap(list, 0, i);
            }
        }


        /// <summary>
        /// 调整堆的方法：将堆调整为大顶堆
        /// </summary>
        /// <param name="array">比较的数组 </param>
        /// <param name="parent">父节点的索引位</param>
        /// <param name="Length">数组的长度</param>
        static void AdjustHeap(int[] array, int parent, int Length)
        {
            int temp = array[parent]; //temp记录父节点,将其插入对应节点中
            int child = 2 * parent + 1; //先获得左子节点
            while (child < Length)
            {
                //与子节点比较
                if (child + 1 < Length && array[child] < array[child + 1])
                {
                    child++;
                }
                //如果父节点的值已经大于较大那个子节点的值，说明已经到达插入位置，则结束判断；如果一直未满足该条件，则是最末尾的parent节点将赋值temp
                if (temp >= array[child])
                    break;
                //把较大孩子节点的值赋给父节点，不断向上推
                array[parent] = array[child];
                //选取孩子节点的左孩子结点，继续向下筛选
                parent = child;
                child = 2 * child + 1;
            }
            array[parent] = temp;

        }


        /// <summary>
        ///通过二叉排序树进行中序遍历来对数组进行排序,时间复杂度：O(nlogn)，空间复杂度O（n），不稳定
        /// </summary>
        /// <param name="array"></param>
        static void BinaryTreeSort(int[]array)
        {
            var binarySortTreeNode = new BinarySortTreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                binarySortTreeNode.Insert(array[i]);
            }
            binarySortTreeNode.IncorderTraversal();
        }


        /// <summary>
        /// 对数组dataArray中索引从left到right之间的数据做排序
        /// </summary>
        /// <param name="dataArray"></param>
        /// <param name="left">开始索引</param>
        /// <param name="right">结束索引</param>
        static void QuickSort(int[] dataArray,int left,int right)  //i = 0;j = arr.Length
        {
            if (left<right)
            {
                int x = dataArray[left];//基准数：把比它小或者等于的放在它的左边，然后比他大的放在它的右边
                int i = left;
                int j = right;
                while (i<j)  //当i=j时，说明我们找到了一个中间位置，这个中间位置就是基准数应该所在的位置；
                {
                    while (i < j)  //从后往前比较，找一个比x小的数字，放在i的位置
                    {
                        if (dataArray[j] <= x) //找到了一个比基准数小于或者等于的数字，应该把它放在x的左边
                        {
                            dataArray[i] = dataArray[j]; break;
                        }
                        else j--;//向左移动 到下一个数字，然后作比较
                    }
                    while (i < j) //从前往后，找一个比x大的数字，放在我们的坑里边，现在的坑在j的位置
                    {
                        if (dataArray[i] > x)
                        {
                            dataArray[j] = dataArray[i]; break;
                        }
                        else i++;
                    }
                }
                dataArray[i] = x; //现在i = j；i是中间位置，基准数放于此处
                QuickSort(dataArray,left,i-1);//递归
                QuickSort(dataArray,i+1,right);
            }
        }






    }


   





}
