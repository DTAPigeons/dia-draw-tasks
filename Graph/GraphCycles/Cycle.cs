using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphCycles
{
    class Cycle
    {
        private List<Rib> ribs = new List<Rib>();

        public Node Start { get; private set; }
        List<Rib> Ribs { get { return ribs; } }

        public Cycle(Node start) {
            Start = start;
        }

        public bool IsValid {
            get { return Ribs.Count>0 && Ribs[0].Start == Start.Name && Ribs[Ribs.Count - 1].End == Start.Name; }
        }


        public bool TryToAddRib(Rib rib) {
            if(HasRib(rib)) { 
                if(rib.End != Start.Name) {
                    return false;
                }                 
            }
            Ribs.Add(rib);
            return true;
        }

        public bool HasRib(Rib rib) {
            return Ribs.Contains(rib);
        }

        public Cycle Copy() {
            Cycle copy = new Cycle(Start);
            foreach(Rib rib in Ribs) {
                copy.ribs.Add(new Rib() { Start = rib.Start, End = rib.End });
            }
            return copy;
        }

        public override bool Equals(object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            }

            Cycle toCompare = (Cycle)obj;
            if(this.Ribs.Count != toCompare.Ribs.Count) {
                return false;
            }

            return this.Ribs.OrderBy(rib => rib.Start).SequenceEqual(toCompare.Ribs.OrderBy(rib => rib.Start));
            
        }

        public override int GetHashCode() {
            return (Start,this.GetType()).GetHashCode();
        }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Rib rib in Ribs) {
                stringBuilder.Append(rib.ToString() + " ");
            }

            return stringBuilder.ToString();
        }
    }
}
