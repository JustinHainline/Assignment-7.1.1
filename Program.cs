namespace Assignment_7._1._1
{
    internal class Program
    {  
            static void Main(string[] args)
            {                
            int[] examScores = { 75, 79, 90, 99, 89, 87, 65, 55, 97, 90 };
            Console.WriteLine("Initial array:");
            PrintArray(examScores);

                // Sort the array
            Sort(examScores);

            Console.WriteLine();
            Console.WriteLine("Sorted array:");
                // Print the sorted array
            PrintArray(examScores);
            }

            static void Sort(int[] arr)
            {
            // Outer loop points to dividing line between sort and unsorted
                for (int i = 0; i < arr.Length - 1; i++)
                {
                /// Find minimum element in unsorted 
                    int min = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[min])
                        {
                            min = j;
                        }
                    }
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }

            static void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
    }
    


}

