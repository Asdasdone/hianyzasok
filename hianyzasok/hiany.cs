using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzasok
{
    class hiany
    {
        public string nev, osztaly;
        public int elso, utolso, mulasztott;

        public hiany(string nev, string osztaly, int elso, int utolso, int mulasztott)
        {
            this.nev = nev;
            this.osztaly = osztaly;
            this.elso = elso;
            this.utolso = utolso;
            this.mulasztott = mulasztott;
        }
    }
}
