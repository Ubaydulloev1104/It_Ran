using Task_2_2;
Menu Happy = new Menu("&#128578;","Happy");
Menu Sad = new Menu("&#128577;", "Sad");
Menu Neither = new Menu("&#128528;", "Neither");
Menu Wheel = new Menu("&#127905;", "Wheel");
Menu Teuck = new Menu("&#128666;", "Teuck");
Menu Car = new Menu("&#128663;", "Car");
Menu Parts = new Menu("Parts", new Menu[] {Wheel});
Menu Whole = new Menu("Whole", new Menu[] {Teuck,Car});
Menu Vehicles = new Menu("Vehicles", new Menu[] { Parts,Whole});
Menu Smilies = new Menu("Smilies", new Menu[] {Happy,Sad,Neither,Vehicles});

MenuGenerator.GenerateMenu(Smilies);

