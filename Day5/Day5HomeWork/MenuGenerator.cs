using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5HomeWork
{
    public class MenuGenerator
    {
        public static T GenerateMenu<T>(T menu) where T : IMenu<T>
        {
            StringBuilder SB = new();

            SB.AppendLine("<ul>");
            SB.AppendLine(GenerateMenuRecursive(menu));
            SB.AppendLine("</ul>");

            File.WriteAllText("index.html", SB.ToString(), Encoding.UTF8);
            return menu;
        }

        public static string GenerateMenuRecursive<T>(T menu) where T : IMenu<T>
        {
            StringBuilder SB = new();
            SB.AppendLine(menu.Generate());

            if (menu.Childs == null)
            {
                menu.Childs = new T[0];
            }

            if (menu.Childs.Length > 0)
            {
                SB.AppendLine("<ul>");
                foreach (var subMenu in menu.Childs)
                {
                    SB.AppendLine(GenerateMenuRecursive(subMenu));
                }
                SB.AppendLine("</ul>");
            }

            return SB.ToString();
        }
    }
}
