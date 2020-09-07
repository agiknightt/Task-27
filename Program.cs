using System;
using System.Collections.Generic;

namespace Task_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dossiers = new Dictionary<string, string>();

            

            bool enterOrExit = true;

            dossiers.Add("Иванов Иван Иванович","Сантехник");
            dossiers.Add("Петров Петр Петрович", "Слесарь");
            dossiers.Add("Викторов Виктор Викторович", "Монтажник");
            dossiers.Add("Алексеев Алексей Алексеевич", "Учитель");
            dossiers.Add("Генадьев Генадий Генадьевич", "Доктор");

            while (enterOrExit)
            {
                Console.WriteLine("Выберите нужный пункт меню\n\n1 - добавить досье\n\n2 - вывести все досье\n\n3- удалить досье\n\n4 - выход\n\n");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AddDossiers(dossiers);
                        break;
                    case 2:
                        OutputDossiers(dossiers);
                        break;
                    case 3:
                        DeleteDossier(dossiers);
                        break;
                    case 4:
                        enterOrExit = false;
                        break;
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...\n");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void AddDossiers(Dictionary<string, string> dossiers)
        {
            string fullname;
            string position;

            Console.Write("Введите фио : ");
            fullname = Console.ReadLine();

            Console.Write("Введите должность : ");
            position = Console.ReadLine();

            dossiers.Add(fullname, position);
            Console.WriteLine($"\nВы добавили {fullname} - {position}\n");
        }

        private static void OutputDossiers(Dictionary<string, string> dossiers)
        {
            foreach (var item in dossiers)
            {
                Console.Write($"{item.Key} - {item.Value} ");
            }
            Console.WriteLine();
        }

        private static void DeleteDossier(Dictionary<string, string> dossiers)
        {
            string fullname;
            Console.Write("Введите фио : ");
            fullname = Console.ReadLine();

            foreach (var item in dossiers)
            {
                if (fullname == item.Key)
                {
                    dossiers.Remove(fullname);
                }
            }            
        }
    }
}
