// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7, 22, 2, 78] -> 76



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
        string N = string.Format("{0:0.00}",Mas[pos]);
        Console.Write(N + "  ");
    }
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
    double lengh = numb.Length;
    double max = 0; 
    for(int i = 0;i < lengh;i++)
    {
        if(max < numb[i])
        {
           max = numb[i] ;
        }
        
    }
    return max - min;
}
Console.Write("массив заполненный случайными числами -> ");
PrintArr(array);
Console.WriteLine();
string min1 = string.Format("{0:0.00}",SumMin(array));
Console.WriteLine($"разница между максимальным и минимальным элементов массива -> {min1} ");