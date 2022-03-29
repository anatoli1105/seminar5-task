// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7, 22, 2, 78] -> 76
//int[] array = Rand(8);


double[] array = Rand(8);
double[] Rand(int lenght)
{
    double[] Set = new double[lenght];
    for(int i = 0;i < lenght;i++)
    {
        Set[i] = new Random().Next(0,30);
    }
    return Set;
}
void PrintArr(double[] Mas)
{
    int count = Mas.Length;
    for(int pos = 0; pos < count;pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
}
double SumMax(double[] numb)
{
    double lenght = numb.Length;
    double max = 0; 
    for(int i = 0;i < lenght;i++)
    {
        if(max < numb[i])
        {
           max = numb[i] ;
        }
        
    }
    return max;
}
double SumMin(double[] numb)
{
    double lenght = numb.Length;
    double min = 1000; 
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

