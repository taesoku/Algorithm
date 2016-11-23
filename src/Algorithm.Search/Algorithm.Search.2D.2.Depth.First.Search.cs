using System;
using System.Collections.Generic;

namespace Algorithm.Search
{

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





}
