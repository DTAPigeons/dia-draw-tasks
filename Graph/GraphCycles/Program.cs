using System;

namespace GraphCycles
{
    class Program
    {
        static void Main(string[] args) {
            Graph graph1 = new Graph();

            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);

            /*
             * N = 6 (0 -> 1), (2 -> 0), (1 -> 2), (2 -> 3), (0 -> 3), (4 -> 5), (5 -> 4) 
            node0.AddRib(1);
            node0.AddRib(3);

            node1.AddRib(2);

            node2.AddRib(3);
            node2.AddRib(0);

            node4.AddRib(5);

            node5.AddRib(4);

            graph1.Nodes.Add(node0);
            graph1.Nodes.Add(node1);
            graph1.Nodes.Add(node2);
            graph1.Nodes.Add(node3);
            graph1.Nodes.Add(node4);
            graph1.Nodes.Add(node5);
            */

            /*
             * N=4 (0 -> 1), (0 -> 2), (1 -> 2), (2 -> 0), (2 -> 3), (3 -> 3)
            node0.AddRib(1);
            node0.AddRib(2);

            node1.AddRib(2);

            node2.AddRib(0);
            node2.AddRib(3);

            node3.AddRib(3);

            graph1.Nodes.Add(node0);
            graph1.Nodes.Add(node1);
            graph1.Nodes.Add(node2);
            graph1.Nodes.Add(node3);
            */

            /* N=4 (0 -> 1), (0 -> 2), (1 -> 2), (2 -> 3)
            node0.AddRib(1);
            node0.AddRib(2);

            node1.AddRib(2);

            node2.AddRib(3);

            graph1.Nodes.Add(node0);
            graph1.Nodes.Add(node1);
            graph1.Nodes.Add(node2);
            graph1.Nodes.Add(node3);
            */

            /* N=4 (0 -> 1), (2 -> 0), (1 -> 2), (2 -> 3), (3 -> 0)
            node0.AddRib(1);

            node1.AddRib(2);

            node2.AddRib(3);
            node2.AddRib(0);

            node3.AddRib(0);

            graph1.Nodes.Add(node0);
            graph1.Nodes.Add(node1);
            graph1.Nodes.Add(node2);
            graph1.Nodes.Add(node3);
            */

            /* N=2 (0 -> 1)
            node0.AddRib(1);

            graph1.Nodes.Add(node0);
            graph1.Nodes.Add(node1);
            */

            /* N=2 (0 -> 1), (1 -> 0)
            node0.AddRib(1);
            node1.AddRib(0);

            graph1.Nodes.Add(node0);
            graph1.Nodes.Add(node1);
            */

            /* N=3 (0 -> 1), (1 -> 2), (0 -> 2)
            node0.AddRib(1);
            node0.AddRib(2);

            node1.AddRib(2);

            graph1.Nodes.Add(node0);
            graph1.Nodes.Add(node1);
            graph1.Nodes.Add(node2);
            */

            CycleCollection cycles = graph1.GetCycles();

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();
            Console.WriteLine(cycles);
            Console.ReadLine();
        }
    }
}
