using System;
using System.Collections.Generic;

namespace Algorithm.Search
{

    public class AlgorithmSearch2D1BreadthFirstSearch
    {

        public static void Answer()
        {

            var graph = new BreadthFirstSearchGraph(9);
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
            graph.BreadthFirstSearch();
            //graph.BFS(3);

            //var board1 = new[,]
            //{
            //    {1, 1, 1, 1, 1, 1}, {0, 0, 1, 0, 0, 1}, {1, 1, 1, 0, 1, 1}, {1, 0, 0, 0, 1, 0}, {1, 1, 1, 0, 1, 0},
            //    {0, 0, 1, 1, 1, 1}
            //};
            //BreadthFirstSearch(board1, 0, 0);
        }

        public class BreadthFirstSearchGraph
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

            public BreadthFirstSearchGraph(int size)
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

            public void BreadthFirstSearch() { BreadthFirstSearch(0); }

            public void BreadthFirstSearch(int index)
            {
                var root = Nodes[index];
                var queue = new Queue<Node>();
                queue.Enqueue(root);
                root.Marked = true;
                while (queue.Count != 0)
                {
                    var curr = queue.Dequeue();
                    foreach (var adjacent in curr.Adjacents)
                    {
                        if (!adjacent.Marked)
                        {
                            adjacent.Marked = true;
                            queue.Enqueue(adjacent);
                        }
                    }
                    Visit(curr);
                }
            }

            public void Visit(Node input)
            {
                Console.WriteLine(input.Data + " ");
            }

        }

        
        public class Queue
        {
            public int Count { get; set; }
            public List<int> Data { get; set; } 
            public List<int> X { get; set; }
            public List<int> Y { get; set; }

            public Queue()
            {
                Count = 0;
                Data = new List<int>();
                X = new List<int>();
                Y = new List<int>();
            }

            public void Enqueue(int data, int x, int y)
            {
                Data.Add(data);
                X.Add(x);
                Y.Add(y);
                Count++;
            }
        }

        public static int BreadthFirstSearch(int[,] board, int x, int y)
        {
            var count = 0;
            var queue = new Queue();
            queue.Enqueue(x, y, 1);
            var shiftX = board.GetLength(0);
            var shiftY = board.GetLength(1);
            while (count < queue.Count && (x < shiftX || y < shiftY))
            {
                board[x, y] = 0;
                var data = queue.Data[count];
                x = queue.X[count];
                y = queue.Y[count];
                if (x > 0 && board[x - 1, y] == 1) queue.Enqueue(data + 1, x - 1, y);
                if (x < shiftX - 1 && board[x + 1, y] == 1) queue.Enqueue(data + 1, x + 1, y);
                if (y > 0 && board[x, y - 1] == 1) queue.Enqueue(data + 1, x , y - 1);
                if (y < shiftY - 1 && board[x, y + 1] == 1) queue.Enqueue(data + 1, x, y + 1);
                count++;
            }
            return count;
        }

    }

}
