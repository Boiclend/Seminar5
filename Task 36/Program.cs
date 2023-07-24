int Zapros(string message) {
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] GetRandomMass(int Size, int MinValue, int MaxValue) {
    int[] arr = new int[Size];
    Random rnd = new Random();
    for(int i = 0; i < Size; i++) {
        arr[i] = rnd.Next(MinValue,MaxValue);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

 void SearchElement(int[] arr) {
    int index = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (index % 2 != 0) {
            count = count + arr[i];
            index++;
        } else {
            index++;
        }
    }
    Console.WriteLine($"Cумма элементов стоящих на нечетных позициях равна {count}");
   
    
}

int[] Mass = GetRandomMass(Zapros("Введите размер массива"),Zapros("Введите мин границу массива"),Zapros("Введите макс границу массива"));
SearchElement(Mass);