﻿//Поиск номера искомого элемента массива
// Делаем массив (любое количество элементов)
int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

// Находим длинну массива
int n = array.Length;

// Пользователь должен ввести номер элемента массива
Console.Write("Введите номер искомого элемента ");
int find = Convert.ToInt32(Console.ReadLine()); // в лекции это 4

// Создаём счетчик index
int index = 0;

// Цикл. Пока Счетчик не дойдет до конца цикла
while (index < n)
{
    // Если элемент array совпадает с искомым find
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //Чтобы у нас искался только первый совпавший элемент при выполнении данного условия нам нужно прервать выполнение (коменда break)
        break;
    }

    //Увеличиваем значение индекса
    //index = index + 1;
    index++;
}