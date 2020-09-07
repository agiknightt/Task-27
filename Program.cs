using System;
using System.Collections.Generic;

namespace Task_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> vocabulary = new Dictionary<string, string>();

            AddDefinition(vocabulary);

            CheckingWordInDictionary(vocabulary);
        }

        private static void AddDefinition(Dictionary<string, string> vocabulary)
        {
            vocabulary.Add("Трава", " в фармацевтике лекарственное растительное сырьё: высушенная или свежая надземная часть травянистых растений. ");
            vocabulary.Add("Стол", "предмет обихода, мебельное изделие, имеющее приподнятую горизонтальную или наклонную поверхность.");
            vocabulary.Add("Стул", "мебель, предназначенная для сидения одного человека, со спинкой и сиденьем с подлокотниками или без них.");
            vocabulary.Add("Чайник", "полое изделие (сосуд) различной формы с крышкой, ручкой и носиком, предназначенное для кипячения воды и заваривания чая.");
            vocabulary.Add("Табурет", "мебельное изделие для сидения одного человека без спинки и подлокотников.");
        }

        private static void CheckingWordInDictionary(Dictionary<string, string> vocabulary)
        {
            string word;
            bool enterOrExit = true;

            while (enterOrExit)
            {
                Console.Write("Введите нужное слово : ");
                word = Console.ReadLine();

                if (vocabulary.ContainsKey(word))
                {
                    Console.WriteLine($"\n{word} - {vocabulary[word]}\n");
                }
                else
                {
                    Console.WriteLine("К сожалению в словаре нет такого слова");
                }

                Console.WriteLine("Если хотите выйти из программы введите exit, для продолжения нажмите клавишу Enter...");

                if (Console.ReadLine() == "exit")
                {
                    enterOrExit = false;
                }
                Console.Clear();
            }
        }
    }
}
