using task_2_1;
//Menu tea = new Menu("Чай");
//Menu juice = new Menu("Сок");
//Menu drinks = new Menu("Напитки", new Menu[] { tea, juice });
//MenuGenerator.GenerateMenu(drinks);

Menu water = new Menu("Water");
Menu Coffee = new Menu("Coffee");
Menu BlackTea = new Menu("Black Tea");
Menu WhiteTea = new Menu("White Tea");
Menu Sencha = new Menu("Sencha");
Menu Gyokuro = new Menu("Gyokuro");
Menu Matcha = new Menu("Matcha");
Menu PiLoChun = new Menu("Pi Lo Chun");

Menu GreenTea = new Menu("GreenTea", new Menu[] {Sencha,Gyokuro,Matcha,PiLoChun});
Menu Tea = new Menu("Tea",new Menu[] { BlackTea, WhiteTea, GreenTea});
Menu Beverages = new Menu("Beverages", new Menu[] { water, Coffee ,Tea});

MenuGenerator.GenerateMenu(Beverages);



