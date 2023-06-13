
namespace Day5HomeWork
{
    public class Menu : IMenu<Menu>
    {
        public Menu()
        {
            Childs = new Menu[0];
        }

        public string MenuName { get; set; }
        public Menu[] Childs { get; set; }
        public string Generate()
        {
            return $"<li>{MenuName}</li>";
        }
    }

    public class ComplexMenu : IMenu<ComplexMenu>
    {
        public ComplexMenu()
        {
            Childs = new ComplexMenu[0];
        }

        public string MenuName { get; set; }
        public string Href { get; set; }
        public ComplexMenu[] Childs { get; set; }
        public string Generate()
        {
            return $"<li><a href='{Href}'>{MenuName}</a></li>";
        }
    }

    public interface IMenu<T>
    {
        T[] Childs { get; set; }

        string Generate();
    }
}
