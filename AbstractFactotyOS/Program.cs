using System;

namespace AbstractFactotyOS
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            string type;
            Console.WriteLine("Выверите операционную систему (windows, macos, ubuntu)");
            Console.WriteLine("Введите тип OS");
            type = Console.ReadLine();
            if (type == "windows")
                new client().windowsSet();
            else if (type == "ubuntu")
                new client().ubuntuSet();
            else if (type == "macos")
                new client().macOSSet();
            else
                Console.WriteLine("Вы ошиблись, попрбуйте снова!");

            Console.ReadKey();

        }
    }
}
