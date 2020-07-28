using System;
using System.Collections.Generic;
using System.Text;

namespace GraphCycles
{
    class CycleCollection
    {
        List<Cycle> cycles = new List<Cycle>();


        public bool RibIsReacurence(Rib rib) {
            return cycles.Exists(cycle => cycle.HasRib(rib));
        }

        public bool TryToAddCycle(Cycle cycle) {
            if (cycles.Contains(cycle) || !cycle.IsValid) { return false; }
            cycles.Add(cycle);
            return true;
        }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Cycle cycle in cycles) {
                stringBuilder.Append(cycle.ToString() + Environment.NewLine);
            }
            return stringBuilder.ToString();
        }
    }
}
