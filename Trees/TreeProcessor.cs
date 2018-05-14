using System;
using System.Collections.Generic;

namespace problemsolving.Trees
{
    public class TreeProcessor
    {
        public enum TraversalType {
            PreOrderRecursive = 1,
            PreOrderIteratively = 2,
            InOrderRecursive = 3,
            InOrderIterative = 4,
            PostOrderRecursive = 5,
            PostOrderIterative = 6,
            BreadthFirst = 7
        }

        public List<char> TraverseTree(TreeNode<char> tree, TraversalType traversalType){

            var list = new List<char>();

            switch(traversalType)
            {
                case TraversalType.PreOrderRecursive:
                    PreOrderTraverseNode(tree, list);
                    break;
                case TraversalType.PreOrderIteratively:
                    PreOrderIterative(tree, list);
                    break;
                case TraversalType.InOrderRecursive:
                    InOrderTraverseNode(tree.Left, list);
                    ProcessNode(tree, list);
                    InOrderTraverseNode(tree.Right, list);
                    break;
                case TraversalType.InOrderIterative:
                    InOrderIterative(tree, list);
                    break;
                case TraversalType.PostOrderRecursive:
                    PostOrderTraverseNode(tree.Left, list);
                    PostOrderTraverseNode(tree.Right, list);
                    ProcessNode(tree, list);
                    break;
                case TraversalType.PostOrderIterative:
                    PostOrderIterative(tree, list);
                    break;
                case TraversalType.BreadthFirst:
                    BreadthFirst(tree, list);
                    break;
                default:
                    throw new Exception("Traversal type not recognised");
            }

            return list;
        }

        private void InOrderTraverseNode(TreeNode<char> node, ICollection<char> list){

            if (node == null) return;

            InOrderTraverseNode(node.Left, list);
            ProcessNode(node, list);
            InOrderTraverseNode(node.Right, list); 
        }

        private void InOrderIterative(TreeNode<char> node, ICollection<char> list){

            if (node == null) return;

            var stack = new Stack<TreeNode<char>>();

            while (node != null){
                
                stack.Push(node);

                node = node.Left;
            }

            while (stack.Count > 0){

                var current = stack.Pop();

                ProcessNode(current, list);

                if (current.Right != null)
                {
                    current = current.Right;

                    while (current != null)
                    {
                        stack.Push(current);

                        current = current.Left;
                    }
                }
            }
        }

        private void PreOrderIterative(TreeNode<char> node, ICollection<char> list){

            if (node == null) return;

            var stack = new Stack<TreeNode<char>>();

            stack.Push(node);

            while (stack.Count > 0){

                var current = stack.Pop();

                ProcessNode(current, list);

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }

        private void PreOrderTraverseNode(TreeNode<char> node, ICollection<char> list)
        {
            if (node == null) return;

            ProcessNode(node, list);
            PreOrderTraverseNode(node.Left, list);
            PreOrderTraverseNode(node.Right, list);
        }

        private void PostOrderTraverseNode(TreeNode<char> node, ICollection<char> list)
        {
            if (node == null) return;

            PostOrderTraverseNode(node.Left, list);
            PostOrderTraverseNode(node.Right, list);
            ProcessNode(node, list);
        }

        private void PostOrderIterative(TreeNode<char> node, ICollection<char> list)
        {
            if (node == null) return;

            var stackOne = new Stack<TreeNode<char>>();

            var stackTwo = new Stack<TreeNode<char>>();

            stackOne.Push(node);

            while (stackOne.Count > 0)
            {
                var current = stackOne.Pop();

                stackTwo.Push(current);

                if (current.Left != null)
                {
                    stackOne.Push(current.Left);
                }

                if (current.Right != null)
                {
                    stackOne.Push(current.Right);
                }
            }

            while (stackTwo.Count > 0){
                ProcessNode(stackTwo.Pop(), list);
            }
        }

        private void BreadthFirst(TreeNode<char> node, ICollection<char> list){

            var queue = new Queue<TreeNode<char>>();

            queue.Enqueue(node);

            while (queue.Count > 0){

                var current = queue.Dequeue();

                list.Add(current.Value);

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        private void ProcessNode(TreeNode<char> node, ICollection<char> list){
            
            list.Add(node.Value);
        }
    }
}
