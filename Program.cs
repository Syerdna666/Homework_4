//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int GetPow (int a, int b){
    int result = 1;
    for (int i = 0; i < b; i++){
        result *= a;
    }
    return result;
}

System.Console.WriteLine(GetPow(3,5));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int GetSum(int number){
    int result = 0;
    while(number > 1){
        result = result + number % 10;
        number /= 10;
    }
    return result;
}

System.Console.WriteLine(GetSum(9012));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] GetArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"arr[{i}] = ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}

System.Console.WriteLine($"[{string.Join(", ", GetArray())}]");



// Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// Пользователь вводит число элементов в массиве и минимальное, и максимальное значение.
// Нужно заполнить массив рандомными данными от минимального до максимального значения.
// Важное уточнение - делать все в методе, который возвращает массив

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] GetArray2(int amount, int maxValue, int minValue){
     int[] arr = new int[amount];
      for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

System.Console.WriteLine($"[{string.Join(", ", GetArray2(5, 10, 2))}]");