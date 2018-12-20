using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gameplatform
{
    class Program
    {
       static public Logger log = LogManager.GetCurrentClassLogger(); //Логирование

        static void Main(string[] args)
        {
        //Объекты
            Gameconsole XboxOne = new Gameconsole("Microsoft", "Kw/h");
            Gameconsole PS4Pro = new Gameconsole("Sony", "Kw/h");
            Portablegame Tetris = new Portablegame("2АА");
            Tetris.Manufacturer = "ChinaCorp.";

            //Ввод параметров
            Console.WriteLine("Выбираем игровую платформу производителя по энергозатратам: {0}, {1}, {2}", XboxOne.Manufacturer, PS4Pro.Manufacturer, Tetris.Manufacturer);
            Console.WriteLine("Играем на консоли: {0}, введите время в часах", XboxOne.Manufacturer);
            Go(XboxOne);
            Console.WriteLine("Играем на консоли: {0}, введите время в часах", PS4Pro.Manufacturer);
            Go(PS4Pro);
            Console.WriteLine("Играем на тетрисе: {0}, введите время в часах", Tetris.Manufacturer);
            Go(Tetris);

            Console.WriteLine("                   Добавляем в коллекцию              ");
            List<Platforms> Platform = new List<Platforms>
            {
                XboxOne,
                PS4Pro,
                Tetris
            };

            Console.WriteLine("                        Сортируем                         ");
            List<Platforms> sortedList = Platform.OrderBy(v => v.ShowConsumption()).ToList();
            
            //Вывод значений после сортировки
            Console.WriteLine("  Список консолей по возрастанию потребления энергии  ");
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("{0} - {1} w", sortedList[i].Manufacturer, sortedList[i].ShowConsumption());
            }

            Console.ReadLine();
         }

        //Ввод времмени и проверка на исключения (ввод текста)
       static private void Go(Platforms Platform)
        {
            try
            {
                int hour = int.Parse(Console.ReadLine()); ;
                Platform.Game(hour);

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Введено не число");
                 log.Info("Введено не числовое значение"); //Логирование
            }
        }

        
    }
}
