using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2Prog
{
    class Cadeau
    {
        private string name;

        public Cadeau(string aName)
        {
            name = aName;
        }
        public string GetName()
        {
            return name;
        }
    }
}
