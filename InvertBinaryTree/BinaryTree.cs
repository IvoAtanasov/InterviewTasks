using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.InvertBinaryTree
{
    public class BinaryTree
    {
        private string _name;
        private BinaryTree? _leftNode;
        private BinaryTree? _rigthNode;

        public BinaryTree(string name, BinaryTree leftNode, BinaryTree rightNode) 
        {
            this._name = name;
            this._leftNode = leftNode;
            this._rigthNode = rightNode;
        }

        public override string ToString()
        {
            if (this == null) 
            {
                return string.Empty;
            }
            return $" {_name} {Environment.NewLine} / \\ {Environment.NewLine} {_leftNode.ToString()} {_rigthNode.ToString()}";
        }
    }
}
