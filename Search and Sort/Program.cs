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
            Console.WriteLine(UserSearch(roadOne, 112));
                                   
            Console.Write("Please input the file path for Road_2_256.txt: ");
            string roadTwoFileData = Console.ReadLine();
            string[] roadTwoString = System.IO.File.ReadAllLines(roadTwoFileData);
            int[] roadTwo = Array.ConvertAll(roadTwoString, int.Parse);
            
            Console.Write("Please input the file path for Road_3_256.txt: ");
            string roadThreeFileData = Console.ReadLine();
            string[] roadThreeString = System.IO.File.ReadAllLines(roadThreeFileData);
            int[] roadThree = Array.ConvertAll(roadThreeString, int.Parse);            
        }

        private static void AscendingSort(int[] arr)
        {
            // Sort the array in ascending order
            int z;
            for (int p = 0; p <= arr.Length - 2; p++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        z = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = z;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void DescendingSort(int[] arr)
        {
            // Sort the array in descending order
            int z;
            for (int p = 0; p <= arr.Length - 2; p++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        z = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = z;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        private static void DisplayTenthValues(int[] arr)
        {
            // Ask user if they would like to sort the values before printing to console
            Console.WriteLine("How would you like to sort the data:\n1)Ascending\n2)Descending\n3)No sort\nResponse: ");
            string tenthValueResponse = Console.ReadLine();
            
            // The Ascending system is reused here
            if (tenthValueResponse == "Ascending")
            {
                int z;
                for (int p = 0; p <= arr.Length - 2; p++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            z = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = z;
                        }
                    }
                }
                // Print each tenth iteration until the max value has been reached
                Console.WriteLine("The values you have selected are:");                
                for (int i = 10; i < arr.Length; i = i + 10)
                {
                    Console.WriteLine(arr[i]);
                }                
            }
            // The Descending system has been reused here
            else if (tenthValueResponse == "Descending")
            {
                int z;
                for (int p = 0; p <= arr.Length - 2; p++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] < arr[i + 1])
                        {
                            z = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = z;
                        }
                    }
                }
                // Print each tenth iteration until the max value has been reached
                Console.WriteLine("The values you have selected are:");
                for (int i = 10; i < arr.Length; i = i + 10)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else if (tenthValueResponse == "No sort")
            {
                // Print each tenth iteration until the max value has been reached
                Console.WriteLine("The values you have selected are:");
                for (int i = 10; i < arr.Length; i = i + 10)
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

        private static int UserSearch(int[] arr, int searchTarget)
        {
            {
                int maxIndex = arr.Length;
                // Check if the user's given number is outside the values of the array
                if (searchTarget <= arr[0])
                    return arr[0];
                if (searchTarget >= arr[maxIndex - 1])
                    return arr[maxIndex - 1];

                // Begin doing a binary search to find the closest value 
                int i = 0, j = maxIndex, midValue = 0;
                while (i < j)
                {
                    midValue = (i + j) / 2;

                    if (arr[midValue] == searchTarget)
                        return arr[midValue];

                    // If the given number is below the midpoint, it will search below this point
                    if (searchTarget < arr[midValue])
                    {

                        // Find the closest value if the given number is greater than the number an index before the midpoint
                        if (midValue > 0 && searchTarget > arr[midValue - 1])
                            return GetClosestValue(arr[midValue - 1],
                                         arr[midValue], searchTarget);

                        // Repeat this again in the lower sector
                        j = midValue;
                    }

                    // If the given number is greater than the midpoint, it will search above this point
                    else
                    {
                        // Find the closest value if the given number is lower than the number an index after the midpoint
                        if (midValue < maxIndex - 1 && searchTarget < arr[midValue + 1])
                            return GetClosestValue(arr[midValue],
                                 arr[midValue + 1], searchTarget);
                        i = midValue + 1;
                    }
                }

                // Return the only single element remaining after the search     
                return arr[midValue];
            }            
        }

        public static int GetClosestValue(int valueOne, int valueTwo, int searchTarget)
        {
            // Determine between two values which is closest to the given number
            if (searchTarget - valueOne >= valueTwo - searchTarget)
                return valueTwo;
            else
                return valueOne;
        }
    }
}
