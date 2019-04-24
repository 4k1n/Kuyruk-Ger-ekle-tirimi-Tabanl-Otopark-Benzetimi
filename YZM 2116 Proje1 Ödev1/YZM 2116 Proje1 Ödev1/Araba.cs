using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM_2116_Proje1_Ödev1
{
    public class Araba
    {
        public int Zaman;
        public int arabaNumara;

        public Araba(int _arabaNumara, int _zaman)
        {
            this.arabaNumara = _arabaNumara;
            this.Zaman = _zaman;
        }
    }
}