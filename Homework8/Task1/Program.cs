// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Random rnd = new Random();

int[,] array = new int[rnd.Next(4, 20), rnd.Next(4, 20)];

System.Console.WriteLine($"Matrix {array.GetLength(0)} x {array.GetLength(1)}");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(-100,100);
        Console.Write(String.Format("{0,5}", array[i, j]) + "  ");
    }
    System.Console.WriteLine();
}

int[] rowArray = new int[array.GetLength(1)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowArray[j] = array[i, j];
    }

    rowArray = mergeSort(rowArray);

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rowArray[j];

    }
}

System.Console.WriteLine("Sorted matrix");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        Console.Write(String.Format("{0,5}", array[i, j]) + "  ");
    }
    System.Console.WriteLine();
}




int[] mergeSort(int[] array)
{
    int[] left;
    int[] right;
    int[] result = new int[array.Length];
    //As this is a recursive algorithm, we need to have a base case to avoid an infinite recursion and therfore a stackoverflow
    if (array.Length <= 1) return array;
    // The exact midpoint of our array  
    int midPoint = array.Length / 2;
    //Will represent our 'left' array
    left = new int[midPoint];

    //if array has an even number of elements, the left and right array will have the same number of elements
    if (array.Length % 2 == 0)
        right = new int[midPoint];
    //if array has an odd number of elements, the right array will have one more element than left
    else
        right = new int[midPoint + 1];
    //populate left array
    for (int i = 0; i < midPoint; i++)
        left[i] = array[i];
    //populate right array. We start our index from the midpoint, as we have already populated the left array from 0 to midpont
    for (int i = midPoint; i < array.Length; i++)
    {
        right[i - midPoint] = array[i];
    }
    //Recursively sort the left array
    left = mergeSort(left);
    //Recursively sort the right array
    right = mergeSort(right);
    //Merge our two sorted arrays
    result = merge(left, right);
    return result;
}

//This method will be responsible for combining our two sorted arrays into one giant array
int[] merge(int[] left, int[] right)
{
    int resultLength = right.Length + left.Length;

    // System.Console.WriteLine($"{resultLength} {right.Length} {left.Length}");

    int[] result = new int[resultLength];
    int indexLeft = 0, indexRight = 0, indexResult = 0;
    //while either array still has an element
    while (indexLeft < left.Length || indexRight < right.Length)
    {
        //if both arrays have elements  
        if (indexLeft < left.Length && indexRight < right.Length)
        {
            //If item on left array is less than item on right array, add that item to the result array 
            if (left[indexLeft] >= right[indexRight])
            {
                result[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }
            // else the item in the right array wll be added to the results array
            else
            {
                result[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }
        }
        //if only the left array still has elements, add all its items to the results array
        else if (indexLeft < left.Length)
        {
            result[indexResult] = left[indexLeft];
            indexLeft++;
            indexResult++;
        }
        //if only the right array still has elements, add all its items to the results array
        else if (indexRight < right.Length)
        {
            result[indexResult] = right[indexRight];
            indexRight++;
            indexResult++;
        }
    }
    return result;
}
