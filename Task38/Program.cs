
double[] Mass = {4.21, 75.3, 65.32, 43.3, 2.2};

double SearchMin(double[] arr) {
    
    double Min = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < Min) {
            Min = arr[i];
            
        }  
    }
    Console.WriteLine($"Минимальное число в массиве это - {Min}");
    return Min;
    
}

 double SearchMax(double[] arr) {
    
    double Max = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > Max) {
            Max = arr[i];
            
        }  
    }
    Console.WriteLine($"Максимальное число в массиве это - {Max}");
    return Max;
   
    
}

double Max = SearchMax(Mass);
double Min = SearchMin(Mass);

Console.WriteLine($"разница между максимальным и минимальным элементов массива - {Max - Min}");
