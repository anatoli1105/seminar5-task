//адача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3  [6 7 3 6] -> 36 21
int[] array = Rand(10);

int[] Rand(int lenght)
{
    int[] Set = new int[lenght];
    for(int i = 0;i < lenght;i++)
    {
        Set[i] = new Random().Next(1,30);
    }
    return Set;
}
void PrintArr(int[] Mas)
{
    int count = Mas.Length;
    for(int pos = 0; pos < count;pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
}
void Sum(int[] number)
{
    int lenght = number.Length;
    int sum = 0; 
    for(int i = 0;i < lenght/2;i++)
    {
        
            sum = number[i] + number[lenght - i - 1];
             Console.Write(sum + " ,");
    }
}
Console.Write("массив заполненный случайными числами -> ");
//Rand(lenght);
PrintArr(array);
Console.WriteLine();
Sum(array);
