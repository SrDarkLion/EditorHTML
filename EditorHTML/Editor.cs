using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor {
        public static void Show() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("MODO EDITOR");
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("-----------");

            Start();

        }

        public static void Start() {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Deseja Salvar o Arquivo?");
            Viewer.Show(file.ToString());

        }

    }
}