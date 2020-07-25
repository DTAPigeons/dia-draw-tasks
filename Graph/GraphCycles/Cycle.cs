using System;
using System.Collections.Generic;
using System.Text;

namespace GraphCycles
{
    class Cycle
    {
        public Node Start { get; set; }
        public List<Rib> Ribs { get; set; }

        public bool HasRib(Rib rib) {
            return Ribs.Contains(rib);
        }
    }
}
