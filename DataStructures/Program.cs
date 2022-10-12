// See https://aka.ms/new-console-template for more information


// BIG O

int[] param = { 1, 2, 3 };
log(param);

void log(int[] numbers)
{
    // O(1) running in constant time
    Console.WriteLine(numbers[0]);
}

void logN(int[] numbers)
{
    // O(n) running linearly and in direct correlation to the size of the input. Where n represents the size of the input
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}

void logN2(int[] numbers)
{
    // O(n^2) running exponentially (quadratic)... when runing over combinations and nested loops
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length; j++)
        {
            Console.WriteLine($"First num: {i}, Second num: {j}");
        }
    }
}
