using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.    Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,
//частотой  работы  процессора,  объемом оперативной памяти, объемом жесткого диска, объемом памяти
//видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.
//Создать список, содержащий 6-10 записей с различным набором значений характеристик.

//Определить:
//Part_1  -все компьютеры с указанным процессором. Название процессора запросить у пользователя;
//Part_2  -все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
//Part_3  -вывести весь список, отсортированный по увеличению стоимости;
//Part_4  -вывести весь список, сгруппированный по типу процессора;
//Part_5  -найти самый дорогой и самый бюджетный компьютер;
//Part_6  -есть ли хотя бы один компьютер в количестве не менее 30 штук?
namespace Part_1
{
    class Comp
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string typeProcessor { get; set; }
        public int frequencyProcessor { get; set; }
        public int capacityOzu { get; set; }
        public int capacityHdd { get; set; }
        public int capacityVideoMemory { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Comp> listComp = new List<Comp>()
            {
                new Comp() { Id=1, Marka="Dell", typeProcessor="Pentium", frequencyProcessor=1000, capacityOzu=2, capacityHdd=500, capacityVideoMemory=500, price=10, quantity=22},
                new Comp() { Id=2, Marka="Asus", typeProcessor="Pentium Gold", frequencyProcessor=1200, capacityOzu=3, capacityHdd=550, capacityVideoMemory=1000, price=11, quantity=40},
                new Comp() { Id=3, Marka="MSI", typeProcessor="Pentium", frequencyProcessor=900, capacityOzu=1, capacityHdd=300, capacityVideoMemory=1500, price=8, quantity=10},
                new Comp() { Id=4, Marka="Dexp", typeProcessor="AMD C70", frequencyProcessor=1100, capacityOzu=4, capacityHdd=600, capacityVideoMemory=2000, price=15, quantity=6},
                new Comp() { Id=5, Marka="Vivo", typeProcessor="AMD 3500", frequencyProcessor=2000, capacityOzu=5, capacityHdd=750, capacityVideoMemory=2500, price=16, quantity=34},
                new Comp() { Id=6, Marka="Эльбрус", typeProcessor="T34", frequencyProcessor=2500, capacityOzu=6, capacityHdd=400, capacityVideoMemory=2200, price=20, quantity=53},
            };

            //Part_1  -все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            Console.WriteLine("Введите марку процессора");
            string typeProcessorPoisk = Console.ReadLine();
            List<Comp> comps = (from g in listComp
                                where g.typeProcessor == typeProcessorPoisk
                                select g).ToList();
            foreach (Comp g in comps)
                Console.WriteLine($"ID-{g.Id}, Марка:{g.Marka}, Процессор:{g.typeProcessor}, Частота процессора:{g.frequencyProcessor}, ОЗУ:{g.capacityOzu}, HDD:{g.capacityHdd}, Видеопамять:{g.capacityVideoMemory}, Цена:{g.price}, Кол-во:{g.quantity}");

            //Part_2  -все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            Console.WriteLine();
            Console.WriteLine("Введите обьем ОЗУ");
            int ozuPoisk = Convert.ToInt32(Console.ReadLine());
            foreach (Comp c in listComp)
            {
                if (c.capacityOzu <= ozuPoisk)
                {
                    Console.WriteLine($"ID-{c.Id}, Марка:{c.Marka}, Частота процессора:{c.frequencyProcessor}, ОЗУ:{c.capacityOzu}, HDD:{c.capacityHdd}, Видеопамять:{c.capacityVideoMemory}, Цена:{c.price}, Кол-во:{c.quantity}");
                }
            }

            //Part_3  -вывести весь список, отсортированный по увеличению стоимости;
            Console.WriteLine();
            Console.WriteLine("Список, отсортированный по стоимости");
            List<Comp> comps_1 = (from g in listComp
                                  orderby g.price
                                  select g).ToList();
            foreach (Comp g in comps_1)
                Console.WriteLine($"ID-{g.Id}, Марка:{g.Marka}, Процессор:{g.typeProcessor}, Частота процессора:{g.frequencyProcessor}, ОЗУ:{g.capacityOzu}, HDD:{g.capacityHdd}, Видеопамять:{g.capacityVideoMemory}, Цена:{g.price}, Кол-во:{g.quantity}");

            //Part_4  -вывести весь список, сгруппированный по типу процессора;
            Console.WriteLine();
            Console.WriteLine("Список, сгруппированный по типу процессора");
            IEnumerable<IGrouping<string, Comp>> comps1 = listComp.GroupBy(v => v.typeProcessor);
            foreach (IGrouping<string, Comp> cgr in comps1)
            {
                Console.WriteLine(cgr.Key);
                foreach (Comp v in cgr)
                {
                    Console.WriteLine($"ID-{v.Id}, Марка:{v.Marka}, Процессор:{v.typeProcessor}, Частота процессора:{v.frequencyProcessor}, ОЗУ:{v.capacityOzu}, HDD:{v.capacityHdd}, Видеопамять:{v.capacityVideoMemory}, Цена:{v.price}, Кол-во:{v.quantity}");
                }
            }

            //Part_5 - вывести весь список, отсортированный по увеличению стоимости;
            Console.WriteLine();
            Console.WriteLine("Компьютер с максимальной стоимостью");
            Comp comp1 = listComp.OrderByDescending(g => g.price).FirstOrDefault();
            Console.WriteLine($"ID-{comp1.Id}, Марка:{comp1.Marka}, Процессор:{comp1.typeProcessor}, Частота процессора:{comp1.frequencyProcessor}, ОЗУ:{comp1.capacityOzu}, HDD:{comp1.capacityHdd}, Видеопамять:{comp1.capacityVideoMemory}, Цена:{comp1.price}, Кол-во:{comp1.quantity}");

            Console.WriteLine();
            Console.WriteLine("Компьютер с минимальной стоимостью");
            Comp comp2 = listComp.OrderByDescending(g => g.price).LastOrDefault();
            Console.WriteLine($"ID-{comp2.Id}, Марка:{comp2.Marka}, Процессор:{comp2.typeProcessor}, Частота процессора:{comp2.frequencyProcessor}, ОЗУ:{comp2.capacityOzu}, HDD:{comp2.capacityHdd}, Видеопамять:{comp2.capacityVideoMemory}, Цена:{comp2.price}, Кол-во:{comp2.quantity}");

            //Part_6  -есть ли хотя бы один компьютер в количестве не менее 30 штук?
            Console.WriteLine();
            Console.WriteLine("Компьютер в количестве не меннее 30 шт.");
            if (comps.Any(v => v.quantity > 30) == true)
            {
                Console.WriteLine("Есть такой компьютер");
            }
            else
            {
                Console.WriteLine("Нет такого компьютера");
            }
            Console.ReadKey();
        }
    }
}
