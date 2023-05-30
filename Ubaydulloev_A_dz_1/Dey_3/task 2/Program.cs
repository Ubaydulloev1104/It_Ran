using task_2;

while (true)
{
    Console.WriteLine("    Действия:  ");
    Console.WriteLine("1) Добавить новый продуктов на файл");
    Console.WriteLine("2) Добавить новый продуктов читать из файда ");
    Console.WriteLine("0) Отключить программу ");
    Console.Write("Выберите действие (Напишите число которые стоит прид действиям ):");
    var operation = Console.ReadLine();
    if (string.IsNullOrEmpty(operation))
    {
        Console.WriteLine(" Дествия не обнаружена ! Напишите число действия !!! " + "\n");
    }
    else
    {
        bool a = int.TryParse(operation, out int b);
        if (a)
        {

            int act = int.Parse(operation);
            if (act >= 0 && act <= 2)
            {
                if (act == 1)
                {
                    Console.WriteLine("Name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Count:");
                    var count = int.Parse(Console.ReadLine());
                    using (var fileManager = new FileManager("file.txt"))
                    {
                        fileManager.WriteToFile($"{name} {count}");
                    }

                }
                else if (act == 2)
                {

                    using (var fileManager = new FileManager("file.txt"))
                    {
                        string text_file = fileManager.ReadFromFile();
                        Console.WriteLine(text_file);
                    }
                }

                else
                {
                    Console.WriteLine(" Выбрено действия 0) Отключить программу " + "\n");
                    Console.WriteLine(" Спасибо за вниман !" + "\n");
                    break;
                }
            }
            else
            {
                Console.WriteLine(" Напишите число действия от 0 до 2" + "\n");
            }
        }
        else
        {
            Console.WriteLine("Напишите число действия от 0 до 3 не буквы" + "\n");
        }
      
    }
}


