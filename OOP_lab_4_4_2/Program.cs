using System;

namespace OOP_lab_4_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть записiв: ");

            int n = int.Parse(Console.ReadLine());

            Results[] work = new Results[n];

            Console.WriteLine("{0, -10} {1, -30} {2, -50}", "Мiсяць", "План випуску продукцiї", "Фактичний випуск продукцiї");

            string str;

            for (int i = 0; i < n; ++i)
            {
                str = Console.ReadLine();

                work[i] = new Results(str);
            }


            int j = 0, difference = 0;

            Console.WriteLine("\nНедовиконано:");

            Console.WriteLine("{0, -10} {1, -30} {2, -50}", "Мiсяць", "План випуску продукцiї", "Фактичний випуск продукцiї");

            for (int i = 0; i < n; ++i)
            {
                difference = Results.Compare(work[j].PlannedProductivity, work[j].Productivity);

                if (difference > 0)
                {
                    Console.WriteLine("{0, -10} {1, -30} {2, -50}", work[j].Month, work[j].PlannedProductivity, work[j].Productivity, difference);

                }
            }
        }
    }
}
