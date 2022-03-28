// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7, 22, 2, 78] -> 76
//int[] array = Rand(8);
//int evenNumber = Sum(arr,false);
//int oddNumber = Sum(array,true);
int[] array = Rand(8);

int[] Rand(int lenght)
{
    int[] Set = new int[lenght];
    for(int i = 0;i < lenght;i++)
    {
        Set[i] = new Random().Next(0,30);
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
int SumMax(int[] numb)
{
    int lenght = numb.Length;
    int max = 0; 
    for(int i = 0;i < lenght;i++)
    {
        if(max < numb[i])
        {
           max = numb[i] ;
        }
        
    }
    return max;
}
int SumMin(int[] numb)
{
    int lenght = numb.Length;
    int min = 1000; 
    for(int i = 0;i < lenght;i++)
    {
        if(numb[i] < min)
        {
           min = numb[i] ;
        }
        
    }
    return min;
}
Console.Write("массив заполненный случайными числами -> ");
//Rand(lenght);
PrintArr(array);
Console.WriteLine();
Console.WriteLine($"max- {SumMax(array)} ");
Console.WriteLine();
Console.WriteLine($"min- {SumMin(array)}");
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным элементов массива -> {SumMax(array) - SumMin(array)} ");
