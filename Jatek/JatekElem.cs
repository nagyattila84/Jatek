using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    class JatekElem
    {
        private int x, y; // az elem poziciója
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        private JatekTer ter;

        public JatekElem(int x, int y, JatekTer jt)
        {
            this.x = x;
            this.y = y;
            ter = jt;

            ter.Felvetel(this);
        }
    }
}
