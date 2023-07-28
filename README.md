# Search and Sort

The Search and Sort Program is a C# console application that allows users to sort and search for values in given data files. It provides functionalities to read data from predefined files or allows users to manually input their data files. The program supports two data sets, each with different lengths: one with 256 elements and another with 2048 elements.

## Getting Started

To run the program, follow these steps:

1. Clone the repository to your local machine.
2. Make sure you have the latest version of the .NET SDK installed on your system.
3. Open the project in your favourite C# development environment (e.g., Visual Studio, Visual Studio Code).
4. Build and run the application.

Upon running the program, you will be greeted with a welcome message and prompted to choose between using the pre-installed data or providing your own files.

## Functionality

The program offers the following functionalities:

1. **Ascending Sort**: Sorts the chosen data set in ascending order and displays the sorted values.
2. **Descending Sort**: Sorts the chosen data set in descending order and displays the sorted values.
3. **Display Iterative Values**: Displays the values in the chosen data set at regular intervals (every tenth value for 256-length arrays, every fiftieth value for 2048-length arrays).
4. **Binary Search**: Searches for a given number in the chosen data set using binary search and returns the closest value to the searched number.
5. **Sequential Search**: Searches for a given number in the chosen data set using sequential search and returns the closest value to the searched number.
6. **Merge Analysis**: Performs special merges of specific data sets and displays the results of sorting and displaying iterative values for the merged arrays.

## Usage

1. Upon running the program, you will be prompted to choose between using the pre-installed data or manually providing file paths for your data sets.
2. If you choose to use pre-installed data, the application will automatically load the predefined data files.
3. If you choose to provide your data, you will be prompted to input the file paths for each data set (Road_1_256.txt, Road_2_256.txt, Road_3_256.txt, Road_1_2048.txt, Road_2_2048.txt, Road_3_2048.txt).
4. After loading the data, you will be presented with a data menu where you can select the data set to work with.
5. Once you choose a data set, you can select the specific process you want to apply to the data from the process menu.

## Data Set Selection

The program provides six data sets to choose from, categorised into two lengths:

1. **256-length data sets**:
   - Road One (Road_1_256.txt)
   - Road Two (Road_2_256.txt)
   - Road Three (Road_3_256.txt)

2. **2048-length data sets**:
   - Road One - 2048 (Road_1_2048.txt)
   - Road Two - 2048 (Road_2_2048.txt)
   - Road Three - 2048 (Road_3_2048.txt)

## Note

The program assumes that the data files (Road_1_256.txt, Road_2_256.txt, Road_3_256.txt, Road_1_2048.txt, Road_2_2048.txt, Road_3_2048.txt) are present in the same directory as the executable or project files.

## Support

For any issues or questions regarding the program, please open an issue on the GitHub repository.
