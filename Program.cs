﻿Console.WriteLine("Введите массив строк через пробел");// Выводим информационное сообщение
var consoleInput = Console.ReadLine(); // Ввод строки с консоли, записываем в переменную

if (consoleInput != null) // Если consoleInput не равно null
{
    var inputArray = consoleInput.Split(" "); // Преобразуем строку в массив, использую в качестве раздилител пробел

    var resultArray = new string[] { };// Определяем новый массив в который мы будем записывать результат
    for (var i = 0; i < inputArray.Length; i++)// Цикл по исходному массиву
    {
        if (inputArray[i].Length <= 3) // Если элемент массива имеет до 3 символов включительно
        {
            resultArray = resultArray.Append(inputArray[i]).ToArray(); // То добавляем этот элемент в результирующий массив
        }
    }

    Console.WriteLine("Исходный массив:");
    Console.WriteLine($"[{string.Join(", ", inputArray)}]");  // Выводим на консоль исходный массив 

    Console.WriteLine("Массив с элементами из исходного массива, которые имеют до 3 символов");
    Console.WriteLine($"[{string.Join(", ", resultArray)}]");// Выводим на консоль результирующий массивы
}

