using System;

namespace AbstractFactotyOS
{
    class client
    {
        /// <summary>
        /// windows настройка
        /// </summary>
        public void windowsSet()
        {
            start(new Windows_switch());
        }
        
        /// <summary>
        /// ubuntu настройка
        /// </summary>
        public void ubuntuSet()
        {
            start(new ubuntu_switcher());
        }
        /// <summary>
        /// macos настройка
        /// </summary>
        public void macOSSet()
        {
            start(new Macos_swith());
        }

        /// <summary>
        /// выводим настройки в зависимости от типа
        /// </summary>
        /// <param name="start"></param>
        public void start(swith swith)
        {
            string inp = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine(swith.type());
                Console.WriteLine(swith.getSet1());
                Console.WriteLine(swith.getSet2());
                Console.WriteLine(swith.getSet3());
                Console.WriteLine(swith.getSet4());
                Console.WriteLine(swith.getSet5());
                Console.WriteLine(swith.getSet6());
                Console.WriteLine(swith.getSet7());
                Console.WriteLine(swith.getSet8());
                Console.WriteLine(swith.getSet9());
                Console.WriteLine(swith.getSet10());
                inp = Console.ReadLine();
                if (inp.CompareTo("exit") == 0) return;
                try
                {
                    int fl = Convert.ToInt32(inp);
                    if (fl < 1 || fl > 10) throw new FormatException();
                    swith.getSettings()[fl-1] ^= 1;
                } catch (FormatException ex)
                {
                    Console.WriteLine("Неправильный вариант конфигурации");
                }
            }
        }

    }
}
