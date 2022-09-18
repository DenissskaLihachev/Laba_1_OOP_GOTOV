//////////////////////////////////////////////Task 1/////////////////////////////////////

using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

//Console.Write("Введите X: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите Y: ");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите Z: ");
//int z = Convert.ToInt32(Console.ReadLine());

//if (x < -10 || x > 10)
//    Console.WriteLine($"X = {x}");
//if (y < -10 || y > 10)
//    Console.WriteLine($"Y = {y}");
//if (z < -10 || z > 10)
//    Console.WriteLine($"Z = {z}");

//Console.ReadKey();
//Console.Clear();

//////////////////////////////////////////////Task 2/////////////////////////////////////

//Console.Write("Введите A: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите C: ");
//int c = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("-------------------------------------");
//Console.WriteLine($"Вы ввели [ {a} {b} {c} ]");

//a = a > 0 ? a : -a;
//b = b > 0 ? b : -b;
//c = c > 0 ? c : -c;

//Console.WriteLine("-------------------------------------");
//Console.WriteLine($"После преобразования [ {a} {b} {c} ]");
//Console.WriteLine("-------------------------------------");

//int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
//int min = a < b ? (a < c ? a : c) : (b < c ? b : c);

//Console.WriteLine($"Максимальное [ {max} ]");
//Console.WriteLine("-------------------------------------");
//Console.WriteLine($"Минимальное [ {min} ]");
//Console.WriteLine("-------------------------------------");

//int res = min * max;
//Console.WriteLine($"Результат [ {res} ]");

//Console.ReadKey();
//Console.Clear();

//////////////////////////////////////////////Task 3/////////////////////////////////////

//Console.Write("Введите номер студента группы: ");
//int N = Convert.ToInt32(Console.ReadLine());
//string FIO = null;

//try
//{
//    switch(N)
//    {
//        case 1:
//            {
//                FIO = "Лихачев Денис";
//                break;
//            }
//        case 2:
//            {
//                FIO = "Таргашина Екатерина";
//                break;
//            }
//        case 3:
//            {
//                FIO = "Немеров Александр";
//                break;
//            }
//        case 4:
//            {
//                FIO = "Мисюркеев Никита";
//                break;
//            }
//        case 5:
//            {
//                FIO = "Ибрагимов Джавидан";
//                break;
//            }
//        default:
//            {
//                throw new Exception("Не найден студент под заданным номером!");
//                break;
//            }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Ошибка: {e.Message}");
//}

//if(FIO != null)
//    Console.WriteLine($"Студент номер [ {N} ] - это [ {FIO} ]");

//Console.ReadKey();
//Console.Clear();

//////////////////////////////////////////////Task 4/////////////////////////////////////

//int ch;
//int chetn = 0, nechetn = 0;

//while(true)
//{
//    Console.Write("Введите число: ");   ch = Convert.ToInt32(Console.ReadLine());

//    if (ch == 0)
//        break;

//    if (ch % 2 == 0)
//        chetn++;
//    else
//        nechetn++;
//}

//if (chetn > nechetn)
//    Console.WriteLine("Четных чисел больше!");
//if (chetn == nechetn)
//    Console.WriteLine("Четных и нечетных поровну!");
//if (chetn < nechetn)
//    Console.WriteLine("Нечетных чисел больше!");

//////////////////////////////////////////////Task 5/////////////////////////////////////

//Console.Write("Введите число: ");
//int chislo = Convert.ToInt32(Console.ReadLine());

//int temp1;
//int temp2;
//int max = 0;

//while (chislo > 0)
//{
//    temp1 = chislo % 10;
//    chislo /= 10;
//    temp2 = chislo % 10;

//    if (temp2 > temp1 && temp2 > max)
//        max = temp2;
//    if (temp1 > max)
//        max = temp1;
//}

//Console.WriteLine($"Наибольшее число {max}");

//////////////////////////////////////////////Task 6/////////////////////////////////////

int MyWins = 0;
int CompWins = 0;

while (true)
{
    Console.WriteLine("0 - Камень");
    Console.WriteLine("1 - Ножницы");
    Console.WriteLine("2 - Бумага");
    Console.Write("Выберите: "); int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("-----------------------------");

    Random rnd = new Random();
    int CompChoice = rnd.Next(0, 3);


    switch (choice)
    {
        case 0://камень
            {
                switch (CompChoice)
                {
                    case 0://камень
                        {
                            Console.WriteLine("НИЧЬЯ!!!");
                            break;
                        }
                    case 1://ножницы
                        {
                            Console.WriteLine("ПОБЕДА!!!");
                            MyWins++;
                            break;
                        }
                    case 2://бумага
                        {
                            Console.WriteLine("ПОРАЖЕНИЕ!!!");
                            CompWins++;
                            break;
                        }
                }
                break;
            }
        case 1://ножницы
            {
                switch (CompChoice)
                {
                    case 0://камень
                        {
                            Console.WriteLine("ПОРАЖЕНИЕ!!!");
                            CompWins++;
                            break;
                        }
                    case 1://ножницы
                        {
                            Console.WriteLine("НИЧЬЯ!!!");
                            break;
                        }
                    case 2://бумага
                        {
                            Console.WriteLine("ПОБЕДА!!!");
                            MyWins++;
                            break;
                        }
                }
                break;
            }
        case 2://бумага
            {
                switch (CompChoice)
                {
                    case 0://камень
                        {
                            Console.WriteLine("ПОБЕДА!!!");
                            MyWins++;
                            break;
                        }
                    case 1://ножницы
                        {
                            Console.WriteLine("ПОРАЖЕНИЕ!!!");
                            CompWins++;
                            break;
                        }
                    case 2://бумага
                        {
                            Console.WriteLine("НИЧЬЯ!!!");
                            break;
                        }
                }
                break;
            }
    }
    Console.WriteLine($"Побед - [{MyWins}] Поражений - [{CompWins}]");
    Console.ReadKey();
    Console.Clear();

    if (MyWins == 5)
    {
        Console.WriteLine("ИГРА ОКОНЧЕНА! ПОБЕДИТЕЛЬ - ВЫ!");
        break;
    }
    if (CompWins == 5)
    {
        Console.WriteLine("ИГРА ОКОНЧЕНА! ПОБЕДИТЕЛЬ - КОМПЬЮТЕР!");
        break;
    }
}
