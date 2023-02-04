using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Rustica : IPizza
    {
        public string GetName()
        {
            return "Rustica";
        }
    }
}
