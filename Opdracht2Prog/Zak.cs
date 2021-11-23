using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Opdracht2Prog
{
    internal class Zak
    {
        List<Cadeau> cadeautjes;
        public Zak()
        {
            cadeautjes = new List<Cadeau>();
        }
        public void AddPresent(Cadeau eenCadeau)
        {
            cadeautjes.Add(eenCadeau);
        }
        public List<Cadeau> GetPresents()
        {
            return cadeautjes;
        }
    }
}
