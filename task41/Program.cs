// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M;
Console.Write("Введите количество чисел: ");
int.TryParse(Console.ReadLine(), out M);

int[] array = new int[M];
for( int i = 0; i < M; i++)
{
    Console.Write("Введите числo: ");
    int.TryParse(Console.ReadLine(), out array[i]);
}

int sum = Positive(array);

for( int i = 0; i < M; i++)
    Console.Write($"{array[i]} ");
Console.Write($" -> {sum}");

int Positive(int[] array)
{
    int sum = 0;
    for(int i = 0; i < M; i++)
    {
        if ( array[i] > 0)
            sum++;
    }
    return sum;
}