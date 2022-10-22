using System.Net.Mime;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            DateTime time = new DateTime(2022, 10, 18);
            Console.WriteLine(time);
            int position = 1;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;

                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    time = time.AddDays(-1);
                    Console.WriteLine(time);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    time = time.AddDays(+1);
                    Console.WriteLine(time);
                }
                if (time.Day == 19)
                {
                    Console.Clear();
                    Console.WriteLine(time);
                    Console.WriteLine("   Пришёл с колледжа");
                    Console.WriteLine("   Решил вечерком что-то глянуть");
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(time);
                            Console.WriteLine("   Но сразу же отрубился, так как поздно лёг");
                        }
                        if (position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(time);
                            Console.WriteLine("   Ничего не нашел, так что решил пораньше лечь");
                        }
                    }
                }
                if (time.Day == 20)
                {
                    Console.Clear();
                    Console.WriteLine(time);
                    Console.WriteLine("   Посмотрел на небо");
                    Console.WriteLine("   Пришёл домой");
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (position == 1)
                        {
                            Console.WriteLine(time);
                            Console.Clear();
                            Console.WriteLine(time);
                            Console.WriteLine("   На небе были серые тучи, которые сигнализировали о том, что скоро наступит дождь");
                        }
                        if (position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(time);
                            Console.WriteLine("   Пошёл делать план по обж, а программирование перенёс на завтра");
                        }
                    }
                }
                if (time.Day == 21)
                {
                    Console.Clear();
                    Console.WriteLine(time);
                    Console.WriteLine("   Пришёл в колледж");
                    Console.WriteLine("   Сделал программирование");
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(time);
                            Console.WriteLine("   Получил шок от количества работ, которые нужно сделать");
                        }
                        if (position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(time);
                            Console.WriteLine("   Сделал программирование, но из-за того, что криво работал git hub ничего отправить не смог");
                        }
                    }
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }
        }
    }
}