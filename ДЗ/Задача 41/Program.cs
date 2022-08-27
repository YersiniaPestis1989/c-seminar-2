
        // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        // 0, 7, 8, -2, -2 -> 2
        // 1, -7, 567, 89, 223-> 4
        Console.WriteLine("Введите через пробел");
        string numbers = Console.ReadLine();
        string[] split = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int Count = 0;
        for (int i = 0; i < split.Length; i++)
        {
            int j = Convert.ToInt32(split[i]);
            if (j > 0)
            {
                Count = Count + 1;
            }

        }
        Console.WriteLine("Количество положительных числен равно " + Count);
