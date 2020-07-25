using System;
using System.Collections.Generic;
using System.Text;

namespace GraphCycles
{
    class Node
    {
        public int Name { get; set; }
        public List<Rib> Ribs { get; set; }

        public override bool Equals(object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            }

            Node toCompare = (Node)obj;
            return this.Name == toCompare.Name;

        }
    }
}
