using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphCycles
{
    class Node
    {
        private List<Rib> ribs = new List<Rib>();

        public int Name { get; set; }
        public List<Rib> Ribs { get { return ribs; }  }


        public Node(int name) {
            Name = name;
        }

        public void AddRib(int end) {
            Ribs.Add(new Rib() { Start = this.Name, End = end });
        }

        public override bool Equals(object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            }

            Node toCompare = (Node)obj;
            return this.Name == toCompare.Name && this.Ribs.OrderBy(rib => rib).SequenceEqual(toCompare.Ribs.OrderBy(rib => rib));

        }

        public override int GetHashCode() {
           return (Name).GetHashCode();
        }

        public override string ToString() {
            return Name.ToString();
        }
    }
}
