using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    struct Horoscop
    {
        public string day;
        public string month;
        public string year;

        public string horoscop;
        public string oriental;

        public void show()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3, -30} {4, -30}", day, month, year, horoscop, oriental);
        }
        public string concat()
        {
            return day + ";" + month + ";" + year + ";" + horoscop + ";" + oriental;
        }
    }
    class Program
    {
    
       
        static void createF(string path, List<Horoscop> L)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (Horoscop l in L)
                {
                    sw.WriteLine(l.concat());
                }
            }
        }


        static void printData(List<Horoscop> L)
        {
            foreach (Horoscop l in L)
            {
                l.show();
            }
        }
        static void getData(string path, List<Horoscop> L)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] arr = sr.ReadLine().Split(';');
                    L.Add(new Horoscop()
                    {
                        day = arr[0],
                        month = arr[1],
                        year = arr[2]
                    });
                }
            }
        }
       
                static void entry(List<Horoscop> L)
        {
            for (int i = 0; i < L.Count; i++)
            {
                Horoscop h = L[i];
                int forParse;

                if (h.day == "" || h.month == "" || !int.TryParse(h.day, out forParse) || !int.TryParse(h.month, out forParse))
                {
                    h.horoscop = "-";
                }
                else
                {

                    if (((Convert.ToInt32(h.day) >= 19) && (Convert.ToInt32(h.day) <= 28) && Convert.ToInt32(h.month) == 2) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 20) && Convert.ToInt32(h.month) == 3))
                    {
                        h.horoscop = ($"Ваш знак зодиака Рыбы");
                      
                    }
                    else if (((Convert.ToInt32(h.day) >= 21) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 1) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 18) && Convert.ToInt32(h.month) == 2))
                    {
                        h.horoscop = "Ваш знак зодиака Водолей";
                    }
                    else if (((Convert.ToInt32(h.day) >= 22) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 12) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 20) && Convert.ToInt32(h.month) == 1))
                    {
                        h.horoscop = "Ваш знак зодиака Козерог";
                    }
                    else if (((Convert.ToInt32(h.day) >= 23) && (Convert.ToInt32(h.day) <= 30) && Convert.ToInt32(h.month) == 11) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 21) && Convert.ToInt32(h.month) == 12))
                    {
                        h.horoscop = "Ваш знак зодиака Стрелец";
                    }
                    else if (((Convert.ToInt32(h.day) >= 24) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 10) || (Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 22) && Convert.ToInt32(h.month) == 11)
                    {
                        h.horoscop = "Ваш знак зодиака Скорпион";
                    }
                    else if (((Convert.ToInt32(h.day) >= 23) && (Convert.ToInt32(h.day) <= 30) && Convert.ToInt32(h.month) == 9) || (Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 23) && Convert.ToInt32(h.month) == 10)
                    {
                        h.horoscop = "Ваш знак зодиака Весы";
                    }
                    else if (((Convert.ToInt32(h.day) >= 24) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 8) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 22) && Convert.ToInt32(h.month) == 9))
                    {
                        h.horoscop = "Ваш знак зодиака Дева";
                    }
                    else if (((Convert.ToInt32(h.day) >= 23) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 7) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 23) && Convert.ToInt32(h.month) == 8))
                    {
                        h.horoscop = "Ваш знак зодиака Лев";
                    }
                    else if (((Convert.ToInt32(h.day) >= 22) && (Convert.ToInt32(h.day) <= 30) && Convert.ToInt32(h.month) == 6) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 22) && Convert.ToInt32(h.month) == 7))
                    {
                        h.horoscop = "nВаш знак зодиака Рак";
                    }
                    else if (((Convert.ToInt32(h.day) >= 22) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 5) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 21) && Convert.ToInt32(h.month) == 6))
                    {
                        h.horoscop = "Ваш знак зодиака Близнец";
                    }
                    else if (((Convert.ToInt32(h.day) >= 21) && (Convert.ToInt32(h.day) <= 30) && Convert.ToInt32(h.month) == 4) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 21) && Convert.ToInt32(h.month) == 5))
                    {
                        h.horoscop = "Ваш знак зодиака Телец";
                    }
                    else if (((Convert.ToInt32(h.day) >= 21) && (Convert.ToInt32(h.day) <= 31) && Convert.ToInt32(h.month) == 3) || ((Convert.ToInt32(h.day) >= 1) && (Convert.ToInt32(h.day) <= 20) && Convert.ToInt32(h.month) == 4))
                    {
                        h.horoscop = "Ваш знак зодиака Овен";
                    }
                }
                if (h.year == "" || !int.TryParse(h.year, out forParse))
                {
                    h.oriental = "-";
                }
                else
                {
                    if (Convert.ToInt32(h.year) % 12 == 0)
                    {
                        h.oriental = "Ваш восточный знак - Обезьяна";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 1)
                    {
                        h.oriental = "Ваш восточный знак - Петух";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 2)
                    {
                        h.oriental = "Ваш восточный знак - Собака";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 3)
                    {
                        h.oriental = "Ваш восточный знак - Свинья";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 4)
                    {
                        h.oriental = "Ваш восточный знак - Крыса";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 5)
                    {
                        h.oriental = "Ваш восточный знак - Бык";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 6)
                    {
                        h.oriental = "Ваш восточный знак - Тигр";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 7)
                    {
                        h.oriental = "Ваш восточный знак - Кролик";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 8)
                    {
                        h.oriental = "Ваш восточный знак - Дракон";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 9)
                    {
                        h.oriental = "Ваш восточный знак - Змея";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 10)
                    {
                        h.oriental = "Ваш восточный знак - Лошадь";
                    }
                    else if (Convert.ToInt32(h.year) % 12 == 11)
                    {
                        h.oriental = "Ваш восточный знак - Коза";
                    }
                }
                L[i] = h;
            }
        }



        static void Main(string[] args)
            {
                List<Horoscop> horoscopes = new List<Horoscop>();
                getData("horoscopeEastern.csv", horoscopes);
                entry(horoscopes);
                printData(horoscopes);
                Console.WriteLine();
                createF("horoscopeEastern2.csv", horoscopes);
            }
        }
    }

