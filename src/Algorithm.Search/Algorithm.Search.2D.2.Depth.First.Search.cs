using System;
using System.Collections.Generic;

namespace Algorithm.Search
{

    // inorder
    // postorder
    // preorder

    //stack with recursive

    public class Algorithm011DepthFirstSearch
    {

        public static void Answer()
        {
            var graph = new DepthFirstSearchGraph(9);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(3, 5);
            graph.AddEdge(5, 6);
            graph.AddEdge(5, 7);
            graph.AddEdge(6, 8);
            //graph.DFS();
            //graph.BFS();
            //graph.DFSR();
            //graph.DFS(3);
            //graph.BFS(3);
            graph.DFSR(3);
        }

        public class DepthFirstSearchGraph
        {
            public class Node
            {
                public bool Marked;
                public int Data;
                public LinkedList<Node> Adjacents;

                public Node(int data)
                {
                    Data = data;
                    Marked = false;
                    Adjacents = new LinkedList<Node>();
                }
            }

            private List<Node> Nodes;

            public DepthFirstSearchGraph(int size)
            {
                Nodes = new List<Node>();
                for (var i = 0; i < size; i++)
                    Nodes.Add(new Node(i));
            }

            public void AddEdge(int i1, int i2)
            {
                var n1 = Nodes[i1];
                var n2 = Nodes[i2];
                if (!n1.Adjacents.Contains(n2)) n1.Adjacents.AddLast(n2);
                if (!n2.Adjacents.Contains(n1)) n2.Adjacents.AddLast(n1);
            }

            public void DepthFirstSearch() { DepthFirstSearch(0); }

            public void DepthFirstSearch(int index)
            {
                var root = Nodes[index];
                var stack = new Stack<Node>();
                stack.Push(root);
                root.Marked = true;
                while (stack.Count != 0)
                {
                    var curr = stack.Pop();
                    foreach (var adjacent in curr.Adjacents)
                    {
                        if (!adjacent.Marked)
                        {
                            adjacent.Marked = true;
                            stack.Push(adjacent);
                        }
                    }
                    Visit(curr);
                }
            }

            public void DepthFirstSearchRecursive(Node input)
            {
                if (input == null) return;
                input.Marked = true;
                Visit(input);
                foreach (var adjacent in input.Adjacents)
                {
                    if (adjacent.Marked) continue;
                    DepthFirstSearchRecursive(adjacent);
                }
            }

            public void DFSR()
            {
                DFSR(0);
            }

            public void DFSR(int index)
            {
                var root = Nodes[index];
                DepthFirstSearchRecursive(root);
            }

            public void Visit(Node input)
            {
                Console.WriteLine(input.Data + " ");
            }

        }
    }




    //public class Algorithm011DepthFirstSearch
    //{

    //    private bool[] marked;
    //    private int[] edgeTo;
    //    private int S;

    //    public Algorithm011DepthFirstSearch(AdjacencyGraphList G, int s)
    //    {
    //        marked = new bool[G.VertexCount];
    //        edgeTo = new int[G.VertexCount];
    //        S = s;
    //    }

    //    //public void DepthFirstSearch(AdjacencyGraphList G, int v)
    //    //{
    //    //    marked[S] = true;
    //    //    foreach (var w in G.GetAdjacencyGraph(v))
    //    //        if (!marked[w])
    //    //        {
    //    //            DepthFirstSearch(G, w);
    //    //            edgeTo[w] = v;
    //    //        }
    //    //}

    //    public class Node<T> where T : IComparable
    //    {
    //        private T data;
    //        public Node<T> Left;
    //        public Node<T> Right;
    //        public Node(T item)
    //        {
    //            data = item;
    //            Left = null;
    //            Right = null;
    //        }
    //        public T Data
    //        {
    //            get { return data; }
    //            set { data = value; }
    //        }
    //    }

    //    public class DepthFirstSearch
    //    {
    //        private Node<int> Nodes;
    //        private Stack<Node<int>> Stacks;

    //        public DepthFirstSearch(Node<int> nodes)
    //        {
    //            Nodes = nodes;
    //            Stacks = new Stack<Node<int>>();
    //        }

    //        public bool IsSearch(int data)
    //        {
    //            Stacks.Push(Nodes);
    //            while(Stacks.Count != 0)
    //            {
    //                var current = Stacks.Pop();
    //                if (current.Data == data) return true;
    //                else
    //                {
    //                    Stacks.Push(current.Left);
    //                    Stacks.Push(current.Right);
    //                }
    //            }
    //            return false;
    //        }
    //    }

    //}


    //consider an undirected graph G with n vertices and e edges
    //what is the time taken by DFS if the graph is represented by (i) adjacency matrix and (ii) adjacency list?
    //O(n2), O(e + n)



}
