using Task1;

Console.Write("Input N elements in array: ");
int N = int.Parse(Console.ReadLine());

double[] myArray = Matrix.RandomMatrix(N);

Console.WriteLine("Randomly generated array:");
for (int i = 0; i < myArray.Length; i++)
    Console.WriteLine($"arr[{i}] -> {myArray[i]}");

double sum = Matrix.SumOfNegativeElements(myArray);
Console.WriteLine($"Sum of negative elements = {sum}");

double minElement = Matrix.SearchMinElement(myArray);
Console.WriteLine($"Minimal element = {minElement}");

int indexMaxElement = Matrix.SearchIndexMaxElement(myArray);
Console.WriteLine($"Index of maximum element = {indexMaxElement}");

double MaxFabsElement = Matrix.MaxFabsElement(myArray);
Console.WriteLine($"Maximum element by module = {MaxFabsElement}");

int SumIndex  = Matrix.SumIndexPositiveElements(myArray);
Console.WriteLine($"Summa indices positive elements = {SumIndex}");

int count = Matrix.SearchCountIntegers(myArray);
Console.WriteLine($"Number of integers = {count}");