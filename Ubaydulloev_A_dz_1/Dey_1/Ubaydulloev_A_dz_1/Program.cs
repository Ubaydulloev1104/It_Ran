using System.Text;
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
                        Console.WriteLine(" Выбрено действия 1) Паказать список  :  " + "\n");
                        Console.WriteLine(" Cписок : ");
                        string[] products = File.ReadAllLines("storage.txt", Encoding.UTF8);
                        foreach (var item in products)
                        {
                            Console.WriteLine($" {item} ");
                        }
                        Console.WriteLine($" На склоде имеютсия - {products.Length} продукт" + "\n");
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
                                cou = "1";
                            }
                            int count = int.Parse(cou);
                            string[] products = File.ReadAllLines("storage.txt", Encoding.UTF8);
                            int s = 0;
                            for (int i = 0; i < products.Length; i++)
                            {
                                string product = products[i];
                                var splitted = product.Split(' ');

                                string productName = splitted[0];
                                int countOfProduct = int.Parse(splitted[1]);
                                if (productName == name)
                                {
                                    countOfProduct += count;
                                    s++;
                                    Console.WriteLine($"Была добавленно на {productName}+{count}={countOfProduct} ");
                                }
                                products[i] = $"{productName} {countOfProduct}";
                            }

                            if (s == 0)
                            {
                                string[] added = new string[products.Length + 1];
                                for (int i = 0; i < products.Length; i++)
                                {
                                    added[i] = products[i];
                                }
                                added[products.Length] = $"{name} {count}";
                                File.WriteAllLines("storage.txt", added, Encoding.UTF8);
                                Console.WriteLine("Успешно дабовлено !" + "\n");
                                Console.WriteLine($"Была добавленно на склад новый продукт названия: {name} количество: {count}" + "\n");
                            }
                            else
                            {
                                string[] added = new string[products.Length];
                                for (int i = 0; i < products.Length; i++)
                                {
                                    added[i] = products[i];
                                }
                                File.WriteAllLines("storage.txt", added, Encoding.UTF8);
                            }

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
                                int spro = 0;
                                int ifo_count = 0;
                                int scol = 0;
                                int if0_count_null = 0;
                                int j = 0;
                                int count = int.Parse(cou);
                                string[] products = File.ReadAllLines("storage.txt", Encoding.UTF8);
                                for (int i = 0; i < products.Length; i++)
                                {
                                    string product = products[i];
                                    var splitted = product.Split(' ');

                                    string productName = splitted[0];
                                    int countOfProduct = int.Parse(splitted[1]);
                                    if (productName == name)
                                    {
                                        if (countOfProduct - count < 0)
                                        {
                                            scol++;
                                            ifo_count = countOfProduct;
                                        }
                                        else
                                        {
                                            countOfProduct -= count;
                                            Console.WriteLine($"Успешно продано {productName} {count}");
                                            Console.WriteLine($"Осталось {productName} {countOfProduct} ");
                                        }
                                        spro++;
                                    }

                                    j++;
                                    if (countOfProduct == 0)
                                    {
                                        Console.WriteLine($"Тавар {productName} ={countOfProduct} не осталос на складе по этому удалил но из склада:" + "\n" + " Вы можете добавыть занова это товар выполняв действия 2) Добавить новый продуктов  ");
                                        products[i] = " ";
                                        if0_count_null = j;
                                    }
                                    else
                                    {
                                        products[i] = $"{productName} {countOfProduct}";
                                    }
                                }
                                if (if0_count_null > 0)
                                {
                                    //for (int i = if0_count_null; i <products.Length; i++)
                                    //{
                                    //    products[i] = products[i + 1];
                                    //}
                                    //Array.Resize(ref products, products.Length-1);
                                    string[] added = new string[products.Length - 1];
                                    int i_arr_add = -1;
                                    foreach (var item in products)
                                    {
                                        if (item != " ")
                                        {
                                            i_arr_add++;
                                            added[i_arr_add] = item;
                                        }

                                    }
                                    File.WriteAllLines("storage.txt", added, Encoding.UTF8);
                                }
                                else
                                {
                                    string[] added = new string[products.Length];
                                    for (int i = 0; i < products.Length; i++)
                                    {
                                        added[i] = products[i];
                                    }
                                    File.WriteAllLines("storage.txt", added, Encoding.UTF8);

                                }

                                if (spro == 0)
                                {
                                    Console.WriteLine($"Складе не найдено товар по имени = {name}" + " Проверьте пожалуйста и повторите действия" + "\n");
                                }
                                if (scol != 0)
                                {
                                    Console.WriteLine($"Складе не хватает товара, количество товара на складе {name} = {ifo_count}" + "\n");
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
