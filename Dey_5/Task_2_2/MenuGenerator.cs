using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    public class MenuGenerator
    {
        public static Menu GenerateMenu(Menu menu)
        {
            if (menu.Childs == null)
            {
                menu.Childs = new Menu[0];
            }

            string html = $"<ul>{menu.Generate()}</ul>";
            File.WriteAllText("index.html", html);

            return menu;
        }
    }
}
