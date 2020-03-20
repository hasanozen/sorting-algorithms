using System.Diagnostics;
using System.Threading;

namespace SortingAlgorithms
{
    class Algorithms
    {
        static public Stopwatch sortTime = new Stopwatch();
        public static void Selection(int[] A)
        {
            Form1.Instance.SetStatus();

            int tmp;
            int arrLenght = A.Length;

            sortTime = Stopwatch.StartNew();
            for (int i = 0; i < arrLenght - 1; i++)
            {
                for (int j = i + 1; j < arrLenght; j++)
                {
                    if (A[j] < A[i])
                    {
                        tmp = A[i];
                        A[i] = A[j];
                        A[j] = tmp;

                        Count(4, 1);

                        SleepAndMeasure();
                    }
                    else
                        Count(0, 1);
                }
            }
            sortTime.Stop();

            Form1.isSorted = true;
        }
        public static void Bubble(int[] A)
        {
            Form1.Instance.SetStatus();

            int tmp;
            int arrLenght = A.Length;

            sortTime = Stopwatch.StartNew();
            for (int i = 0; i < arrLenght; i++)
            {
                for (int j = 0; j < arrLenght - 1; j++)
                {
                    if (A[j + 1] < A[j])
                    {
                        tmp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = tmp;

                        Count(4, 1);

                        SleepAndMeasure();
                    }
                    else
                        Count(0, 1);
                }
            }
            sortTime.Stop();

            Form1.isSorted = true;
        }
        public static void Cocktail(int[] A)
        {
            Form1.Instance.SetStatus();

            int tmp;
            bool swapped = true;
            int arrLenght = A.Length;

            sortTime = Stopwatch.StartNew();
            while (swapped == true)
            {
                swapped = false;

                for (int j = arrLenght - 1; j > 0; j--)
                {
                    if (A[j - 1] > A[j])
                    {
                        tmp = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = tmp;
                        swapped = true;

                        Count(4, 1);
                    }
                    else
                        Count(0, 1);

                    SleepAndMeasure();
                }

                if (swapped == false)
                    break;

                for (int j = 0; j < arrLenght - 1; j++)
                {
                    if (A[j + 1] < A[j])
                    {
                        tmp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = tmp;
                        swapped = true;

                        Count(4, 1);
                    }
                    else
                        Count(0, 1);

                    SleepAndMeasure();
                }

            }
            sortTime.Stop();

            Form1.isSorted = true;
        }
        public static void OddEven(int[] A)
        {
            Form1.Instance.SetStatus();

            int tmp;
            bool swapped = true;
            int arrLenght = A.Length;

            int i = 0;
            sortTime = Stopwatch.StartNew();
            while (swapped == true)
            {
                swapped = false;
                for (int j = i % 2 == 0 ? j = 0 : j = 1; j < arrLenght - 1; j += 2)
                {
                    if (A[j + 1] < A[j])
                    {
                        tmp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = tmp;
                        swapped = true;

                        Count(4, 1);

                        SleepAndMeasure();
                    }
                    else
                        Count(0, 1);
                }
                i++;
            }
            sortTime.Stop();

            Form1.isSorted = true;
        }
        public static void Comb(int[] A)
        {
            Form1.Instance.SetStatus();

            int tmp;
            int arrLenght = A.Length;
            int gap = arrLenght;
            bool swapped = true;

            sortTime = Stopwatch.StartNew();
            while ((gap != 1) || (swapped == true))
            {
                gap = (int)(gap / 1.3);

                if (gap < 1)
                {
                    gap = 1;
                    swapped = false;
                }

                for (int i = 0; i < arrLenght - gap; i++)
                {
                    if (A[i] > A[i + gap])
                    {
                        tmp = A[i];
                        A[i] = A[i + gap];
                        A[i + gap] = tmp;
                        swapped = true;

                        Count(4, 1);

                        SleepAndMeasure();
                    }
                    else
                        Count(0, 1);
                }
            }
            sortTime.Stop();

            Form1.isSorted = true;
        }
        public static void Insertion(int[] A)
        {
            int tmp, j;
            int arrLenght = A.Length;

            sortTime = Stopwatch.StartNew();
            for (int i = 1; i < arrLenght; i++)
            {
                Form1.Instance.SetStatus();

                tmp = A[i];
                j = i - 1;

                Count(1, 0);

                while ((j > -1) && (A[j] > tmp))
                {
                    A[j + 1] = A[j];
                    j--;
                    A[j + 1] = tmp;

                    Count(3, 2);

                    SleepAndMeasure();
                }
            }
            sortTime.Stop();

            Form1.isSorted = true;
        }
        public static void Shell(int[] A)
        {
            Form1.Instance.SetStatus();

            int tmp;
            int arrLenght = A.Length;

            sortTime = Stopwatch.StartNew();
            for (int gap = arrLenght / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < arrLenght; i++)
                {
                    tmp = A[i];

                    Count(0, 1);

                    int j;
                    for (j = i; j >= gap && A[j - gap] > tmp; j -= gap)
                    {
                        A[j] = A[j - gap];
                        Count(2, 1);
                    }

                    A[j] = tmp;
                    Count(1, 0);

                    SleepAndMeasure();
                }
            }
            sortTime.Stop();

