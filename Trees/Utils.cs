namespace problemsolving.Trees
{
    public static class Utils
    {
        public static TreeNode<int> GetTree()
        {

            var root = new TreeNode<int>()
            {
                Value = 3,
                Left = new TreeNode<int>
                {
                    Value = 2,
                    Left = new TreeNode<int> { Value = 6 },

                },
                Right = new TreeNode<int>
                {
                    Value = 4,
                    Right = new TreeNode<int> { Value = 5 }
                }
            };

            return root;
        }

        public static TreeNode<int> GetUnbalancedTree()
        {
            var root = new TreeNode<int>()
            {
                Value = 3,
                Left = new TreeNode<int>
                {
                    Value = 2,
                    Left = new TreeNode<int> { Value = 1, Left = new TreeNode<int> { Value = 6 } },

                },
                Right = new TreeNode<int>
                {
                    Value = 4,
                    Right = new TreeNode<int> { Value = 5 }
                }
            };

            return root;
        }

        public static TreeNode<char> GetCharTree()
        {
            return new TreeNode<char>
            {
                Value = 'F',
                Left = new TreeNode<char>
                {
                    Value = 'B',
                    Left = new TreeNode<char>
                    {
                        Value = 'A'
                    },
                    Right = new TreeNode<char>
                    {
                        Value = 'D',
                        Left = new TreeNode<char>
                        {
                            Value = 'C'
                        },
                        Right = new TreeNode<char>
                        {
                            Value = 'E'
                        }

                    }
                },
                Right = new TreeNode<char>
                {
                    Value = 'G',
                    Right = new TreeNode<char>{
                        Value = 'I',
                        Left = new TreeNode<char>{
                            Value = 'H'
                        }
                    }
                }
            };
        }

        public static TreeNode<int> FindSuccessorTree() {

            var fourNode = new TreeNode<int> { Value = 4 };

            var sixNode = new TreeNode<int> { Value = 6 };

            var threeNode = new TreeNode<int>
            {
                Value = 3,
                Right = fourNode
            };
           
            var sevenNode = new TreeNode<int> 
            { 
                Value = 7,
                Left = sixNode
            };

            var rootNode = new TreeNode<int>
            {
                Value = 5,
                Left = threeNode,
                Right = sevenNode
            };

            return rootNode;
        }
    }
}
