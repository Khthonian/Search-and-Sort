using System;
using System.IO;

namespace Search_and_Sort
{
    class Program
    {
        public static void Main()
        {
            // Welcome the user to the program
            Console.WriteLine("Hello user, welcome to the Search and Sort Program. This program is designed to sort and search for values in given data files.");
            // Ask the user for the file paths to each of the respective data sets and sort them into individual arrays
            Console.Write("Please input the file path for Road_1_256.txt: ");
            string roadOneFileData = Console.ReadLine();
            FileValidation(roadOneFileData);
            string[] roadOneString = System.IO.File.ReadAllLines(roadOneFileData);
            int[] roadOne = Array.ConvertAll(roadOneString, int.Parse);
                                                           
            Console.Write("Please input the file path for Road_2_256.txt: ");
            string roadTwoFileData = Console.ReadLine();
            FileValidation(roadTwoFileData);
            string[] roadTwoString = System.IO.File.ReadAllLines(roadTwoFileData);
            int[] roadTwo = Array.ConvertAll(roadTwoString, int.Parse);
            
            Console.Write("Please input the file path for Road_3_256.txt: ");
            string roadThreeFileData = Console.ReadLine();
            FileValidation(roadThreeFileData);
            string[] roadThreeString = System.IO.File.ReadAllLines(roadThreeFileData);
            int[] roadThree = Array.ConvertAll(roadThreeString, int.Parse);

            Console.Write("Please input the file path for Road_1_2048.txt: ");
            string roadOne2048FileData = Console.ReadLine();
            FileValidation(roadOne2048FileData);
            string[] roadOne2048String = System.IO.File.ReadAllLines(roadOne2048FileData);
            int[] roadOne2048 = Array.ConvertAll(roadOne2048String, int.Parse);

            Console.Write("Please input the file path for Road_2_2048.txt: ");
            string roadTwo2048FileData = Console.ReadLine();
            FileValidation(roadTwo2048FileData);
            string[] roadTwo2048String = System.IO.File.ReadAllLines(roadTwo2048FileData);
            int[] roadTwo2048 = Array.ConvertAll(roadTwo2048String, int.Parse);

            Console.Write("Please input the file path for Road_3_2048.txt: ");
            string roadThree2048FileData = Console.ReadLine();
            FileValidation(roadThree2048FileData);
            string[] roadThree2048String = System.IO.File.ReadAllLines(roadThree2048FileData);
            int[] roadThree2048 = Array.ConvertAll(roadThree2048String, int.Parse);

            // Ask the user which data set they would like to use
            DataMenu(roadOne, roadTwo, roadThree, roadOne2048, roadTwo2048, roadThree2048);           
        }

        private static void AscendingSort(int[] arr)
        {
            if (arr.Length == 256)
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
                Console.WriteLine();
                Console.WriteLine("The values you have requested are:");
                Console.WriteLine(string.Join(", ", arr));
            }

            else if (arr.Length == 2048)
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
                for (int i = 50; i < arr.Length; i = i + 50)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        private static void DescendingSort(int[] arr)
        {
            if (arr.Length == 256)
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
                Console.WriteLine();
                Console.WriteLine("The values you have requested are:");
                Console.WriteLine(string.Join(", ", arr));
            }

