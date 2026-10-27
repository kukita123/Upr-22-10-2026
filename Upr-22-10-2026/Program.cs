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

            //упражнение 5 - задача точка в равнината

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

        }
    }
}
