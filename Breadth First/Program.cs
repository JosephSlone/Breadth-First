using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breadth_First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("DFS and BFS Tree Traversal\n\n");

            Tree<int> tree =
                 new Tree<int>(7,   
                    new Tree<int>(19,
                        new Tree<int>(1),
                        new Tree<int>(12),
                        new Tree<int>(31)),
                    new Tree<int>(21),
                        new Tree<int>(14,
                        new Tree<int>(23),
                        new Tree<int>(6))
                );

            Console.WriteLine("Depth First Search Traversal");
            tree.TraverseDFS();
            Console.WriteLine("Breadth First Search Traversal");
            tree.TraverseBFS();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
