using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//#define USE_MATRIX

namespace Question3_5
{
    public class Node : IComparable<Node>
    {
        public int nState;

        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(int nState)
        {
            this.nState = nState;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }
    enum coloredNodes
    {
        red,
        orange,
        yellow,
        green,
        lightblue,
        darkblue,
        purple,
        grey

    }
    internal static class Graphs
    {
        static bool[,] mGraph = new bool[,]

    {                   // red      orange    yellow    green    lightblue  darkblue  purple    grey 
           /*red*/      { false   , false   , false   , false   , false   , true    , false   , true  },
           /*orange*/   { false   , false   , false   , false   , false   , false   , true    , false },
           /*yellow*/   { false   , false   , false   , true    , false   , false   , false   , false },
           /*green*/    { false   , false   , false   , false   , false   , false   , false   , false },
           /*lightblue*/{ false   , false   , false   , false   , false   , true    , false   , true  },
           /*darkblue*/ { false   , false   , true    , false   , true    , false   , false   , false },
           /*purple*/   { false   , false   , true    , false   , false   , false   , false   , false },
           /*grey*/     { false   , true    , false   , false   , true    , false   , false   , false }
    };

        static int[][] lGraph = new int[][]
        {
            /*red*/      new int[] { (int)coloredNodes.grey,(int)coloredNodes.darkblue},
            /*orange*/   new int[] { (int)coloredNodes.purple },
            /*yellow*/   new int[] { (int)coloredNodes.green },
            /*green*/    null,
            /*lightblue*/new int[] { (int)coloredNodes.grey,(int)coloredNodes.darkblue },
            /*darkblue*/ new int[] { (int)coloredNodes.yellow,(int)coloredNodes.lightblue },
            /*purple*/   new int[] { (int)coloredNodes.yellow },
            /*grey*/     new int[] { (int)coloredNodes.lightblue, (int)coloredNodes.orange }
        };




        static int nState = 0;
        static string sUserState = null;

        static bool bWaitingForMove = false;
        static List<Node> graph = new List<Node>();

        static void Main(string[] args)
        {

            string sState = null;


            Node node;
            node = new Node((int)coloredNodes.red);
            graph.Add(node);

            node = new Node((int)coloredNodes.orange);
            graph.Add(node);

            node = new Node((int)coloredNodes.yellow);
            graph.Add(node);

            node = new Node((int)coloredNodes.green);
            graph.Add(node);

            node = new Node((int)coloredNodes.lightblue);
            graph.Add(node);

            node = new Node((int)coloredNodes.darkblue);
            graph.Add(node);

            node = new Node((int)coloredNodes.purple);
            graph.Add(node);

            node = new Node((int)coloredNodes.grey);
            graph.Add(node);

            graph[(int)coloredNodes.red].AddEdge(1, graph[(int)coloredNodes.darkblue]);
            graph[(int)coloredNodes.red].AddEdge(5, graph[(int)coloredNodes.grey]);
            graph[(int)coloredNodes.red].edges.Sort();

            graph[(int)coloredNodes.orange].AddEdge(1, graph[(int)coloredNodes.purple]);

            graph[(int)coloredNodes.orange].edges.Sort();

            graph[(int)coloredNodes.yellow].AddEdge(6, graph[(int)coloredNodes.green]);
            graph[(int)coloredNodes.yellow].edges.Sort();

            //graph[(int)coloredNodes.green].AddEdge(3, graph[(int)coloredNodes.TTH]);
            //graph[(int)coloredNodes.green].AddEdge(7, graph[(int)coloredNodes.HHH]);
            graph[(int)coloredNodes.green].edges.Sort();

            graph[(int)coloredNodes.lightblue].AddEdge(1, graph[(int)coloredNodes.darkblue]);
            graph[(int)coloredNodes.lightblue].AddEdge(1, graph[(int)coloredNodes.grey]);
            graph[(int)coloredNodes.lightblue].edges.Sort();

            graph[(int)coloredNodes.darkblue].AddEdge(1, graph[(int)coloredNodes.lightblue]);
            graph[(int)coloredNodes.darkblue].AddEdge(8, graph[(int)coloredNodes.yellow]);
            graph[(int)coloredNodes.darkblue].edges.Sort();

            graph[(int)coloredNodes.purple].AddEdge(1, graph[(int)coloredNodes.yellow]);
            graph[(int)coloredNodes.purple].edges.Sort();

            graph[(int)coloredNodes.grey].AddEdge(1, graph[(int)coloredNodes.orange]);
            graph[(int)coloredNodes.grey].AddEdge(0, graph[(int)coloredNodes.lightblue]);
            graph[(int)coloredNodes.grey].edges.Sort();

            List<Node> shortestPathFromRedtoGreen = GetShortestPathDijkstra();
            Console.WriteLine("Djikstra: ");
            foreach(Node n in shortestPathFromRedtoGreen)
            {
                if(n.nState == 0) { Console.Write("Red "); }
                if (n.nState == 1) { Console.Write("Orange "); }
                if (n.nState == 2) { Console.Write("Yellow "); }
                if (n.nState == 3) { Console.Write("Green "); }
                if (n.nState == 4) { Console.Write("LightBlue "); }
                if (n.nState == 5) { Console.Write("DarkBlue "); }
                if (n.nState == 6) { Console.Write("Purple "); }
                if (n.nState == 7) { Console.Write("Grey "); }
            }











            Random rand = new Random();
            sState = null;

            int nUserState = 0;

            int nMoves = 0;

            while (true)
            {
                nState = (int)coloredNodes.red;

                if (nState != (int)coloredNodes.green)
                {
                    break;
                }
            }

            Thread t = new Thread(DFS);
            t.Start();

            while (nState != (int)coloredNodes.green)
            {
                // convert the current numeric state to a string
                //sState = NState2SState(nState);
                sState = ((coloredNodes)nState).ToString();

                // output the current state
                //Console.WriteLine("Current color state: " + sState);
                Console.WriteLine("");
                // prompt for the desired state
                Console.WriteLine("DFS: ");
                //sUserState = Console.ReadLine().ToUpper();

                bWaitingForMove = true;
                while (bWaitingForMove) ;

                nUserState = (int)Enum.Parse(typeof(coloredNodes), sUserState);

            }
        }


