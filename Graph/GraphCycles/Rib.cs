using System;
using System.Collections.Generic;
using System.Text;

namespace GraphCycles
{
    class Rib
    {
        public int Start { get; set; }
        public int End { get; set; }

        public override bool Equals(object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            }

            Rib toCompare = (Rib)obj;

            return (this.Start == toCompare.Start && this.End == toCompare.End) ||
                   (this.Start == toCompare.End && this.End == toCompare.Start);
        }
    }
}
