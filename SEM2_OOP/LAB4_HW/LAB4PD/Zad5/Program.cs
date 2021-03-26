using System;

namespace Zad5
{
    abstract class Window
    {
        protected int punkt_x;
        protected int punkt_y;
        protected int width;
        protected int height;
        protected string name;
        public Window(int punkt_x, int punkt_y, int width, int height, string name)
        {
            this.punkt_x = punkt_x;
            this.punkt_y = punkt_y;
            this.width = width;
            this.height = height;
            this.name = name;
        }
        abstract public void DrawWindow();
    }
    class TextBox : Window
    {
        string content;
        public TextBox(int punkt_x, int punkt_y, int width, int height, string name, string content) : base(punkt_x, punkt_y, width, height, name)
        {
            this.content = content;
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Okno o punkcie zaczepienia: [{0};{1}], szerokości: {2}, wysokosci: {3}, nazwie: \"{4}\" i zawartosci: {5}", punkt_x, punkt_y, width, height, name, content);

        }
    }
    class ListBox : Window
    {
        string[] list;
        public ListBox(int punkt_x, int punkt_y, int width, int height, string name, string[] list) : base(punkt_x, punkt_y, width, height, name)
        {
            this.list = list;
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Lista o punkcie zaczepienia: [" + punkt_x + ";" + punkt_y + "], szerokości: " + width + ", wysokosci: " + height + ", nazwie: " + name + " i zawartosci: ");
            WyswietlListe();
        }
        public void WyswietlListe()
        {
            int index = 1;
            foreach(var element in list)
            {
                Console.WriteLine("{0}: {1}", index, element);
                index++;
            }
        }
    }
    class Button : Window
    {
        bool clicked;
        public Button(int punkt_x, int punkt_y, int width, int height, string name, bool clicked) : base(punkt_x, punkt_y, width, height, name)
        {
            this.clicked = clicked;
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Przycisk o punkcie zaczepienia: [" + punkt_x + ";" + punkt_y + "], szerokości: " + width + ", wysokosci: " + height + ", nazwie: " + name + ". Stan przycisku: " + ((clicked) ? "Wcisniety" : "Niewcisniety"));
        }
        public void ClickButton()
        {
            clicked = !clicked;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TextBox tx = new TextBox(0, 0, 300, 400, "Example", "Example content");
            tx.DrawWindow();
            string[] lista = new string[8]{ "Polska", "Niemcy", "Czechy", "Słowacja", "Ukraina", "Białoruś", "Rosja", "Litwa" };
            ListBox lb = new ListBox(0, 0, 300, 400, "Kraje", lista);
            lb.DrawWindow();
            Button but = new Button(0, 0, 300, 400, "Przycisk", false);
            but.DrawWindow();
            but.ClickButton();
            but.DrawWindow();
        }
    }
}