        static void DFS()
        {
            bool[] visited = new bool[lGraph.Length];

            DFSUtil(nState, visited);
        }


        static void DFSUtil(int v, bool[] visited)
        {
            while (!bWaitingForMove) ;
            visited[v] = true;

            Console.Write(((coloredNodes)v).ToString() + " ");

            sUserState = ((coloredNodes)v).ToString();

            bWaitingForMove = true;

            int[] thisStateList = lGraph[v];

            if (thisStateList != null)
            {
                foreach (int n in thisStateList)
                {
                    if (!visited[n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }
        }
        static public List<Node> GetShortestPathDijkstra()
        {
            // traverse the path and calculate the minCostToStart and nearestToStart
            DijkstraSearch();

            List<Node> shortestPath = new List<Node>();

            // start from the end
            shortestPath.Add(graph[(int)coloredNodes.green]);

            // recursively traverse from finish to start
            BuildShortestPath(shortestPath, graph[(int)coloredNodes.green]);

            // reverse the path
            shortestPath.Reverse();

            // return the shortest path
            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }


        static int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = graph[(int)coloredNodes.red];

            start.minCostToStart = 0;

            List<Node> queue = new List<Node>();
            queue.Add(start);

            // 2 ways to point our delegate variable to a delegate method
            Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            //Func<Node, int> nodeOrderBy = NodeOrderBy;

            // stay in this loop while we have items in our queue
            do
            {
                // sort our queue by minCostToStart
                // option #1, use .Sort() which sorts in place
                queue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // the next 5 lines are equivalent from descriptive to abbreviated:
                queue = queue.OrderBy(nodeOrderBy).ToList();
                queue = queue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((n) => n.minCostToStart).ToList();
                queue = queue.OrderBy(n => n.minCostToStart).ToList();

                // grab the first node from our sorted queue
                Node node = queue.First();

                // remove it
                queue.Remove(node);

                // look at each edge and calculate the minCostToStart for each neighbor
                foreach (Edge cnn in node.edges)
                {
                    Node neighborNode = cnn.connectedNode;

                    if (neighborNode.visited)
                    {
                        continue;
                    }

                    // check if the path from this neighbor to the start is shorter if passing through this node
                    if (neighborNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < neighborNode.minCostToStart)
                    {
                        // if it is then set this node as being nearest to start
                        neighborNode.minCostToStart = node.minCostToStart + cnn.cost;
                        neighborNode.nearestToStart = node;

                        // and add this neighbor to the queue
                        if (!queue.Contains(neighborNode))
                        {
                            queue.Add(neighborNode);
                        }
                    }
                }

                // set this node as being visited
                node.visited = true;

                // if we reached the target, then we're done!
                if (node == graph[(int)coloredNodes.green])
                {
                    return;
                }

            } while (queue.Any());
        }
    }
}