            Form1.isSorted = true;
        }
        //----------------------- MERGE SORT -----------------------// TODO: Fix time measurement
        public static void MergeSort(int[] A, int startIndex, int endIndex, int arraySize)
        {
            int middleOfArray;

            Form1.Instance.SetStatus();

            sortTime = Stopwatch.StartNew();
            if (startIndex < endIndex)
            {
                middleOfArray = (startIndex + endIndex) / 2;
                MergeSort(A, startIndex, middleOfArray, arraySize);
                MergeSort(A, middleOfArray + 1, endIndex, arraySize);


                Merge(A, startIndex, middleOfArray, middleOfArray + 1, endIndex, arraySize);

                SleepAndMeasure();
            }
            sortTime.Stop();
        }
        private static void Merge(int[] A, int start, int middle, int oneMoreOfMiddle, int end, int size)
        {
            int tempStart, tempMiddle, tempEnd;
            int[] tempA = new int[size];
            tempStart = start;
            tempMiddle = oneMoreOfMiddle;
            tempEnd = 0;

            while (tempStart <= middle && tempMiddle <= end)
            {
                if (A[tempStart] < A[tempMiddle])
                {
                    tempA[tempEnd++] = A[tempStart++];
                    Count(1, 1);
                }
                else
                {
                    tempA[tempEnd++] = A[tempMiddle++];
                    Count(1, 1);
                }
            }

            while (tempStart <= middle)
            {
                tempA[tempEnd++] = A[tempStart++];
                Count(1, 0);
            }

            while (tempMiddle <= end)
            {
                tempA[tempEnd++] = A[tempMiddle++];
                Count(1, 0);
            }

            for (tempStart = start, tempMiddle = 0; tempStart <= end; tempStart++, tempMiddle++)
            {
                A[tempStart] = tempA[tempMiddle];
                Count(1, 0);
                Thread.Sleep(Form1.delayMs);
            }
        }
        //----------------------- MERGE SORT -----------------------//

        //----------------------- COUNTING SORT -----------------------//
        public static void CountSort(int[] A)
        {
            int n = A.Length;
            int[] output = new int[n];
            int[] count = new int[Form1.upperSize];

            sortTime = Stopwatch.StartNew();
            for (int i = 0; i < count.Length; i++)
                count[i] = 0;

            for (int i = 0; i < n; i++)
            {
                count[A[i]] += 1;
                Count(1, 0);
                SleepAndMeasure();
            }

            for (int i = 1; i <= count.Length - 1; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[A[i]] - 1] = A[i];
                count[A[i]]--;
                Count(3, 0);
            }

            for (int i = 0; i < n; ++i)
            {
                A[i] = output[i];
                Count(1, 0);

                SleepAndMeasure();
            }
            sortTime.Start();

        }
        //----------------------- COUNTING SORT -----------------------//

        //----------------------- QUICK SORT -----------------------//
        public static void QuickSort(int[] arr, int low, int high)
        {

            sortTime = Stopwatch.StartNew();

            ApplyQuickSort(arr, low, high);

            sortTime.Stop();
        }

        private static void ApplyQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                
                ApplyQuickSort(arr, low, pi - 1);
                ApplyQuickSort(arr, pi + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            Count(0, 1);

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    Count(4, 1);
                }

                SleepAndMeasure();
            }
            
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            Count(4, 1);

            SleepAndMeasure();

            return i + 1;
        }
        //----------------------- QUICK SORT -----------------------//

        private static void Count(int accessCount, int compCount)
        {
            Form1.comparison += compCount;
            Form1.arrayAccess += accessCount;
        }

        private static void SleepAndMeasure()
        {
            sortTime.Stop();
            Thread.Sleep(Form1.delayMs);
            sortTime.Start();
        }
    }
}
