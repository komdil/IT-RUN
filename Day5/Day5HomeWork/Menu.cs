
namespace Day5HomeWork
{
    public class Menu : IMenu
    {
        public Menu()
        {
            Childs = new Menu[0];
        }

        public string MenuName { get; set; }
        public Menu[] Childs { get; set; }
        IMenu[] IMenu.Childs { get => Childs; set => Childs = (Menu[])value; }
        public string Generate()
        {
            return $"<li>{MenuName}</li>";
        }
    }

    public class ComplexMenu : IMenu
    {
        public ComplexMenu()
        {
            Childs = new ComplexMenu[0];
        }

        public string MenuName { get; set; }
        public string Href { get; set; }
        public ComplexMenu[] Childs { get; set; }
        IMenu[] IMenu.Childs { get => Childs; set => Childs = (ComplexMenu[])value; }
        public string Generate()
        {
            return $"<li><a href='{Href}'>{MenuName}</a></li>";
        }
    }

    public interface IMenu
    {
        IMenu[] Childs { get; set; }

        string Generate();
    }
}
