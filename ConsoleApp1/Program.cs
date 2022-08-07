using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Part_2  -все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
namespace Part_2
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
                new Comp() { Id=1, Marka="Dell", typeProcessor="Pentium", frequencyProcessor=1000, capacityOzu=2, capacityHdd=500, capacityVideoMemory=500, price=10, quantity=2},
                new Comp() { Id=2, Marka="Asus", typeProcessor="Pentium Gold", frequencyProcessor=1200, capacityOzu=3, capacityHdd=550, capacityVideoMemory=1000, price=11, quantity=4},
                new Comp() { Id=3, Marka="MSI", typeProcessor="Pentium 1", frequencyProcessor=900, capacityOzu=1, capacityHdd=300, capacityVideoMemory=1500, price=8, quantity=1},
                new Comp() { Id=4, Marka="Dexp", typeProcessor="AMD C70", frequencyProcessor=1100, capacityOzu=4, capacityHdd=600, capacityVideoMemory=2000, price=15, quantity=6},
                new Comp() { Id=5, Marka="Vivo", typeProcessor="AMD 3500", frequencyProcessor=2000, capacityOzu=5, capacityHdd=750, capacityVideoMemory=2500, price=16, quantity=3},
                new Comp() { Id=6, Marka="Эльбрус", typeProcessor="T34", frequencyProcessor=2500, capacityOzu=6, capacityHdd=400, capacityVideoMemory=2200, price=20, quantity=5},
            };

            Console.WriteLine("Введите обьем ОЗУ");
            int ozuPoisk = Convert.ToInt32(Console.ReadLine());

            //List<Comp> comps = new List<Comp>();

            foreach (Comp c in listComp)
            {
                if (c.capacityOzu < ozuPoisk)
                {
                    Console.WriteLine($"ID-{c.Id}, Марка:{c.Marka}, Частота процессора:{c.frequencyProcessor}, ОЗУ:{c.capacityOzu}, HDD:{c.capacityHdd}, Видеопамять:{c.capacityVideoMemory}, Цена:{c.price}, Кол-во:{c.quantity}");
                }
            }
            Console.ReadKey();
        }
    }
}
