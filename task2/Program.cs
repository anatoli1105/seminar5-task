//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 26
//[-4, -6, 4, 67] -> 0
int[] array = Rand(8);

int[] Rand(int lenght)
{
    int[] Set = new int[lenght];
    for(int i = 0;i < lenght;i++)
    {
        Set[i] = new Random().Next(-30,30);
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
int Sum(int[] number)
{
    int lenght = number.Length;
    int sum = 0; 
    for(int i = 0;i < lenght;i++)
    {
        if(i%2 != 0)
        {
            sum += number[i];
        }
    }
    return sum;
}
Console.Write("массив заполненный случайными числами -> ");
//Rand(lenght);
PrintArr(array);
Console.WriteLine();
Console.WriteLine($"сумму элементов, стоящих на не чётных позициях-> {Sum(array)}");
