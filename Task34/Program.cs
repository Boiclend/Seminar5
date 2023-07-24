int Zapros(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetRandomMass(int Size) {
    int[] arr = new int[Size];
    Random rnd = new Random();
    for(int i = 0; i < Size; i++) {
        arr[i] = rnd.Next(100,1000);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

 void SearchElement(int[] arr) {
    
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) {
            count++;
            
        } 
    }
    Console.WriteLine($"В массиве {count} четных чисел");
   
    
}

int[] Mass = GetRandomMass(Zapros("Введите размер массива"));
Console.WriteLine();
SearchElement(Mass);