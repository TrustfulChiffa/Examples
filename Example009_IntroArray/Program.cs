// Поиск максимума из девяти

int Max(int arg1, int arg2, int arg3)

{ //Ищем максимальный элемент из трех
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
// Выводим результат в переменной
    return result;
}

// Создаём массив
//    индекс     0   1   2   3   4   5    6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

// // Обращаемся к массиву и записываем в него значение:
// array[0] = 12;

// // Обращаемся к массиву и получаем значение сответствующего элемента по указанному индексу:
// Console.WriteLine(array[4]);

// Можно воспользоваться уже имеющейся функцией
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
// Выводим максимальное
Console.WriteLine(max);