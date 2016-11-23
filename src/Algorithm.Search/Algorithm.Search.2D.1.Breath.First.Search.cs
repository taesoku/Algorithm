using System.Collections.Generic;

namespace Algorithm.Search
{

    public class AlgorithmSearch2D1BreadthFirstSearch
    {

        public static void Answer()
        {
            var board1 = new [,] {{1, 1, 1, 1, 1, 1}, {0, 0, 1, 0, 0, 1}, {1, 1, 1, 0, 1, 1}, {1, 0, 0, 0, 1, 0}, {1, 1, 1, 0, 1, 0}, {0, 0, 1, 1, 1, 1} };
            BreadthFirstSearch(board1, 0, 0);
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
