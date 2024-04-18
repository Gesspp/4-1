using System;
namespace _4_1;
class Program
{
    public static void Main()
    {
        Console.WriteLine("будем делать проверку по инту или по стрингу или стоп? (1/2/3)");
        int dec = 100;
        while (dec != 3)
        {
            Console.WriteLine("будем делать проверку по инту или по стрингу или стоп? (1/2/3)");
            dec = int.Parse(Console.ReadLine());
            if (dec == 1)
            {
                LineArray<int> lArray = new LineArray<int>(true);
                Conditions<int> con = new Conditions<int>();
                Actions<int> act = new Actions<int>();


                int[] array = lArray.DefaultArray();

                int choice = 100;

                while (choice != 0)
                {
                    Console.WriteLine("Выберите действие: /n 0) закончить работу /n 1) Отсортировать массив /n 2) Добавить элемент /n 3) Узнать длину массива /n 4) Перевернуть массив /n 5) Удалить элемент из массива");
                    Console.WriteLine("6) Найти максимальное значение /n 7) Найти минимальное значение /n 8) Посчитать кол-во элементов по условию");
                    Console.WriteLine("9) Узнать подходить ли хотя бы 1 элемент под условие /n 10) Узнать выполняют ли все элементы условие /n 11) Получить первый элемент удоволетворяющий условию /n 12) Выыести массив /n 13) применить действие к массиву /n 14) перейти на проверку по стрингу");

                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        lArray.ArraySort();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Какой элемент добавить?");
                        int el = int.Parse(Console.ReadLine());
                        lArray.ArrayAppend(el);
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine(lArray.LengthCounter());
                    }
                    else if (choice == 4)
                    {
                        lArray.ArrayReverse();
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Какой элемент вы хотите удалить?");
                        int el = int.Parse(Console.ReadLine());
                        lArray.DeleteElement(el);
                    }
                    else if (choice == 6)
                    {
                        lArray.FindMax();
                    }
                    else if (choice == 7)
                    {
                        lArray.FindMin();
                    }
                    else if (choice == 8)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.ConditionElementCount(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.ConditionElementCount(con.IsVowel);
                        }
                        if (des == 3)
                        {
                            lArray.ConditionElementCount(con.IsEven);
                        }
                    }
                    else if (choice == 9)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.OneElementCondition(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.OneElementCondition(con.IsVowel);
                        }
                        if (des == 3)
                        {
                            lArray.OneElementCondition(con.IsEven);
                        }
                    }
                    else if (choice == 10)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.AllElementsCondition(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.AllElementsCondition(con.IsVowel);
                        }
                        if (des == 3)
                        {
                            lArray.AllElementsCondition(con.IsEven);
                        }
                    }
                    else if (choice == 11)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.GetFirstEl(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.GetFirstEl(con.IsVowel);
                        }
                        if (des == 3)
                        {
                            lArray.GetFirstEl(con.IsEven);
                        }
                    }
                    else if (choice == 12)
                    {
                        lArray.PrintArray();
                    }
                    else if (choice == 13)
                    {
                        Console.WriteLine("Выберите действие: /n 1) Перевести строки в верхний регистр /n 2) Прибавить к каждому элементу 1");
                        int des = int.Parse(Console.ReadLine());

                        if (des == 1)
                        {
                            lArray.MakeAction(act.Upper);
                        }
                    }
                    else if (choice == 14)
                    {
                        break;
                    }

                }
            }
            else if (dec == 2)
            {
                LineArray<string> lArray = new LineArray<string>(true);
                Conditions<string> con = new Conditions<string>();
                Actions<string> act = new Actions<string>();


                string[] array = lArray.DefaultArray();

                int choice = 100;

                while (choice != 0)
                {
                    Console.WriteLine("Выберите действие: /n 0) закончить работу /n 1) Отсортировать массив /n 2) Добавить элемент /n 3) Узнать длину массива /n 4) Перевернуть массив /n 5) Удалить элемент из массива");
                    Console.WriteLine("6) Найти максимальное значение /n 7) Найти минимальное значение /n 8) Посчитать кол-во элементов по условию");
                    Console.WriteLine("9) Узнать подходить ли хотя бы 1 элемент под условие /n 10) Узнать выполняют ли все элементы условие /n 11) Получить первый элемент удоволетворяющий условию /n 12) Выыести массив /n 13) применить действие к массиву /n 14) перейти на проверку по стрингу");

                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        lArray.ArraySort();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Какой элемент добавить?");
                        string el = Console.ReadLine();
                        lArray.ArrayAppend(el);
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine(lArray.LengthCounter());
                    }
                    else if (choice == 4)
                    {
                        lArray.ArrayReverse();
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Какой элемент вы хотите удалить?");
                        string el = Console.ReadLine();
                        lArray.DeleteElement(el);
                    }
                    else if (choice == 6)
                    {
                        lArray.FindMax();
                    }
                    else if (choice == 7)
                    {
                        lArray.FindMin();
                    }
                    else if (choice == 8)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.ConditionElementCount(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.ConditionElementCount(con.IsVowel);
                        }
                        if (des == 1)
                        {
                            lArray.ConditionElementCount(con.IsEven);
                        }
                    }
                    else if (choice == 9)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.OneElementCondition(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.OneElementCondition(con.IsVowel);
                        }
                        if (des == 1)
                        {
                            lArray.OneElementCondition(con.IsEven);
                        }
                    }
                    else if (choice == 10)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.AllElementsCondition(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.AllElementsCondition(con.IsVowel);
                        }
                        if (des == 1)
                        {
                            lArray.AllElementsCondition(con.IsEven);
                        }
                    }
                    else if (choice == 11)
                    {
                        Console.WriteLine("Выберите условие: /n 1) Строка длиннее 5 /n 2) символ является солгасной буквой /n 3) Число четное");
                        int des = int.Parse(Console.ReadLine());
                        if (des == 1)
                        {
                            lArray.GetFirstEl(con.LengthFive);
                        }
                        if (des == 2)
                        {
                            lArray.GetFirstEl(con.IsVowel);
                        }
                        if (des == 1)
                        {
                            lArray.GetFirstEl(con.IsEven);
                        }
                    }
                    else if (choice == 12)
                    {
                        lArray.PrintArray();
                    }
                    else if (choice == 13)
                    {
                        Console.WriteLine("Выберите действие: /n 1) Перевести строки в верхний регистр /n 2) Прибавить к каждому элементу 1");
                        int des = int.Parse(Console.ReadLine());

                        if (des == 1)
                        {
                            lArray.MakeAction(act.Upper);
                        }
                    }
                    else if (choice == 14)
                    {
                        break;
                    }

                }
            }
            else if (dec == 3)
            {
                break;
            }

        }




    }

}
