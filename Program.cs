using System;
using problemsolving.Trees;

namespace problemsolving
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Recursion.Fibonacci fib = new Recursion.Fibonacci();
            //  Console.WriteLine(fib.GetFibonnaci(10));

            //Recursion.FindPermutations p = new Recursion.FindPermutations();

            //var result = p.Find("ABC");
            //foreach (var i in result)
            //Console.WriteLine(i);

            //Recursion.SubSets s = new Recursion.SubSets();
            //var result = s.FindSubSets(new System.Collections.Generic.List<int> { 1, 2, 3 }, 0);
            //foreach (var i in result)
            //{
            //    i.ForEach(j => Console.Write(string.Format("{0},",j)));
            //    Console.WriteLine();
            //}

            //UniqueChars uc = new UniqueChars();

            //Console.WriteLine(uc.HasUniqueChars("abcdefghijklmnop"));
            //Console.WriteLine(uc.HasUniqueChars("abcdefghiijklmnop"));

            //ReverseString rv = new ReverseString();
            //string result = rv.GetReverseString("ABCDE");
            //Console.WriteLine(result);

            //string a = "aabcccccaaav";
            //StringCompress sc = new StringCompress();
            //Console.WriteLine(sc.Compress(a));

            // WhiteOut w = new WhiteOut(10, 12);

            //w.SetFalse(4, 6);
            //w.SetFalse(5, 8);
            //w.SetFalse(2, 2);

            //w.PrintMatrix();
            //w.WhiteOutRowCols();
            //w.PrintMatrix();
            //var f = new FindNodeFromLast();
            //var node = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5, new Node(6, new Node(7,null)))))));
            //var result = f.Find(node, 3);
            //Console.WriteLine(result.Value);

            //var node8 = new Node(8, null);
            //var node7 = new Node(7, node8);
            //var node6 = new Node(6, node7);
            //var node5 = new Node(5, node6);
            //var node4 = new Node(4, null); //node5);
            //var node3 = new Node(3, node4);
            //var node2 = new Node(2, node3);
            //var node1 = new Node(1, node2);
            //node8.Next = node4;

            //FindLoopStart f = new FindLoopStart();

            //var result = f.Find(node1);
            //Console.WriteLine(result.Value);

            //Palidrome p = new Palidrome();
            //var result = p.IsPalidrome(new Node(1, new Node(0, new Node(0, new Node(0, new Node(1, null))))));
            //Console.WriteLine(result);

            //DeleteNode d = new DeleteNode();

            //var r = d.Delete(node3);
            //Console.WriteLine(r);

            //SumOfLists sum = new SumOfLists(false);
            ////forward : 617
            ////reverse: 716
            //var result = sum.Sum(new Node(6, new Node(1, new Node(7, null))), new Node(2, new Node(9, new Node(5, null))));

            //var v = result.Value;
            //while(v != null){
            //    Console.Write(v.Value);
            //    v = v.Next;
            //}

            //Console.WriteLine();

            //SumOfLists sum2 = new SumOfLists(true);
            //var result2 = sum2.Sum(new Node(7, new Node(1, new Node(6, null))), new Node(5, new Node(9, new Node(2, null))));

            //v = result2.Value;
            //while (v != null)
            //{
            //    Console.Write(v.Value);
            //    v = v.Next;
            //}
            //Console.ReadKey();

            //var q = new StacksAndQueues.StackQueue<int>();

            //for (int i = 0; i < 10; i++){
            //    q.Enqueue(i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}

            //var treeProcessor = new TreeProcessor();


            //Console.WriteLine("BF:");
            //PrintResult(treeProcessor.TraverseTree(Trees.Utils.GetCharTree(), TraversalType.BreadthFirst));

            //var bt = new BalancedTree();

            //var result = bt.IsBalanced(Trees.Utils.GetUnbalancedTree());

            //var finder = new PathFinder(Graphs.Utils.GetDirectedGraph());

            //var result = finder.FindPath(1, 5);

            //Console.WriteLine("1 => 5: " + result);

            //result = finder.FindPath(6, 3);

            //Console.WriteLine("6 => 3: " + result);

            //var minBst = new MinimalBST();

            //var result = minBst.CreateMinimalBST(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //var b = new BinaryTreeToLinkLists();
            //var result = b.Convert(Utils.GetTree());

            var bst = new IsBinarySearchTree();
            var result = bst.Validate(Utils.GetTree());
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void PrintResult(System.Collections.IList list){
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
