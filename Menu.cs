using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            ColorBackground();

            DrawScreen();

            WriteOptions();

            var option = short.Parse(Console.ReadLine());

        }

        //TELA

        //COR DA TELA

        public static void ColorBackground()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void DrawScreen()
        {

            Line();

            Paipe();

            Line();
        }

        static void Line()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");


            Console.Write("+");
            Console.Write("\n");
        }

        static void Paipe()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
        //TELA 

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);

            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(3, 3);

            Console.WriteLine("====================");
            Console.SetCursorPosition(3, 4);

            Console.WriteLine("Selecione uma opção");
            
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            
            
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            
            
            Console.SetCursorPosition(3, 9); 
            Console.WriteLine("0 - Sair");
            
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
            



        }
    
    }
}
