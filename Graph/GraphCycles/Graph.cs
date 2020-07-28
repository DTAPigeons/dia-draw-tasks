using System;
using System.Collections.Generic;
using System.Text;

namespace GraphCycles
{
    class Graph
    {
        private CycleCollection cycleCollection = new CycleCollection();
        private List<Node> nodes = new List<Node>();

        public List<Node> Nodes { get { return nodes; } }

        public CycleCollection GetCycles() {
            cycleCollection = new CycleCollection();

            foreach(Node node in Nodes) {
                foreach(Rib rib in node.Ribs) {
                    Cycle cycle = new Cycle(node);
                    if (cycle.TryToAddRib(rib)) {
                        GetCyclesForRib(cycle, rib);
                    }
                }
            }

            return cycleCollection;
        }

        private void GetCyclesForRib(Cycle cycle, Rib currentRib) {
            if (cycle.IsValid) {
                cycleCollection.TryToAddCycle(cycle);
                return;
            }
            Node nextNode = TraverseRib(currentRib);
            if(nextNode.Ribs == null || nextNode.Ribs.Count == 0) {
                return;
            }
            foreach(Rib rib in nextNode.Ribs) {
                Cycle currentCycle = cycle.Copy();
                if (currentCycle.TryToAddRib(rib)) {
                    GetCyclesForRib(currentCycle, rib);
                }
            }
        }

        private Node TraverseRib(Rib rib) {
            return GetNodeByName(rib.End);
        }

        private Node GetNodeByName(int name) {
            return Nodes.Find(node => node.Name == name);
        }
    }
}
