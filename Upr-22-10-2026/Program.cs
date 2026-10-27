using System;

namespace Upr_22_10_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upr 2.1
            //zad. 1
            string fullName = "Иван Петров";
            int age = 15;
            double averageGrade = 5.65;
            char classLetter = 'А';
            bool isExcellent = true;

            Console.WriteLine("=== ПРОФИЛ НА УЧЕНИКА ===");
            Console.WriteLine($"Име: {fullName}");
            Console.WriteLine($"Възраст: {age} години");
            Console.WriteLine($"Паралелка: 9 '{classLetter}' клас");
            Console.WriteLine($"Среден успех: {averageGrade:F2}");
            Console.WriteLine($"Отличник: {isExcellent}");
            Console.WriteLine("=========================");
            Console.WriteLine();

            //zad. 2
            Console.Write("Въведете любим учебен предмет: ");
            string subject = Console.ReadLine();

            Console.Write("Колко часа седмично го учите? ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Каква оценка целите за срока? ");
            double targetGrade = double.Parse(Console.ReadLine());

            Console.Write("Въведете любим символ за късмет: ");
            char luckyChar = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"--- РЕЗУЛТАТ ОТ АНКЕТАТА ---");
            Console.WriteLine($"Вие учите {subject} по {hours} часа седмично.");
            Console.WriteLine($"Вашата цел е успех {targetGrade:F2} {luckyChar}");
            Console.WriteLine();

            //zad. 3
            Console.Write("Въведете вашето тегло на Земята (кг): ");
            double weightEarth = double.Parse(Console.ReadLine());

            double weightMoon = weightEarth * 0.17;

            Console.WriteLine($"Вашето тегло на Луната ще бъде приблизително: {weightMoon:F2} кг.");
            Console.WriteLine();

            //zad. 4
            Console.Write("Цена за кг зеленчуци (лв): ");
            double vegPrice = double.Parse(Console.ReadLine());

            Console.Write("Цена за кг плодове (лв): ");
            double fruitPrice = double.Parse(Console.ReadLine());

            Console.Write("Продадени кг зеленчуци: ");
            int vegKg = int.Parse(Console.ReadLine());

            Console.Write("Продадени кг плодове: ");
            int fruitKg = int.Parse(Console.ReadLine());

            double totalBgn = (vegPrice * vegKg) + (fruitPrice * fruitKg);
            double totalEur = totalBgn / 1.94;

            Console.WriteLine();
            Console.WriteLine($"Общ приход в лева: {totalBgn:c}");
            Console.WriteLine($"Общ приход в евро: {totalEur:F2} Euro.");

            //Напишете програма, която чете температура в градуси по
            //Фаренхайт (реално число) от
            //конзолата, пресмята съответствието в Целзий и го извежда.

            Console.WriteLine("\nТЕМПЕРАТУРЕН КОНВЕРТОР: ");
            Console.Write("Въведете температура във Фаренхайт: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9.0;
            int roundedCelsius = (int)celsius; // Явно кастване за отрязване на дробната част

            Console.WriteLine($"{fahrenheit:F2}°F = {celsius:F2}°C");
            Console.WriteLine($"Цяла стойност (закръглена): {roundedCelsius}°C");

            //Напишете програма, която симулира касова бележка.
            Console.WriteLine("КАСОВА БЕЛЕЖКА:");
            Console.Write("\nИме на продукта: ");
            string product = Console.ReadLine();

            Console.Write("Единична цена: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Количество: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Платена сума: ");
            double paid = Convert.ToDouble(Console.ReadLine());

            double totalSum = price * quantity;
            double change = paid - totalSum;

            Console.WriteLine("\n--- КАСОВА БЕЛЕЖКА ---");
            Console.WriteLine($"Продукт: {product}");
            Console.WriteLine($"Обща сума: {totalSum:C}");
            Console.WriteLine($"Платено: {paid:C}");
            Console.WriteLine($"Ресто: {change:C}");

            //индекс на телесна маса
            Console.WriteLine("\nИНДЕКС НА ТЕЛЕСНА МАСА:");
            Console.Write("Въведете тегло в кг: ");
            double weightKg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Въведете височина в см: ");
            int heightCm = int.Parse(Console.ReadLine());

            double heightMeters = heightCm / 100.0;

            double bmi = weightKg / (heightMeters * heightMeters);

            Console.WriteLine($"BMI: {bmi:F1}");
            Console.WriteLine($"Цяла част на BMI: {(int)bmi}");

            //упражнение 5 - изчисляване окръжност
            Console.WriteLine("\nИЗЧИСЛЯВАНЕ НА ОКРЪЖНОСТ");
            Console.Write("Въведи радиус на окръност r = ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Обиколка: { perimeter: F2}");
            Console.WriteLine($" Лице: { area: F2}");

            //упражнение 5 - задача точка в равнината

            Console.WriteLine("\nРАЗСТОЯНИЕ МЕЖДУ ТОЧКИ В РАВНИНАТА: ");
            Console.WriteLine("Enter point A coordinates (x y):");
            Console.Write("x: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter point B coordinates (x y):");
            Console.Write("x: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y: ");
            double y2 = double.Parse(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Разстоянието между точките е: {d:F2}");

            //упражнение 5 - математически изрази
            //израз 1:
            Console.WriteLine("\nМАТЕМАТИЧЕСКИ ИЗРАЗИ:");
            Console.Write("Въведи x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Въведи y = ");
            double y = double.Parse(Console.ReadLine());
            double z = Math.Abs(x - y) + Math.Sqrt(Math.Pow(x, 4) + Math.Abs(y));
            Console.WriteLine($"Стойност на z = { z: F2}");

            //израз 2:
            double numerator = Math.Pow(x + y, 4);
            double denominator = Math.Abs(x) + 1;
            double D = numerator / denominator;
            Console.WriteLine($"Стойност на D = { D: F2}");




        }
    }
}
