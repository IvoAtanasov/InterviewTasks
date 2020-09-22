using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTasks.Node
{
    public class Node
    {
        private string _name;
        private Node? _leftNode;
        private Node? _rigthNode;

        public Node(string name, Node leftNode, Node rightNode) 
        {
            this._name = name;
            this._leftNode = leftNode;
            this._rigthNode = rightNode;
        }

        public String Name 
        {
            get 
            {
                return _name;
            }
        }
        public override string ToString()
        {
            string leftChild = _leftNode == null ? string.Empty : _leftNode.ToString();
            string rightChild = _rigthNode == null ? string.Empty : _rigthNode.ToString();

            string leftChildName = _leftNode == null ? string.Empty : _leftNode.Name;
            string rightChildName = _rigthNode == null ? string.Empty : _rigthNode.Name;

            if (this == null) 
            {
                return string.Empty;
            }
            return $"  {_name} {Environment.NewLine} / \\ {Environment.NewLine} {leftChildName}  {rightChildName}";
        }
    }
}
