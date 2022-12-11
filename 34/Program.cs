Console.Clear();
Console.WriteLine("Введите размер массива"); 
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0) // ищем четные числа
count++; // добавляем найденные +1

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");// ответ

void FillArrayRandomNumbers(int[] numbers)// заполняем рандомными числами до 999
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)// вывод на экран массива
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}