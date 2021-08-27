using System;

namespace StryhelskiCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите желаемый номер задания (1, 2, 3)");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CheckNumber();
                        break;
                    case "2":
                        CheckName();
                        break;
                    case "3":
                        CheckArray();
                        break;
                    default:
                        Console.WriteLine("Было введено некоректное значение");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        //First task
        static void CheckNumber()
        {
            try
            {
                Console.WriteLine("Введите число:");
                double number = double.Parse(Console.ReadLine());
                if (number > 7)
                {
                    Console.WriteLine("Привет");
                }
                else
                {
                    throw new ArgumentException("Число должно быть больше 7");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Должно быть введено число");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Second task
        static void CheckName()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            if (name.Equals("Вячеслал"))
            {
                Console.WriteLine("Привет, Вячеслав");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
        }
        
        //Third task
        static void CheckArray()
        {
            try
            {
                Console.WriteLine("Введите размер массива:");
                int arraySize = int.Parse(Console.ReadLine());
                if (arraySize < 1) throw new ArgumentException("Размер массива не может быть меньше 1");
                int[] array = new int[arraySize];
                Console.WriteLine("Введите элементы масива:");

                for (int x = 0; x < arraySize; x++)
                {
                    array[x] = int.Parse(Console.ReadLine());
                }

                int count = 0;
                Console.WriteLine("Числа кратные трем:");

                foreach (int x in array)
                {
                    if (x % 3 == 0)
                    {
                        Console.Write(x + " ");
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("Числа кратные трем отсутствуют");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Могут быть введены только целые числа");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
