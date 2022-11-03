using System;

namespace pk111
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[26, 5];//Массив для оценок
            string[] names = new string[26];//Массив для фамилий
            Random rnd = new Random();
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    marks[i, j] = rnd.Next(2, 6);
                }
            }
            //Рандомная генерация фамилий и имен
            string[] newNames = { "Игорь", "Филипп", "Егор", "Данил", "Дмитрий", "Захар" };
            string[] newSecondNames = { "Бахрушев", "Туруттин", "Сергеев", "Леонов", "Морозов", "Деникин" };
            for (int i = 0; i < names.Length; i++)
            {
                int x = rnd.Next(6);
                int y = rnd.Next(6);
                names[i] = newNames[x] + " " + newSecondNames[y];
            }
            //Вывод списка студентов с оценками
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.Write(names[i] + " ");
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.Write(marks[i, j] + ",");
                }
                Console.WriteLine("");
            }
        }
    }
}
