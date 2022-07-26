using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._07._22_2_
{
    class Program
    {
         public struct Human
        {
            public string Name;
            public int Age;
        }
        static void ReplaceElement(string[] array, int _number, string _item)
        {
            array[_number] = _item;
            PrintArray(array);
        }
        static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        public static void FindAge(int[] array, int index)
        {
            Console.WriteLine("Возраст гостя: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (index == i + 1)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        static void ChangeAge(int[] array, int index)
        {
            FindAge(array, index);
            Console.WriteLine("Введите новый возраст: ");
            string tmp = Console.ReadLine();
            int _newAge = int.Parse(tmp);
            array[index - 1] = _newAge;
        }
        static void Main(string[] args)
        {
            string[] Guests = new string[] { "Боб", "Том", "Джон", "Джоан", "Джастин", "Тед" };
            bool Flag = Guests.Length % 2 == 0;
            string match = "Джоан";
            PrintArray(Guests);
            foreach (var item in Guests)
            {
                if (item == match)
                {
                    Console.WriteLine("Имя {0} входит!", match);
                }
            }
            for (int i = 0; i < Guests.Length; i++)
            {
                if (Guests[i] == match)
                {
                    Console.WriteLine("Имя {0} входит, имеет номер {1}", match, i);
                }
            }
            ReplaceElement(Guests, 3, "*");
            PrintArray(Guests);

            int[] Ages = new int[] { 12, 22, 40, 33, 23, 54 };
            PrintArray(Ages);
            Console.WriteLine("Введите номер гостя: ");
            string tmp = Console.ReadLine();
            int _human = int.Parse(tmp);
            ChangeAge(Ages, _human);
            PrintArray(Ages);


            Human[] human = new Human[2];
            human[0].Name = "Билл";
            human[0].Age = 12;
            Console.WriteLine();
        }
    }
}

