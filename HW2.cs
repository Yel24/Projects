﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchdepth
{
    

    public class Node
    {
        public int value;
        public Node left, right;

        public Node(int val)
        {
            value = val;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        Node root;

        int maxDepth(Node root)
        {
            if (root == null)
                return 0;

            int leftDepth = maxDepth(root.left);
            int rightDepth = maxDepth(root.right);


            if (leftDepth > rightDepth)
                return (leftDepth + 1);
            else
                return (rightDepth + 1);
        }


        public static void Main()
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.right.left = new Node(5);
            tree.root.right.right = new Node(6);

            Console.WriteLine("Max depth: " + tree.maxDepth(tree.root));
        }
    }
    }
