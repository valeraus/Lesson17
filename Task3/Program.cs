﻿using System;
using System.Collections.Generic;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Використовуючи динамічні та анонімні типи даних, створіть Англо-Російський словник на 10 слів та виведіть на екран його зміст. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
                               {
                                  {new {Key = "table"},    new {Value="стол"}},
                                  {new {Key = "apple"},    new {Value="яблоко"}},
                                  {new {Key = "pen"},      new {Value="ручка"}},
                                  {new {Key = "pencil"},   new {Value="карандаш"}},
                                  {new {Key = "task"},     new {Value="задание"}},
                                  {new {Key = "key"},      new {Value="ключ"}},
                                  {new {Key = "customer"}, new {Value="покупатель"}},
                                  {new {Key = "ship"},     new {Value="корабль"}},
                                  {new {Key = "car"},      new {Value="машина"}},
                                  {new {Key = "cap"},      new {Value="чашка"}}

                                  //{"table",   "стол"},
                                  //{"apple",    "яблоко"},
                                  //{"pen",      "ручка"},
                                  //{"pencil",   "карандаш"},
                                  //{"task",     "задание"},
                                  //{"key",      "ключ"},
                                  //{"customer", "покупатель"},
                                  //{"ship",     "корабль"},
                                  //{"car",      "машина"},
                                  //{"cap",      "чашка"}
                               };
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