            else if (arr.Length == 2048)
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
                for (int i = 50; i < arr.Length; i = i + 50)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        private static void DisplayIterativeValues(int[] arr)
        {
            int dataLength = arr.Length;

            if (dataLength == 256)
            {
                // Ask user if they would like to sort the values before printing to console
                Console.WriteLine();
                Console.WriteLine("How would you like to sort the data:\n1) Ascending\n2) Descending\n3) No sort\nResponse: ");
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
                    Console.WriteLine();
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
                    Console.WriteLine();
                    Console.WriteLine("The values you have selected are:");
                    for (int i = 10; i < arr.Length; i = i + 10)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                else if (tenthValueResponse == "No sort")
                {
                    // Print each tenth iteration until the max value has been reached
                    Console.WriteLine();
                    Console.WriteLine("The values you have selected are:");
                    for (int i = 10; i < arr.Length; i = i + 10)
                    {
                        Console.WriteLine(arr[i]);
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Try again");
                    DisplayIterativeValues(arr);
                }
            }

            if (dataLength == 2048)
            {
                // Ask user if they would like to sort the values before printing to console
                Console.WriteLine("How would you like to sort the data:\n1) Ascending\n2) Descending\n3) No sort\nResponse: ");
                string fiftiethValueResponse = Console.ReadLine();

                // The Ascending system is reused here
                if (fiftiethValueResponse == "Ascending")
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
                    // Print each fiftieth iteration until the max value has been reached
                    Console.WriteLine();
                    Console.WriteLine("The values you have selected are:");
                    for (int i = 50; i < arr.Length; i = i + 50)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                // The Descending system has been reused here
                else if (fiftiethValueResponse == "Descending")
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
                    // Print each fiftieth iteration until the max value has been reached
                    Console.WriteLine();
                    Console.WriteLine("The values you have selected are:");
                    for (int i = 50; i < arr.Length; i = i + 50)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                else if (fiftiethValueResponse == "No sort")
                {
                    // Print each fiftieth iteration until the max value has been reached
                    Console.WriteLine();
                    Console.WriteLine("The values you have selected are:");
                    for (int i = 50; i < arr.Length; i = i + 50)
                    {
                        Console.WriteLine(arr[i]);
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Try again");
                    DisplayIterativeValues(arr);
                }
            }
        }

        private static int UserSearch(int[] arr)
        {
            // Declare a temporary array, used only in the search 
            int[] tempArr = new int[arr.Length];
            Array.Copy(arr, 0, tempArr, 0, arr.Length);
            // Reuse the system to arrange the values in ascending order
            int z;
            for (int p = 0; p <= tempArr.Length - 2; p++)
            {
                for (int i = 0; i <= tempArr.Length - 2; i++)
                {
                    if (tempArr[i] > tempArr[i + 1])
                    {
                        z = tempArr[i + 1];
                        tempArr[i + 1] = tempArr[i];
                        tempArr[i] = z;
                    }
                }
            }

            // Ask the user what number they want to search for
            Console.WriteLine();
            Console.WriteLine("What number would you like to search for: ");
            string searchTargetRaw = Console.ReadLine();
            int searchTarget = Int32.Parse(searchTargetRaw);
            {
                int maxIndex = tempArr.Length;
                // Check if the user's given number is outside the values of the array
                if (searchTarget <= tempArr[0])
                    return tempArr[0];
                if (searchTarget >= tempArr[maxIndex - 1])
                    return arr[maxIndex - 1];

                // Begin doing a binary search to find the closest value 
                int i = 0, j = maxIndex, midValue = 0;
                while (i < j)
                {
                    midValue = (i + j) / 2;

                    if (tempArr[midValue] == searchTarget)
                        return tempArr[midValue];

                    // If the given number is below the midpoint, it will search below this point
                    if (searchTarget < tempArr[midValue])
                    {

                        // Find the closest value if the given number is greater than the number an index before the midpoint
                        if (midValue > 0 && searchTarget > tempArr[midValue - 1])
                            return GetClosestValue(tempArr[midValue], tempArr[midValue - 1], searchTarget);                        

                        // Repeat this again in the lower sector
                        j = midValue;
                    }

                    // If the given number is greater than the midpoint, it will search above this point
                    else
                    {
                        // Find the closest value if the given number is lower than the number an index after the midpoint
                        if (midValue < maxIndex - 1 && searchTarget < tempArr[midValue + 1])
                            return GetClosestValue(tempArr[midValue], tempArr[midValue + 1], searchTarget);                        
                        
                        // Repeat this again in the upper sector
                        i = midValue + 1;
                    }
                }

                // Return the only single element remaining after the search     
                return tempArr[midValue];
                
            }            
        }

        private static int GetClosestValue(int valueOne, int valueTwo, int searchTarget)
        {
            // Determine between two values which is closest to the given number
            if (searchTarget - valueOne >= valueTwo - searchTarget)
                return valueTwo;
            else
                return valueOne;
        }

        private static void DataMenu(int[] roadOne, int[] roadTwo, int[] roadThree, int[] roadOne2048, int[] roadTwo2048, int[] roadThree2048)
        {
            Console.WriteLine();
            Console.WriteLine("Which data set would you like to use:\n1) Road One\n2) Road Two\n3) Road Three\n4) Road One - 2048\n5) Road Two - 2048\n6) Road Three - 2048\n7) View Special Merges\nResponse: ");
            string dataResponse = Console.ReadLine();           
            if (dataResponse == "Road One")
            {
                ProcessMenu(roadOne);
            }
            else if (dataResponse == "Road Two")
            {
                ProcessMenu(roadTwo);
            }
            else if (dataResponse == "Road Three")
            {
                ProcessMenu(roadThree);
            }
            else if (dataResponse == "Road One - 2048")
            {
                ProcessMenu(roadOne2048);
            }
            else if (dataResponse == "Road Two - 2048")
            {
                ProcessMenu(roadTwo2048);
            }
            else if (dataResponse == "Road Three - 2048")
            {
                ProcessMenu(roadThree2048);
            }
            else if (dataResponse == "View Special Merges")
            {
                SpecialMerge(roadOne, roadThree, roadOne2048, roadThree2048);
            }
            else
            {
                Console.WriteLine("Try again");
                DataMenu(roadOne, roadTwo, roadThree, roadOne2048, roadTwo2048, roadThree2048);
            }

        }

        private static void ProcessMenu(int[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Which process would you like to use:\n1) Ascending Sort\n2) Descending Sort\n3) Display Iterative Values\n4) Value Search\nResponse: ");
            string processResponse = Console.ReadLine();
            if (processResponse == "Ascending Sort")
            {
                AscendingSort(arr);
                RestartSystem();
            }
            else if (processResponse == "Descending Sort")
            {
                DescendingSort(arr);
                RestartSystem();
            }
            else if (processResponse == "Display Iterative Values")
            {
                DisplayIterativeValues(arr);
                RestartSystem();
            }
            else if (processResponse == "Value Search")
            {
                int closestValue = UserSearch(arr);
                int valuePosition = Array.IndexOf(arr, closestValue) + 1;
                Console.WriteLine($"The closest value to your search is {closestValue}, found at position {valuePosition}");
                RestartSystem();
            }
            else
            {
                ProcessMenu(arr);
            }
        }

