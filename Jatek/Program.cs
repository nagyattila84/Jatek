using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    class Program
    {
        static void Main(string[] args)
        {
            JatekTer jt = new JatekTer(20, 20);
            JatekElem elem1 = new JatekElem(1, 1, jt);
            JatekElem elem2 = new JatekElem(3, 3, jt);
            JatekElem elem3 = new JatekElem(5, 5, jt);
            JatekElem elem4 = new JatekElem(11, 11, jt);
            JatekElem elem5 = new JatekElem(12, 15, jt);
            JatekElem elem6 = new JatekElem(12, 12, jt);
            JatekElem elem7 = new JatekElem(11, 11, jt);

            jt.Torles(elem1);
            Console.WriteLine("A 11, 11 helyen lévő elemek száma: " + jt.MegadottHelyenLevok(10, 10, 2).Length);
            Console.ReadLine();
        }
    }
}
