// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



double[] GetArray(int arrayLength)
{
    double[] result = new double[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        result[i] = new Random().NextDouble() * 10 + new Random().Next(100);
        result[i] = Math.Round(result[i], 2);
    }
    return result;
}

double FindsDifferenceElements(double[] arrayN)
{
    double min = arrayN[0];
    double max = arrayN[0];
    foreach (double el in arrayN)
    {
        if (min > el) min = el;
        if (max < el) max = el;
    }
    return max - min;
}



double[] array = GetArray(8);
Console.WriteLine(String.Join("  ", array));
Console.WriteLine($"Разница = {FindsDifferenceElements(array)}");