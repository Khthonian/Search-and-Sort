using System;

namespace Search_and_Sort
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ask the user for the file paths to each of the respective data sets and sort them into individual arrays
            Console.Write("Please input the file path for Road_1_256.txt: ");
            string roadOneFileData = Console.ReadLine();
            string[] roadOneString = System.IO.File.ReadAllLines(roadOneFileData);
            int[] roadOne = Array.ConvertAll(roadOneString, int.Parse);
                       
            Console.Write("Please input the file path for Road_2_256.txt: ");
            string roadTwoFileData = Console.ReadLine();
            string[] roadTwoString = System.IO.File.ReadAllLines(roadTwoFileData);
            int[] roadTwo = Array.ConvertAll(roadTwoString, int.Parse);
            
            Console.Write("Please input the file path for Road_3_256.txt: ");
            string roadThreeFileData = Console.ReadLine();
            string[] roadThreeString = System.IO.File.ReadAllLines(roadThreeFileData);
            int[] roadThree = Array.ConvertAll(roadThreeString, int.Parse);
            Array.Sort(roadThree);
        }

        private static void AscendingSort(int[] arr)
        {
            // Sort the array in ascending order
            Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void DescendingSort(int[] arr)
        {
            // Sort the array in descending order
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void DisplayTenthValues(int[] arr)
        {
            Console.WriteLine("How would you like to sort the data:\n1)Ascending\n2)Descending\n3)No sort\nResponse: ");
            string tenthValueResponse = Console.ReadLine();
            
            if (tenthValueResponse == "Ascending")
            {
                Array.Sort(arr);
                Console.WriteLine("The values you have selected are:");
                for (int i = 10; i < 260; i = i + 10)
                {
                    Console.WriteLine(arr[i]);
                }                
            }
            else if (tenthValueResponse == "Descending")
            {
                Array.Sort(arr);
                Array.Reverse(arr);
                Console.WriteLine("The values you have selected are:");
                for (int i = 10; i < 260; i = i + 10)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else if (tenthValueResponse == "No sort")
            {
                Console.WriteLine("The values you have selected are:");
                for (int i = 10; i < 260; i = i + 10)
                {
                    Console.WriteLine(arr[i]);
                }
                
            }
            else
            {
                Console.WriteLine("Try again");
                DisplayTenthValues(arr);
            }           
        }
        
    }
}
