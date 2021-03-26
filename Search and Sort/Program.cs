using System;

namespace Search_and_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the file paths to each of the respective data sets and sort them into individual arrays
            Console.Write("Please input the file path for Road_1_256.txt: ");
            string roadOneFileData = Console.ReadLine();
            string[] roadOne = System.IO.File.ReadAllLines(roadOneFileData);

            Console.Write("Please input the file path for Road_2_256.txt: ");
            string roadTwoFileData = Console.ReadLine();
            string[] roadTwo = System.IO.File.ReadAllLines(roadTwoFileData);

            Console.Write("Please input the file path for Road_3_256.txt: ");
            string roadThreeFileData = Console.ReadLine();
            string[] roadThree = System.IO.File.ReadAllLines(roadThreeFileData);


        }
    }
}