        private static void FileValidation(string data)
        {
            if (File.Exists(data))
            {
                Console.WriteLine("Valid file");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This file path was invalid. Resetting system.");
                Main();
            }
        }

        private static void RestartSystem()
        {
            Console.WriteLine();
            Console.WriteLine("Do you wish to use the system again (Yes/No)");
            string restartResponse = Console.ReadLine();
            if (restartResponse == "Yes")
            {
                Console.WriteLine();
                Console.WriteLine("Restarting system.");
                Console.WriteLine();
                Main();
            }
            else if (restartResponse == "No")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Search and Sort Program.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Try again.");
                Console.WriteLine();
                RestartSystem();
            }
        }

        private static void SpecialMerge(int[] roadOne256, int[] roadThree256, int[] roadOne2048, int[] roadThree2048)
        {
            // Copy the relevant arrays into a single array specifically for this task
            int[] merge256 = new int[512];
            Array.Copy(roadOne256, 0, merge256, 0, roadOne256.Length);
            Array.Copy(roadThree256, 0, merge256, 256, roadThree256.Length);

            int[] merge2048 = new int[4096];
            Array.Copy(roadOne2048, 0, merge2048, 0, roadOne2048.Length);
            Array.Copy(roadThree2048, 0, merge2048, 2048, roadThree2048.Length);

            Console.WriteLine("We shall begin with the merges of Road_1_256.txt and Road_3_256.txt.");
            Console.WriteLine();
            Console.WriteLine("Here is the ascending sort:");
            AscendingSort(merge256);
            Console.WriteLine();
            Console.WriteLine("Here is the descending sort:");
            DescendingSort(merge256);
            Console.WriteLine();
            Console.WriteLine("Here is the display of the iterative values:");
            DisplayIterativeValues(merge256);
            Console.WriteLine();
            Console.WriteLine("Now we shall use the merges of Road_1_2048.txt and Road_3_2048.txt.");
            Console.WriteLine();
            Console.WriteLine("Here is the ascending sort:");
            AscendingSort(merge2048);
            Console.WriteLine();
            Console.WriteLine("Here is the descending sort:");
            DescendingSort(merge2048);
            Console.WriteLine();
            Console.WriteLine("Here is the display of the iterative values:");
            DisplayIterativeValues(merge2048);
            Console.WriteLine();
            RestartSystem();
        }
    }
}
