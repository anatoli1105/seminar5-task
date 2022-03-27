
int[] array = new int[8];
void Rand(int[] Set)
{
    int lenght = Set.Length;
    for(int i = 0;i < lenght;i++)
    {
        Set[i] = new Random().Next(100,1001);
    }
}
void console(int[] Mas)
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
        if(number[i]%2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
Console.Write("массив заполненный случайными положительными трёхзначными числами -> ");
Rand(array);
console(array);
Console.WriteLine();
Console.WriteLine($"количество чётных чисел ->  {Sum(array)}");

