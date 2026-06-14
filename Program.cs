using System.Diagnostics;

namespace Expr_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Для запуска конкретной задачи убрать комментарий. Для запуска следующей задачи - закомментировать предыдущую задачу, разкомментировать следующую.

            //Exrp1.Run();
            //Exrp2.Run();
            //Exrp3.Run();
            //Exrp4.Run();
            //Exrp5.Run();
            //Exrp6.Run();
            //Exrp7.Run();
            //Exrp8.Run();

        }
    }

    // Ниже находится код для каждой из исполняемых программ
    //------------------------------------------------------
    // Exrp 1
    class Exrp1
    {
        public static void Run()
        {
            // EXPR 1.Как поменять местами значения двух переменных? 
            //Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?

            //Способ 1. Промежуточная переменная:
            Console.WriteLine("Тест Способ 1: промеж. переменна C. Введите два целых числа\n");

            // Объявляем переменные и запрашиваем ввод.
            Console.WriteLine("Введите число A: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("----------------------");

            // Объявляем новую переменную, которая является промежуточной и выполняем алгоритм.
            int C = 0;
            Console.WriteLine("Объявляем промежуточную переменную C=" + C);
            Console.WriteLine("----------------------");
            C = A;
            Console.WriteLine("C теперь = " + C);
            Console.WriteLine("----------------------");
            A = B;
            Console.WriteLine("A теперь = " + A);
            B = C;
            Console.WriteLine("B теперь = " + B + "\n");

            //Способ 2. Арифметический :
            Console.WriteLine("Тест Способ 2: Арифметический. Введите два целых числа\n");

            //Запрашиваем ввод. Переменные были уже объявлены в Способ 1.
            Console.WriteLine("Введите число A: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B: ");
            B = int.Parse(Console.ReadLine());
            // Выводим введеные данные
            Console.WriteLine("----------------------");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("----------------------\n");

            //Арифметические выражения и результат
            A = A + B;
            Console.WriteLine("промежуточный A = " + A);
            B = A - B;
            Console.WriteLine("----------------------");
            Console.WriteLine("B теперь = " + B);
            A = A - B;
            Console.WriteLine("A теперь = " + A);
        }
    }

    //------------------------------------------------------
    // Exrp 2
    class Exrp2
    {
        public static void Run()
        {
            // EXPR 2. Задается натуральное трехзначное число (гарантируется, что трехзначное). 
            //Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
            Console.WriteLine("Expr2. Способ 1. Кортежем");
            Console.WriteLine("Введите трехзначное число: ");
            // Ввод значений
            var Astr = Console.ReadLine();

            char A1char = Astr[0];
            char A2char = Astr[1];
            char A3char = Astr[2];

            // Делаем разворот через присваивание кортежем
            //(A1char, A3char) = (A3char, A1char); Т.к. данный компилятор поддерживает только .NET 4.7.2, поэтому придется ввести временную переменную для разворота

            char Anchar = A1char;
            A1char = A3char;
            A3char = Anchar;

            int A1 = int.Parse(A1char.ToString());
            int A2 = int.Parse(A2char.ToString());
            int A3 = int.Parse(A3char.ToString());

            int A = (A1 * 100) + (A2 * 10) + A3;
            // Выводим результат
            Console.WriteLine(A);
            Console.WriteLine("\n");

            //Способ 2.
            //Запрос ввода
            Console.WriteLine("Введите трехзначное число");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Получено число: " + B);

            //Получаем первую цифру
            int B1 = B / 100;
            Console.WriteLine("Промежуточное значение B1:");
            Console.WriteLine(B1);

            Console.WriteLine("-----------------------");


            //Получаем среднюю цифру
            int B2 = (B / 10) % 10;
            Console.WriteLine("Промежуточное значение B2:\n");
            Console.WriteLine(B2);

            Console.WriteLine("-----------------------");

            //Получаем последнюю цифру
            int B3 = B % 10;
            Console.WriteLine("Промежуточное значение B3:");
            Console.WriteLine(B3);

            Console.WriteLine("-----------------------");


            //Делаем сборку перевернутого числа:
            B = (B3 * 100) + (B2 * 10) + B1;
            // Выводим результат
            Console.WriteLine(B);
        }
    }

    //------------------------------------------------------
    // Exrp 3
    class Exrp3
    {
        public static void Run()
        {
            //Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовыми и минутными стрелками. 
            //Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.

            //Запрашиваем ввод данных. Принимаем, что минутная стрелка находится на 12 часах.
            Console.WriteLine("Введите час");
            int H = int.Parse(Console.ReadLine());

            H = H % 12; // Конвертируем в 12 часовой формат, если введенное значение > 12
            int sC = H * 30; //т.к. 1 час = 30 градусам
            int bC = 360 - sC; // Определяем второй угол

            int C = Math.Min(sC, bC); // Получаем наикратчайший угол между минутной и часовой стрелками
            Console.WriteLine("Наикратчайший угол между стрелками = " + C);
        }
    }

    //------------------------------------------------------
    // Exrp 4
    class Exrp4
    {
        public static void Run()
        {
            //Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.

            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый делитель (2, 3, 5, 7, 11, 13, 17, 19 и т.п.)");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй делитель (2, 3, 5, 7, 11, 13, 17, 19 и т.п.)");
            int Y = int.Parse(Console.ReadLine());

            int countX = (N - 1) / X;
            int countY = (N - 1) / Y;

            int countXY = (N - 1) / (X * Y);

            int countN = countX + countY - countXY;
            Console.WriteLine("Количество чисел, меньших " + N + ", которые имеют простые делители " + X + " и " + Y + " равно:" + countN);
        }
    }

    //------------------------------------------------------
    // Exrp 5
    class Exrp5
    {
        public static void Run()
        {
            //Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.

            // Основные правила високосного года:
            // 1. Год должен делится на 4.
            // 2. Если он делится на 100, то он не високосный.
            // 3. Исключение: если он делится на 400, то он всё равно високосный.

            //Запрашиваем ввод
            Console.WriteLine("[A;B]. Введите конечный год  B:");
            int B = int.Parse(Console.ReadLine());

            // Следуя первому правилу:
            int count4B = B / 4;

            // Следуя второму правилу:
            int count100B = B / 100;

            // Следуя исключению:
            int count400B = B / 400;

            // Получаем выражение:
            int countX = count4B - count100B + count400B; // Здесь мы нашли значение в промежутке [1; B]
                                                          // Далее считаем для A. Т.к. A у нас входит в диапазон [1; B], то в дальнейшем мы его исключим
                                                          // и искомый диапазон примем как [1; A-1]

            Console.WriteLine("[A;B]. Введите начальный год A:");
            int A = int.Parse(Console.ReadLine());

            // Следуя первому правилу:
            int count4A = A / 4;

            // Следуя второму правилу:
            int count100A = A / 100;

            // Следуя исключению:
            int count400A = A / 400;

            int countY = count4A - count100A + count400A;

            // Подводим оба выражения для диапазона [A;B] путем вычитания хвоста
            int countXY = countX - countY;
            Console.WriteLine("Количество високосных годов в промежутке между " + A + " и " + B + " равен: " + countXY);

        }
    }

    //------------------------------------------------------
    // Exrp 6
    class Exrp6
    {
        public static void Run()
        {
            // Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.

            // Принимаем входные данные для точек:

            // C:
            Console.WriteLine("Введите координаты точки C. X:");
            double X0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки C. Y:");
            double Y0 = double.Parse(Console.ReadLine());

            // A:
            Console.WriteLine("Введите координаты точки A на прямой a. X:");
            double X1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки A на прямой a. Y:");
            double Y1 = double.Parse(Console.ReadLine());

            // B:
            Console.WriteLine("Введите координаты точки B на прямой a. X:");
            double X2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B на прямой a. Y:");
            double Y2 = double.Parse(Console.ReadLine());

            // Используя входные данные находим площадь и основание прямой "a(A,B)":
            double a = Math.Sqrt( (Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2)) );
            double S = (1.0 / 2) * Math.Abs((X2-X1)*(Y1-Y0) - (Y2-Y1)*(X1-X0));
            double h = (2 * S) / a;

            Console.WriteLine("Расстояние от заданной точки C до прямой a(A, B) равно = " + h);

        }
    }

    //------------------------------------------------------
    // Exrp 7
    class Exrp7
    {
        public static void Run()
        {
            //Expr7. Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.

            //  Принимаем данные от пользователя. Т.к. из формулы C не будет использоваться, принимаем значения только Ax и By
            //  Ax:
            Console.WriteLine("Введите коэффициент Ax:");
            double Ax = int.Parse(Console.ReadLine());
            //  By:
            Console.WriteLine("Введите коэффициент By:");
            double By = int.Parse(Console.ReadLine());

            string perpendicular = "(" + GetPerpendicularVector(Ax, By) + ")";
            string parallel = "(" + GetParallelVector(Ax, By) + ")";

            Console.WriteLine("Вектор, параллельный прямой: " + parallel);
            Console.WriteLine("Вектор, перпендикулярный прямой: " + perpendicular);


        }

        // Возвращаем перпендикуляр прямой
        public static string GetPerpendicularVector(double Ax, double By)
        {
            return Ax + ";" + By;
        }

        public static string GetParallelVector(double Ax, double By)
        {
            return By + ";" + -Ax; // или также можно вернуть '-By + ";" + Ax;' 
        }
    }

    //------------------------------------------------------
    // Exrp 8
    class Exrp8
    {
        public static void Run()
        {
            //Expr8. Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P,
            //проходящей через точку A. Можете считать, что прямая задана либо двумя точками,
            //либо коэффициентами уравнения прямой — как вам удобнее.

            // Принимаем ввод от пользователя

            // A (x0, y0):
            Console.WriteLine("Введите X для точки A:");
            double X0 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y для точки A:");
            double Y0 = double.Parse(Console.ReadLine());

            // M1 (x1, y1):
            Console.WriteLine("Введите X для точки M1:");
            double X1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y для точки M1:");
            double Y1 = double.Parse(Console.ReadLine());

            // M2 (x2, y2):
            Console.WriteLine("Введите X для точки M2:");
            double X2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Y для точки M2:");
            double Y2 = double.Parse(Console.ReadLine());

            // Считаем вектор вдоль прямой:
            double Vx = X2 - X1;
            double Vy = Y2 - Y1;
            Console.WriteLine("Вектор вдоль прямой: (" + Vx + ";" + Vy + ")");

            // Считаем вектор к нашей точке:
            double Ux = X0 - X1;
            double Uy = Y0 - Y1;
            Console.WriteLine("Вектор к нашей точке: (" + Ux + ";" + Uy + ")");

            // Тогда, коэффициент сдвига:
            double k = ((Ux * Vx) + (Uy * Vy))/( Math.Pow(Vx, 2) + Math.Pow(Vy, 2) );
            Console.WriteLine("Коэффициент сдвига k = " + k);

            // Отсюда:
            double Xp = X1 + k * Vx;
            double Yp = Y1 + k * Vy;
            Console.WriteLine("Вектор P: (" + Xp + ";" + Yp + ")");

            Console.WriteLine();

        }
    }
}
