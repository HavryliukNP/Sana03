using Task1;

Console.Write("Input N elements in array: ");
int N = int.Parse(Console.ReadLine());

int[] myArray = Matrix.RandomMatrix(N);

Console.WriteLine("Randomly generated array:");
for (int i = 0; i < myArray.Length; i++)
    Console.WriteLine($"arr[{i}] -> {myArray[i]}");

int sum = Matrix.SumOfNegativeElements(myArray);
Console.WriteLine($"Sum of negative elements = {sum}");
