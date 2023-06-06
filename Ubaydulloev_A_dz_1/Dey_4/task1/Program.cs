using task1;
Product product = new Product();
while (true)
{
    Console.WriteLine("    Действия:  ");
    Console.WriteLine("1) Паказать список  ");
    Console.WriteLine("2) Добавить новый продуктов");
    Console.WriteLine("3) Продать продукт");
    Console.WriteLine("0) Отключить программу ");
    Console.Write("Выберите действие (Напишите число которые стоит прид действиям ):");
    string action = Console.ReadLine().Trim();
    Console.WriteLine(" ");
    if (string.IsNullOrEmpty(action))
    {
        Console.WriteLine(" Дествия не обнаружена ! Напишите число действия !!! " + "\n");
    }
    else
    {
        if (action.Length > 1)
        {
            Console.WriteLine(" Напишите число действия от 0 до 3" + "\n");
        }
        else
        {
            bool a = int.TryParse(action, out int b);
            if (a)
            {

                int act = int.Parse(action);
                if (act >= 0 && act <= 3)
                {
                    if (act == 1)
                    {
                        string[] n = product.GetProduts();
                        foreach (var item in n)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else if (act == 2)
                    {
                        Console.WriteLine(" Выбрено действия 2) Добавить новый продуктов " + "\n");
                        Console.Write("Напишите имя товара : ");
                        string name = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("Имя товара не должень быт пустим пожалуста пофтарите действия " + "\n");
                        }
                        else
                        {
                            Console.Write("Напишите количество товара : ");
                            string cou = Console.ReadLine().Trim();
                            if (string.IsNullOrEmpty(cou))
                            {
                                Console.WriteLine($"Количество товара не указонно, по этому поумалчания количество товара {name}=1" + "\n");
                               
                            }
                            int count = int.Parse(cou);
                            product.SaveToFile($"{name} {count}");


                        }
                    }
                    else if (act == 3)
                    {
                        Console.WriteLine(" Выбрено действия 3) Продать продукт " + "\n");
                        Console.Write("Напишите имя товара : ");
                        string name = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("Имя товара не должень быт пустим пожалуста пофтарите действия " + "\n");
                        }
                        else
                        {
                            Console.Write("Напишите количество товара : ");
                            string cou = Console.ReadLine().Trim();
                            if (string.IsNullOrEmpty(cou))
                            {
                                Console.WriteLine($"Количество товара не указонно пожалуста пофтарите действия " + "\n");
                            }
                            else
                            {
                                int count = int.Parse(cou);
                                bool ab = product.ProductExists(name,count);
                                if(ab ==true)
                                {
                                    Console.WriteLine("Да имеются токое продукт");
                                }
                                else
                                {
                                    Console.WriteLine("Нет не меются токое продукт");
                                }

                            }

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
                    Console.WriteLine(" Напишите число действия от 0 до 3" + "\n");
                }
            }
            else
            {
                Console.WriteLine("Напишите число действия от 0 до 3 не буквы" + "\n");
            }
        }

    }


}
