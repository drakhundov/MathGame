//v 1.2
    /*
    v1.3:
      Example_5 with examples of type (a^3) + (b^3)
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class Program
    {
        public static int points = 0;

        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("1 - составить тест автоматически");
            Console.WriteLine("2 - составить тест самому");

            //тест
            int test = Convert.ToInt32(Console.ReadLine());

            if(test == 1)                       /*автоматически*/
            {
              Console.WriteLine("Сколько заданий ты хочешь решить?");
              int z_1 = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("1 - легко");
              Console.WriteLine("2 - средне");
              Console.WriteLine("3 - сложно");
              int x = Convert.ToInt32(Console.ReadLine());

              Random rnd = new Random();

              for(int i_1 = 0; i_1 < z_1; i_1++)
              {
                int y = rnd.Next(1,5);
                switch(x)
                {
                  case 1:
                  switch(y)
                  {
                    case 1:
                    Example_1.Low();
                    break;
                    case 2:
                    Example_2.Low();
                    break;
                    case 3:
                    Example_3.Low();
                    break;
                    case 4:
                    Example_4.Low();
                    break;
                  }
                  break;

                  case 2:
                  switch(y)
                  {
                    case 1:
                    Example_1.Medium();
                    break;
                    case 2:
                    Example_2.Medium();
                    break;
                    case 3:
                    Example_3.Medium();
                    break;
                    case 4:
                    Example_4.Medium();
                    break;
                  }
                  break;

                  case 3:
                  switch(y)
                  {
                    case 1:
                    Example_1.Hard();
                    break;
                    case 2:
                    Example_2.Hard();
                    break;
                    case 3:
                    Example_3.Hard();
                    break;
                    case 4:
                    Example_4.Hard();
                    break;
                  }
                  break;
                }
              }
              Console.WriteLine("Ты решил " + points + " из " + z_1);
            }
            if(test == 2)                       /*вручную*/
            {
              Console.WriteLine("Сколько задач ты хочешь решить?");
              int z_2 = Convert.ToInt32(Console.ReadLine());

              for(int i_2 = 0; i_2 < z_2; i_2++)
              {
                  //задачи
                  Console.WriteLine("1 - примеры типа a+b");
                  Console.WriteLine("2 - примеры типа a-b");
                  Console.WriteLine("3 - примеры типа a*b");
                  Console.WriteLine("4 - примеры типа (a^2) + (b^2)");

                  //выбор задачи
                  int exercise = Convert.ToInt32(Console.ReadLine());
                  switch (exercise)
                  {
                      case 1:
                          //уровни
                          Console.WriteLine("1 - Легко");
                          Console.WriteLine("2 - Средне");
                          Console.WriteLine("3 - Сложно");

                          //выбор уровня
                          int level_1 = Convert.ToInt32(Console.ReadLine());
                          switch (level_1)
                          {
                              case 1:
                                  Example_1.Low();
                                  break;
                              case 2:
                                  Example_1.Medium();
                                  break;
                              case 3:
                                  Example_1.Hard();
                                  break;
                          }
                          break;
                      case 2:
                          //уровни
                          Console.WriteLine("1 - Легко");
                          Console.WriteLine("2 - Средне");
                          Console.WriteLine("3 - Сложно");

                          //выбор уровня
                          int level_2 = Convert.ToInt32(Console.ReadLine());
                          switch (level_2)
                          {
                              case 1:
                                  Example_2.Low();
                                  break;
                              case 2:
                                  Example_2.Medium();
                                  break;
                              case 3:
                                  Example_2.Hard();
                                  break;
                          }
                          break;
                      case 3:
                          //уровни
                          Console.WriteLine("1 - Легко");
                          Console.WriteLine("2 - Средне");
                          Console.WriteLine("3 - Сложно");

                          //выбор уровня
                          int level_3 = Convert.ToInt32(Console.ReadLine());
                          switch (level_3)
                          {
                              case 1:
                                  Example_3.Low();
                                  break;
                              case 2:
                                  Example_3.Medium();
                                  break;
                              case 3:
                                  Example_3.Hard();
                                  break;
                          }
                          break;
                      case 4:
                          //уровни
                          Console.WriteLine("1 - Легко");
                          Console.WriteLine("2 - Средне");
                          Console.WriteLine("3 - Сложно");

                          //выбор уровня
                          int level_4 = Convert.ToInt32(Console.ReadLine());
                          switch (level_4)
                          {
                              case 1:
                                  Example_4.Low();
                                  break;
                              case 2:
                                  Example_4.Medium();
                                  break;
                              case 3:
                                  Example_4.Hard();
                                  break;
                          }
                          break;

                  }

              }
                  Console.WriteLine("Ты решил " + points + " из " + z_2);
            }

            Console.ReadKey();
        }
    }

    class Example_1
    {
        /*легко*/
        public static void Low()
        {
            //числа от 100 до 1000
            Random x = new Random();
            int a = x.Next(100, 1000);
            int b = x.Next(100, 1000);

            //выполнение задачи
            Console.WriteLine("" + a as string + "+" + b as string);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a + b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a + b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }

        /*средне*/
        public static void Medium()
        {
            //числа от 1000 до 10000
            Random x = new Random();
            int a = x.Next(1000, 10000);
            int b = x.Next(1000, 10000);

            //выполнение задачи
            Console.WriteLine("" + a as string + "+" + b as string);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a + b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a + b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }

        /*сложно*/
        public static void Hard()
        {
            //числа от 10000 до 100000
            Random x = new Random();
            int a = x.Next(10000, 100000);
            int b = x.Next(10000, 100000);

            //выполнение задачи
            Console.WriteLine("" + a as string + "+" + b as string);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a + b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a + b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }
    }

    class Example_2
    {
        /*легко*/
        public static void Low()
        {
            //числа от 100 до 1000
            Random x = new Random();
            int a = x.Next(100, 1000);
            int b = x.Next(100, 1000);

            //выполнение задачи
            Console.WriteLine("" + a + "-" + b);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a - b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a - b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }

        /*средне*/
        public static void Medium()
        {
            //числа от 1000 до 10000
            Random x = new Random();
            int a = x.Next(1000, 10000);
            int b = x.Next(1000, 10000);

            //выполнение задачи
            Console.WriteLine("" + a + "-" + b);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a - b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a - b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }

        /*сложно*/
        public static void Hard()
        {
            //числа от 10000 до 100000
            Random x = new Random();
            int a = x.Next(10000, 100000);
            int b = x.Next(10000, 100000);

            //выполнение задачи
            Console.WriteLine("" + a + "-" + b);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a + b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a + b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }
    }

    class Example_3
    {
        /*легко*/
        public static void Low()
        {
            //числа от 1 до 25
            Random x = new Random();
            int a = x.Next(1, 25);
            int b = x.Next(1, 25);

            //выполнение задачи
            Console.WriteLine(a + "*" + b);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a * b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a * b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }

        /*средне*/
        public static void Medium()
        {
            //числа от 25 до 50
            Random x = new Random();
            int a = x.Next(25, 50);
            int b = x.Next(25, 50);

            //выполнение задачи
            Console.WriteLine(a + "*" + b);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a * b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a * b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }

        /*сложно*/
        public static void Hard()
        {
            //числа от 50 до 100
            Random x = new Random();
            int a = x.Next(50, 100);
            int b = x.Next(50, 100);

            //выполнение задачи
            Console.WriteLine(a + "*" + b);
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == (a * b))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Молодец!");
                Program.points++;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно!");
                Console.WriteLine("Правильный ответ: " + (a * b));
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }
    }

    class Example_4
    {
      /*легко*/
      public static void Low()
      {
        //числа от 1 до 10
        Random x = new Random();
        int a = x.Next(1, 10);
        int b = x.Next(1, 10);

        //выполнение задачи
        Console.WriteLine(a + "^2" + "+" + b + "^2");
        int answer = Convert.ToInt32(Console.ReadLine());
        if(answer == (a*a) + (b*b))
        {
          Console.BackgroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine("Молодец!");
          Program.points++;
          Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        else
        {
          Console.BackgroundColor = ConsoleColor.Red;
          Console.WriteLine("Неправильно!");
          Console.WriteLine("Правильный ответ: " + ((a*a) + (b*b)));
          Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
      }

      /*средне*/
      public static void Medium()
      {
        /*числа от 10 до 50*/
        Random x = new Random();
        int a = x.Next(10, 50);
        int b = x.Next(10, 50);

        //выполнение задачи
        //выполнение задачи
        Console.WriteLine(a + "^2" + "+" + b + "^2");
        int answer = Convert.ToInt32(Console.ReadLine());
        if(answer == (a*a) + (b*b))
        {
          Console.BackgroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine("Молодец!");
          Program.points++;
          Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        else
        {
          Console.BackgroundColor = ConsoleColor.Red;
          Console.WriteLine("Неправильно!");
          Console.WriteLine("Правильный ответ: " + ((a*a) + (b*b)));
          Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
      }

      /*сложно*/
      public static void Hard()
      {
        /*числа от 50 до 100*/
        Random x = new Random();
        int a = x.Next(50, 100);
        int b = x.Next(50, 100);

        //выполнение задачи
        Console.WriteLine(a + "^2" + "+" + b + "^2");
        int answer = Convert.ToInt32(Console.ReadLine());
        if(answer == (a*a) + (b*b))
        {
          Console.BackgroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine("Молодец!");
          Program.points++;
          Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
        else
        {
          Console.BackgroundColor = ConsoleColor.Red;
          Console.WriteLine("Неправильно!");
          Console.WriteLine("Правильный ответ: " + ((a*a) + (b*b)));
          Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
      }
    }
}
