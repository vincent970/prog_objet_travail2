using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu
{
    interface IPointable : INommable
    {       
        int Points { get;  }
    }
}
