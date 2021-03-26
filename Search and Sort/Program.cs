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
            Array.Sort(roadOne);
           
            Console.Write("Please input the file path for Road_2_256.txt: ");
            string roadTwoFileData = Console.ReadLine();
            string[] roadTwoString = System.IO.File.ReadAllLines(roadTwoFileData);
            int[] roadTwo = Array.ConvertAll(roadTwoString, int.Parse);
            Array.Sort(roadTwo);

            Console.Write("Please input the file path for Road_3_256.txt: ");
            string roadThreeFileData = Console.ReadLine();
            string[] roadThreeString = System.IO.File.ReadAllLines(roadThreeFileData);
            int[] roadThree = Array.ConvertAll(roadThreeString, int.Parse);
            Array.Sort(roadThree);
        }

        
    }
}
